namespace BatchMonitoring
{
    partial class BatchMonitoring
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchMonitoring));
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "מספר אצווה");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "חומר");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "תוקף");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup1 = new Telerik.WinControls.UI.ListViewDataItemGroup("אצוות");
            this.lblHeader = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.n = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.cmbMedia = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOfBatches = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.btnLoginBatches = new Telerik.WinControls.UI.RadButton();
            this.lsvBatches = new Telerik.WinControls.UI.RadListView();
            this.txtYear = new Telerik.WinControls.UI.RadTextBox();
            this.txtBatch = new Telerik.WinControls.UI.RadTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.object_fc51f977_d922_4ea8_a29c_d7c8fec7fec6 = new Telerik.WinControls.RootRadElement();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit2 = new Telerik.WinControls.UI.RadButton();
            this.lblGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            this.n.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsvBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Location = new System.Drawing.Point(221, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(171, 39);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "הזנת אצוות";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stockk.ico");
            // 
            // n
            // 
            this.n.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.n.Controls.Add(this.btnAdd);
            this.n.Controls.Add(this.cmbMedia);
            this.n.Controls.Add(this.label4);
            this.n.Controls.Add(this.label3);
            this.n.Controls.Add(this.lblNumOfBatches);
            this.n.Controls.Add(this.label2);
            this.n.Controls.Add(this.label1);
            this.n.Controls.Add(this.btnExit);
            this.n.Controls.Add(this.btnLoginBatches);
            this.n.Controls.Add(this.lsvBatches);
            this.n.Controls.Add(this.txtYear);
            this.n.Controls.Add(this.txtBatch);
            this.n.HeaderText = "";
            this.n.Location = new System.Drawing.Point(35, 65);
            this.n.Name = "n";
            this.n.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.n.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.n.Size = new System.Drawing.Size(737, 565);
            this.n.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 63);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 20);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbMedia
            // 
            this.cmbMedia.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbMedia.Location = new System.Drawing.Point(516, 63);
            this.cmbMedia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMedia.Name = "cmbMedia";
            this.cmbMedia.Size = new System.Drawing.Size(130, 20);
            this.cmbMedia.TabIndex = 0;
            this.cmbMedia.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbMedia_SelectedIndexChanged);
            this.cmbMedia.Enter += new System.EventHandler(this.cmbMedia_Enter);
            this.cmbMedia.Leave += new System.EventHandler(this.cmbMedia_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(236, 61);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "שנה:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(652, 62);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "חומר:";
            // 
            // lblNumOfBatches
            // 
            this.lblNumOfBatches.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumOfBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumOfBatches.Location = new System.Drawing.Point(28, 485);
            this.lblNumOfBatches.Name = "lblNumOfBatches";
            this.lblNumOfBatches.Size = new System.Drawing.Size(50, 24);
            this.lblNumOfBatches.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(441, 61);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "אצווה:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(95, 485);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "סה\"כ:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(640, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(83, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "יציאה";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoginBatches
            // 
            this.btnLoginBatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginBatches.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginBatches.Location = new System.Drawing.Point(533, 513);
            this.btnLoginBatches.Name = "btnLoginBatches";
            this.btnLoginBatches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLoginBatches.Size = new System.Drawing.Size(80, 33);
            this.btnLoginBatches.TabIndex = 9;
            this.btnLoginBatches.Text = "הזן אצוות";
            this.btnLoginBatches.Click += new System.EventHandler(this.btnLoginBatches_Click);
            // 
            // lsvBatches
            // 
            this.lsvBatches.AllowEdit = false;
            this.lsvBatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            listViewDetailColumn1.HeaderText = "מספר אצווה";
            listViewDetailColumn2.HeaderText = "חומר";
            listViewDetailColumn3.HeaderText = "תוקף";
            listViewDetailColumn3.Width = 250F;
            this.lsvBatches.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.lsvBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            listViewDataItemGroup1.Image = ((System.Drawing.Image)(resources.GetObject("listViewDataItemGroup1.Image")));
            listViewDataItemGroup1.ImageKey = "stockk.ico";
            listViewDataItemGroup1.Text = "אצוות";
            this.lsvBatches.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] {
            listViewDataItemGroup1});
            this.lsvBatches.ImageList = this.imageList1;
            this.lsvBatches.ItemSpacing = -1;
            this.lsvBatches.Location = new System.Drawing.Point(15, 116);
            this.lsvBatches.Name = "lsvBatches";
            this.lsvBatches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lsvBatches.Size = new System.Drawing.Size(708, 354);
            this.lsvBatches.TabIndex = 8;
            this.lsvBatches.Text = "radListView1";
            this.lsvBatches.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lsvBatches.ItemRemoved += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lsvBatches_ItemRemoved);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(158, 60);
            this.txtYear.Name = "txtYear";
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYear.Size = new System.Drawing.Size(76, 27);
            this.txtYear.TabIndex = 2;
            this.txtYear.TabStop = false;
            this.txtYear.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.txtYear_TextChanging);
            this.txtYear.Enter += new System.EventHandler(this.txt_Enter);
            this.txtYear.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtBatch
            // 
            this.txtBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.Location = new System.Drawing.Point(298, 60);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBatch.Size = new System.Drawing.Size(142, 27);
            this.txtBatch.TabIndex = 1;
            this.txtBatch.TabStop = false;
            this.txtBatch.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.txtBatch_TextChanging);
            this.txtBatch.Enter += new System.EventHandler(this.txt_Enter);
            this.txtBatch.Leave += new System.EventHandler(this.txt_Leave);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.txtBatch.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // object_fc51f977_d922_4ea8_a29c_d7c8fec7fec6
            // 
            this.object_fc51f977_d922_4ea8_a29c_d7c8fec7fec6.Name = "object_fc51f977_d922_4ea8_a29c_d7c8fec7fec6";
            this.object_fc51f977_d922_4ea8_a29c_d7c8fec7fec6.StretchHorizontally = true;
            this.object_fc51f977_d922_4ea8_a29c_d7c8fec7fec6.StretchVertically = true;
            this.object_fc51f977_d922_4ea8_a29c_d7c8fec7fec6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // btnExit2
            // 
            this.btnExit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.Location = new System.Drawing.Point(26, 649);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit2.Size = new System.Drawing.Size(83, 33);
            this.btnExit2.TabIndex = 12;
            this.btnExit2.Text = "יציאה";
            this.btnExit2.Visible = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGroup.Location = new System.Drawing.Point(763, 669);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(0, 7);
            this.lblGroup.TabIndex = 13;
            // 
            // BatchMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.n);
            this.Controls.Add(this.lblHeader);
            this.Name = "BatchMonitoring";
            this.Size = new System.Drawing.Size(801, 685);
            this.Load += new System.EventHandler(this.BatchMonitoring_Load);
            this.Resize += new System.EventHandler(this.BatchMonitoring_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            this.n.ResumeLayout(false);
            this.n.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsvBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadGroupBox n;
        private System.Windows.Forms.Label lblNumOfBatches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadButton btnLoginBatches;
        private Telerik.WinControls.UI.RadListView lsvBatches;
        private Telerik.WinControls.UI.RadTextBox txtBatch;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadDropDownList cmbMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadTextBox txtYear;
        private Telerik.WinControls.RootRadElement object_fc51f977_d922_4ea8_a29c_d7c8fec7fec6;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadButton btnExit2;
        private System.Windows.Forms.Label lblGroup;
    }
}
