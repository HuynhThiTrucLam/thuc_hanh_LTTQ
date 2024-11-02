
using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Windows.Forms;
using WinFormsCore.Models.Entities;

namespace WinFormsCore.Views
{
    public partial class MainForm : Form
    {
        private readonly ShopContext _context;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editItem;
        private ToolStripMenuItem deleteItem;
        public MainForm(ShopContext context)
        {


            InitializeComponent();


            listView.Columns.Add("STT", 50, System.Windows.Forms.HorizontalAlignment.Center);
            listView.Columns.Add("FirstName", 150, System.Windows.Forms.HorizontalAlignment.Center);
            listView.Columns.Add("LastName", 100, System.Windows.Forms.HorizontalAlignment.Center);
            listView.Columns.Add("City", 100, System.Windows.Forms.HorizontalAlignment.Center);
            listView.Columns.Add("Country", 100, System.Windows.Forms.HorizontalAlignment.Center);
            listView.Columns.Add("Phone", 100, System.Windows.Forms.HorizontalAlignment.Center);
            _context = context;
            LoadDataIntoListView();
            InitializeContextMenu();


        }
        private void LoadDataIntoListView()
        {
            // Retrieve products from the database
            var customers = _context.Customers.ToList();


            // Clear existing items
            listView.Items.Clear();

            // Loop through the products and add them to the ListView
            foreach (var cus in customers)
            {
                ListViewItem item = new ListViewItem(cus.Id.ToString());
                item.SubItems.Add(cus.FirstName);
                item.SubItems.Add(cus.LastName);
                item.SubItems.Add(cus.City);
                item.SubItems.Add(cus.Country);
                item.SubItems.Add(cus.Phone); // Format as currency

                listView.Items.Add(item);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_firstName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbx_lastName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerFName = tbx_firstName.Text.Trim();
            string customerLName = tbx_lastName.Text.Trim();
            string phone = tbx_phone.Text.Trim();
            string province = cbx_province.SelectedItem.ToString();
            string country = cbx_country.SelectedItem.ToString();

            Customer newCustomer = new Customer
            {
                FirstName = customerFName,
                LastName = customerLName,
                Phone = phone,
                City = province,
                Country = country
            };

            _context.Customers.Add(newCustomer);

            // Lưu thay đổi vào cơ sở dữ liệu
            _context.SaveChanges();

            LoadDataIntoListView();
            // Làm sạch TextBox sau khi thêm
            tbx_firstName.Clear();
            tbx_lastName.Clear();
            tbx_phone.Clear();

            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ListViewItem clickedItem = listView.GetItemAt(e.X, e.Y);
                if (clickedItem != null)
                {
                    listView.SelectedItems.Clear();
                    clickedItem.Selected = true;
                    contextMenuStrip1.Show(listView, e.Location);
                }

            }
        }

        private void EditSelectedItem()
        {
            // Kiểm tra nếu có item nào được chọn
            if (listView.FocusedItem != null)
            {
                ListViewItem selectedItem = listView.FocusedItem;

                // Lấy thông tin từ item được chọn và hiển thị vào các TextBox
                tbx_firstName.Text = selectedItem.SubItems[1].Text; // First Name
                tbx_lastName.Text = selectedItem.SubItems[2].Text;  // Last Name
                tbx_phone.Text = selectedItem.SubItems[5].Text;      // Phone
                cbx_province.SelectedItem = selectedItem.SubItems[3].Text; // City/Province
                cbx_country.SelectedItem = selectedItem.SubItems[4].Text; // Country

                if (cbx_province.Items.Contains(selectedItem.SubItems[3].Text))
                {
                    cbx_province.SelectedItem = selectedItem.SubItems[3].Text;
                }
                else
                {
                    cbx_province.Items.Add(selectedItem.SubItems[3].Text);
                    cbx_province.SelectedItem = selectedItem.SubItems[3].Text;
                }
                if (cbx_country.Items.Contains(selectedItem.SubItems[4].Text))
                {
                    cbx_country.SelectedItem = selectedItem.SubItems[4].Text;
                }
                else
                {
                    cbx_country.Items.Add(selectedItem.SubItems[4].Text);
                    cbx_country.SelectedItem = selectedItem.SubItems[4].Text;
                }

                // Kích hoạt nút cập nhật (Update) nếu có thay đổi
                btn_print.Enabled = true;

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSelectedItem()
        {
            // Kiểm tra nếu có item nào được chọn
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                // Lấy ID của khách hàng từ item được chọn
                int customerId = int.Parse(selectedItem.SubItems[0].Text);

                // Tìm khách hàng trong cơ sở dữ liệu
                var customer = _context.Customers.Find(customerId);

                if (customer != null)
                {
                    // Xóa khách hàng
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();

                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới ListView sau khi xóa
                    LoadDataIntoListView();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void InitializeContextMenu()
        {
            contextMenuStrip1 = new ContextMenuStrip();

            // Create menu items
            editItem = new ToolStripMenuItem("Edit");
            deleteItem = new ToolStripMenuItem("Delete");

            // Add event handlers for menu items
            editItem.Click += (sender, e) => EditSelectedItem();
            deleteItem.Click += (sender, e) => DeleteSelectedItem();

            // Add items to the context menu
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editItem, deleteItem });

            // Set the ContextMenuStrip of ListView
            listView.ContextMenuStrip = contextMenuStrip1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Lấy item đang được chọn
            if (listView.FocusedItem != null)
            {
                ListViewItem selectedItem = listView.FocusedItem;

                // Lấy lại thông tin từ TextBox
                string updatedFirstName = tbx_firstName.Text.Trim();
                string updatedLastName = tbx_lastName.Text.Trim();
                string updatedPhone = tbx_phone.Text.Trim();
                string updatedProvince = cbx_province.SelectedItem.ToString();
                string updatedCountry = cbx_country.SelectedItem.ToString();

                // Cập nhật thông tin khách hàng vào cơ sở dữ liệu
                int customerId = int.Parse(selectedItem.SubItems[0].Text); // ID của khách hàng
                var customer = _context.Customers.Find(customerId);

                if (customer != null)
                {
                    customer.FirstName = updatedFirstName;
                    customer.LastName = updatedLastName;
                    customer.Phone = updatedPhone;
                    customer.City = updatedProvince;
                    customer.Country = updatedCountry;

                    _context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới ListView
                    LoadDataIntoListView();
                    tbx_firstName.Clear();
                    tbx_lastName.Clear();
                    tbx_phone.Clear();
                    cbx_country.SelectedIndex = 0;
                    cbx_province.SelectedIndex = 0;
                    btn_print.Enabled = false;
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Load the DOCX template from ProjecrPath\bin\Debug\net8.0-windows
            Document doc = new Document();
            string relativePath = "Template\\template.docx";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            doc.LoadFromFile(fullPath);


            // Replace placeholders with actual values
            doc.Replace("{{hoTen}}", tbx_firstName.Text + tbx_lastName.Text, true, true);
            doc.Replace("{{tinh}}", cbx_province.SelectedItem.ToString(), true, true);
            doc.Replace("{{sdt}}", tbx_phone.Text, true, true);
            doc.Replace("{{quocGia}}", cbx_country.SelectedItem.ToString(), true, true);

            // Export the document as PDF
            string pdfPath = "D:\\dotNet\\Lập trình trực quan\\WinFormsCore\\Template\\output_file_path.pdf";
            doc.SaveToFile(pdfPath, FileFormat.PDF);

            MessageBox.Show("PDF exported successfully at " + pdfPath);
        }
        
    }
}
