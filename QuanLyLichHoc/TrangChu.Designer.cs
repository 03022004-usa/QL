namespace QuanLyLichHoc
{
    partial class TrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageSchedule;
        private System.Windows.Forms.Button btnManageAssignment;
        private System.Windows.Forms.Button btnSendNotification;
        private System.Windows.Forms.Button btnHocSinh;  
        private System.Windows.Forms.Button btnThongKe;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnManageSchedule = new System.Windows.Forms.Button();
            this.btnManageAssignment = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
           


            this.btnManageSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageSchedule.FlatAppearance.BorderSize = 0;
            this.btnManageSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageSchedule.ForeColor = System.Drawing.Color.White;
            this.btnManageSchedule.Location = new System.Drawing.Point(235, 113);
            this.btnManageSchedule.Name = "btnManageSchedule";
            this.btnManageSchedule.Size = new System.Drawing.Size(288, 62);
            this.btnManageSchedule.TabIndex = 0;
            this.btnManageSchedule.Text = "Quản lý lịch học";
            this.btnManageSchedule.UseVisualStyleBackColor = false;
            this.btnManageSchedule.Click += new System.EventHandler(this.btnManageSchedule_Click);
           


            this.btnManageAssignment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageAssignment.FlatAppearance.BorderSize = 0;
            this.btnManageAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAssignment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageAssignment.ForeColor = System.Drawing.Color.White;
            this.btnManageAssignment.Location = new System.Drawing.Point(235, 200);
            this.btnManageAssignment.Name = "btnManageAssignment";
            this.btnManageAssignment.Size = new System.Drawing.Size(288, 54);
            this.btnManageAssignment.TabIndex = 1;
            this.btnManageAssignment.Text = "Quản lý bài tập";
            this.btnManageAssignment.UseVisualStyleBackColor = false;
            this.btnManageAssignment.Click += new System.EventHandler(this.btnManageAssignment_Click);
            


            this.btnSendNotification.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSendNotification.FlatAppearance.BorderSize = 0;
            this.btnSendNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSendNotification.ForeColor = System.Drawing.Color.White;
            this.btnSendNotification.Location = new System.Drawing.Point(235, 275);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(288, 59);
            this.btnSendNotification.TabIndex = 2;
            this.btnSendNotification.Text = "Gửi thông báo";
            this.btnSendNotification.UseVisualStyleBackColor = false;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            


            this.btnHocSinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHocSinh.FlatAppearance.BorderSize = 0;
            this.btnHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHocSinh.ForeColor = System.Drawing.Color.White;
            this.btnHocSinh.Location = new System.Drawing.Point(235, 340);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(288, 61);
            this.btnHocSinh.TabIndex = 3;
            this.btnHocSinh.Text = "Quản lý học sinh";
            this.btnHocSinh.UseVisualStyleBackColor = false;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            


            this.btnThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(235, 420);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(288, 55);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
             


            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(752, 530);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.btnManageAssignment);
            this.Controls.Add(this.btnManageSchedule);
            this.Controls.Add(this.btnThongKe);
            this.Name = "TrangChu";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.ResumeLayout(false);

        }

    }
}
