namespace Bai4._6
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnStudent = new System.Windows.Forms.ToolStripButton();
            this.btnProduct = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.contextMenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuCatalog,
            this.mnuWindow});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.MdiWindowListItem = this.mnuWindow;
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1082, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogout,
            this.mnuExit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(85, 24);
            this.mnuSystem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(224, 26);
            this.mnuLogout.Text = "Đăng xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(224, 26);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuCatalog
            // 
            this.mnuCatalog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudent,
            this.mnuProduct});
            this.mnuCatalog.Name = "mnuCatalog";
            this.mnuCatalog.Size = new System.Drawing.Size(90, 24);
            this.mnuCatalog.Text = "Danh mục";
            // 
            // mnuStudent
            // 
            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Size = new System.Drawing.Size(224, 26);
            this.mnuStudent.Text = "Quản lý Sinh viên";
            this.mnuStudent.Click += new System.EventHandler(this.openStudents_Click);
            // 
            // mnuProduct
            // 
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Size = new System.Drawing.Size(224, 26);
            this.mnuProduct.Text = "Quản lý Sản phẩm";
            this.mnuProduct.Click += new System.EventHandler(this.openProducts_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuTileHorizontal,
            this.mnuTileVertical});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(70, 24);
            this.mnuWindow.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(224, 26);
            this.mnuCascade.Text = "Cascade";
            this.mnuCascade.Click += new System.EventHandler(this.cascade_Click);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Name = "mnuTileHorizontal";
            this.mnuTileHorizontal.Size = new System.Drawing.Size(224, 26);
            this.mnuTileHorizontal.Text = "Tile Horizontal";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.tileHorizontal_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Name = "mnuTileVertical";
            this.mnuTileVertical.Size = new System.Drawing.Size(224, 26);
            this.mnuTileVertical.Text = "Tile Vertical";
            this.mnuTileVertical.Click += new System.EventHandler(this.tileVertical_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStudent,
            this.btnProduct});
            this.toolStripMain.Location = new System.Drawing.Point(0, 28);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1082, 27);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // btnStudent
            // 
            this.btnStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStudent.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            this.btnStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(29, 24);
            this.btnStudent.Text = "Quản lý Sinh viên";
            this.btnStudent.Click += new System.EventHandler(this.openStudents_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProduct.Image = System.Drawing.SystemIcons.Application.ToBitmap();
            this.btnProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(29, 24);
            this.btnProduct.Text = "Quản lý Sản phẩm";
            this.btnProduct.Click += new System.EventHandler(this.openProducts_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.lblStatus,
            this.lblClock});
            this.statusStripMain.Location = new System.Drawing.Point(0, 628);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1082, 26);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(128, 20);
            this.lblUser.Text = "Người dùng: Admin";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(789, 20);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Trạng thái: Sẵn sàng";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClock
            // 
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(150, 20);
            this.lblClock.Text = "12/10/2026 00:00:00";
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxStudent,
            this.ctxProduct,
            this.ctxCascade});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(211, 104);
            // 
            // ctxStudent
            // 
            this.ctxStudent.Name = "ctxStudent";
            this.ctxStudent.Size = new System.Drawing.Size(210, 24);
            this.ctxStudent.Text = "Quản lý Sinh viên";
            this.ctxStudent.Click += new System.EventHandler(this.openStudents_Click);
            // 
            // ctxProduct
            // 
            this.ctxProduct.Name = "ctxProduct";
            this.ctxProduct.Size = new System.Drawing.Size(210, 24);
            this.ctxProduct.Text = "Quản lý Sản phẩm";
            this.ctxProduct.Click += new System.EventHandler(this.openProducts_Click);
            // 
            // ctxCascade
            // 
            this.ctxCascade.Name = "ctxCascade";
            this.ctxCascade.Size = new System.Drawing.Size(210, 24);
            this.ctxCascade.Text = "Sắp xếp Cascade";
            this.ctxCascade.Click += new System.EventHandler(this.cascade_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 654);
            this.ContextMenuStrip = this.contextMenuMain;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Bài 4.7 - Khung ứng dụng MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.contextMenuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalog;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnStudent;
        private System.Windows.Forms.ToolStripButton btnProduct;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblClock;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem ctxStudent;
        private System.Windows.Forms.ToolStripMenuItem ctxProduct;
        private System.Windows.Forms.ToolStripMenuItem ctxCascade;
    }
}
