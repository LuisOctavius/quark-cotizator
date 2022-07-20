namespace qk_cotiztr.Views
{
    partial class ViewMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMain));
            this.Panel_FixedTop = new System.Windows.Forms.Panel();
            this.Btn_CloseApp = new System.Windows.Forms.PictureBox();
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.Panel_StoreInfo = new System.Windows.Forms.Panel();
            this.Label_StoreAddress = new System.Windows.Forms.Label();
            this.Label_StoreName = new System.Windows.Forms.Label();
            this.Panel_SellerInfo = new System.Windows.Forms.Panel();
            this.LinkLabel_VendorCotizations = new System.Windows.Forms.LinkLabel();
            this.Label_VendorInfo = new System.Windows.Forms.Label();
            this.Panel_FixedBottom = new System.Windows.Forms.Panel();
            this.label_CotizationResult = new System.Windows.Forms.Label();
            this.Btn_GenerateCotization = new System.Windows.Forms.Button();
            this.Panel_MainContent = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_CotizationQuantity = new System.Windows.Forms.TextBox();
            this.Group_SelectedGarmentInfo = new System.Windows.Forms.GroupBox();
            this.label_AvailableStockInfoData = new System.Windows.Forms.Label();
            this.label_AvailableStockInfo = new System.Windows.Forms.Label();
            this.Group_Step2 = new System.Windows.Forms.GroupBox();
            this.checkBox_PremiumQuality = new System.Windows.Forms.CheckBox();
            this.Group_Step3 = new System.Windows.Forms.GroupBox();
            this.listBox_GarmentVariants = new System.Windows.Forms.ListBox();
            this.Group_Step1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Garments = new System.Windows.Forms.ComboBox();
            this.errorProvider_MainWindow = new System.Windows.Forms.ErrorProvider(this.components);
            this.Panel_FixedTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_CloseApp)).BeginInit();
            this.Panel_StoreInfo.SuspendLayout();
            this.Panel_SellerInfo.SuspendLayout();
            this.Panel_FixedBottom.SuspendLayout();
            this.Panel_MainContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Group_SelectedGarmentInfo.SuspendLayout();
            this.Group_Step2.SuspendLayout();
            this.Group_Step3.SuspendLayout();
            this.Group_Step1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MainWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_FixedTop
            // 
            this.Panel_FixedTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(42)))), ((int)(((byte)(167)))));
            this.Panel_FixedTop.Controls.Add(this.Btn_CloseApp);
            this.Panel_FixedTop.Controls.Add(this.AppTitleLabel);
            this.Panel_FixedTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_FixedTop.Location = new System.Drawing.Point(0, 0);
            this.Panel_FixedTop.Name = "Panel_FixedTop";
            this.Panel_FixedTop.Size = new System.Drawing.Size(596, 90);
            this.Panel_FixedTop.TabIndex = 0;
            this.Panel_FixedTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_FixedTop_MouseDown);
            // 
            // Btn_CloseApp
            // 
            this.Btn_CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CloseApp.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CloseApp.Image")));
            this.Btn_CloseApp.Location = new System.Drawing.Point(559, 12);
            this.Btn_CloseApp.Name = "Btn_CloseApp";
            this.Btn_CloseApp.Size = new System.Drawing.Size(25, 25);
            this.Btn_CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_CloseApp.TabIndex = 1;
            this.Btn_CloseApp.TabStop = false;
            this.Btn_CloseApp.Click += new System.EventHandler(this.Btn_CloseApp_Click);
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.AutoSize = true;
            this.AppTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AppTitleLabel.Location = new System.Drawing.Point(12, 30);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(257, 36);
            this.AppTitleLabel.TabIndex = 0;
            this.AppTitleLabel.Text = "Cotizador Express";
            // 
            // Panel_StoreInfo
            // 
            this.Panel_StoreInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel_StoreInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_StoreInfo.Controls.Add(this.Label_StoreAddress);
            this.Panel_StoreInfo.Controls.Add(this.Label_StoreName);
            this.Panel_StoreInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_StoreInfo.Location = new System.Drawing.Point(0, 90);
            this.Panel_StoreInfo.Name = "Panel_StoreInfo";
            this.Panel_StoreInfo.Size = new System.Drawing.Size(596, 46);
            this.Panel_StoreInfo.TabIndex = 1;
            // 
            // Label_StoreAddress
            // 
            this.Label_StoreAddress.AutoSize = true;
            this.Label_StoreAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.Label_StoreAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(42)))), ((int)(((byte)(167)))));
            this.Label_StoreAddress.Location = new System.Drawing.Point(396, 16);
            this.Label_StoreAddress.Name = "Label_StoreAddress";
            this.Label_StoreAddress.Size = new System.Drawing.Size(189, 22);
            this.Label_StoreAddress.TabIndex = 1;
            this.Label_StoreAddress.Text = "Dirección de la Tienda";
            // 
            // Label_StoreName
            // 
            this.Label_StoreName.AutoSize = true;
            this.Label_StoreName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.Label_StoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(42)))), ((int)(((byte)(167)))));
            this.Label_StoreName.Location = new System.Drawing.Point(13, 16);
            this.Label_StoreName.Name = "Label_StoreName";
            this.Label_StoreName.Size = new System.Drawing.Size(137, 22);
            this.Label_StoreName.TabIndex = 0;
            this.Label_StoreName.Text = "Nombre Tienda";
            // 
            // Panel_SellerInfo
            // 
            this.Panel_SellerInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel_SellerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_SellerInfo.Controls.Add(this.LinkLabel_VendorCotizations);
            this.Panel_SellerInfo.Controls.Add(this.Label_VendorInfo);
            this.Panel_SellerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SellerInfo.Location = new System.Drawing.Point(0, 136);
            this.Panel_SellerInfo.Name = "Panel_SellerInfo";
            this.Panel_SellerInfo.Size = new System.Drawing.Size(596, 46);
            this.Panel_SellerInfo.TabIndex = 2;
            // 
            // LinkLabel_VendorCotizations
            // 
            this.LinkLabel_VendorCotizations.AutoSize = true;
            this.LinkLabel_VendorCotizations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel_VendorCotizations.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.LinkLabel_VendorCotizations.Location = new System.Drawing.Point(396, 13);
            this.LinkLabel_VendorCotizations.Name = "LinkLabel_VendorCotizations";
            this.LinkLabel_VendorCotizations.Size = new System.Drawing.Size(173, 21);
            this.LinkLabel_VendorCotizations.TabIndex = 1;
            this.LinkLabel_VendorCotizations.TabStop = true;
            this.LinkLabel_VendorCotizations.Text = "Historial Cotizaciones";
            // 
            // Label_VendorInfo
            // 
            this.Label_VendorInfo.AutoSize = true;
            this.Label_VendorInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Label_VendorInfo.ForeColor = System.Drawing.Color.Blue;
            this.Label_VendorInfo.Location = new System.Drawing.Point(13, 13);
            this.Label_VendorInfo.Name = "Label_VendorInfo";
            this.Label_VendorInfo.Size = new System.Drawing.Size(322, 21);
            this.Label_VendorInfo.TabIndex = 0;
            this.Label_VendorInfo.Text = "Vendor Name + Surname | Vendor Code";
            // 
            // Panel_FixedBottom
            // 
            this.Panel_FixedBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel_FixedBottom.Controls.Add(this.label_CotizationResult);
            this.Panel_FixedBottom.Controls.Add(this.Btn_GenerateCotization);
            this.Panel_FixedBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_FixedBottom.Location = new System.Drawing.Point(0, 529);
            this.Panel_FixedBottom.Name = "Panel_FixedBottom";
            this.Panel_FixedBottom.Size = new System.Drawing.Size(596, 100);
            this.Panel_FixedBottom.TabIndex = 3;
            // 
            // label_CotizationResult
            // 
            this.label_CotizationResult.AutoSize = true;
            this.label_CotizationResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CotizationResult.Location = new System.Drawing.Point(40, 33);
            this.label_CotizationResult.Name = "label_CotizationResult";
            this.label_CotizationResult.Size = new System.Drawing.Size(113, 28);
            this.label_CotizationResult.TabIndex = 1;
            this.label_CotizationResult.Text = "Precio: $ -";
            // 
            // Btn_GenerateCotization
            // 
            this.Btn_GenerateCotization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(42)))), ((int)(((byte)(167)))));
            this.Btn_GenerateCotization.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerateCotization.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_GenerateCotization.Location = new System.Drawing.Point(320, 6);
            this.Btn_GenerateCotization.Name = "Btn_GenerateCotization";
            this.Btn_GenerateCotization.Size = new System.Drawing.Size(264, 82);
            this.Btn_GenerateCotization.TabIndex = 0;
            this.Btn_GenerateCotization.Text = "Cotizar";
            this.Btn_GenerateCotization.UseVisualStyleBackColor = false;
            // 
            // Panel_MainContent
            // 
            this.Panel_MainContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel_MainContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_MainContent.Controls.Add(this.groupBox1);
            this.Panel_MainContent.Controls.Add(this.Group_SelectedGarmentInfo);
            this.Panel_MainContent.Controls.Add(this.Group_Step2);
            this.Panel_MainContent.Controls.Add(this.Group_Step3);
            this.Panel_MainContent.Controls.Add(this.Group_Step1);
            this.Panel_MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MainContent.Location = new System.Drawing.Point(0, 182);
            this.Panel_MainContent.Name = "Panel_MainContent";
            this.Panel_MainContent.Size = new System.Drawing.Size(596, 347);
            this.Panel_MainContent.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_CotizationQuantity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(291, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4. Cantidad a cotizar";
            // 
            // textBox_CotizationQuantity
            // 
            this.textBox_CotizationQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CotizationQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CotizationQuantity.Location = new System.Drawing.Point(21, 23);
            this.textBox_CotizationQuantity.MaxLength = 5;
            this.textBox_CotizationQuantity.Multiline = true;
            this.textBox_CotizationQuantity.Name = "textBox_CotizationQuantity";
            this.textBox_CotizationQuantity.Size = new System.Drawing.Size(244, 36);
            this.textBox_CotizationQuantity.TabIndex = 0;
            // 
            // Group_SelectedGarmentInfo
            // 
            this.Group_SelectedGarmentInfo.Controls.Add(this.label_AvailableStockInfoData);
            this.Group_SelectedGarmentInfo.Controls.Add(this.label_AvailableStockInfo);
            this.Group_SelectedGarmentInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_SelectedGarmentInfo.Location = new System.Drawing.Point(291, 168);
            this.Group_SelectedGarmentInfo.Name = "Group_SelectedGarmentInfo";
            this.Group_SelectedGarmentInfo.Size = new System.Drawing.Size(292, 162);
            this.Group_SelectedGarmentInfo.TabIndex = 6;
            this.Group_SelectedGarmentInfo.TabStop = false;
            this.Group_SelectedGarmentInfo.Text = "Detalles de tu selección actual";
            // 
            // label_AvailableStockInfoData
            // 
            this.label_AvailableStockInfoData.AutoSize = true;
            this.label_AvailableStockInfoData.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AvailableStockInfoData.Location = new System.Drawing.Point(16, 68);
            this.label_AvailableStockInfoData.Name = "label_AvailableStockInfoData";
            this.label_AvailableStockInfoData.Size = new System.Drawing.Size(21, 28);
            this.label_AvailableStockInfoData.TabIndex = 1;
            this.label_AvailableStockInfoData.Text = "-";
            // 
            // label_AvailableStockInfo
            // 
            this.label_AvailableStockInfo.AutoSize = true;
            this.label_AvailableStockInfo.Location = new System.Drawing.Point(12, 34);
            this.label_AvailableStockInfo.Name = "label_AvailableStockInfo";
            this.label_AvailableStockInfo.Size = new System.Drawing.Size(125, 19);
            this.label_AvailableStockInfo.TabIndex = 0;
            this.label_AvailableStockInfo.Text = "Stock Disponible:";
            // 
            // Group_Step2
            // 
            this.Group_Step2.Controls.Add(this.checkBox_PremiumQuality);
            this.Group_Step2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Step2.Location = new System.Drawing.Point(291, 27);
            this.Group_Step2.Name = "Group_Step2";
            this.Group_Step2.Size = new System.Drawing.Size(292, 62);
            this.Group_Step2.TabIndex = 7;
            this.Group_Step2.TabStop = false;
            this.Group_Step2.Text = "2. Calidad de la Prenda";
            // 
            // checkBox_PremiumQuality
            // 
            this.checkBox_PremiumQuality.AutoSize = true;
            this.checkBox_PremiumQuality.Location = new System.Drawing.Point(16, 25);
            this.checkBox_PremiumQuality.Name = "checkBox_PremiumQuality";
            this.checkBox_PremiumQuality.Size = new System.Drawing.Size(83, 23);
            this.checkBox_PremiumQuality.TabIndex = 0;
            this.checkBox_PremiumQuality.Text = "Premium";
            this.checkBox_PremiumQuality.UseVisualStyleBackColor = true;
            // 
            // Group_Step3
            // 
            this.Group_Step3.Controls.Add(this.listBox_GarmentVariants);
            this.Group_Step3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Step3.Location = new System.Drawing.Point(17, 95);
            this.Group_Step3.Name = "Group_Step3";
            this.Group_Step3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Group_Step3.Size = new System.Drawing.Size(256, 234);
            this.Group_Step3.TabIndex = 3;
            this.Group_Step3.TabStop = false;
            this.Group_Step3.Text = "3. Elegí tu variante preferida";
            // 
            // listBox_GarmentVariants
            // 
            this.listBox_GarmentVariants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_GarmentVariants.FormattingEnabled = true;
            this.listBox_GarmentVariants.ItemHeight = 19;
            this.listBox_GarmentVariants.Location = new System.Drawing.Point(12, 33);
            this.listBox_GarmentVariants.Name = "listBox_GarmentVariants";
            this.listBox_GarmentVariants.Size = new System.Drawing.Size(238, 194);
            this.listBox_GarmentVariants.TabIndex = 9;
            // 
            // Group_Step1
            // 
            this.Group_Step1.Controls.Add(this.comboBox_Garments);
            this.Group_Step1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Step1.Location = new System.Drawing.Point(17, 27);
            this.Group_Step1.Name = "Group_Step1";
            this.Group_Step1.Size = new System.Drawing.Size(251, 62);
            this.Group_Step1.TabIndex = 0;
            this.Group_Step1.TabStop = false;
            this.Group_Step1.Text = "1. Selecciona una Prenda";
            // 
            // comboBox_Garments
            // 
            this.comboBox_Garments.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Garments.FormattingEnabled = true;
            this.comboBox_Garments.Location = new System.Drawing.Point(12, 21);
            this.comboBox_Garments.Name = "comboBox_Garments";
            this.comboBox_Garments.Size = new System.Drawing.Size(233, 27);
            this.comboBox_Garments.TabIndex = 3;
            // 
            // errorProvider_MainWindow
            // 
            this.errorProvider_MainWindow.ContainerControl = this;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 629);
            this.Controls.Add(this.Panel_MainContent);
            this.Controls.Add(this.Panel_FixedBottom);
            this.Controls.Add(this.Panel_SellerInfo);
            this.Controls.Add(this.Panel_StoreInfo);
            this.Controls.Add(this.Panel_FixedTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMain";
            this.Text = "Cotizador";
            this.Load += new System.EventHandler(this.ViewMain_Load);
            this.Panel_FixedTop.ResumeLayout(false);
            this.Panel_FixedTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_CloseApp)).EndInit();
            this.Panel_StoreInfo.ResumeLayout(false);
            this.Panel_StoreInfo.PerformLayout();
            this.Panel_SellerInfo.ResumeLayout(false);
            this.Panel_SellerInfo.PerformLayout();
            this.Panel_FixedBottom.ResumeLayout(false);
            this.Panel_FixedBottom.PerformLayout();
            this.Panel_MainContent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Group_SelectedGarmentInfo.ResumeLayout(false);
            this.Group_SelectedGarmentInfo.PerformLayout();
            this.Group_Step2.ResumeLayout(false);
            this.Group_Step2.PerformLayout();
            this.Group_Step3.ResumeLayout(false);
            this.Group_Step1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MainWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_FixedTop;
        private System.Windows.Forms.Panel Panel_StoreInfo;
        private System.Windows.Forms.Label AppTitleLabel;
        private System.Windows.Forms.Panel Panel_SellerInfo;
        private System.Windows.Forms.Panel Panel_FixedBottom;
        private System.Windows.Forms.Panel Panel_MainContent;
        private System.Windows.Forms.PictureBox Btn_CloseApp;
        private System.Windows.Forms.GroupBox Group_Step3;
        private System.Windows.Forms.GroupBox Group_Step1;
        private System.Windows.Forms.GroupBox Group_Step2;
        private System.Windows.Forms.GroupBox Group_SelectedGarmentInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_AvailableStockInfo;
        public System.Windows.Forms.ComboBox comboBox_Garments;
        public System.Windows.Forms.ListBox listBox_GarmentVariants;
        public System.Windows.Forms.CheckBox checkBox_PremiumQuality;
        public System.Windows.Forms.Label Label_VendorInfo;
        public System.Windows.Forms.Label Label_StoreName;
        public System.Windows.Forms.Label Label_StoreAddress;
        public System.Windows.Forms.LinkLabel LinkLabel_VendorCotizations;
        public System.Windows.Forms.TextBox textBox_CotizationQuantity;
        public System.Windows.Forms.Button Btn_GenerateCotization;
        public System.Windows.Forms.Label label_CotizationResult;
        public System.Windows.Forms.Label label_AvailableStockInfoData;
        public System.Windows.Forms.ErrorProvider errorProvider_MainWindow;
    }
}

