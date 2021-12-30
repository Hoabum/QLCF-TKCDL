namespace POS
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lb_gia = new Guna.UI.WinForms.GunaLabel();
            this.lb_soluong = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lb_tenmon = new Guna.UI.WinForms.GunaLabel();
            this.btn_delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.gunaLinePanel1.Controls.Add(this.lb_gia);
            this.gunaLinePanel1.Controls.Add(this.lb_soluong);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel1.Controls.Add(this.lb_tenmon);
            this.gunaLinePanel1.Controls.Add(this.btn_delete);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(493, 90);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // lb_gia
            // 
            this.lb_gia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.749999F, System.Drawing.FontStyle.Bold);
            this.lb_gia.Location = new System.Drawing.Point(421, 34);
            this.lb_gia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(49, 18);
            this.lb_gia.TabIndex = 4;
            this.lb_gia.Text = "25.00";
            // 
            // lb_soluong
            // 
            this.lb_soluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_soluong.BackColor = System.Drawing.Color.Transparent;
            this.lb_soluong.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lb_soluong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_soluong.ButtonColor = System.Drawing.Color.Transparent;
            this.lb_soluong.ButtonForeColor = System.Drawing.Color.Transparent;
            this.lb_soluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lb_soluong.ForeColor = System.Drawing.Color.Black;
            this.lb_soluong.Location = new System.Drawing.Point(320, 23);
            this.lb_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.lb_soluong.Maximum = ((long)(999));
            this.lb_soluong.Minimum = ((long)(0));
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Radius = 4;
            this.lb_soluong.Size = new System.Drawing.Size(76, 30);
            this.lb_soluong.TabIndex = 3;
            this.lb_soluong.Text = "gunaNumeric1";
            this.lb_soluong.Value = ((long)(1));
            this.lb_soluong.ValueChanged += new System.EventHandler(this.lb_soluong_ValueChanged);
            this.lb_soluong.Click += new System.EventHandler(this.lb_soluong_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel2.Location = new System.Drawing.Point(71, 47);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(57, 19);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "@22:00";
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.AutoSize = true;
            this.lb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenmon.Location = new System.Drawing.Point(75, 12);
            this.lb_tenmon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(60, 20);
            this.lb_tenmon.TabIndex = 1;
            this.lb_tenmon.Text = "Món a";
            this.lb_tenmon.Click += new System.EventHandler(this.lb_tenmon_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BaseColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_delete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_delete.CheckedForeColor = System.Drawing.Color.White;
            this.btn_delete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.CheckedImage")));
            this.btn_delete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_delete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_delete.Location = new System.Drawing.Point(19, 23);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Size = new System.Drawing.Size(44, 32);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "gunaAdvenceButton1";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLinePanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(493, 90);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaLabel lb_tenmon;
        public Guna.UI.WinForms.GunaLabel lb_gia;
        public Guna.UI.WinForms.GunaNumeric lb_soluong;
        public Guna.UI.WinForms.GunaAdvenceButton btn_delete;
    }
}
