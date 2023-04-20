using DevExpress.XtraBars;
using KaraokeBar.SecondView;
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

namespace KaraokeBar.MainView
{
    public partial class formAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public formAdmin()
        {
            InitializeComponent();
        }

        private void barButtonItemAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formAccountManage formPanel = new formAccountManage();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemStaff_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formStaffManage formPanel = new formStaffManage();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formCustomerManage formPanel = new formCustomerManage();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemRoomType_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formRoomTypeManage formPanel = new formRoomTypeManage();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemRoom_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formRoomManager formPanel = new formRoomManager();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemBooking_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formBookingRoomManager formPanel = new formBookingRoomManager();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemServiceCate_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formServiceCateManager formPanel = new formServiceCateManager();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemService_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formServiceManager formPanel = new formServiceManager();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formReceiptManager formPanel = new formReceiptManager();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }

        private void barButtonItemDetailReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelFormAdmin.Controls.Clear();
            formDetailReceiptManager formPanel = new formDetailReceiptManager();
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.Dock = DockStyle.Fill;
            panelFormAdmin.Controls.Add(formPanel);
            formPanel.Show();
        }
    }
}