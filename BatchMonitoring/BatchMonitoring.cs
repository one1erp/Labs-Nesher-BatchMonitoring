using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DAL;
using LSExtensionWindowLib;
using LSSERVICEPROVIDERLib;
using One1.Controls;
using Telerik.WinControls.UI;
using Common;
using XmlService;

namespace BatchMonitoring
{

    [ComVisible(true)]
    [ProgId("BatchMonitoring.BatchMonitoring")]
    public partial class BatchMonitoring : UserControl, IExtensionWindow
    {
        #region Ctor

        public BatchMonitoring()
        {
            InitializeComponent();
            this.BackColor = Color.FromName("Control");

        }

        #endregion


        #region private members


        private IExtensionWindowSite2 _ntlsSite;
        private INautilusDBConnection _ntlsCon;
        private IDataLayer _dal;
        private NautilusServiceProvider sp;

        private int _numOfBatches;
        private string _selectedMedia;
        private string _batchNo;
        private string _year;
        private List<string> _samplesForLogin = new List<string>();
        private NautilusUser _ntlUser;

        private string _currentGroup = null;

        #endregion


        #region Implementation of IExtensionWindow

        public bool CloseQuery()
        {
            if (lsvBatches.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("?" + "אצוות לא הוזנו למערכת. האם לצאת בכל זאת",
                    "הזנת אצווה", MessageBoxButtons.YesNo);
                return dr == DialogResult.Yes;
            }
            return true;
        }

        public void Internationalise()
        {
        }

        public void SetSite(object site)
        {
            _ntlsSite = (IExtensionWindowSite2)site;
            _ntlsSite.SetWindowInternalName("BatchMonitoring");
            _ntlsSite.SetWindowRegistryName("BatchMonitoring");
            _ntlsSite.SetWindowTitle("הזנת אצווה");
        }

        public void PreDisplay()
        {
            Utils.CreateConstring(_ntlsCon);
            _dal = new DataLayer();
            Init(_dal);

        }

        private void SetCurrentGroup()
        {
            var wid = _ntlUser.GetWorkstationId();
            var currentWorkstation = _dal.getWorkStaitionById((long)wid);
            if (currentWorkstation != null && currentWorkstation.LIMS_GROUP != null
                && currentWorkstation.LIMS_GROUP.Name != null)
            {
                _currentGroup = currentWorkstation.LIMS_GROUP.Name;
                n.Enabled = true;
            }

            else
            {
                //Where is the source????????
                //SelectGroupForm selectGroup = new SelectGroupForm(_dal);
          ///      selectGroup.StartPosition = FormStartPosition.CenterParent;
             //   selectGroup.ShowDialog();
               // _currentGroup = selectGroup.SelectedGroup;
              
         //       if (string.IsNullOrEmpty(_currentGroup))
           //     {
             //       CustomMessageBox.Show("לא הוגדרה מעבדה לתחנה" + "\n" + "לא ניתן להזין אצוות");
               //     n.Enabled = false;
                 //   btnExit2.Visible = true;
              //  }

            }
            lblGroup.Text = _currentGroup;
        }

        public WindowButtonsType GetButtons()
        {
            return LSExtensionWindowLib.WindowButtonsType.windowButtonsNone;
        }

        public bool SaveData()
        {
            return false;
        }

        public void SetServiceProvider(object serviceProvider)
        {
            sp = serviceProvider as NautilusServiceProvider;
            _ntlsCon = Utils.GetNtlsCon(sp);
            _ntlUser = Utils.GetNautilusUser(sp);
        }

        public void SetParameters(string parameters)
        {
        }

        public void Setup()
        {
            // populate media types            
            Dictionary<string, string> media = _dal.GetPhraseByName("Calture Media").PhraseEntriesDescriptionByName;
            var list = media.Select(m => new RadListDataItem(m.Value, m));

            cmbMedia.DataSource = list;

            txtYear.Text = DateTime.Now.ToString("yy");
            SetCurrentGroup();
        }

        public WindowRefreshType DataChange()
        {
            return LSExtensionWindowLib.WindowRefreshType.windowRefreshNone;
        }

        public WindowRefreshType ViewRefresh()
        {
            return LSExtensionWindowLib.WindowRefreshType.windowRefreshNone;
        }

        public void refresh()
        {
        }

        public void SaveSettings(int hKey)
        {
        }

        public void RestoreSettings(int hKey)
        {
        }


        #endregion


        public void Init(IDataLayer dal)
        {
            _dal = dal;
            _dal.Connect();
        }


        private void BatchMonitoring_Resize(object sender, EventArgs e)
        {
            lblHeader.Location = new Point(Width / 2 - lblHeader.Width / 2, lblHeader.Location.Y);
            n.Location = new Point(Width / 2 - n.Width / 2, n.Location.Y);
        }


