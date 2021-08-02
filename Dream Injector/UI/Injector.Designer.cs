
namespace Dream_Injector
{
    partial class Injector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Injector));
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.pathTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.commonDropDown = new Siticone.UI.WinForms.SiticoneComboBox();
            this.injectBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.miniBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.maxResetBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.FreeBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.workLabel = new System.Windows.Forms.Label();
            this.busyBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dream Injector";
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Animated = false;
            this.pathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.pathTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.pathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathTextBox.DefaultText = "";
            this.pathTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathTextBox.DisabledState.Parent = this.pathTextBox;
            this.pathTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.pathTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathTextBox.FocusedState.Parent = this.pathTextBox;
            this.pathTextBox.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.pathTextBox.ForeColor = System.Drawing.Color.White;
            this.pathTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathTextBox.HoveredState.Parent = this.pathTextBox;
            this.pathTextBox.Location = new System.Drawing.Point(6, 78);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.PasswordChar = '\0';
            this.pathTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.pathTextBox.PlaceholderText = "";
            this.pathTextBox.SelectedText = "";
            this.pathTextBox.ShadowDecoration.Parent = this.pathTextBox;
            this.pathTextBox.Size = new System.Drawing.Size(283, 37);
            this.pathTextBox.TabIndex = 8;
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(1, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "DLL";
            // 
            // chooseBtn
            // 
            this.chooseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.chooseBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.chooseBtn.BorderRadius = 4;
            this.chooseBtn.BorderThickness = 2;
            this.chooseBtn.CheckedState.Parent = this.chooseBtn;
            this.chooseBtn.CustomImages.Parent = this.chooseBtn;
            this.chooseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.chooseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chooseBtn.ForeColor = System.Drawing.Color.White;
            this.chooseBtn.HoveredState.Parent = this.chooseBtn;
            this.chooseBtn.Location = new System.Drawing.Point(297, 78);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.ShadowDecoration.Parent = this.chooseBtn;
            this.chooseBtn.Size = new System.Drawing.Size(111, 37);
            this.chooseBtn.TabIndex = 14;
            this.chooseBtn.Text = "Choose DLL";
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // commonDropDown
            // 
            this.commonDropDown.Animated = true;
            this.commonDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.commonDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.commonDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.commonDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commonDropDown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.commonDropDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.commonDropDown.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.commonDropDown.ForeColor = System.Drawing.Color.White;
            this.commonDropDown.HoveredState.Parent = this.commonDropDown;
            this.commonDropDown.ItemHeight = 30;
            this.commonDropDown.ItemsAppearance.Parent = this.commonDropDown;
            this.commonDropDown.Location = new System.Drawing.Point(6, 156);
            this.commonDropDown.Name = "commonDropDown";
            this.commonDropDown.ShadowDecoration.Parent = this.commonDropDown;
            this.commonDropDown.Size = new System.Drawing.Size(283, 36);
            this.commonDropDown.TabIndex = 17;
            this.commonDropDown.SelectedIndexChanged += new System.EventHandler(this.commonDropDown_SelectedIndexChanged);
            // 
            // injectBtn
            // 
            this.injectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.injectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.injectBtn.BorderRadius = 4;
            this.injectBtn.BorderThickness = 2;
            this.injectBtn.CheckedState.Parent = this.injectBtn;
            this.injectBtn.CustomImages.Parent = this.injectBtn;
            this.injectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.injectBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.injectBtn.ForeColor = System.Drawing.Color.White;
            this.injectBtn.HoveredState.Parent = this.injectBtn;
            this.injectBtn.Location = new System.Drawing.Point(414, 156);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.ShadowDecoration.Parent = this.injectBtn;
            this.injectBtn.Size = new System.Drawing.Size(111, 37);
            this.injectBtn.TabIndex = 18;
            this.injectBtn.Text = "Inject";
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(1, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Process";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.refreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.refreshBtn.BorderRadius = 4;
            this.refreshBtn.BorderThickness = 2;
            this.refreshBtn.CheckedState.Parent = this.refreshBtn;
            this.refreshBtn.CustomImages.Parent = this.refreshBtn;
            this.refreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.HoveredState.Parent = this.refreshBtn;
            this.refreshBtn.Location = new System.Drawing.Point(297, 155);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.ShadowDecoration.Parent = this.refreshBtn;
            this.refreshBtn.Size = new System.Drawing.Size(111, 37);
            this.refreshBtn.TabIndex = 20;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.exitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.exitBtn.BorderRadius = 4;
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.exitBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoveredState.Parent = this.exitBtn;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.exitBtn.Location = new System.Drawing.Point(671, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 27);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.miniBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.miniBtn.BorderRadius = 4;
            this.miniBtn.BorderThickness = 2;
            this.miniBtn.CheckedState.Parent = this.miniBtn;
            this.miniBtn.CustomImages.Parent = this.miniBtn;
            this.miniBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.miniBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.HoveredState.Parent = this.miniBtn;
            this.miniBtn.Image = ((System.Drawing.Image)(resources.GetObject("miniBtn.Image")));
            this.miniBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.miniBtn.Location = new System.Drawing.Point(569, 0);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(45, 27);
            this.miniBtn.TabIndex = 22;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // maxResetBtn
            // 
            this.maxResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.maxResetBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.maxResetBtn.BorderRadius = 4;
            this.maxResetBtn.BorderThickness = 2;
            this.maxResetBtn.CheckedState.Parent = this.maxResetBtn;
            this.maxResetBtn.CustomImages.Parent = this.maxResetBtn;
            this.maxResetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.maxResetBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.maxResetBtn.ForeColor = System.Drawing.Color.White;
            this.maxResetBtn.HoveredState.Parent = this.maxResetBtn;
            this.maxResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("maxResetBtn.Image")));
            this.maxResetBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.maxResetBtn.Location = new System.Drawing.Point(620, 0);
            this.maxResetBtn.Name = "maxResetBtn";
            this.maxResetBtn.ShadowDecoration.Parent = this.maxResetBtn;
            this.maxResetBtn.Size = new System.Drawing.Size(45, 27);
            this.maxResetBtn.TabIndex = 23;
            this.maxResetBtn.Click += new System.EventHandler(this.maxResetBtn_Click);
            // 
            // FreeBtn
            // 
            this.FreeBtn.Animated = false;
            this.FreeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.FreeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.FreeBtn.BorderRadius = 4;
            this.FreeBtn.BorderThickness = 2;
            this.FreeBtn.CheckedState.Parent = this.FreeBtn;
            this.FreeBtn.CustomImages.Parent = this.FreeBtn;
            this.FreeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.FreeBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.FreeBtn.ForeColor = System.Drawing.Color.White;
            this.FreeBtn.HoveredState.Parent = this.FreeBtn;
            this.FreeBtn.Image = ((System.Drawing.Image)(resources.GetObject("FreeBtn.Image")));
            this.FreeBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.FreeBtn.ImeMode = System.Windows.Forms.ImeMode.On;
            this.FreeBtn.Location = new System.Drawing.Point(2, 392);
            this.FreeBtn.Name = "FreeBtn";
            this.FreeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.FreeBtn.PressedDepth = 0;
            this.FreeBtn.ShadowDecoration.Parent = this.FreeBtn;
            this.FreeBtn.Size = new System.Drawing.Size(24, 23);
            this.FreeBtn.TabIndex = 24;
            this.FreeBtn.Click += new System.EventHandler(this.workBtn_Click);
            this.FreeBtn.MouseHover += new System.EventHandler(this.workBtn_MouseHover);
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.workLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.workLabel.Location = new System.Drawing.Point(28, 392);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(36, 20);
            this.workLabel.TabIndex = 25;
            this.workLabel.Text = "N/A";
            // 
            // busyBtn
            // 
            this.busyBtn.Animated = false;
            this.busyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.busyBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.busyBtn.BorderRadius = 4;
            this.busyBtn.BorderThickness = 2;
            this.busyBtn.CheckedState.Parent = this.busyBtn;
            this.busyBtn.CustomImages.Parent = this.busyBtn;
            this.busyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.busyBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.busyBtn.ForeColor = System.Drawing.Color.White;
            this.busyBtn.HoveredState.Parent = this.busyBtn;
            this.busyBtn.Image = ((System.Drawing.Image)(resources.GetObject("busyBtn.Image")));
            this.busyBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.busyBtn.ImeMode = System.Windows.Forms.ImeMode.On;
            this.busyBtn.Location = new System.Drawing.Point(2, 392);
            this.busyBtn.Name = "busyBtn";
            this.busyBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.busyBtn.PressedDepth = 0;
            this.busyBtn.ShadowDecoration.Parent = this.busyBtn;
            this.busyBtn.Size = new System.Drawing.Size(24, 23);
            this.busyBtn.TabIndex = 26;
            // 
            // Injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(717, 418);
            this.Controls.Add(this.busyBtn);
            this.Controls.Add(this.workLabel);
            this.Controls.Add(this.FreeBtn);
            this.Controls.Add(this.maxResetBtn);
            this.Controls.Add(this.miniBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.commonDropDown);
            this.Controls.Add(this.chooseBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Injector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dream Injector";
            this.Load += new System.EventHandler(this.Injector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneTextBox pathTextBox;
        private System.Windows.Forms.Label label4;
        public Siticone.UI.WinForms.SiticoneButton chooseBtn;
        public Siticone.UI.WinForms.SiticoneButton injectBtn;
        private Siticone.UI.WinForms.SiticoneComboBox commonDropDown;
        private System.Windows.Forms.Label label3;
        public Siticone.UI.WinForms.SiticoneButton refreshBtn;
        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        public Siticone.UI.WinForms.SiticoneButton miniBtn;
        public Siticone.UI.WinForms.SiticoneButton maxResetBtn;
        public Siticone.UI.WinForms.SiticoneButton FreeBtn;
        private System.Windows.Forms.Label workLabel;
        public Siticone.UI.WinForms.SiticoneButton busyBtn;
    }
}

