
namespace KaraokeBar.MainView
{
    partial class formAdmin
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemStaff = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRoomType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRoom = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemServiceCate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemService = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBooking = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemReceipt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDetailReceipt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRevenueStatistic = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPagePersonManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupStaff = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCustomer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageKaraokeBarManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupRoom = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupService = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupReceipt = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageStatistic = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupStatistic = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelFormAdmin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(57);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItemAccount,
            this.barButtonItemStaff,
            this.barButtonItemCustomer,
            this.barButtonItem5,
            this.barButtonItemRoomType,
            this.barButtonItemRoom,
            this.barButtonItemServiceCate,
            this.barButtonItemService,
            this.barButtonItemBooking,
            this.barButtonItemReceipt,
            this.barButtonItemDetailReceipt,
            this.barButtonItemRevenueStatistic});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(6);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 644;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPagePersonManage,
            this.ribbonPageKaraokeBarManage,
            this.ribbonPageStatistic});
            this.ribbon.Size = new System.Drawing.Size(1918, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItemAccount
            // 
            this.barButtonItemAccount.Caption = "Danh sách tài khoản";
            this.barButtonItemAccount.Id = 2;
            this.barButtonItemAccount.ImageOptions.Image = global::KaraokeBar.Properties.Resources.account;
            this.barButtonItemAccount.Name = "barButtonItemAccount";
            this.barButtonItemAccount.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAccount_ItemClick);
            // 
            // barButtonItemStaff
            // 
            this.barButtonItemStaff.Caption = "Danh sách nhân viên";
            this.barButtonItemStaff.Id = 3;
            this.barButtonItemStaff.ImageOptions.Image = global::KaraokeBar.Properties.Resources.person;
            this.barButtonItemStaff.Name = "barButtonItemStaff";
            this.barButtonItemStaff.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemStaff_ItemClick);
            // 
            // barButtonItemCustomer
            // 
            this.barButtonItemCustomer.Caption = "Danh sách khách hàng";
            this.barButtonItemCustomer.Id = 4;
            this.barButtonItemCustomer.ImageOptions.Image = global::KaraokeBar.Properties.Resources.customer;
            this.barButtonItemCustomer.Name = "barButtonItemCustomer";
            this.barButtonItemCustomer.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCustomer_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItemRoomType
            // 
            this.barButtonItemRoomType.Caption = "Danh sách loại phòng";
            this.barButtonItemRoomType.Id = 6;
            this.barButtonItemRoomType.ImageOptions.Image = global::KaraokeBar.Properties.Resources.roomtype;
            this.barButtonItemRoomType.Name = "barButtonItemRoomType";
            this.barButtonItemRoomType.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemRoomType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRoomType_ItemClick);
            // 
            // barButtonItemRoom
            // 
            this.barButtonItemRoom.Caption = "Danh sách phòng";
            this.barButtonItemRoom.Id = 7;
            this.barButtonItemRoom.ImageOptions.Image = global::KaraokeBar.Properties.Resources.roomkaraokeicon;
            this.barButtonItemRoom.Name = "barButtonItemRoom";
            this.barButtonItemRoom.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRoom_ItemClick);
            // 
            // barButtonItemServiceCate
            // 
            this.barButtonItemServiceCate.Caption = "Danh sách loại dịch vụ";
            this.barButtonItemServiceCate.Id = 8;
            this.barButtonItemServiceCate.ImageOptions.Image = global::KaraokeBar.Properties.Resources.servicecate;
            this.barButtonItemServiceCate.Name = "barButtonItemServiceCate";
            this.barButtonItemServiceCate.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemServiceCate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemServiceCate_ItemClick);
            // 
            // barButtonItemService
            // 
            this.barButtonItemService.Caption = "Danh sách dịch vụ";
            this.barButtonItemService.Id = 9;
            this.barButtonItemService.ImageOptions.Image = global::KaraokeBar.Properties.Resources.serviceicon;
            this.barButtonItemService.Name = "barButtonItemService";
            this.barButtonItemService.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemService_ItemClick);
            // 
            // barButtonItemBooking
            // 
            this.barButtonItemBooking.Caption = "Danh sách đặt phòng";
            this.barButtonItemBooking.Id = 10;
            this.barButtonItemBooking.ImageOptions.Image = global::KaraokeBar.Properties.Resources.booking;
            this.barButtonItemBooking.Name = "barButtonItemBooking";
            this.barButtonItemBooking.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemBooking.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBooking_ItemClick);
            // 
            // barButtonItemReceipt
            // 
            this.barButtonItemReceipt.Caption = "Danh sách hoá đơn";
            this.barButtonItemReceipt.Id = 11;
            this.barButtonItemReceipt.ImageOptions.Image = global::KaraokeBar.Properties.Resources.receipt;
            this.barButtonItemReceipt.Name = "barButtonItemReceipt";
            this.barButtonItemReceipt.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemReceipt_ItemClick);
            // 
            // barButtonItemDetailReceipt
            // 
            this.barButtonItemDetailReceipt.Caption = "Danh sách chi tiết hoá đơn";
            this.barButtonItemDetailReceipt.Id = 12;
            this.barButtonItemDetailReceipt.ImageOptions.Image = global::KaraokeBar.Properties.Resources.detailReceipt;
            this.barButtonItemDetailReceipt.Name = "barButtonItemDetailReceipt";
            this.barButtonItemDetailReceipt.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemDetailReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDetailReceipt_ItemClick);
            // 
            // barButtonItemRevenueStatistic
            // 
            this.barButtonItemRevenueStatistic.Caption = "Doanh thu";
            this.barButtonItemRevenueStatistic.Id = 13;
            this.barButtonItemRevenueStatistic.ImageOptions.Image = global::KaraokeBar.Properties.Resources.statistic;
            this.barButtonItemRevenueStatistic.Name = "barButtonItemRevenueStatistic";
            this.barButtonItemRevenueStatistic.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPagePersonManage
            // 
            this.ribbonPagePersonManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupStaff,
            this.ribbonPageGroupCustomer});
            this.ribbonPagePersonManage.Name = "ribbonPagePersonManage";
            this.ribbonPagePersonManage.Text = "Quản lý cá nhân";
            // 
            // ribbonPageGroupStaff
            // 
            this.ribbonPageGroupStaff.ItemLinks.Add(this.barButtonItemAccount);
            this.ribbonPageGroupStaff.ItemLinks.Add(this.barButtonItemStaff);
            this.ribbonPageGroupStaff.Name = "ribbonPageGroupStaff";
            this.ribbonPageGroupStaff.Text = "Nhân viên";
            // 
            // ribbonPageGroupCustomer
            // 
            this.ribbonPageGroupCustomer.ItemLinks.Add(this.barButtonItemCustomer);
            this.ribbonPageGroupCustomer.Name = "ribbonPageGroupCustomer";
            this.ribbonPageGroupCustomer.Text = "Khách hàng";
            // 
            // ribbonPageKaraokeBarManage
            // 
            this.ribbonPageKaraokeBarManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupRoom,
            this.ribbonPageGroupService,
            this.ribbonPageGroupReceipt});
            this.ribbonPageKaraokeBarManage.Name = "ribbonPageKaraokeBarManage";
            this.ribbonPageKaraokeBarManage.Text = "Quản lý quán";
            // 
            // ribbonPageGroupRoom
            // 
            this.ribbonPageGroupRoom.ItemLinks.Add(this.barButtonItemRoomType);
            this.ribbonPageGroupRoom.ItemLinks.Add(this.barButtonItemRoom);
            this.ribbonPageGroupRoom.ItemLinks.Add(this.barButtonItemBooking);
            this.ribbonPageGroupRoom.Name = "ribbonPageGroupRoom";
            this.ribbonPageGroupRoom.Text = "Phòng";
            // 
            // ribbonPageGroupService
            // 
            this.ribbonPageGroupService.ItemLinks.Add(this.barButtonItemServiceCate);
            this.ribbonPageGroupService.ItemLinks.Add(this.barButtonItemService);
            this.ribbonPageGroupService.Name = "ribbonPageGroupService";
            this.ribbonPageGroupService.Text = "Dịch vụ";
            // 
            // ribbonPageGroupReceipt
            // 
            this.ribbonPageGroupReceipt.ItemLinks.Add(this.barButtonItemReceipt);
            this.ribbonPageGroupReceipt.ItemLinks.Add(this.barButtonItemDetailReceipt);
            this.ribbonPageGroupReceipt.Name = "ribbonPageGroupReceipt";
            this.ribbonPageGroupReceipt.Text = "Hoá đơn";
            // 
            // ribbonPageStatistic
            // 
            this.ribbonPageStatistic.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupStatistic});
            this.ribbonPageStatistic.Name = "ribbonPageStatistic";
            this.ribbonPageStatistic.Text = "Thống kê";
            // 
            // ribbonPageGroupStatistic
            // 
            this.ribbonPageGroupStatistic.ItemLinks.Add(this.barButtonItemRevenueStatistic);
            this.ribbonPageGroupStatistic.Name = "ribbonPageGroupStatistic";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1049);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1918, 30);
            // 
            // panelFormAdmin
            // 
            this.panelFormAdmin.BackColor = System.Drawing.Color.White;
            this.panelFormAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormAdmin.Location = new System.Drawing.Point(0, 193);
            this.panelFormAdmin.Name = "panelFormAdmin";
            this.panelFormAdmin.Size = new System.Drawing.Size(1918, 856);
            this.panelFormAdmin.TabIndex = 2;
            // 
            // formAdmin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1079);
            this.Controls.Add(this.panelFormAdmin);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::KaraokeBar.Properties.Resources.logoApp;
            this.Name = "formAdmin";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản trị viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPagePersonManage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStaff;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageKaraokeBarManage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupRoom;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemStaff;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCustomer;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCustomer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageStatistic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStatistic;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRoomType;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRoom;
        private DevExpress.XtraBars.BarButtonItem barButtonItemServiceCate;
        private DevExpress.XtraBars.BarButtonItem barButtonItemService;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBooking;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReceipt;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDetailReceipt;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupService;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupReceipt;
        private System.Windows.Forms.Panel panelFormAdmin;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRevenueStatistic;
    }
}