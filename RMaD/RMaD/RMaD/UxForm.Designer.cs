using RMaD.Classes;

namespace RMaD
{
    partial class UxForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxForm));
            this.pnlShipments = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.flpShipments = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddShipment = new System.Windows.Forms.Button();
            this.lblShipments = new System.Windows.Forms.Label();
            this.pnlGroups = new System.Windows.Forms.Panel();
            this.lblGroups = new System.Windows.Forms.Label();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblReports = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblSettins = new System.Windows.Forms.Label();
            this.elShipments = new System.Diagnostics.EventLog();
            this.iconImages = new System.Windows.Forms.ImageList(this.components);
            this.btnSettingsMenu = new System.Windows.Forms.Button();
            this.btnUserMenu = new System.Windows.Forms.Button();
            this.btnReportsMenu = new System.Windows.Forms.Button();
            this.btnGroupMenu = new System.Windows.Forms.Button();
            this.btnShipmentMenu = new System.Windows.Forms.Button();
            this.pbIconImage = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlShipments.SuspendLayout();
            this.pnlGroups.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elShipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShipments
            // 
            this.pnlShipments.Controls.Add(this.btnRemove);
            this.pnlShipments.Controls.Add(this.btnRefresh);
            this.pnlShipments.Controls.Add(this.flpShipments);
            this.pnlShipments.Controls.Add(this.btnAddShipment);
            this.pnlShipments.Controls.Add(this.lblShipments);
            this.pnlShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlShipments.Location = new System.Drawing.Point(77, 2);
            this.pnlShipments.Name = "pnlShipments";
            this.pnlShipments.Size = new System.Drawing.Size(550, 670);
            this.pnlShipments.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(502, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // flpShipments
            // 
            this.flpShipments.AutoScroll = true;
            this.flpShipments.Location = new System.Drawing.Point(31, 53);
            this.flpShipments.Name = "flpShipments";
            this.flpShipments.Size = new System.Drawing.Size(500, 518);
            this.flpShipments.TabIndex = 2;
            // 
            // btnAddShipment
            // 
            this.btnAddShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShipment.Location = new System.Drawing.Point(31, 599);
            this.btnAddShipment.Name = "btnAddShipment";
            this.btnAddShipment.Size = new System.Drawing.Size(126, 43);
            this.btnAddShipment.TabIndex = 1;
            this.btnAddShipment.Text = "Add Shipment";
            this.btnAddShipment.UseVisualStyleBackColor = true;
            this.btnAddShipment.Click += new System.EventHandler(this.btnAddShipment_Click);
            // 
            // lblShipments
            // 
            this.lblShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipments.Location = new System.Drawing.Point(30, 8);
            this.lblShipments.Name = "lblShipments";
            this.lblShipments.Size = new System.Drawing.Size(180, 42);
            this.lblShipments.TabIndex = 0;
            this.lblShipments.Text = "Shipments";
            // 
            // pnlGroups
            // 
            this.pnlGroups.Controls.Add(this.lblGroups);
            this.pnlGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGroups.Location = new System.Drawing.Point(77, 2);
            this.pnlGroups.Name = "pnlGroups";
            this.pnlGroups.Size = new System.Drawing.Size(550, 670);
            this.pnlGroups.TabIndex = 1;
            // 
            // lblGroups
            // 
            this.lblGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.Location = new System.Drawing.Point(30, 27);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(127, 42);
            this.lblGroups.TabIndex = 0;
            this.lblGroups.Text = "Groups";
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.lblReports);
            this.pnlReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReports.Location = new System.Drawing.Point(77, 2);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(550, 670);
            this.pnlReports.TabIndex = 2;
            // 
            // lblReports
            // 
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(30, 27);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(127, 42);
            this.lblReports.TabIndex = 0;
            this.lblReports.Text = "Reports";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.pbIconImage);
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUser.Location = new System.Drawing.Point(77, 2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(550, 670);
            this.pnlUser.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(178, 245);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(176, 42);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.lblSettins);
            this.pnlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSettings.Location = new System.Drawing.Point(77, 2);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(550, 670);
            this.pnlSettings.TabIndex = 4;
            // 
            // lblSettins
            // 
            this.lblSettins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettins.Location = new System.Drawing.Point(30, 27);
            this.lblSettins.Name = "lblSettins";
            this.lblSettins.Size = new System.Drawing.Size(137, 42);
            this.lblSettins.TabIndex = 0;
            this.lblSettins.Text = "Settings";
            // 
            // elShipments
            // 
            this.elShipments.SynchronizingObject = this;
            // 
            // iconImages
            // 
            this.iconImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImages.ImageStream")));
            this.iconImages.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImages.Images.SetKeyName(0, "GroupMenu32x32.png");
            this.iconImages.Images.SetKeyName(1, "Shipments32x32.png");
            this.iconImages.Images.SetKeyName(2, "ReportMenu32x32.png");
            this.iconImages.Images.SetKeyName(3, "UserMenu32x32.png");
            this.iconImages.Images.SetKeyName(4, "Settings32x32.png");
            this.iconImages.Images.SetKeyName(5, "UserIcon.png");
            // 
            // btnSettingsMenu
            // 
            this.btnSettingsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsMenu.ImageIndex = 4;
            this.btnSettingsMenu.ImageList = this.iconImages;
            this.btnSettingsMenu.Location = new System.Drawing.Point(-1, 622);
            this.btnSettingsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettingsMenu.Name = "btnSettingsMenu";
            this.btnSettingsMenu.Size = new System.Drawing.Size(75, 50);
            this.btnSettingsMenu.TabIndex = 5;
            this.btnSettingsMenu.UseVisualStyleBackColor = true;
            this.btnSettingsMenu.Click += new System.EventHandler(this.btnSettingsMenu_Click);
            // 
            // btnUserMenu
            // 
            this.btnUserMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserMenu.ImageIndex = 3;
            this.btnUserMenu.ImageList = this.iconImages;
            this.btnUserMenu.Location = new System.Drawing.Point(-1, 572);
            this.btnUserMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserMenu.Name = "btnUserMenu";
            this.btnUserMenu.Size = new System.Drawing.Size(75, 50);
            this.btnUserMenu.TabIndex = 75;
            this.btnUserMenu.UseVisualStyleBackColor = true;
            this.btnUserMenu.Click += new System.EventHandler(this.btnUserMenu_Click);
            // 
            // btnReportsMenu
            // 
            this.btnReportsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportsMenu.ImageIndex = 2;
            this.btnReportsMenu.ImageList = this.iconImages;
            this.btnReportsMenu.Location = new System.Drawing.Point(-1, 102);
            this.btnReportsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportsMenu.Name = "btnReportsMenu";
            this.btnReportsMenu.Size = new System.Drawing.Size(75, 50);
            this.btnReportsMenu.TabIndex = 3;
            this.btnReportsMenu.UseVisualStyleBackColor = true;
            this.btnReportsMenu.Click += new System.EventHandler(this.btnReportsMenu_Click);
            // 
            // btnGroupMenu
            // 
            this.btnGroupMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupMenu.ImageKey = "GroupMenu32x32.png";
            this.btnGroupMenu.ImageList = this.iconImages;
            this.btnGroupMenu.Location = new System.Drawing.Point(-1, 52);
            this.btnGroupMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnGroupMenu.Name = "btnGroupMenu";
            this.btnGroupMenu.Size = new System.Drawing.Size(75, 50);
            this.btnGroupMenu.TabIndex = 2;
            this.btnGroupMenu.UseVisualStyleBackColor = true;
            this.btnGroupMenu.Click += new System.EventHandler(this.btnGroupMenu_Click);
            // 
            // btnShipmentMenu
            // 
            this.btnShipmentMenu.AccessibleDescription = "Shows a list of shipments that are currently being tracked or have been completed" +
    ".";
            this.btnShipmentMenu.AccessibleName = "Shipments";
            this.btnShipmentMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShipmentMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnShipmentMenu.ImageKey = "Shipments32x32.png";
            this.btnShipmentMenu.ImageList = this.iconImages;
            this.btnShipmentMenu.Location = new System.Drawing.Point(-1, 2);
            this.btnShipmentMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnShipmentMenu.Name = "btnShipmentMenu";
            this.btnShipmentMenu.Size = new System.Drawing.Size(75, 50);
            this.btnShipmentMenu.TabIndex = 1;
            this.btnShipmentMenu.UseVisualStyleBackColor = false;
            this.btnShipmentMenu.Click += new System.EventHandler(this.btnShipmentMenu_Click);
            // 
            // pbIconImage
            // 
            this.pbIconImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbIconImage.Image = ((System.Drawing.Image)(resources.GetObject("pbIconImage.Image")));
            this.pbIconImage.Location = new System.Drawing.Point(196, 90);
            this.pbIconImage.Name = "pbIconImage";
            this.pbIconImage.Size = new System.Drawing.Size(133, 134);
            this.pbIconImage.TabIndex = 1;
            this.pbIconImage.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(163, 599);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 43);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Shipment";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // UxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 672);
            this.Controls.Add(this.btnSettingsMenu);
            this.Controls.Add(this.btnUserMenu);
            this.Controls.Add(this.btnReportsMenu);
            this.Controls.Add(this.btnGroupMenu);
            this.Controls.Add(this.btnShipmentMenu);
            this.Controls.Add(this.pnlShipments);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.pnlGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UxForm_Load);
            this.pnlShipments.ResumeLayout(false);
            this.pnlGroups.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elShipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShipments;
        private System.Windows.Forms.Label lblShipments;
        private System.Windows.Forms.Button btnShipmentMenu;
        private System.Windows.Forms.Button btnGroupMenu;
        private System.Windows.Forms.Button btnReportsMenu;
        private System.Windows.Forms.Button btnUserMenu;
        private System.Windows.Forms.Button btnSettingsMenu;
        private System.Windows.Forms.Panel pnlGroups;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSettins;
        private System.Windows.Forms.Button btnAddShipment;
        private System.Windows.Forms.FlowLayoutPanel flpShipments;
        private System.Diagnostics.EventLog elShipments;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList iconImages;
        private System.Windows.Forms.PictureBox pbIconImage;
        private System.Windows.Forms.Button btnRemove;
    }
}