namespace PolyMYR
{
    partial class FRMmenu
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
            this.TileWallet = new MetroFramework.Controls.MetroTile();
            this.TILEpricing = new MetroFramework.Controls.MetroTile();
            this.TILEnews = new MetroFramework.Controls.MetroTile();
            this.TILEcommunity = new MetroFramework.Controls.MetroTile();
            this.TILEmining = new MetroFramework.Controls.MetroTile();
            this.TILEsettings = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // TileWallet
            // 
            this.TileWallet.Location = new System.Drawing.Point(23, 73);
            this.TileWallet.Name = "TileWallet";
            this.TileWallet.Size = new System.Drawing.Size(111, 78);
            this.TileWallet.TabIndex = 0;
            this.TileWallet.Text = "Wallet";
            this.TileWallet.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TileWallet.Click += new System.EventHandler(this.TileWallet_Click);
            // 
            // TILEpricing
            // 
            this.TILEpricing.Location = new System.Drawing.Point(167, 73);
            this.TILEpricing.Name = "TILEpricing";
            this.TILEpricing.Size = new System.Drawing.Size(111, 78);
            this.TILEpricing.Style = MetroFramework.MetroColorStyle.Orange;
            this.TILEpricing.TabIndex = 1;
            this.TILEpricing.Text = "Pricing";
            // 
            // TILEnews
            // 
            this.TILEnews.Location = new System.Drawing.Point(23, 169);
            this.TILEnews.Name = "TILEnews";
            this.TILEnews.Size = new System.Drawing.Size(111, 78);
            this.TILEnews.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TILEnews.TabIndex = 2;
            this.TILEnews.Text = "News";
            // 
            // TILEcommunity
            // 
            this.TILEcommunity.Location = new System.Drawing.Point(167, 169);
            this.TILEcommunity.Name = "TILEcommunity";
            this.TILEcommunity.Size = new System.Drawing.Size(111, 78);
            this.TILEcommunity.Style = MetroFramework.MetroColorStyle.Pink;
            this.TILEcommunity.TabIndex = 3;
            this.TILEcommunity.Text = "Community";
            // 
            // TILEmining
            // 
            this.TILEmining.Location = new System.Drawing.Point(315, 73);
            this.TILEmining.Name = "TILEmining";
            this.TILEmining.Size = new System.Drawing.Size(111, 78);
            this.TILEmining.Style = MetroFramework.MetroColorStyle.Lime;
            this.TILEmining.TabIndex = 4;
            this.TILEmining.Text = "Mining";
            // 
            // TILEsettings
            // 
            this.TILEsettings.Location = new System.Drawing.Point(315, 169);
            this.TILEsettings.Name = "TILEsettings";
            this.TILEsettings.Size = new System.Drawing.Size(111, 78);
            this.TILEsettings.Style = MetroFramework.MetroColorStyle.Red;
            this.TILEsettings.TabIndex = 5;
            this.TILEsettings.Text = "Settings";
            // 
            // FRMmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 287);
            this.Controls.Add(this.TILEsettings);
            this.Controls.Add(this.TILEmining);
            this.Controls.Add(this.TILEcommunity);
            this.Controls.Add(this.TILEnews);
            this.Controls.Add(this.TILEpricing);
            this.Controls.Add(this.TileWallet);
            this.KeyPreview = true;
            this.Name = "FRMmenu";
            this.Text = "Main Menu";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile TileWallet;
        private MetroFramework.Controls.MetroTile TILEpricing;
        private MetroFramework.Controls.MetroTile TILEnews;
        private MetroFramework.Controls.MetroTile TILEcommunity;
        private MetroFramework.Controls.MetroTile TILEmining;
        private MetroFramework.Controls.MetroTile TILEsettings;
    }
}