namespace QuanLyLichHoc
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnManageSchool = new System.Windows.Forms.Button();
            this.btnManageAccounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            


            this.btnManageSchool.Location = new System.Drawing.Point(151, 156);
            this.btnManageSchool.Name = "btnManageSchool";
            this.btnManageSchool.Size = new System.Drawing.Size(252, 40);
            this.btnManageSchool.TabIndex = 0;
            this.btnManageSchool.Text = "Quản lý trường học";
            this.btnManageSchool.UseVisualStyleBackColor = true;
            this.btnManageSchool.Click += new System.EventHandler(this.btnManageSchool_Click);
           


            this.btnManageAccounts.Location = new System.Drawing.Point(151, 248);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(252, 40);
            this.btnManageAccounts.TabIndex = 1;
            this.btnManageAccounts.Text = "Quản lý tài khoản";
            this.btnManageAccounts.UseVisualStyleBackColor = true;
            this.btnManageAccounts.Click += new System.EventHandler(this.btnManageAccounts_Click);
            


            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(610, 401);
            this.Controls.Add(this.btnManageAccounts);
            this.Controls.Add(this.btnManageSchool);
            this.Name = "AdminForm";
            this.Text = " Quản lý hệ thống";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnManageSchool;
        private System.Windows.Forms.Button btnManageAccounts;
    }
}
