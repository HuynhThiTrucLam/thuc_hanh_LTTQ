namespace WinFormsCore.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            listView = new ListView();
            panel2 = new Panel();
            btn_print = new Button();
            button1 = new Button();
            btn_add = new Button();
            cbx_country = new ComboBox();
            tbx_phone = new TextBox();
            cbx_province = new ComboBox();
            tbx_lastName = new TextBox();
            tbx_firstName = new TextBox();
            lbl_country = new Label();
            lbl_firstName = new Label();
            lbl_infor = new Label();
            lbl_lastName = new Label();
            lbl_phone = new Label();
            lbl_province = new Label();
            lbl_heading = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(listView);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl_heading);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 386);
            panel1.TabIndex = 0;
            // 
            // listView
            // 
            listView.FullRowSelect = true;
            listView.Location = new Point(22, 267);
            listView.Name = "listView";
            listView.Size = new Size(613, 116);
            listView.TabIndex = 2;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.MouseDown += listView_MouseClick;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_print);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(cbx_country);
            panel2.Controls.Add(tbx_phone);
            panel2.Controls.Add(cbx_province);
            panel2.Controls.Add(tbx_lastName);
            panel2.Controls.Add(tbx_firstName);
            panel2.Controls.Add(lbl_country);
            panel2.Controls.Add(lbl_firstName);
            panel2.Controls.Add(lbl_infor);
            panel2.Controls.Add(lbl_lastName);
            panel2.Controls.Add(lbl_phone);
            panel2.Controls.Add(lbl_province);
            panel2.Location = new Point(22, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(613, 153);
            panel2.TabIndex = 1;
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.FromArgb(255, 255, 192);
            btn_print.Location = new Point(310, 114);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(72, 29);
            btn_print.TabIndex = 110;
            btn_print.Text = "In";
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Enabled = false;
            button1.Location = new Point(489, 114);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 109;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(192, 255, 192);
            btn_add.Location = new Point(389, 114);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 107;
            btn_add.Text = "Thêm mới";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // cbx_country
            // 
            cbx_country.FormattingEnabled = true;
            cbx_country.Items.AddRange(new object[] { "", "Japan", "Italy", "New Zealand", "Brazil", "Norway", "VietNam" });
            cbx_country.Location = new Point(432, 74);
            cbx_country.Name = "cbx_country";
            cbx_country.Size = new Size(151, 28);
            cbx_country.TabIndex = 106;
            // 
            // tbx_phone
            // 
            tbx_phone.BorderStyle = BorderStyle.FixedSingle;
            tbx_phone.Location = new Point(134, 114);
            tbx_phone.Name = "tbx_phone";
            tbx_phone.Size = new Size(148, 27);
            tbx_phone.TabIndex = 105;
            // 
            // cbx_province
            // 
            cbx_province.FormattingEnabled = true;
            cbx_province.Items.AddRange(new object[] { "", "An Giang", "Bà Rịa - Vũng Tàu", "Bạc Liêu", "Bắc Giang", "Bắc Kạn", "Bắc Ninh", "Bến Tre", "Bình Dương", "Bình Định", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Cần Thơ ", "Đà Nẵng ", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương", "Hải Phòng ", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên - Huế", "Tiền Giang", "TP. Hồ Chí Minh", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cbx_province.Location = new Point(432, 37);
            cbx_province.Name = "cbx_province";
            cbx_province.Size = new Size(151, 28);
            cbx_province.TabIndex = 104;
            // 
            // tbx_lastName
            // 
            tbx_lastName.BorderStyle = BorderStyle.FixedSingle;
            tbx_lastName.Location = new Point(76, 74);
            tbx_lastName.Name = "tbx_lastName";
            tbx_lastName.Size = new Size(206, 27);
            tbx_lastName.TabIndex = 102;
            // 
            // tbx_firstName
            // 
            tbx_firstName.BorderStyle = BorderStyle.FixedSingle;
            tbx_firstName.Location = new Point(76, 42);
            tbx_firstName.Name = "tbx_firstName";
            tbx_firstName.Size = new Size(206, 27);
            tbx_firstName.TabIndex = 101;
            // 
            // lbl_country
            // 
            lbl_country.AutoSize = true;
            lbl_country.Location = new Point(310, 77);
            lbl_country.Name = "lbl_country";
            lbl_country.Size = new Size(72, 20);
            lbl_country.TabIndex = 12;
            lbl_country.Text = "Quốc gia:";
            // 
            // lbl_firstName
            // 
            lbl_firstName.AutoSize = true;
            lbl_firstName.Location = new Point(19, 45);
            lbl_firstName.Name = "lbl_firstName";
            lbl_firstName.Size = new Size(32, 20);
            lbl_firstName.TabIndex = 11;
            lbl_firstName.Text = "Họ:";
            // 
            // lbl_infor
            // 
            lbl_infor.AutoSize = true;
            lbl_infor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_infor.Location = new Point(14, 10);
            lbl_infor.Name = "lbl_infor";
            lbl_infor.Size = new Size(161, 20);
            lbl_infor.TabIndex = 100;
            lbl_infor.Text = "Thông tin khách hàng";
            // 
            // lbl_lastName
            // 
            lbl_lastName.AutoSize = true;
            lbl_lastName.Location = new Point(19, 77);
            lbl_lastName.Name = "lbl_lastName";
            lbl_lastName.Size = new Size(35, 20);
            lbl_lastName.TabIndex = 10;
            lbl_lastName.Text = "Tên:";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(19, 116);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(100, 20);
            lbl_phone.TabIndex = 9;
            lbl_phone.Text = "Số điện thoại:";
            // 
            // lbl_province
            // 
            lbl_province.AutoSize = true;
            lbl_province.Location = new Point(310, 45);
            lbl_province.Name = "lbl_province";
            lbl_province.Size = new Size(116, 20);
            lbl_province.TabIndex = 8;
            lbl_province.Text = "Tỉnh/Thành phố:";
            // 
            // lbl_heading
            // 
            lbl_heading.AutoSize = true;
            lbl_heading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_heading.Location = new Point(241, 10);
            lbl_heading.Name = "lbl_heading";
            lbl_heading.Size = new Size(205, 28);
            lbl_heading.TabIndex = 0;
            lbl_heading.Text = "Quản lý Khách Hàng";
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(429, 223);
            button2.Name = "button2";
            button2.Size = new Size(206, 29);
            button2.TabIndex = 3;
            button2.Text = "In danh sách khách hàng";
            button2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 384);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_heading;
        private Panel panel2;
        private Label lbl_country;
        private Label lbl_firstName;
        private Label lbl_infor;
        private Label lbl_lastName;
        private Label lbl_phone;
        private Label lbl_province;
        private TextBox tbx_lastName;
        private TextBox tbx_firstName;
        private ComboBox cbx_province;
        private TextBox tbx_phone;
        private ComboBox cbx_country;
        private Button btn_add;
        private ListView listView;
        private Button button1;
        private Button btn_print;
        private Button button2;
    }
}
