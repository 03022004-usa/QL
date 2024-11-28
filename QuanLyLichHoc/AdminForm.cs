using System;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class AdminForm : Form
    {
        private UserSession userSession;
        public AdminForm(UserSession session)
        {
            InitializeComponent();
            userSession = session;
        }

        private void btnManageSchool_Click(object sender, EventArgs e)
        {
            this.Hide();

            TrangChu trangChuForm = new TrangChu(userSession);
            trangChuForm.FormClosed += (s, args) => this.Show();
            trangChuForm.Show();
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan manageAccountsForm = new QuanLyTaiKhoan();
            manageAccountsForm.Show();
        }
    }
}
