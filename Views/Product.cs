using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCore.Models.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsCore.Views
{
    public partial class Product : Form
    {
        private readonly ShopContext _context;
        public Product(ShopContext context)
        {

            InitializeComponent();
            _context = context;

            // Clear existing items
            listProduct.Items.Clear();

            listProduct.Columns.Add("STT", 50, System.Windows.Forms.HorizontalAlignment.Center);
            listProduct.Columns.Add("Tên sản phẩm", 250, System.Windows.Forms.HorizontalAlignment.Center);
            listProduct.Columns.Add("Nhà cung cấp", 150, System.Windows.Forms.HorizontalAlignment.Center);
            listProduct.Columns.Add("Giá", 100, System.Windows.Forms.HorizontalAlignment.Center);
            listProduct.Columns.Add("Package", 100, System.Windows.Forms.HorizontalAlignment.Center);
            listProduct.Columns.Add("Discount", 100, System.Windows.Forms.HorizontalAlignment.Center);

            LoadDataIntoListView();

            LoadDataIntoListNCC();

        }

        private void LoadDataIntoListNCC()
        {
            // Lấy danh sách nhà cung cấp từ cơ sở dữ liệu
            var listNCC = _context.Suppliers.ToList(); // Nếu bạn muốn lấy danh sách nhà cung cấp

            // Xóa hết các mục hiện tại trong ComboBox
            list_NCC.Items.Clear();

            // Thêm nhà cung cấp vào ComboBox
            foreach (var supplier in listNCC)
            {
                // Thêm tên nhà cung cấp vào ComboBox
                list_NCC.Items.Add(supplier.CompanyName); // Giả sử có thuộc tính Name trong Supplier
            }

            // Tùy chọn để chọn mục đầu tiên (nếu có)
            if (list_NCC.Items.Count > 0)
            {
                list_NCC.SelectedIndex = 0; // Chọn mục đầu tiên
            }
        }

        private void LoadDataIntoListView()
        {
            // Retrieve products from the database

            var products = _context.Products.Include(p => p.Supplier).ToList();


            // Clear existing items
            listProduct.Items.Clear();

            // Loop through the products and add them to the ListView
            foreach (var pro in products)
            {
                ListViewItem item = new ListViewItem(pro.Id.ToString());
                item.SubItems.Add(pro.ProductName);
                item.SubItems.Add(pro.Supplier?.CompanyName ?? "N/A");
                item.SubItems.Add(pro.UnitPrice?.ToString("C") ?? "N/A");
                item.SubItems.Add(pro.Package);
                item.SubItems.Add(pro.IsDiscontinued.ToString());

                listProduct.Items.Add(item);
            }

        }
        private void menu_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn Đăng xuất hay không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var signInForm = new Sign_in(_context);
                this.Hide();
                signInForm.ShowDialog();
            }
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn Thoát chương trình hay không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked Yes
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }
        }


        private void btn_import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        // Đọc file CSV
                        var lines = File.ReadAllLines(filePath);
                        listProduct.Items.Clear(); // Xóa các mục hiện tại

                        foreach (var line in lines.Skip(1)) // Bỏ qua header nếu có
                        {
                            var values = line.Split(',');

                            if (values.Length >= 4) // Giả sử có ít nhất 4 cột: Name, Supplier, Package, Price
                            {
                                // Tạo một ListViewItem với thông tin sản phẩm
                                var item = new ListViewItem(values[0]); // Tên sản phẩm
                                item.SubItems.Add(values[1]); // Nhà cung cấp
                                item.SubItems.Add(values[2]); // Package
                                item.SubItems.Add(values[3]); // Giá

                                // Thêm sản phẩm vào ListView
                                listProduct.Items.Add(item);

                                // Tạo một đối tượng sản phẩm mới để lưu vào cơ sở dữ liệu
                                var product = new Models.Entities.Product
                                {
                                    ProductName = values[0],
                                    Supplier = _context.Suppliers.FirstOrDefault(s => s.CompanyName == values[1]),
                                    Package = values[2],
                                    UnitPrice = decimal.TryParse(values[3], out decimal price) ? price : (decimal?)null,
                                    IsDiscontinued = false // hoặc gán theo cách khác nếu cần
                                };

                                // Lưu sản phẩm vào cơ sở dữ liệu
                                _context.Products.Add(product);
                            }
                        }

                        // Lưu thay đổi vào cơ sở dữ liệu
                        _context.SaveChanges();
                        MessageBox.Show("Nhập sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi nhập sản phẩm: {ex.Message}", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btn_export_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.Title = "Save an Excel File";
                saveFileDialog.FileName = "ProductList.xlsx"; // Default filename

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Tạo một workbook mới
                        IWorkbook workbook = new XSSFWorkbook();
                        ISheet worksheet = workbook.CreateSheet("Products");

                        // Thiết lập hàng tiêu đề
                        IRow headerRow = worksheet.CreateRow(0);
                        headerRow.CreateCell(0).SetCellValue("STT");
                        headerRow.CreateCell(1).SetCellValue("Tên sản phẩm");
                        headerRow.CreateCell(2).SetCellValue("Nhà cung cấp");
                        headerRow.CreateCell(3).SetCellValue("Giá");
                        headerRow.CreateCell(4).SetCellValue("Package");
                        headerRow.CreateCell(5).SetCellValue("Discount");

                        // Lấy danh sách sản phẩm từ cơ sở dữ liệu
                        var products = _context.Products.Include(p => p.Supplier).ToList();

                        // Điền dữ liệu vào worksheet
                        for (int i = 0; i < products.Count; i++)
                        {
                            var pro = products[i];
                            IRow row = worksheet.CreateRow(i + 1);
                            row.CreateCell(0).SetCellValue(i + 1); // STT
                            row.CreateCell(1).SetCellValue(pro.ProductName ?? "N/A"); // Tên sản phẩm
                            row.CreateCell(2).SetCellValue(pro.Supplier?.CompanyName ?? "N/A"); // Nhà cung cấp
                            row.CreateCell(3).SetCellValue(pro.UnitPrice?.ToString("C") ?? "N/A"); // Giá
                            row.CreateCell(4).SetCellValue(pro.Package ?? "N/A"); // Package
                            row.CreateCell(5).SetCellValue(pro.IsDiscontinued.ToString()); // Discount
                        }

                        // Hiển thị số lượng sản phẩm
                        MessageBox.Show(products.Count.ToString());

                        // Lưu workbook
                        using (var fileData = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            workbook.Write(fileData);
                        }

                        MessageBox.Show("Xuất sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất sản phẩm: {ex.Message}", "Lỗi xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
