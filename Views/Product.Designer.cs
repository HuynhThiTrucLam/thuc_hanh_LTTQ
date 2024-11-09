namespace WinFormsCore.Views
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menu = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            menu_logout = new ToolStripMenuItem();
            menu_exit = new ToolStripMenuItem();
            hàngHóaToolStripMenuItem = new ToolStripMenuItem();
            listProduct = new ListView();
            lbl_nhacc = new Label();
            lbl_name = new Label();
            lbl_heading = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            lbl_package = new Label();
            lbl_price = new Label();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lbl_discount = new Label();
            btn_import = new Button();
            btn_export = new Button();
            list_NCC = new ComboBox();
            productBindingSource = new BindingSource(components);
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, hàngHóaToolStripMenuItem, đơnHàngToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 28);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu_logout, menu_exit });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(48, 24);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // menu_logout
            // 
            menu_logout.Name = "menu_logout";
            menu_logout.Size = new Size(160, 26);
            menu_logout.Text = "Đăng xuất";
            menu_logout.Click += menu_logout_Click;
            // 
            // menu_exit
            // 
            menu_exit.Name = "menu_exit";
            menu_exit.Size = new Size(160, 26);
            menu_exit.Text = "Thoát";
            menu_exit.Click += menu_exit_Click;
            // 
            // hàngHóaToolStripMenuItem
            // 
            hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            hàngHóaToolStripMenuItem.Size = new Size(88, 24);
            hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            // 
            // listProduct
            // 
            listProduct.FullRowSelect = true;
            listProduct.Location = new Point(22, 225);
            listProduct.Name = "listProduct";
            listProduct.Size = new Size(750, 199);
            listProduct.TabIndex = 1;
            listProduct.UseCompatibleStateImageBehavior = false;
            listProduct.View = View.Details;
            // 
            // lbl_nhacc
            // 
            lbl_nhacc.AutoSize = true;
            lbl_nhacc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_nhacc.Location = new Point(22, 135);
            lbl_nhacc.Name = "lbl_nhacc";
            lbl_nhacc.Size = new Size(104, 20);
            lbl_nhacc.TabIndex = 2;
            lbl_nhacc.Text = "Nhà cung cấp";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_name.Location = new Point(22, 89);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(103, 20);
            lbl_name.TabIndex = 3;
            lbl_name.Text = "Tên sản phẩm";
            // 
            // lbl_heading
            // 
            lbl_heading.AutoSize = true;
            lbl_heading.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_heading.ForeColor = SystemColors.ActiveCaptionText;
            lbl_heading.Location = new Point(319, 38);
            lbl_heading.Name = "lbl_heading";
            lbl_heading.Size = new Size(150, 23);
            lbl_heading.TabIndex = 4;
            lbl_heading.Text = "Quản lý hàng hóa";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(153, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(153, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(257, 27);
            textBox3.TabIndex = 7;
            // 
            // lbl_package
            // 
            lbl_package.AutoSize = true;
            lbl_package.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_package.Location = new Point(24, 181);
            lbl_package.Name = "lbl_package";
            lbl_package.Size = new Size(66, 20);
            lbl_package.TabIndex = 8;
            lbl_package.Text = "Package";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_price.Location = new Point(458, 89);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(31, 20);
            lbl_price.TabIndex = 9;
            lbl_price.Text = "Giá";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(495, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 27);
            textBox4.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(lbl_discount);
            groupBox1.Location = new Point(458, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 42);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(241, 7);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Không";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(158, 7);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Có";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbl_discount
            // 
            lbl_discount.AutoSize = true;
            lbl_discount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_discount.Location = new Point(0, 9);
            lbl_discount.Name = "lbl_discount";
            lbl_discount.Size = new Size(69, 20);
            lbl_discount.TabIndex = 12;
            lbl_discount.Text = "Discount";
            // 
            // btn_import
            // 
            btn_import.BackColor = Color.FromArgb(192, 255, 255);
            btn_import.FlatStyle = FlatStyle.Flat;
            btn_import.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_import.Location = new Point(458, 181);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(137, 29);
            btn_import.TabIndex = 13;
            btn_import.Text = "Import sản phẩm";
            btn_import.UseVisualStyleBackColor = false;
            btn_import.Click += btn_import_Click;
            // 
            // btn_export
            // 
            btn_export.BackColor = Color.FromArgb(192, 255, 192);
            btn_export.FlatStyle = FlatStyle.Flat;
            btn_export.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_export.Location = new Point(601, 181);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(171, 29);
            btn_export.TabIndex = 14;
            btn_export.Text = "Export các sản phẩm";
            btn_export.UseVisualStyleBackColor = false;
            btn_export.Click += btn_export_Click_1;
            // 
            // list_NCC
            // 
            list_NCC.FormattingEnabled = true;
            list_NCC.Location = new Point(153, 133);
            list_NCC.Name = "list_NCC";
            list_NCC.Size = new Size(257, 28);
            list_NCC.TabIndex = 15;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Entities.Product);
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(88, 24);
            đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(list_NCC);
            Controls.Add(btn_export);
            Controls.Add(btn_import);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Controls.Add(lbl_price);
            Controls.Add(lbl_package);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(lbl_heading);
            Controls.Add(lbl_name);
            Controls.Add(lbl_nhacc);
            Controls.Add(listProduct);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Product";
            Text = "Product";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem menu_logout;
        private ToolStripMenuItem menu_exit;
        private ToolStripMenuItem hàngHóaToolStripMenuItem;
        private ListView listProduct;
        private Label lbl_nhacc;
        private Label lbl_name;
        private Label lbl_heading;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label lbl_package;
        private Label lbl_price;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label lbl_discount;
        private Button btn_import;
        private Button btn_export;
        private ComboBox list_NCC;
        private BindingSource productBindingSource;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
    }
}