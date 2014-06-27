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
using PolyMYR.Daemon.Config;


namespace PolyMYR
{
    public partial class FRMmenu : MetroFramework.Forms.MetroForm
    {
        public FRMmenu()
        {
            InitializeComponent();

            InitDaemon();
        }

        private void InitDaemon()
        {
            var config = new DaemonConfig("127.0.0.1", 9333, "user", "password");
            var daemon = new DaemonClient();
            daemon.Initialize(config);
            var valid = daemon.ValidateAddress("myxWybbhUkGzGF7yaf2QVNx3hh3HWTya5t");
        }

        private void TileWallet_Click(object sender, EventArgs e)
        {
            Form Mining = new WalletMenu();
            Mining.Show();
        }
    }
}
