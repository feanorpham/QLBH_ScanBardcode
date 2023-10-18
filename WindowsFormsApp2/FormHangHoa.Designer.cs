namespace WindowsFormsApp2
{
    partial class FormHangHoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangHoa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChucNang = new System.Windows.Forms.ComboBox();
            this.btunStop = new System.Windows.Forms.Button();
            this.btunScan = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btunThoat = new System.Windows.Forms.Button();
            this.btunXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbMaNhaCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbDonGiaSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbTenHangHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbBardcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pbardcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbTenNhaCC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbMaCC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tongsonhacungcap = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tongsomathang = new System.Windows.Forms.Label();
            this.hovaten = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labaledate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChucNang);
            this.groupBox1.Controls.Add(this.btunStop);
            this.groupBox1.Controls.Add(this.btunScan);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btunThoat);
            this.groupBox1.Controls.Add(this.btunXoa);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(9, 627);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // cmbChucNang
            // 
            this.cmbChucNang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucNang.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChucNang.FormattingEnabled = true;
            this.cmbChucNang.Items.AddRange(new object[] {
            "Thêm nhà cung cấp",
            "Thêm hàng hóa",
            "Danh sách hàng hóa",
            "Danh sách nhà cung cấp"});
            this.cmbChucNang.Location = new System.Drawing.Point(12, 24);
            this.cmbChucNang.Name = "cmbChucNang";
            this.cmbChucNang.Size = new System.Drawing.Size(302, 31);
            this.cmbChucNang.TabIndex = 12;
            this.cmbChucNang.SelectedIndexChanged += new System.EventHandler(this.cmbChucNang_SelectedIndexChanged);
            // 
            // btunStop
            // 
            this.btunStop.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunStop.Image = ((System.Drawing.Image)(resources.GetObject("btunStop.Image")));
            this.btunStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunStop.Location = new System.Drawing.Point(602, 16);
            this.btunStop.Name = "btunStop";
            this.btunStop.Size = new System.Drawing.Size(74, 40);
            this.btunStop.TabIndex = 11;
            this.btunStop.Text = "Stop";
            this.btunStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunStop.UseVisualStyleBackColor = true;
            // 
            // btunScan
            // 
            this.btunScan.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunScan.Image = ((System.Drawing.Image)(resources.GetObject("btunScan.Image")));
            this.btunScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunScan.Location = new System.Drawing.Point(524, 16);
            this.btunScan.Name = "btunScan";
            this.btunScan.Size = new System.Drawing.Size(74, 40);
            this.btunScan.TabIndex = 10;
            this.btunScan.Text = "Scan";
            this.btunScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunScan.UseVisualStyleBackColor = true;
            this.btunScan.Click += new System.EventHandler(this.btunScan_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(369, 22);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(149, 31);
            this.textBox7.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nhập";
            // 
            // btunThoat
            // 
            this.btunThoat.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunThoat.Image = ((System.Drawing.Image)(resources.GetObject("btunThoat.Image")));
            this.btunThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunThoat.Location = new System.Drawing.Point(862, 16);
            this.btunThoat.Name = "btunThoat";
            this.btunThoat.Size = new System.Drawing.Size(76, 40);
            this.btunThoat.TabIndex = 6;
            this.btunThoat.Text = "Thoát";
            this.btunThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunThoat.UseVisualStyleBackColor = true;
            // 
            // btunXoa
            // 
            this.btunXoa.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunXoa.Image = ((System.Drawing.Image)(resources.GetObject("btunXoa.Image")));
            this.btunXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunXoa.Location = new System.Drawing.Point(785, 16);
            this.btunXoa.Name = "btunXoa";
            this.btunXoa.Size = new System.Drawing.Size(74, 40);
            this.btunXoa.TabIndex = 5;
            this.btunXoa.Text = "Xóa";
            this.btunXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunXoa.UseVisualStyleBackColor = true;
            this.btunXoa.Click += new System.EventHandler(this.btunXoa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(680, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Khởi tạo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbMaNhaCC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbDonGiaSP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbTenHangHoa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbBardcode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hàng hóa";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(146, 262);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(299, 22);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Hết Hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Sản Xuất";
            // 
            // txtbMaNhaCC
            // 
            this.txtbMaNhaCC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaNhaCC.Location = new System.Drawing.Point(146, 164);
            this.txtbMaNhaCC.Multiline = true;
            this.txtbMaNhaCC.Name = "txtbMaNhaCC";
            this.txtbMaNhaCC.Size = new System.Drawing.Size(299, 31);
            this.txtbMaNhaCC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Nhà Cung Cấp";
            // 
            // txtbDonGiaSP
            // 
            this.txtbDonGiaSP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDonGiaSP.Location = new System.Drawing.Point(146, 114);
            this.txtbDonGiaSP.Multiline = true;
            this.txtbDonGiaSP.Name = "txtbDonGiaSP";
            this.txtbDonGiaSP.Size = new System.Drawing.Size(299, 31);
            this.txtbDonGiaSP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn Giá";
            // 
            // txtbTenHangHoa
            // 
            this.txtbTenHangHoa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenHangHoa.Location = new System.Drawing.Point(146, 66);
            this.txtbTenHangHoa.Multiline = true;
            this.txtbTenHangHoa.Name = "txtbTenHangHoa";
            this.txtbTenHangHoa.Size = new System.Drawing.Size(299, 31);
            this.txtbTenHangHoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // txtbBardcode
            // 
            this.txtbBardcode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBardcode.Location = new System.Drawing.Point(146, 19);
            this.txtbBardcode.Multiline = true;
            this.txtbBardcode.Name = "txtbBardcode";
            this.txtbBardcode.Size = new System.Drawing.Size(299, 31);
            this.txtbBardcode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bardcode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHangHoa);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(942, 298);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.pbardcode,
            this.TenHangHoa,
            this.DonGiaSP,
            this.MaNhaCC,
            this.NgaySX,
            this.NgayHetHan});
            this.dgvHangHoa.Location = new System.Drawing.Point(6, 21);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(930, 271);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Update";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "Update";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Text = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 60;
            // 
            // pbardcode
            // 
            this.pbardcode.DataPropertyName = "Bardcode";
            this.pbardcode.HeaderText = "Bardcode";
            this.pbardcode.Name = "pbardcode";
            this.pbardcode.ReadOnly = true;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            this.TenHangHoa.HeaderText = "Tên Hàng Hóa";
            this.TenHangHoa.Name = "TenHangHoa";
            // 
            // DonGiaSP
            // 
            this.DonGiaSP.DataPropertyName = "DonGiaSP";
            this.DonGiaSP.HeaderText = "Đơn Giá";
            this.DonGiaSP.Name = "DonGiaSP";
            // 
            // MaNhaCC
            // 
            this.MaNhaCC.DataPropertyName = "MaNhaCC";
            this.MaNhaCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNhaCC.Name = "MaNhaCC";
            this.MaNhaCC.ReadOnly = true;
            // 
            // NgaySX
            // 
            this.NgaySX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySX.DataPropertyName = "NgaySX";
            this.NgaySX.HeaderText = "Ngày Sản Xuất";
            this.NgaySX.Name = "NgaySX";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbTenNhaCC);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtbMaCC);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(467, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 117);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin nhà cung cấp";
            // 
            // txtbTenNhaCC
            // 
            this.txtbTenNhaCC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenNhaCC.Location = new System.Drawing.Point(173, 72);
            this.txtbTenNhaCC.Multiline = true;
            this.txtbTenNhaCC.Name = "txtbTenNhaCC";
            this.txtbTenNhaCC.Size = new System.Drawing.Size(282, 31);
            this.txtbTenNhaCC.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên Nhà Cung Cấp";
            // 
            // txtbMaCC
            // 
            this.txtbMaCC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaCC.Location = new System.Drawing.Point(173, 25);
            this.txtbMaCC.Multiline = true;
            this.txtbMaCC.Name = "txtbMaCC";
            this.txtbMaCC.Size = new System.Drawing.Size(282, 31);
            this.txtbMaCC.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã Nhà Cung Cấp";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tongsonhacungcap);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.tongsomathang);
            this.groupBox5.Controls.Add(this.hovaten);
            this.groupBox5.Controls.Add(this.date);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.labaledate);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(467, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(482, 187);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông hàng trong kho";
            // 
            // tongsonhacungcap
            // 
            this.tongsonhacungcap.AutoSize = true;
            this.tongsonhacungcap.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongsonhacungcap.ForeColor = System.Drawing.Color.Red;
            this.tongsonhacungcap.Location = new System.Drawing.Point(170, 106);
            this.tongsonhacungcap.Name = "tongsonhacungcap";
            this.tongsonhacungcap.Size = new System.Drawing.Size(125, 16);
            this.tongsonhacungcap.TabIndex = 15;
            this.tongsonhacungcap.Text = "tongsonhacungcap";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(12, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tổng số nhà cung cấp: ";
            // 
            // tongsomathang
            // 
            this.tongsomathang.AutoSize = true;
            this.tongsomathang.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongsomathang.ForeColor = System.Drawing.Color.Red;
            this.tongsomathang.Location = new System.Drawing.Point(142, 85);
            this.tongsomathang.Name = "tongsomathang";
            this.tongsomathang.Size = new System.Drawing.Size(103, 16);
            this.tongsomathang.TabIndex = 13;
            this.tongsomathang.Text = "tongsomathang";
            // 
            // hovaten
            // 
            this.hovaten.AutoSize = true;
            this.hovaten.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hovaten.ForeColor = System.Drawing.Color.Red;
            this.hovaten.Location = new System.Drawing.Point(87, 60);
            this.hovaten.Name = "hovaten";
            this.hovaten.Size = new System.Drawing.Size(56, 16);
            this.hovaten.TabIndex = 12;
            this.hovaten.Text = "hovaten";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Red;
            this.date.Location = new System.Drawing.Point(55, 35);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(33, 16);
            this.date.TabIndex = 11;
            this.date.Text = "date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(13, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tổng số mặt hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(13, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhân viên:";
            // 
            // labaledate
            // 
            this.labaledate.AutoSize = true;
            this.labaledate.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labaledate.ForeColor = System.Drawing.Color.Red;
            this.labaledate.Location = new System.Drawing.Point(14, 35);
            this.labaledate.Name = "labaledate";
            this.labaledate.Size = new System.Drawing.Size(46, 16);
            this.labaledate.TabIndex = 8;
            this.labaledate.Text = "Ngày: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 711);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbMaNhaCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbDonGiaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbTenHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbBardcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btunThoat;
        private System.Windows.Forms.Button btunXoa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbTenNhaCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbMaCC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btunStop;
        private System.Windows.Forms.Button btunScan;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbChucNang;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbardcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Label tongsonhacungcap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label tongsomathang;
        private System.Windows.Forms.Label hovaten;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labaledate;
        private System.Windows.Forms.Timer timer2;
    }
}