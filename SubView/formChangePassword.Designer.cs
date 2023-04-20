
namespace KaraokeBar.SubView
{
    partial class formChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChangePassword));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewAccPass = new System.Windows.Forms.TextBox();
            this.textBoxAccountUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConfirmNewAccPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.buttonSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.textBoxOldAccPass = new System.Windows.Forms.TextBox();
            this.textBoxStaffID = new System.Windows.Forms.TextBox();
            this.labelStaffName = new System.Windows.Forms.Label();
            this.labelStaffID = new System.Windows.Forms.Label();
            this.panelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.label3);
            this.panelChangePassword.Controls.Add(this.textBoxNewAccPass);
            this.panelChangePassword.Controls.Add(this.textBoxAccountUserName);
            this.panelChangePassword.Controls.Add(this.label2);
            this.panelChangePassword.Controls.Add(this.textBoxConfirmNewAccPass);
            this.panelChangePassword.Controls.Add(this.label1);
            this.panelChangePassword.Controls.Add(this.buttonClose);
            this.panelChangePassword.Controls.Add(this.buttonSave);
            this.panelChangePassword.Controls.Add(this.textBoxOldAccPass);
            this.panelChangePassword.Controls.Add(this.textBoxStaffID);
            this.panelChangePassword.Controls.Add(this.labelStaffName);
            this.panelChangePassword.Controls.Add(this.labelStaffID);
            this.panelChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChangePassword.Location = new System.Drawing.Point(0, 0);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(756, 406);
            this.panelChangePassword.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label3.Location = new System.Drawing.Point(46, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 33);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // textBoxNewAccPass
            // 
            this.textBoxNewAccPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewAccPass.Location = new System.Drawing.Point(300, 211);
            this.textBoxNewAccPass.Name = "textBoxNewAccPass";
            this.textBoxNewAccPass.Size = new System.Drawing.Size(400, 42);
            this.textBoxNewAccPass.TabIndex = 50;
            // 
            // textBoxAccountUserName
            // 
            this.textBoxAccountUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAccountUserName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccountUserName.Location = new System.Drawing.Point(300, 91);
            this.textBoxAccountUserName.Name = "textBoxAccountUserName";
            this.textBoxAccountUserName.ReadOnly = true;
            this.textBoxAccountUserName.Size = new System.Drawing.Size(400, 42);
            this.textBoxAccountUserName.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label2.Location = new System.Drawing.Point(46, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 33);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nhập lại mật khẩu:";
            // 
            // textBoxConfirmNewAccPass
            // 
            this.textBoxConfirmNewAccPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmNewAccPass.Location = new System.Drawing.Point(300, 271);
            this.textBoxConfirmNewAccPass.Name = "textBoxConfirmNewAccPass";
            this.textBoxConfirmNewAccPass.Size = new System.Drawing.Size(400, 42);
            this.textBoxConfirmNewAccPass.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label1.Location = new System.Drawing.Point(46, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // buttonClose
            // 
            this.buttonClose.AllowAnimations = true;
            this.buttonClose.AllowMouseEffects = true;
            this.buttonClose.AllowToggling = false;
            this.buttonClose.AnimationSpeed = 200;
            this.buttonClose.AutoGenerateColors = false;
            this.buttonClose.AutoRoundBorders = false;
            this.buttonClose.AutoSizeLeftIcon = true;
            this.buttonClose.AutoSizeRightIcon = true;
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackColor1 = System.Drawing.Color.Tomato;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonClose.ButtonText = "Thoát";
            this.buttonClose.ButtonTextMarginLeft = 0;
            this.buttonClose.ColorContrastOnClick = 45;
            this.buttonClose.ColorContrastOnHover = 45;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.buttonClose.CustomizableEdges = borderEdges3;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.DisabledBorderColor = System.Drawing.Color.Tomato;
            this.buttonClose.DisabledFillColor = System.Drawing.Color.Tomato;
            this.buttonClose.DisabledForecolor = System.Drawing.Color.White;
            this.buttonClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonClose.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonClose.IconMarginLeft = 11;
            this.buttonClose.IconPadding = 10;
            this.buttonClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonClose.IconSize = 25;
            this.buttonClose.IdleBorderColor = System.Drawing.Color.Tomato;
            this.buttonClose.IdleBorderRadius = 25;
            this.buttonClose.IdleBorderThickness = 1;
            this.buttonClose.IdleFillColor = System.Drawing.Color.Tomato;
            this.buttonClose.IdleIconLeftImage = null;
            this.buttonClose.IdleIconRightImage = null;
            this.buttonClose.IndicateFocus = false;
            this.buttonClose.Location = new System.Drawing.Point(510, 336);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.OnDisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.buttonClose.OnDisabledState.BorderRadius = 25;
            this.buttonClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonClose.OnDisabledState.BorderThickness = 1;
            this.buttonClose.OnDisabledState.FillColor = System.Drawing.Color.Tomato;
            this.buttonClose.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.buttonClose.OnDisabledState.IconLeftImage = null;
            this.buttonClose.OnDisabledState.IconRightImage = null;
            this.buttonClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.buttonClose.onHoverState.BorderRadius = 25;
            this.buttonClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonClose.onHoverState.BorderThickness = 1;
            this.buttonClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.buttonClose.onHoverState.ForeColor = System.Drawing.Color.Navy;
            this.buttonClose.onHoverState.IconLeftImage = null;
            this.buttonClose.onHoverState.IconRightImage = null;
            this.buttonClose.OnIdleState.BorderColor = System.Drawing.Color.Tomato;
            this.buttonClose.OnIdleState.BorderRadius = 25;
            this.buttonClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonClose.OnIdleState.BorderThickness = 1;
            this.buttonClose.OnIdleState.FillColor = System.Drawing.Color.Tomato;
            this.buttonClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonClose.OnIdleState.IconLeftImage = null;
            this.buttonClose.OnIdleState.IconRightImage = null;
            this.buttonClose.OnPressedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonClose.OnPressedState.BorderRadius = 25;
            this.buttonClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonClose.OnPressedState.BorderThickness = 1;
            this.buttonClose.OnPressedState.FillColor = System.Drawing.Color.OrangeRed;
            this.buttonClose.OnPressedState.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClose.OnPressedState.IconLeftImage = null;
            this.buttonClose.OnPressedState.IconRightImage = null;
            this.buttonClose.Size = new System.Drawing.Size(190, 40);
            this.buttonClose.TabIndex = 45;
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonClose.TextMarginLeft = 0;
            this.buttonClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonClose.UseDefaultRadiusAndThickness = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AllowAnimations = true;
            this.buttonSave.AllowMouseEffects = true;
            this.buttonSave.AllowToggling = false;
            this.buttonSave.AnimationSpeed = 200;
            this.buttonSave.AutoGenerateColors = false;
            this.buttonSave.AutoRoundBorders = false;
            this.buttonSave.AutoSizeLeftIcon = true;
            this.buttonSave.AutoSizeRightIcon = true;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackColor1 = System.Drawing.Color.LimeGreen;
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSave.ButtonText = "Lưu";
            this.buttonSave.ButtonTextMarginLeft = 0;
            this.buttonSave.ColorContrastOnClick = 45;
            this.buttonSave.ColorContrastOnHover = 45;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.buttonSave.CustomizableEdges = borderEdges4;
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSave.DisabledBorderColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.DisabledFillColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.DisabledForecolor = System.Drawing.Color.White;
            this.buttonSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonSave.IconMarginLeft = 11;
            this.buttonSave.IconPadding = 10;
            this.buttonSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonSave.IconSize = 25;
            this.buttonSave.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.IdleBorderRadius = 25;
            this.buttonSave.IdleBorderThickness = 1;
            this.buttonSave.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.IdleIconLeftImage = null;
            this.buttonSave.IdleIconRightImage = null;
            this.buttonSave.IndicateFocus = false;
            this.buttonSave.Location = new System.Drawing.Point(300, 336);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnDisabledState.BorderColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.OnDisabledState.BorderRadius = 25;
            this.buttonSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSave.OnDisabledState.BorderThickness = 1;
            this.buttonSave.OnDisabledState.FillColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.buttonSave.OnDisabledState.IconLeftImage = null;
            this.buttonSave.OnDisabledState.IconRightImage = null;
            this.buttonSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.buttonSave.onHoverState.BorderRadius = 25;
            this.buttonSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSave.onHoverState.BorderThickness = 1;
            this.buttonSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.buttonSave.onHoverState.ForeColor = System.Drawing.Color.Navy;
            this.buttonSave.onHoverState.IconLeftImage = null;
            this.buttonSave.onHoverState.IconRightImage = null;
            this.buttonSave.OnIdleState.BorderColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.OnIdleState.BorderRadius = 25;
            this.buttonSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSave.OnIdleState.BorderThickness = 1;
            this.buttonSave.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonSave.OnIdleState.IconLeftImage = null;
            this.buttonSave.OnIdleState.IconRightImage = null;
            this.buttonSave.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.buttonSave.OnPressedState.BorderRadius = 25;
            this.buttonSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSave.OnPressedState.BorderThickness = 1;
            this.buttonSave.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.buttonSave.OnPressedState.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSave.OnPressedState.IconLeftImage = null;
            this.buttonSave.OnPressedState.IconRightImage = null;
            this.buttonSave.Size = new System.Drawing.Size(190, 40);
            this.buttonSave.TabIndex = 44;
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSave.TextMarginLeft = 0;
            this.buttonSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonSave.UseDefaultRadiusAndThickness = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxOldAccPass
            // 
            this.textBoxOldAccPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldAccPass.Location = new System.Drawing.Point(300, 151);
            this.textBoxOldAccPass.Name = "textBoxOldAccPass";
            this.textBoxOldAccPass.Size = new System.Drawing.Size(400, 42);
            this.textBoxOldAccPass.TabIndex = 43;
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxStaffID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffID.Location = new System.Drawing.Point(300, 30);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.ReadOnly = true;
            this.textBoxStaffID.Size = new System.Drawing.Size(400, 42);
            this.textBoxStaffID.TabIndex = 42;
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.labelStaffName.Location = new System.Drawing.Point(46, 97);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(134, 33);
            this.labelStaffName.TabIndex = 41;
            this.labelStaffName.Text = "Tài khoản:";
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.labelStaffID.Location = new System.Drawing.Point(46, 37);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(174, 33);
            this.labelStaffID.TabIndex = 40;
            this.labelStaffID.Text = "Mã nhân viên:";
            // 
            // formChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 406);
            this.Controls.Add(this.panelChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChangePassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonSave;
        private System.Windows.Forms.TextBox textBoxOldAccPass;
        private System.Windows.Forms.TextBox textBoxStaffID;
        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.Label labelStaffID;
        private System.Windows.Forms.TextBox textBoxConfirmNewAccPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAccountUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewAccPass;
    }
}