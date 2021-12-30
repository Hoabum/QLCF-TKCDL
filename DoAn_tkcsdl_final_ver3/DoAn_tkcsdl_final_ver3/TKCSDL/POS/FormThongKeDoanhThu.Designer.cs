
namespace POS
{
    partial class FormThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.txt_title_thongkeDoanhThu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grb_thongtin = new System.Windows.Forms.GroupBox();
            this.ngayBD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.toDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grb_thongtinBieuDo = new System.Windows.Forms.GroupBox();
            this.radioBtnNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioBtnQuy = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioBtnThang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.grb_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.grb_thongtinBieuDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_title_thongkeDoanhThu
            // 
            this.txt_title_thongkeDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.txt_title_thongkeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title_thongkeDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.txt_title_thongkeDoanhThu.Location = new System.Drawing.Point(492, 70);
            this.txt_title_thongkeDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_title_thongkeDoanhThu.Name = "txt_title_thongkeDoanhThu";
            this.txt_title_thongkeDoanhThu.Size = new System.Drawing.Size(311, 39);
            this.txt_title_thongkeDoanhThu.TabIndex = 18;
            this.txt_title_thongkeDoanhThu.Text = "THỐNG KÊ DOANH THU";
            // 
            // grb_thongtin
            // 
            this.grb_thongtin.Controls.Add(this.ngayBD);
            this.grb_thongtin.Controls.Add(this.guna2HtmlLabel2);
            this.grb_thongtin.Controls.Add(this.toDate);
            this.grb_thongtin.Controls.Add(this.btnXem);
            this.grb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thongtin.Location = new System.Drawing.Point(200, 129);
            this.grb_thongtin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_thongtin.Name = "grb_thongtin";
            this.grb_thongtin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_thongtin.Size = new System.Drawing.Size(949, 105);
            this.grb_thongtin.TabIndex = 17;
            this.grb_thongtin.TabStop = false;
            this.grb_thongtin.Text = "Xem theo ngày";
            // 
            // ngayBD
            // 
            this.ngayBD.BackColor = System.Drawing.Color.Transparent;
            this.ngayBD.BorderRadius = 5;
            this.ngayBD.Checked = true;
            this.ngayBD.CheckedState.Parent = this.ngayBD;
            this.ngayBD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ngayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayBD.HoverState.Parent = this.ngayBD;
            this.ngayBD.Location = new System.Drawing.Point(129, 37);
            this.ngayBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayBD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngayBD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngayBD.Name = "ngayBD";
            this.ngayBD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ngayBD.ShadowDecoration.Parent = this.ngayBD;
            this.ngayBD.Size = new System.Drawing.Size(200, 31);
            this.ngayBD.TabIndex = 8;
            this.ngayBD.UseTransparentBackground = true;
            this.ngayBD.Value = new System.DateTime(2021, 12, 24, 15, 39, 59, 774);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(381, 46);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(33, 22);
            this.guna2HtmlLabel2.TabIndex = 11;
            this.guna2HtmlLabel2.Text = "Đến";
            // 
            // toDate
            // 
            this.toDate.BorderRadius = 5;
            this.toDate.Checked = true;
            this.toDate.CheckedState.Parent = this.toDate;
            this.toDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.HoverState.Parent = this.toDate;
            this.toDate.Location = new System.Drawing.Point(513, 37);
            this.toDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDate.Name = "toDate";
            this.toDate.ShadowDecoration.Parent = this.toDate;
            this.toDate.Size = new System.Drawing.Size(200, 31);
            this.toDate.TabIndex = 9;
            this.toDate.Value = new System.DateTime(2021, 12, 24, 15, 40, 5, 124);
            // 
            // btnXem
            // 
            this.btnXem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXem.BorderRadius = 5;
            this.btnXem.BorderThickness = 2;
            this.btnXem.CheckedState.Parent = this.btnXem;
            this.btnXem.CustomImages.Parent = this.btnXem;
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.DisabledState.Parent = this.btnXem;
            this.btnXem.FillColor = System.Drawing.SystemColors.Control;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXem.HoverState.Parent = this.btnXem;
            this.btnXem.Location = new System.Drawing.Point(747, 37);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.ShadowDecoration.Parent = this.btnXem;
            this.btnXem.Size = new System.Drawing.Size(115, 31);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // chartThongKe
            // 
            chartArea3.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend3);
            this.chartThongKe.Location = new System.Drawing.Point(36, 46);
            this.chartThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartThongKe.Name = "chartThongKe";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Doanh Thu";
            this.chartThongKe.Series.Add(series3);
            this.chartThongKe.Size = new System.Drawing.Size(826, 390);
            this.chartThongKe.TabIndex = 19;
            this.chartThongKe.Text = "chart1";
            title3.Name = "Thống Kê Theo Tuần";
            this.chartThongKe.Titles.Add(title3);
            // 
            // grb_thongtinBieuDo
            // 
            this.grb_thongtinBieuDo.Controls.Add(this.radioBtnNam);
            this.grb_thongtinBieuDo.Controls.Add(this.radioBtnQuy);
            this.grb_thongtinBieuDo.Controls.Add(this.radioBtnThang);
            this.grb_thongtinBieuDo.Controls.Add(this.chartThongKe);
            this.grb_thongtinBieuDo.Location = new System.Drawing.Point(72, 267);
            this.grb_thongtinBieuDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_thongtinBieuDo.Name = "grb_thongtinBieuDo";
            this.grb_thongtinBieuDo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_thongtinBieuDo.Size = new System.Drawing.Size(1269, 469);
            this.grb_thongtinBieuDo.TabIndex = 20;
            this.grb_thongtinBieuDo.TabStop = false;
            this.grb_thongtinBieuDo.Text = "Biểu Đồ Doanh Thu";
            this.grb_thongtinBieuDo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioBtnNam
            // 
            this.radioBtnNam.AutoSize = true;
            this.radioBtnNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnNam.CheckedState.BorderThickness = 0;
            this.radioBtnNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnNam.CheckedState.InnerOffset = -4;
            this.radioBtnNam.Location = new System.Drawing.Point(1114, 298);
            this.radioBtnNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnNam.Name = "radioBtnNam";
            this.radioBtnNam.Size = new System.Drawing.Size(95, 21);
            this.radioBtnNam.TabIndex = 22;
            this.radioBtnNam.Text = "Theo Năm";
            this.radioBtnNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnNam.UncheckedState.BorderThickness = 2;
            this.radioBtnNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioBtnNam.CheckedChanged += new System.EventHandler(this.radioBtnNam_CheckedChanged);
            // 
            // radioBtnQuy
            // 
            this.radioBtnQuy.AutoSize = true;
            this.radioBtnQuy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnQuy.CheckedState.BorderThickness = 0;
            this.radioBtnQuy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnQuy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnQuy.CheckedState.InnerOffset = -4;
            this.radioBtnQuy.Location = new System.Drawing.Point(1114, 218);
            this.radioBtnQuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnQuy.Name = "radioBtnQuy";
            this.radioBtnQuy.Size = new System.Drawing.Size(92, 21);
            this.radioBtnQuy.TabIndex = 21;
            this.radioBtnQuy.Text = "Theo Quý";
            this.radioBtnQuy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnQuy.UncheckedState.BorderThickness = 2;
            this.radioBtnQuy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnQuy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioBtnQuy.CheckedChanged += new System.EventHandler(this.radioBtnQuy_CheckedChanged);
            // 
            // radioBtnThang
            // 
            this.radioBtnThang.AutoSize = true;
            this.radioBtnThang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnThang.CheckedState.BorderThickness = 0;
            this.radioBtnThang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnThang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnThang.CheckedState.InnerOffset = -4;
            this.radioBtnThang.Location = new System.Drawing.Point(1114, 134);
            this.radioBtnThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnThang.Name = "radioBtnThang";
            this.radioBtnThang.Size = new System.Drawing.Size(107, 21);
            this.radioBtnThang.TabIndex = 20;
            this.radioBtnThang.Text = "Theo Tháng";
            this.radioBtnThang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnThang.UncheckedState.BorderThickness = 2;
            this.radioBtnThang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnThang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioBtnThang.CheckedChanged += new System.EventHandler(this.radioBtnThang_CheckedChanged);
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 737);
            this.Controls.Add(this.grb_thongtinBieuDo);
            this.Controls.Add(this.txt_title_thongkeDoanhThu);
            this.Controls.Add(this.grb_thongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDoanhThu";
            this.Load += new System.EventHandler(this.FormThongKeDoanhThu_Load);
            this.grb_thongtin.ResumeLayout(false);
            this.grb_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.grb_thongtinBieuDo.ResumeLayout(false);
            this.grb_thongtinBieuDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private Guna.UI2.WinForms.Guna2HtmlLabel txt_title_thongkeDoanhThu;
        private System.Windows.Forms.GroupBox grb_thongtin;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngayBD;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker toDate;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private System.Windows.Forms.GroupBox grb_thongtinBieuDo;
        private Guna.UI2.WinForms.Guna2RadioButton radioBtnNam;
        private Guna.UI2.WinForms.Guna2RadioButton radioBtnQuy;
        private Guna.UI2.WinForms.Guna2RadioButton radioBtnThang;
    }
}