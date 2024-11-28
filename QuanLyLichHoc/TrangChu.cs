using System;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class TrangChu : Form
    {
        private UserSession userSession;

        public TrangChu(UserSession session)
        {
            InitializeComponent();
            this.userSession = session;  
            PhanQuyen();  
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLichHoc manageScheduleForm = new QuanLyLichHoc(userSession); 
            manageScheduleForm.FormClosed += (s, args) => this.Show();
            manageScheduleForm.Show();
        }

        private void btnManageAssignment_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBT manageAssignmentForm = new QuanLyBT(userSession);  
            manageAssignmentForm.FormClosed += (s, args) => this.Show();
            manageAssignmentForm.Show();
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            if (userSession.Role == "Teacher" || userSession.Role == "Admin")
            {
                this.Hide();
                ThongBao sendNotificationForm = new ThongBao(userSession);  
                sendNotificationForm.FormClosed += (s, args) => this.Show();
                sendNotificationForm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            if (userSession.Role == "Teacher")
            {
                this.Hide();
                HocSinh hocSinhForm = new HocSinh(userSession);  
                hocSinhForm.FormClosed += (s, args) => this.Show();
                hocSinhForm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (userSession.Role == "Teacher")
            {
                this.Hide();
                ThongKeForm thongKeForm = new ThongKeForm(userSession); 
                thongKeForm.FormClosed += (s, args) => this.Show();
                thongKeForm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PhanQuyen()
        {

             btnManageSchedule.Visible = false;
            btnManageAssignment.Visible = false;
            btnSendNotification.Visible = false;
            btnHocSinh.Visible = false;
            btnThongKe.Visible = false;

 
            switch (userSession.Role)
            {
                case "Admin":
                    btnManageSchedule.Visible = true;
                    btnSendNotification.Visible = true;
                    break;

                case "Teacher":
                    btnManageSchedule.Visible = true;
                    btnManageAssignment.Visible = true;
                    btnSendNotification.Visible = true;
                    btnHocSinh.Visible = true;
                    btnThongKe.Visible = true;
                    break;

                case "Student":
                    btnManageSchedule.Visible = true;
                    btnManageAssignment.Visible = true;
                    break;

                default:
                    this.Close();
                    break;
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
