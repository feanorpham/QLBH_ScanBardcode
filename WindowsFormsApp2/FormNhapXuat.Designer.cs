namespace WindowsFormsApp2
{
    partial class FormNhapXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapXuat));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbSoLuongNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhaCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNhapXuat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btunThem = new System.Windows.Forms.Button();
            this.btunHangHoa = new System.Windows.Forms.Button();
            this.cmbnhapxuat = new System.Windows.Forms.ComboBox();
            this.cmbChucNang = new System.Windows.Forms.ComboBox();
            this.btunStop = new System.Windows.Forms.Button();
            this.btunScan = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btunThoat = new System.Windows.Forms.Button();
            this.btunXoa = new System.Windows.Forms.Button();
            this.btunKT = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbdongiaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbsoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbBardcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtbSoNhapXuat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hovaten = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labaledate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNX = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbThanhTien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtbSoLuongNCC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaNhaCC);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu";
            // 
            // txtbThanhTien
            // 
            this.txtbThanhTien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbThanhTien.Location = new System.Drawing.Point(134, 113);
            this.txtbThanhTien.Multiline = true;
            this.txtbThanhTien.Name = "txtbThanhTien";
            this.txtbThanhTien.ReadOnly = true;
            this.txtbThanhTien.Size = new System.Drawing.Size(440, 31);
            this.txtbThanhTien.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Thành tiền";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(440, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txtbSoLuongNCC
            // 
            this.txtbSoLuongNCC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSoLuongNCC.Location = new System.Drawing.Point(134, 66);
            this.txtbSoLuongNCC.Multiline = true;
            this.txtbSoLuongNCC.Name = "txtbSoLuongNCC";
            this.txtbSoLuongNCC.ReadOnly = true;
            this.txtbSoLuongNCC.Size = new System.Drawing.Size(440, 31);
            this.txtbSoLuongNCC.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày tạo";
            // 
            // txtMaNhaCC
            // 
            this.txtMaNhaCC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhaCC.Location = new System.Drawing.Point(134, 21);
            this.txtMaNhaCC.Multiline = true;
            this.txtMaNhaCC.Name = "txtMaNhaCC";
            this.txtMaNhaCC.ReadOnly = true;
            this.txtMaNhaCC.Size = new System.Drawing.Size(440, 31);
            this.txtMaNhaCC.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNhapXuat);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(612, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(812, 300);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết nhập xuất";
            // 
            // dgvNhapXuat
            // 
            this.dgvNhapXuat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhapXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvNhapXuat.Location = new System.Drawing.Point(6, 21);
            this.dgvNhapXuat.Name = "dgvNhapXuat";
            this.dgvNhapXuat.Size = new System.Drawing.Size(800, 273);
            this.dgvNhapXuat.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SoNhapXuat";
            this.Column1.HeaderText = "Số phiếu nhập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Bardcode";
            this.Column2.HeaderText = "Bardcode";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DonGiaSP";
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "NgayTao";
            this.Column5.HeaderText = "Ngày Tạo";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Thành Tiền";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Update";
            this.Column7.Name = "Column7";
            this.Column7.ToolTipText = "Update";
            this.Column7.UseColumnTextForButtonValue = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Delete";
            this.Column8.Name = "Column8";
            this.Column8.ToolTipText = "Delete";
            this.Column8.UseColumnTextForButtonValue = true;
            this.Column8.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btunThem);
            this.groupBox1.Controls.Add(this.btunHangHoa);
            this.groupBox1.Controls.Add(this.cmbnhapxuat);
            this.groupBox1.Controls.Add(this.cmbChucNang);
            this.groupBox1.Controls.Add(this.btunStop);
            this.groupBox1.Controls.Add(this.btunScan);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.btunThoat);
            this.groupBox1.Controls.Add(this.btunXoa);
            this.groupBox1.Controls.Add(this.btunKT);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 565);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1410, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(270, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nhập/Xuất:";
            // 
            // btunThem
            // 
            this.btunThem.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunThem.Image = ((System.Drawing.Image)(resources.GetObject("btunThem.Image")));
            this.btunThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunThem.Location = new System.Drawing.Point(837, 19);
            this.btunThem.Name = "btunThem";
            this.btunThem.Size = new System.Drawing.Size(82, 40);
            this.btunThem.TabIndex = 14;
            this.btunThem.Text = "Thêm";
            this.btunThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunThem.UseVisualStyleBackColor = true;
            this.btunThem.Click += new System.EventHandler(this.btunThem_Click);
            // 
            // btunHangHoa
            // 
            this.btunHangHoa.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("btunHangHoa.Image")));
            this.btunHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunHangHoa.Location = new System.Drawing.Point(1093, 19);
            this.btunHangHoa.Name = "btunHangHoa";
            this.btunHangHoa.Size = new System.Drawing.Size(97, 40);
            this.btunHangHoa.TabIndex = 13;
            this.btunHangHoa.Text = "Hàng Hóa";
            this.btunHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunHangHoa.UseVisualStyleBackColor = true;
            // 
            // cmbnhapxuat
            // 
            this.cmbnhapxuat.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cmbnhapxuat.FormattingEnabled = true;
            this.cmbnhapxuat.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cmbnhapxuat.Location = new System.Drawing.Point(351, 27);
            this.cmbnhapxuat.Name = "cmbnhapxuat";
            this.cmbnhapxuat.Size = new System.Drawing.Size(104, 25);
            this.cmbnhapxuat.TabIndex = 18;
            // 
            // cmbChucNang
            // 
            this.cmbChucNang.FormattingEnabled = true;
            this.cmbChucNang.Items.AddRange(new object[] {
            "Thêm phiếu nhập",
            "Thêm phiếu xuất"});
            this.cmbChucNang.Location = new System.Drawing.Point(16, 26);
            this.cmbChucNang.Name = "cmbChucNang";
            this.cmbChucNang.Size = new System.Drawing.Size(232, 24);
            this.cmbChucNang.TabIndex = 12;
            // 
            // btunStop
            // 
            this.btunStop.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunStop.Image = ((System.Drawing.Image)(resources.GetObject("btunStop.Image")));
            this.btunStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunStop.Location = new System.Drawing.Point(648, 19);
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
            this.btunScan.Location = new System.Drawing.Point(568, 18);
            this.btunScan.Name = "btunScan";
            this.btunScan.Size = new System.Drawing.Size(74, 40);
            this.btunScan.TabIndex = 10;
            this.btunScan.Text = "Start";
            this.btunScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunScan.UseVisualStyleBackColor = true;
            this.btunScan.Click += new System.EventHandler(this.btunScan_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(487, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 20);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "In phiếu";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btunThoat
            // 
            this.btunThoat.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunThoat.Image = ((System.Drawing.Image)(resources.GetObject("btunThoat.Image")));
            this.btunThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunThoat.Location = new System.Drawing.Point(1006, 19);
            this.btunThoat.Name = "btunThoat";
            this.btunThoat.Size = new System.Drawing.Size(81, 40);
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
            this.btunXoa.Location = new System.Drawing.Point(925, 20);
            this.btunXoa.Name = "btunXoa";
            this.btunXoa.Size = new System.Drawing.Size(75, 40);
            this.btunXoa.TabIndex = 5;
            this.btunXoa.Text = "Xóa";
            this.btunXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunXoa.UseVisualStyleBackColor = true;
            // 
            // btunKT
            // 
            this.btunKT.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunKT.Image = ((System.Drawing.Image)(resources.GetObject("btunKT.Image")));
            this.btunKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunKT.Location = new System.Drawing.Point(728, 20);
            this.btunKT.Name = "btunKT";
            this.btunKT.Size = new System.Drawing.Size(103, 40);
            this.btunKT.TabIndex = 2;
            this.btunKT.Text = "Khởi tạo";
            this.btunKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunKT.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtbdongiaSP);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtbsoluong);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtbBardcode);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(612, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 241);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết phiếu";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(99, 165);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(443, 22);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ngày tạo";
            // 
            // txtbdongiaSP
            // 
            this.txtbdongiaSP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbdongiaSP.Location = new System.Drawing.Point(99, 119);
            this.txtbdongiaSP.Multiline = true;
            this.txtbdongiaSP.Name = "txtbdongiaSP";
            this.txtbdongiaSP.Size = new System.Drawing.Size(443, 31);
            this.txtbdongiaSP.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đơn giá";
            // 
            // txtbsoluong
            // 
            this.txtbsoluong.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbsoluong.Location = new System.Drawing.Point(99, 73);
            this.txtbsoluong.Multiline = true;
            this.txtbsoluong.Name = "txtbsoluong";
            this.txtbsoluong.Size = new System.Drawing.Size(443, 31);
            this.txtbsoluong.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng";
            // 
            // txtbBardcode
            // 
            this.txtbBardcode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBardcode.Location = new System.Drawing.Point(99, 28);
            this.txtbBardcode.Multiline = true;
            this.txtbBardcode.Name = "txtbBardcode";
            this.txtbBardcode.Size = new System.Drawing.Size(443, 31);
            this.txtbBardcode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bardcode";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtbSoNhapXuat);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.hovaten);
            this.groupBox5.Controls.Add(this.date);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.labaledate);
            this.groupBox5.Location = new System.Drawing.Point(1177, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(247, 241);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // txtbSoNhapXuat
            // 
            this.txtbSoNhapXuat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSoNhapXuat.Location = new System.Drawing.Point(105, 73);
            this.txtbSoNhapXuat.Multiline = true;
            this.txtbSoNhapXuat.Name = "txtbSoNhapXuat";
            this.txtbSoNhapXuat.ReadOnly = true;
            this.txtbSoNhapXuat.Size = new System.Drawing.Size(104, 31);
            this.txtbSoNhapXuat.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số Nhập Xuất:";
            // 
            // hovaten
            // 
            this.hovaten.AutoSize = true;
            this.hovaten.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hovaten.ForeColor = System.Drawing.Color.Red;
            this.hovaten.Location = new System.Drawing.Point(79, 43);
            this.hovaten.Name = "hovaten";
            this.hovaten.Size = new System.Drawing.Size(56, 16);
            this.hovaten.TabIndex = 10;
            this.hovaten.Text = "hovaten";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Red;
            this.date.Location = new System.Drawing.Point(47, 18);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(33, 16);
            this.date.TabIndex = 9;
            this.date.Text = "date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(5, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nhân viên:";
            // 
            // labaledate
            // 
            this.labaledate.AutoSize = true;
            this.labaledate.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labaledate.ForeColor = System.Drawing.Color.Red;
            this.labaledate.Location = new System.Drawing.Point(6, 18);
            this.labaledate.Name = "labaledate";
            this.labaledate.Size = new System.Drawing.Size(46, 16);
            this.labaledate.TabIndex = 7;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvPhieuNX);
            this.groupBox6.Location = new System.Drawing.Point(12, 259);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(594, 300);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhập xuất";
            // 
            // dgvPhieuNX
            // 
            this.dgvPhieuNX.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhieuNX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvPhieuNX.Location = new System.Drawing.Point(7, 22);
            this.dgvPhieuNX.Name = "dgvPhieuNX";
            this.dgvPhieuNX.Size = new System.Drawing.Size(581, 272);
            this.dgvPhieuNX.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SoNhapXuat";
            this.Column9.HeaderText = "Số phiếu nhập";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 40;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MaNhaCC";
            this.Column10.HeaderText = "Mã nhà cung cấp";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "SoLuong";
            this.Column11.HeaderText = "Số Lượng";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "ThanhTien";
            this.Column12.HeaderText = "Thành Tiền";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.DataPropertyName = "NgayTao";
            this.Column13.HeaderText = "Ngày Tạo";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Loai";
            this.Column14.HeaderText = "Loại";
            this.Column14.Name = "Column14";
            this.Column14.Width = 60;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Delete";
            this.Column15.Name = "Column15";
            this.Column15.ToolTipText = "Delete";
            this.Column15.UseColumnTextForButtonValue = true;
            this.Column15.Width = 60;
            // 
            // FormNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 645);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormNhapXuat";
            this.Text = "FormNhapXuat";
            this.Load += new System.EventHandler(this.FormNhapXuat_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btunStop;
        private System.Windows.Forms.Button btunScan;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btunThoat;
        private System.Windows.Forms.Button btunXoa;
        private System.Windows.Forms.Button btunKT;
        private System.Windows.Forms.ComboBox cmbChucNang;
        private System.Windows.Forms.TextBox txtbSoLuongNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNhaCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvNhapXuat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbdongiaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbBardcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label hovaten;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labaledate;
        private System.Windows.Forms.TextBox txtbSoNhapXuat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbnhapxuat;
        private System.Windows.Forms.Button btunHangHoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btunThem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvPhieuNX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewButtonColumn Column15;
    }
}