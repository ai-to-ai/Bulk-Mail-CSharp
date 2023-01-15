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
    public partial class FrmBack : Form
    {
        public FrmBack()
        {
            InitializeComponent();
        }

        private void FrmBack_Load(object sender, EventArgs e)
        {
            Size = Owner.Size;
            Location = Owner.Location;
        }
    }
}
