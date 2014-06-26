using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolyMYR.Daemon;


namespace PolyMYR
{
    public partial class FRMmenu : MetroFramework.Forms.MetroForm
    {
        public FRMmenu()
        {
            InitializeComponent();
            var _daemonClient = daemonClient;
        }

        private void TileWallet_Click(object sender, EventArgs e)
        {
            Form Mining = new WalletMenu();
            Mining.Show();
        }
    }
}