        private void RegisterForLogin()
        {
            string name = string.Format("CMED - {0} - {1} - {2}", _year, _batchNo, _selectedMedia);
            Sample existingBatchSample = _dal.GetSampleByName(name);
            if (existingBatchSample != null)
            {
                DateTime expirationDate = existingBatchSample.EXPECTED_ON.GetValueOrDefault();
                if (DateTime.Compare(expirationDate, DateTime.Now) >= 0)
                {
                    if (!_samplesForLogin.Contains(name))
                    {
                        _samplesForLogin.Add(name);

                        ListViewDataItem item = new ListViewDataItem(_batchNo,
                            new[]
                            {
                                _batchNo,
                                _selectedMedia,
                                expirationDate.ToString("dd/MM/yy")
                            });
                        item.Tag = name;
                        item.TextAlignment = ContentAlignment.MiddleLeft;
                        item.Image = imageList1.Images[0];
                        lsvBatches.Items.Add(item);

                        lblNumOfBatches.Text = (++_numOfBatches).ToString();

                        txtBatch.Text = "";
                        txtYear.Text = DateTime.Now.ToString("yy");

                        cmbMedia.Focus();
                    }
                }
                else
                {
                    string message = string.Format("אצווה אינה בתוקף." + "\n");
                    message += "(" + expirationDate.ToString("yy/MM/yy") + ")";
                    CustomMessageBox.Show(message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbMedia.Focus();
                }
            }
            else
            {
                string message = "האצווה המבוקשת לא הוזנה במערכת." + "\n";
                message += "יש לבדוק מספר אצווה, סוג חומר ושנה.";
                CustomMessageBox.Show(message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbMedia.Focus();
            }


            cmbMedia.Focus();

        }

        private bool Login(string batchNo, string media)
        {
            LoginXmlHandler loginXmlHandler = new LoginXmlHandler(sp);
            loginXmlHandler.CreateLoginXml("SAMPLE", "רישום אצוות");
            loginXmlHandler.AddProperties("GROUP_ID", _currentGroup);
            loginXmlHandler.AddProperties("U_BATCH", batchNo);
            loginXmlHandler.AddProperties("U_CULTURE_MEDIA", media);

            return loginXmlHandler.ProcssXml();
        }


        private void BatchMonitoring_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnLoginBatches_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                btnAdd.Enabled = false;
                txtBatch.Enabled = false;
                txtYear.Enabled = false;
                cmbMedia.Enabled = false;
                lsvBatches.Enabled = false;
                btnExit.Enabled = false;
                btnLoginBatches.Enabled = false;

                bool succeed = true;
                var items = lsvBatches.Items;
                foreach (ListViewDataItem item in items)
                {
                    bool result = Login(item.SubItems[0].ToString(), item.SubItems[1].ToString());
                    if (!result)
                        succeed = false;
                }

                Cursor = Cursors.Default;

                if (!succeed)
                    CustomMessageBox.Show("." + "בעיה בהזנת אצוות", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Cursor = Cursors.Default;

                _samplesForLogin.Clear();

                btnAdd.Enabled = true;
                txtBatch.Enabled = true;
                txtYear.Enabled = true;
                cmbMedia.Enabled = true;

                txtBatch.Text = "";
                txtYear.Text = DateTime.Now.ToString("yy");
                lsvBatches.Enabled = true;
                btnExit.Enabled = true;
                btnLoginBatches.Enabled = true;
                lsvBatches.Items.Clear();
                _numOfBatches = 0;
                lblNumOfBatches.Text = "";
                cmbMedia.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool proceed = true;
            if (string.IsNullOrEmpty(txtYear.Text.Trim()) || txtYear.Text.Trim().Length != 2)
            {
                errorProvider1.SetError(txtYear, "הזן שנה בשתי ספרות");
                proceed = false;
            }
            else
            {
                _year = txtYear.Text.Trim();
            }



            if (string.IsNullOrEmpty(txtBatch.Text.Trim()))
            {
                errorProvider1.SetError(txtBatch, "הזן מספר אצווה");
                proceed = false;
            }
            else
            {
                _batchNo = txtBatch.Text.Trim();
            }


            if (proceed)
                RegisterForLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _ntlsSite.CloseWindow();
        }




        private void lsvBatches_ItemRemoved(object sender, ListViewItemEventArgs e)
        {
            lblNumOfBatches.Text = (--_numOfBatches).ToString();
            _samplesForLogin.Remove((string)e.Item.Tag);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            cmbMedia.Focus();
            timer1.Stop();
        }

        private void cmbMedia_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = (sender as RadDropDownList).SelectedItem;
            object dataBoundItem = item.DataBoundItem;
            object value = ((RadListDataItem)(dataBoundItem)).Value;
            _selectedMedia = ((KeyValuePair<string, string>)(value)).Key;
        }


        private void txtYear_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
        {
            errorProvider1.SetError(txtYear, "");

            if (!string.IsNullOrEmpty(e.NewValue))
            {
                int temp;
                if (!int.TryParse(e.NewValue, out temp) || ((RadTextBox)sender).TextLength > 2)
                    e.Cancel = true;
            }
        }

        private void txtBatch_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
        {
            errorProvider1.SetError(txtBatch, "");

        }

        #region back color


        private void txt_Enter(object sender, EventArgs e)
        {
            ((RadTextBox)sender).TextBoxElement.Fill.BackColor = Color.AntiqueWhite;
            ((RadTextBox)sender).TextBoxElement.TextBoxItem.BackColor = Color.AntiqueWhite;
            ((RadTextBox)sender).SelectionStart = 0;
            ((RadTextBox)sender).SelectionLength = ((RadTextBox)sender).TextLength;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            ((RadTextBox)sender).TextBoxElement.Fill.BackColor = Color.White;
            ((RadTextBox)sender).TextBoxElement.TextBoxItem.BackColor = Color.White;
        }

        private void cmbMedia_Enter(object sender, EventArgs e)
        {
            cmbMedia.DropDownListElement.TextBox.Fill.BackColor = Color.AntiqueWhite;
            cmbMedia.DropDownListElement.TextBox.BackColor = Color.AntiqueWhite;
            cmbMedia.DropDownListElement.EditableElement.BackColor = Color.AntiqueWhite;
        }

        private void cmbMedia_Leave(object sender, EventArgs e)
        {
            cmbMedia.DropDownListElement.TextBox.Fill.BackColor = Color.White;
            cmbMedia.DropDownListElement.TextBox.BackColor = Color.White;
            cmbMedia.DropDownListElement.EditableElement.BackColor = Color.White;
        }

        #endregion
    }


}

