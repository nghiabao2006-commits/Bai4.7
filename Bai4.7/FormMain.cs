using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai4._6
{
    public partial class FormMain : Form
    {
        private readonly Timer clockTimer;

        public FormMain()
        {
            InitializeComponent();

            clockTimer = new Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Người dùng: Admin";
            UpdateStatus("Sẵn sàng.");
            UpdateClock();
            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            UpdateStatus("Đã đăng xuất khỏi hệ thống.");
            MessageBox.Show("Đã đăng xuất.", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openStudents_Click(object sender, EventArgs e)
        {
            OpenChild<FormStudent>();
        }

        private void openProducts_Click(object sender, EventArgs e)
        {
            OpenChild<FormProduct>();
        }

        private void cascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            UpdateStatus("Đã sắp xếp cửa sổ kiểu Cascade.");
        }

        private void tileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            UpdateStatus("Đã sắp xếp cửa sổ kiểu Tile Horizontal.");
        }

        private void tileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            UpdateStatus("Đã sắp xếp cửa sổ kiểu Tile Vertical.");
        }

        private void OpenChild<T>() where T : Form, new()
        {
            var openedForm = MdiChildren.OfType<T>().FirstOrDefault();
            if (openedForm != null)
            {
                openedForm.Activate();
                UpdateStatus("Đã kích hoạt cửa sổ: " + openedForm.Text);
                return;
            }

            var form = new T();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;

            var studentForm = form as FormStudent;
            if (studentForm != null)
            {
                studentForm.StatusMessageChanged += UpdateStatus;
            }

            var productForm = form as FormProduct;
            if (productForm != null)
            {
                productForm.StatusMessageChanged += UpdateStatus;
            }

            form.FormClosed += Child_FormClosed;
            form.Show();
            UpdateStatus("Đã mở cửa sổ: " + form.Text);
        }

        private void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            var studentForm = sender as FormStudent;
            if (studentForm != null)
            {
                studentForm.StatusMessageChanged -= UpdateStatus;
            }

            var productForm = sender as FormProduct;
            if (productForm != null)
            {
                productForm.StatusMessageChanged -= UpdateStatus;
            }
        }

        public void UpdateStatus(string message)
        {
            lblStatus.Text = "Trạng thái: " + message;
        }

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
