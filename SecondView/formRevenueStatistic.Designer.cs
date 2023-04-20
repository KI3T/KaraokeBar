
namespace KaraokeBar.SecondView
{
    partial class formRevenueStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRevenueStatistic));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelFormRevenueStatistic = new System.Windows.Forms.Panel();
            this.panelGridView = new System.Windows.Forms.Panel();
            this.gridControlRevenueStatistic = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.labelTO = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.buttonStatistic = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelFormRevenueStatistic.SuspendLayout();
            this.panelGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRevenueStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormRevenueStatistic
            // 
            this.panelFormRevenueStatistic.Controls.Add(this.panelGridView);
            this.panelFormRevenueStatistic.Controls.Add(this.panelControl);
            this.panelFormRevenueStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormRevenueStatistic.Location = new System.Drawing.Point(0, 0);
            this.panelFormRevenueStatistic.Name = "panelFormRevenueStatistic";
            this.panelFormRevenueStatistic.Size = new System.Drawing.Size(1918, 856);
            this.panelFormRevenueStatistic.TabIndex = 0;
            // 
            // panelGridView
            // 
            this.panelGridView.Controls.Add(this.gridControlRevenueStatistic);
            this.panelGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGridView.Location = new System.Drawing.Point(0, 76);
            this.panelGridView.Name = "panelGridView";
            this.panelGridView.Size = new System.Drawing.Size(1918, 780);
            this.panelGridView.TabIndex = 1;
            // 
            // gridControlRevenueStatistic
            // 
            this.gridControlRevenueStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRevenueStatistic.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlRevenueStatistic.Location = new System.Drawing.Point(0, 0);
            this.gridControlRevenueStatistic.MainView = this.gridView1;
            this.gridControlRevenueStatistic.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlRevenueStatistic.Name = "gridControlRevenueStatistic";
            this.gridControlRevenueStatistic.Size = new System.Drawing.Size(1918, 780);
            this.gridControlRevenueStatistic.TabIndex = 0;
            this.gridControlRevenueStatistic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlRevenueStatistic;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonStatistic);
            this.panelControl.Controls.Add(this.labelTO);
            this.panelControl.Controls.Add(this.dateTimePickerEnd);
            this.panelControl.Controls.Add(this.dateTimePickerBegin);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1918, 70);
            this.panelControl.TabIndex = 0;
            // 
            // labelTO
            // 
            this.labelTO.AutoSize = true;
            this.labelTO.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTO.Location = new System.Drawing.Point(545, 18);
            this.labelTO.Name = "labelTO";
            this.labelTO.Size = new System.Drawing.Size(64, 37);
            this.labelTO.TabIndex = 2;
            this.labelTO.Text = "đến";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(683, 12);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(450, 45);
            this.dateTimePickerEnd.TabIndex = 1;
            this.dateTimePickerEnd.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBegin.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(450, 45);
            this.dateTimePickerBegin.TabIndex = 0;
            this.dateTimePickerBegin.Value = new System.DateTime(2023, 2, 1, 0, 0, 0, 0);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.AllowAnimations = true;
            this.buttonStatistic.AllowMouseEffects = true;
            this.buttonStatistic.AllowToggling = false;
            this.buttonStatistic.AnimationSpeed = 200;
            this.buttonStatistic.AutoGenerateColors = false;
            this.buttonStatistic.AutoRoundBorders = false;
            this.buttonStatistic.AutoSizeLeftIcon = true;
            this.buttonStatistic.AutoSizeRightIcon = true;
            this.buttonStatistic.BackColor = System.Drawing.Color.Transparent;
            this.buttonStatistic.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonStatistic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStatistic.BackgroundImage")));
            this.buttonStatistic.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonStatistic.ButtonText = "Thống kê";
            this.buttonStatistic.ButtonTextMarginLeft = 0;
            this.buttonStatistic.ColorContrastOnClick = 45;
            this.buttonStatistic.ColorContrastOnHover = 45;
            this.buttonStatistic.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonStatistic.CustomizableEdges = borderEdges1;
            this.buttonStatistic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonStatistic.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonStatistic.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonStatistic.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonStatistic.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonStatistic.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistic.ForeColor = System.Drawing.Color.White;
            this.buttonStatistic.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistic.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonStatistic.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonStatistic.IconMarginLeft = 11;
            this.buttonStatistic.IconPadding = 10;
            this.buttonStatistic.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStatistic.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonStatistic.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonStatistic.IconSize = 25;
            this.buttonStatistic.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonStatistic.IdleBorderRadius = 30;
            this.buttonStatistic.IdleBorderThickness = 1;
            this.buttonStatistic.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonStatistic.IdleIconLeftImage = null;
            this.buttonStatistic.IdleIconRightImage = null;
            this.buttonStatistic.IndicateFocus = false;
            this.buttonStatistic.Location = new System.Drawing.Point(1260, 12);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonStatistic.OnDisabledState.BorderRadius = 30;
            this.buttonStatistic.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonStatistic.OnDisabledState.BorderThickness = 1;
            this.buttonStatistic.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonStatistic.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonStatistic.OnDisabledState.IconLeftImage = null;
            this.buttonStatistic.OnDisabledState.IconRightImage = null;
            this.buttonStatistic.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonStatistic.onHoverState.BorderRadius = 30;
            this.buttonStatistic.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonStatistic.onHoverState.BorderThickness = 1;
            this.buttonStatistic.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonStatistic.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonStatistic.onHoverState.IconLeftImage = null;
            this.buttonStatistic.onHoverState.IconRightImage = null;
            this.buttonStatistic.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonStatistic.OnIdleState.BorderRadius = 30;
            this.buttonStatistic.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonStatistic.OnIdleState.BorderThickness = 1;
            this.buttonStatistic.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonStatistic.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonStatistic.OnIdleState.IconLeftImage = null;
            this.buttonStatistic.OnIdleState.IconRightImage = null;
            this.buttonStatistic.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonStatistic.OnPressedState.BorderRadius = 30;
            this.buttonStatistic.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonStatistic.OnPressedState.BorderThickness = 1;
            this.buttonStatistic.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonStatistic.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonStatistic.OnPressedState.IconLeftImage = null;
            this.buttonStatistic.OnPressedState.IconRightImage = null;
            this.buttonStatistic.Size = new System.Drawing.Size(214, 45);
            this.buttonStatistic.TabIndex = 3;
            this.buttonStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonStatistic.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonStatistic.TextMarginLeft = 0;
            this.buttonStatistic.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonStatistic.UseDefaultRadiusAndThickness = true;
            // 
            // formRevenueStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1918, 856);
            this.Controls.Add(this.panelFormRevenueStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formRevenueStatistic";
            this.Text = "formRevenueStatistic";
            this.panelFormRevenueStatistic.ResumeLayout(false);
            this.panelGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRevenueStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormRevenueStatistic;
        private System.Windows.Forms.Panel panelGridView;
        private System.Windows.Forms.Panel panelControl;
        private DevExpress.XtraGrid.GridControl gridControlRevenueStatistic;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelTO;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonStatistic;
    }
}