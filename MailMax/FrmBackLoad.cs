using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailMax
{
    public partial class FrmBackLoad : Form
    {
        public FrmBackLoad()
        {
            InitializeComponent();
        }

        private void FrmBackLoad_Load(object sender, EventArgs e)
        {
            Size = Owner.Size;
            Location = Owner.Location;
        }
    }
}
