﻿using KaraokeBar.SubView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeBar
{
    public partial class formStaff : Form
    {
        public formStaff()
        {
            InitializeComponent();
        }

        private void formStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formStaff_Load(object sender, EventArgs e)
        {
            // Tạo một Timer với khoảng thời gian là 1 giây
            Timer timer = new Timer();
            timer.Interval = 1000;

            // Gán sự kiện Tick cho Timer
            timer.Tick += new EventHandler(timer_Tick);

            // Bắt đầu chạy Timer
            timer.Start();

            DateTime now = DateTime.Now;
            labelDay.Text = now.ToString("dddd");
            labelDate.Text = now.ToString("dd/MM/yyyy");
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại của hệ thống
            DateTime currentTime = DateTime.Now;

            // Gán giá trị định dạng thời gian vào thuộc tính Text của Label
            labelTime.Text = currentTime.ToString("hh:mm:ss tt");
        }

        private void buttonListRoom_Click(object sender, EventArgs e)
        {
            flowLayoutPanelRoomService.Visible = false;
        }

        private void buttonListService_Click(object sender, EventArgs e)
        {
            flowLayoutPanelRoomService.Visible = false;
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            flowLayoutPanelRoomService.Visible = true;
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            flowLayoutPanelRoomService.Visible = true;
        }

        private void accInforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAccountProfile f = new formAccountProfile();
            f.ShowDialog();
        }
    }
}
