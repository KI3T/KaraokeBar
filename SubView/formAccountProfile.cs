using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeBar.SubView
{
    public partial class formAccountProfile : Form
    {
        public formAccountProfile()
        {
            InitializeComponent();
            numericUpDownStaffPhone.Controls[0].Visible = false;
            numericUpDownStaffCCCD.Controls[0].Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            formChangePassword f = new formChangePassword();
            f.ShowDialog();
        }
    }
}
