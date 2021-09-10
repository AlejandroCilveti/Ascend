namespace KeyAuth
{
    // Token: 0x02000002 RID: 2
    public partial class Login : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation1 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.key = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.Login_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RememberCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(457, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ascend | Inici de Sessió";
            // 
            // key
            // 
            this.key.AllowDrop = true;
            this.key.BorderColor = System.Drawing.Color.Purple;
            this.key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.key, Siticone.UI.AnimatorNS.DecorationType.None);
            this.key.DefaultText = "";
            this.key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key.DisabledState.Parent = this.key;
            this.key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.key.FocusedState.Parent = this.key;
            this.key.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.key.HoveredState.Parent = this.key;
            this.key.IconRight = ((System.Drawing.Image)(resources.GetObject("key.IconRight")));
            this.key.Location = new System.Drawing.Point(76, 92);
            this.key.Margin = new System.Windows.Forms.Padding(4);
            this.key.Name = "key";
            this.key.PasswordChar = '•';
            this.key.PlaceholderText = "";
            this.key.SelectedText = "";
            this.key.ShadowDecoration.Parent = this.key;
            this.key.Size = new System.Drawing.Size(354, 39);
            this.key.TabIndex = 32;
            this.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // Login_button
            // 
            this.Login_button.Active = false;
            this.Login_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(156)))), ((int)(((byte)(157)))));
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.Login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_button.BorderRadius = 7;
            this.Login_button.ButtonText = "Iniciar Sessió";
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.Login_button, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Login_button.DisabledColor = System.Drawing.Color.Gray;
            this.Login_button.Iconcolor = System.Drawing.Color.Transparent;
            this.Login_button.Iconimage = null;
            this.Login_button.Iconimage_right = null;
            this.Login_button.Iconimage_right_Selected = null;
            this.Login_button.Iconimage_Selected = null;
            this.Login_button.IconMarginLeft = 0;
            this.Login_button.IconMarginRight = 0;
            this.Login_button.IconRightVisible = true;
            this.Login_button.IconRightZoom = 0D;
            this.Login_button.IconVisible = true;
            this.Login_button.IconZoom = 90D;
            this.Login_button.IsTab = false;
            this.Login_button.Location = new System.Drawing.Point(126, 203);
            this.Login_button.Name = "Login_button";
            this.Login_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.Login_button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(141)))));
            this.Login_button.OnHoverTextColor = System.Drawing.Color.White;
            this.Login_button.selected = false;
            this.Login_button.Size = new System.Drawing.Size(250, 48);
            this.Login_button.TabIndex = 42;
            this.Login_button.Text = "Iniciar Sessió";
            this.Login_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_button.Textcolor = System.Drawing.Color.White;
            this.Login_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // RememberCheckBox
            // 
            this.RememberCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.RememberCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.RememberCheckBox.Checked = true;
            this.RememberCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.siticoneTransition1.SetDecoration(this.RememberCheckBox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.RememberCheckBox.ForeColor = System.Drawing.Color.White;
            this.RememberCheckBox.Location = new System.Drawing.Point(126, 159);
            this.RememberCheckBox.Name = "RememberCheckBox";
            this.RememberCheckBox.Size = new System.Drawing.Size(20, 20);
            this.RememberCheckBox.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(116)))), ((int)(((byte)(173)))));
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(152, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Enrecorda\'m";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siticoneTransition1.SetDecoration(this.pictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(437, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 18);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siticoneTransition1.SetDecoration(this.pictureBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(437, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 18);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 288);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RememberCheckBox);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox key;
        private Bunifu.Framework.UI.BunifuFlatButton Login_button;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox RememberCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}