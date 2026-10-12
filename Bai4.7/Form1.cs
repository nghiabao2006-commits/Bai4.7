using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai4._6
{
    public partial class FormStudent : Form
    {
        private BindingList<Student> students;
        private ContextMenuStrip contextMenuStudents;

        public event Action<string> StatusMessageChanged;

        public FormStudent()
        {
            InitializeComponent();
            Text = "Quản lý Sinh viên";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new BindingList<Student>
            {
                new Student { StudentId = "SV001", FullName = "Nguyễn Văn A", Age = 20, Gender = "Nam", AvatarPath = string.Empty },
                new Student { StudentId = "SV002", FullName = "Trần Thị B", Age = 21, Gender = "Nữ", AvatarPath = string.Empty }
            };

            bindingSourceStudents.DataSource = students;

            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.DataSource = bindingSourceStudents;

            txtStudentId.DataBindings.Add("Text", bindingSourceStudents, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", bindingSourceStudents, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);

            var bAge = txtAge.DataBindings.Add("Text", bindingSourceStudents, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            bAge.Format += (s, ev) => { ev.Value = ev.Value == null ? string.Empty : ev.Value.ToString(); };
            bAge.Parse += (s, ev) => { int v; if (int.TryParse(ev.Value == null ? string.Empty : ev.Value.ToString(), out v)) ev.Value = v; else ev.Value = 0; };

            cmbGender.DataBindings.Add("Text", bindingSourceStudents, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceStudents.CurrentChanged += BindingSourceStudents_CurrentChanged;
            ConfigureStudentContextMenu();

            LoadCurrentAvatar();
            NotifyStatus("Đã mở chức năng Quản lý Sinh viên.");
        }

        private void BindingSourceStudents_CurrentChanged(object sender, EventArgs e)
        {
            LoadCurrentAvatar();
        }

        private void LoadCurrentAvatar()
        {
            var cur = bindingSourceStudents.Current as Student;
            if (cur == null || string.IsNullOrEmpty(cur.AvatarPath) || !File.Exists(cur.AvatarPath))
            {
                if (picAvatar.Image != null)
                {
                    picAvatar.Image.Dispose();
                    picAvatar.Image = null;
                }
                return;
            }

            try
            {
                using (var img = Image.FromFile(cur.AvatarPath))
                {
                    var bmp = new Bitmap(img);
                    if (picAvatar.Image != null) picAvatar.Image.Dispose();
                    picAvatar.Image = bmp;
                }
            }
            catch
            {
                // ignore image load errors
            }
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var path = openFileDialog.FileName;
            var cur = bindingSourceStudents.Current as Student;
            if (cur == null) return;
            cur.AvatarPath = path;
            bindingSourceStudents.ResetCurrentItem();
            LoadCurrentAvatar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int age = 0;
            int.TryParse(txtAge.Text, out age);
            var s = new Student
            {
                StudentId = txtStudentId.Text,
                FullName = txtFullName.Text,
                Age = age,
                Gender = cmbGender.Text,
                AvatarPath = string.Empty
            };
            students.Add(s);
            bindingSourceStudents.Position = students.IndexOf(s);
            NotifyStatus("Đã thêm sinh viên: " + s.FullName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCurrentStudent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var cur = bindingSourceStudents.Current as Student;
            if (cur == null) return;
            int age;
            if (int.TryParse(txtAge.Text, out age)) cur.Age = age;
            bindingSourceStudents.ResetCurrentItem();
            NotifyStatus("Đã cập nhật sinh viên: " + cur.FullName);
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            var path = saveFileDialog.FileName;
            try
            {
                using (var sw = new StreamWriter(path, false, new UTF8Encoding(true)))
                {
                    sw.WriteLine("StudentId,FullName,Age,Gender,AvatarPath");
                    foreach (var s in students)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4}",
                            EscapeCsv(s.StudentId), EscapeCsv(s.FullName), s.Age, EscapeCsv(s.Gender), EscapeCsv(s.AvatarPath)));
                    }
                }
                MessageBox.Show("Export completed", "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotifyStatus("Đã xuất danh sách sinh viên ra file CSV.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EscapeCsv(string field)
        {
            if (field == null) return string.Empty;
            bool needQuote = field.Contains(",") || field.Contains(";") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r");
            if (needQuote) return "\"" + field.Replace("\"", "\"\"") + "\"";
            return field;
        }

        private void ConfigureStudentContextMenu()
        {
            contextMenuStudents = new ContextMenuStrip();
            contextMenuStudents.Items.Add("Xóa dòng", null, (s, e) => DeleteCurrentStudent());
            contextMenuStudents.Items.Add("Làm mới dữ liệu", null, (s, e) => RefreshStudents());
            contextMenuStudents.Items.Add("Xem chi tiết", null, (s, e) => ShowCurrentStudentDetail());
            dgvStudents.ContextMenuStrip = contextMenuStudents;
            dgvStudents.MouseDown += DgvStudents_MouseDown;
        }

        private void DgvStudents_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var hit = dgvStudents.HitTest(e.X, e.Y);
            if (hit.RowIndex >= 0)
            {
                dgvStudents.ClearSelection();
                dgvStudents.Rows[hit.RowIndex].Selected = true;
                bindingSourceStudents.Position = hit.RowIndex;
            }
        }

        private void DeleteCurrentStudent()
        {
            var cur = bindingSourceStudents.Current as Student;
            if (cur == null) return;

            var name = cur.FullName;
            bindingSourceStudents.RemoveCurrent();
            NotifyStatus("Đã xóa sinh viên: " + name);
        }

        private void RefreshStudents()
        {
            bindingSourceStudents.ResetBindings(false);
            LoadCurrentAvatar();
            NotifyStatus("Đã làm mới dữ liệu sinh viên.");
        }

        private void ShowCurrentStudentDetail()
        {
            var cur = bindingSourceStudents.Current as Student;
            if (cur == null) return;

            MessageBox.Show(
                "Mã SV: " + cur.StudentId + Environment.NewLine +
                "Họ tên: " + cur.FullName + Environment.NewLine +
                "Tuổi: " + cur.Age + Environment.NewLine +
                "Giới tính: " + cur.Gender,
                "Chi tiết sinh viên",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            NotifyStatus("Đang xem chi tiết sinh viên: " + cur.FullName);
        }

        private void NotifyStatus(string message)
        {
            if (StatusMessageChanged != null)
            {
                StatusMessageChanged(message);
            }
        }
    }
}
