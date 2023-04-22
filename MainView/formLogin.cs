using KaraokeBar.DAO;
using KaraokeBar.MainView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeBar
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonLoginStaff_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "staff";
            textBoxPassword.Text = "123";
            buttonLogin_Click(sender, e);
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "admin";
            textBoxPassword.Text = "123";
            buttonLogin_Click(sender, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void textBoxUsername_TextChange(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                buttonLogin.Enabled = true;
                //buttonLogin.IdleBorderColor = Color.FromArgb(254, 189, 148);
                //buttonLogin.IdleFillColor = Color.FromArgb(254, 189, 148);
                buttonLogin.Cursor = Cursors.Hand;
                textBoxPassword.IconLeft = Properties.Resources.lockopen;
            }
            else
            {
                buttonLogin.Enabled = false;
                //buttonLogin.IdleBorderColor = Color.WhiteSmoke;
                //buttonLogin.IdleFillColor = Color.WhiteSmoke;
                buttonLogin.Cursor = Cursors.Default;
                textBoxPassword.IconLeft = Properties.Resources.lockclose;
            }
        }

        private void textBoxPassword_TextChange(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                buttonLogin.Enabled = true;
                buttonLogin.Cursor = Cursors.Hand;
                textBoxPassword.IconLeft = Properties.Resources.lockopen;
            }
            else
            {
                buttonLogin.Enabled = false;
                buttonLogin.Cursor = Cursors.Default;
                textBoxPassword.IconLeft = Properties.Resources.lockclose;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string accountUserName = textBoxUsername.Text;
            string accountPassword = textBoxPassword.Text;

            //Thread thread = new Thread(() =>
            //{
            //    // Hiển thị formWait
            //    formWait fWait = new formWait();
            //    fWait.ShowDialog();
            //});

            //thread.Start(); // Bắt đầu chạy thread mới
            //Thread.Sleep(500); // Chờ 0.1 giây trước khi tiếp tục thực hiện đoạn code phía dưới

            if (Login(accountUserName, accountPassword))
            {
                // Đóng formWait nếu đã đăng nhập thành công
                //thread.Abort();
                string accountPermission = AccountDAO.Instance.GetAccountPermission(accountUserName);
                switch (accountPermission.ToLower())
                {
                    case "boss":
                        formBoss f1 = new formBoss();
                        this.Hide();
                        f1.ShowDialog();
                        this.Show();
                        break;
                    case "admin":
                        formAdmin f2 = new formAdmin();
                        this.Hide();
                        f2.ShowDialog();
                        this.Show();
                        break;
                    case "staff":
                        formStaff f3 = new formStaff();
                        this.Hide();
                        f3.ShowDialog();
                        this.Show();
                        break;
                }
            }
            else
            {
                // Đóng formWait nếu đăng nhập không thành công
                //thread.Abort();
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }


        bool Login(string accountUserName, string accountPassword)
        {
            return AccountDAO.Instance.Login(accountUserName, accountPassword);
        }

        private void checkBoxShowHide_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkBoxShowHide.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void checkBoxShowHide_MouseHover(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked)
            {
                checkBoxShowHide.ToolTipText = "Ẩn mật khẩu";
            }
            else
            {
                checkBoxShowHide.ToolTipText = "Hiện mật khẩu";
            }
        }
    }
}
