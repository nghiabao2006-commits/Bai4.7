using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bai4._6
{
    public partial class FormProduct : Form
    {
        private readonly BindingList<ProductItem> products;

        public event Action<string> StatusMessageChanged;

        public FormProduct()
        {
            InitializeComponent();

            products = new BindingList<ProductItem>
            {
                new ProductItem { ProductId = "SP001", ProductName = "Bàn phím", UnitPrice = 250000, Quantity = 10 },
                new ProductItem { ProductId = "SP002", ProductName = "Chuột", UnitPrice = 180000, Quantity = 15 }
            };
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = products;
            NotifyStatus("Đã mở chức năng Quản lý Sản phẩm.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            products.Add(new ProductItem
            {
                ProductId = txtProductId.Text,
                ProductName = txtProductName.Text,
                UnitPrice = numericPrice.Value,
                Quantity = (int)numericQuantity.Value
            });
            NotifyStatus("Đã thêm sản phẩm: " + txtProductName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            var product = dgvProducts.CurrentRow.DataBoundItem as ProductItem;
            if (product == null) return;

            products.Remove(product);
            NotifyStatus("Đã xóa sản phẩm: " + product.ProductName);
        }

        private void NotifyStatus(string message)
        {
            if (StatusMessageChanged != null)
            {
                StatusMessageChanged(message);
            }
        }
    }

    public class ProductItem
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
