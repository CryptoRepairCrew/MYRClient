namespace PolyMYR
{
    partial class MainMenu
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TABoverview = new MetroFramework.Controls.MetroTabPage();
            this.TABtransactions = new MetroFramework.Controls.MetroTabPage();
            this.TABconsole = new MetroFramework.Controls.MetroTabPage();
            this.TABsend_coins = new MetroFramework.Controls.MetroTabPage();
            this.TABaddresses = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.TABoverview);
            this.metroTabControl1.Controls.Add(this.TABtransactions);
            this.metroTabControl1.Controls.Add(this.TABconsole);
            this.metroTabControl1.Controls.Add(this.TABsend_coins);
            this.metroTabControl1.Controls.Add(this.TABaddresses);
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 4;
            this.metroTabControl1.Size = new System.Drawing.Size(477, 248);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // TABoverview
            // 
            this.TABoverview.HorizontalScrollbarBarColor = true;
            this.TABoverview.Location = new System.Drawing.Point(4, 38);
            this.TABoverview.Name = "TABoverview";
            this.TABoverview.Size = new System.Drawing.Size(489, 206);
            this.TABoverview.TabIndex = 0;
            this.TABoverview.Text = "Overview";
            this.TABoverview.VerticalScrollbarBarColor = true;
            // 
            // TABtransactions
            // 
            this.TABtransactions.HorizontalScrollbarBarColor = true;
            this.TABtransactions.Location = new System.Drawing.Point(4, 38);
            this.TABtransactions.Name = "TABtransactions";
            this.TABtransactions.Size = new System.Drawing.Size(489, 206);
            this.TABtransactions.TabIndex = 1;
            this.TABtransactions.Text = "Transactions";
            this.TABtransactions.VerticalScrollbarBarColor = true;
            // 
            // TABconsole
            // 
            this.TABconsole.HorizontalScrollbarBarColor = true;
            this.TABconsole.Location = new System.Drawing.Point(4, 38);
            this.TABconsole.Name = "TABconsole";
            this.TABconsole.Size = new System.Drawing.Size(489, 206);
            this.TABconsole.TabIndex = 2;
            this.TABconsole.Text = "Console";
            this.TABconsole.VerticalScrollbarBarColor = true;
            // 
            // TABsend_coins
            // 
            this.TABsend_coins.HorizontalScrollbarBarColor = true;
            this.TABsend_coins.Location = new System.Drawing.Point(4, 38);
            this.TABsend_coins.Name = "TABsend_coins";
            this.TABsend_coins.Size = new System.Drawing.Size(489, 206);
            this.TABsend_coins.TabIndex = 3;
            this.TABsend_coins.Text = "Send Coins";
            this.TABsend_coins.VerticalScrollbarBarColor = true;
            // 
            // TABaddresses
            // 
            this.TABaddresses.HorizontalScrollbarBarColor = true;
            this.TABaddresses.Location = new System.Drawing.Point(4, 38);
            this.TABaddresses.Name = "TABaddresses";
            this.TABaddresses.Size = new System.Drawing.Size(469, 206);
            this.TABaddresses.TabIndex = 4;
            this.TABaddresses.Text = "Recieve Coins";
            this.TABaddresses.VerticalScrollbarBarColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 325);
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "MainMenu";
            this.Text = "MyriadCoin Wallet";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TABoverview;
        private MetroFramework.Controls.MetroTabPage TABtransactions;
        private MetroFramework.Controls.MetroTabPage TABconsole;
        private MetroFramework.Controls.MetroTabPage TABsend_coins;
        private MetroFramework.Controls.MetroTabPage TABaddresses;

    }
}