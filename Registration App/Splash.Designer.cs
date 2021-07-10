
namespace Registration_App
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.label1 = new System.Windows.Forms.Label();
            this.MyProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSearchEditing = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchEditing = new Guna.UI2.WinForms.Guna2TextBox();
            this.MyProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("AD-STOOR", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "نظام تسجيل الطلبة";
            // 
            // MyProgress
            // 
            this.MyProgress.BackColor = System.Drawing.Color.Transparent;
            this.MyProgress.Controls.Add(this.guna2CirclePictureBox1);
            this.MyProgress.FillThickness = 10;
            this.MyProgress.ForeColor = System.Drawing.Color.Transparent;
            this.MyProgress.Location = new System.Drawing.Point(174, 66);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.ProgressColor = System.Drawing.Color.DarkGreen;
            this.MyProgress.ProgressColor2 = System.Drawing.Color.LimeGreen;
            this.MyProgress.ProgressThickness = 10;
            this.MyProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MyProgress.ShadowDecoration.Parent = this.MyProgress;
            this.MyProgress.Size = new System.Drawing.Size(153, 141);
            this.MyProgress.TabIndex = 2;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(33, 28);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(86, 82);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("AD-STOOR", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلية علوم الحاسوب و الرياضيات";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.MyProgress);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSearchEditing);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtSearchEditing);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Indigo;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.DarkCyan;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(523, 253);
            this.guna2CustomGradientPanel1.TabIndex = 8;
            // 
            // btnSearchEditing
            // 
            this.btnSearchEditing.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchEditing.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchEditing.BorderRadius = 15;
            this.btnSearchEditing.BorderThickness = 1;
            this.btnSearchEditing.CheckedState.Parent = this.btnSearchEditing;
            this.btnSearchEditing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchEditing.CustomImages.Parent = this.btnSearchEditing;
            this.btnSearchEditing.FillColor = System.Drawing.Color.DarkGreen;
            this.btnSearchEditing.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btnSearchEditing.ForeColor = System.Drawing.Color.White;
            this.btnSearchEditing.HoverState.Parent = this.btnSearchEditing;
            this.btnSearchEditing.Location = new System.Drawing.Point(849, 17);
            this.btnSearchEditing.Name = "btnSearchEditing";
            this.btnSearchEditing.ShadowDecoration.Parent = this.btnSearchEditing;
            this.btnSearchEditing.Size = new System.Drawing.Size(118, 35);
            this.btnSearchEditing.TabIndex = 1;
            this.btnSearchEditing.Text = "جلب المعلومات";
            // 
            // txtSearchEditing
            // 
            this.txtSearchEditing.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchEditing.BorderColor = System.Drawing.Color.White;
            this.txtSearchEditing.BorderRadius = 7;
            this.txtSearchEditing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEditing.DefaultText = "";
            this.txtSearchEditing.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchEditing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchEditing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchEditing.DisabledState.Parent = this.txtSearchEditing;
            this.txtSearchEditing.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchEditing.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchEditing.FocusedState.Parent = this.txtSearchEditing;
            this.txtSearchEditing.Font = new System.Drawing.Font("Hacen Liner Screen Bd", 12F);
            this.txtSearchEditing.ForeColor = System.Drawing.Color.Black;
            this.txtSearchEditing.HideSelection = false;
            this.txtSearchEditing.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchEditing.HoverState.Parent = this.txtSearchEditing;
            this.txtSearchEditing.Location = new System.Drawing.Point(975, 15);
            this.txtSearchEditing.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearchEditing.Name = "txtSearchEditing";
            this.txtSearchEditing.PasswordChar = '\0';
            this.txtSearchEditing.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchEditing.PlaceholderText = "ادخل التسلسل او الاسم للطالب";
            this.txtSearchEditing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchEditing.SelectedText = "";
            this.txtSearchEditing.ShadowDecoration.Parent = this.txtSearchEditing;
            this.txtSearchEditing.Size = new System.Drawing.Size(261, 38);
            this.txtSearchEditing.TabIndex = 0;
            this.txtSearchEditing.TabStop = false;
            this.txtSearchEditing.Tag = "";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.MyProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar MyProgress;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSearchEditing;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchEditing;
    }
}

