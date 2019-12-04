using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplication
{
    public partial class CWID : Form
    {
        public CWID()
        {
            InitializeComponent();
        }

        private void TextCWID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMain myMain = new frmMain(textCWID.Text);

            if(myMain.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }
        }
    }
}
