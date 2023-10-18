namespace WindowsFormsApp2
{
    partial class FormDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoanhThu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rdTKNV = new System.Windows.Forms.RadioButton();
            this.rdXuatExe = new System.Windows.Forms.RadioButton();
            this.rdTKnam = new System.Windows.Forms.RadioButton();
            this.rdTKthang = new System.Windows.Forms.RadioButton();
            this.btunKT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.txtbNhap = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbNhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.rdTKNV);
            this.groupBox1.Controls.Add(this.rdXuatExe);
            this.groupBox1.Controls.Add(this.rdTKnam);
            this.groupBox1.Controls.Add(this.rdTKthang);
            this.groupBox1.Controls.Add(this.btunKT);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(733, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rdTKNV
            // 
            this.rdTKNV.AutoSize = true;
            this.rdTKNV.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTKNV.Location = new System.Drawing.Point(162, 47);
            this.rdTKNV.Name = "rdTKNV";
            this.rdTKNV.Size = new System.Drawing.Size(163, 19);
            this.rdTKNV.TabIndex = 4;
            this.rdTKNV.TabStop = true;
            this.rdTKNV.Text = "Thông kê theo nhân viên";
            this.rdTKNV.UseVisualStyleBackColor = true;
            // 
            // rdXuatExe
            // 
            this.rdXuatExe.AutoSize = true;
            this.rdXuatExe.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdXuatExe.Location = new System.Drawing.Point(162, 22);
            this.rdXuatExe.Name = "rdXuatExe";
            this.rdXuatExe.Size = new System.Drawing.Size(86, 19);
            this.rdXuatExe.TabIndex = 3;
            this.rdXuatExe.TabStop = true;
            this.rdXuatExe.Text = "Xuất Exect";
            this.rdXuatExe.UseVisualStyleBackColor = true;
            // 
            // rdTKnam
            // 
            this.rdTKnam.AutoSize = true;
            this.rdTKnam.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTKnam.Location = new System.Drawing.Point(16, 46);
            this.rdTKnam.Name = "rdTKnam";
            this.rdTKnam.Size = new System.Drawing.Size(133, 19);
            this.rdTKnam.TabIndex = 2;
            this.rdTKnam.TabStop = true;
            this.rdTKnam.Text = "Thông kê theo năm";
            this.rdTKnam.UseVisualStyleBackColor = true;
            // 
            // rdTKthang
            // 
            this.rdTKthang.AutoSize = true;
            this.rdTKthang.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTKthang.Location = new System.Drawing.Point(16, 21);
            this.rdTKthang.Name = "rdTKthang";
            this.rdTKthang.Size = new System.Drawing.Size(140, 19);
            this.rdTKthang.TabIndex = 1;
            this.rdTKthang.TabStop = true;
            this.rdTKthang.Text = "Thống kê theo tháng";
            this.rdTKthang.UseVisualStyleBackColor = true;
            // 
            // btunKT
            // 
            this.btunKT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunKT.Image = ((System.Drawing.Image)(resources.GetObject("btunKT.Image")));
            this.btunKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunKT.Location = new System.Drawing.Point(622, 16);
            this.btunKT.Name = "btunKT";
            this.btunKT.Size = new System.Drawing.Size(105, 44);
            this.btunKT.TabIndex = 0;
            this.btunKT.Text = "Khởi Tạo";
            this.btunKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunKT.UseVisualStyleBackColor = true;
            this.btunKT.Click += new System.EventHandler(this.btunKT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTK);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // dgvTK
            // 
            this.dgvTK.AllowUserToAddRows = false;
            this.dgvTK.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(7, 22);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.Size = new System.Drawing.Size(820, 410);
            this.dgvTK.TabIndex = 0;
            // 
            // txtbNhap
            // 
            this.txtbNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNhap.Location = new System.Drawing.Point(400, 27);
            this.txtbNhap.Multiline = true;
            this.txtbNhap.Name = "txtbNhap";
            this.txtbNhap.Size = new System.Drawing.Size(207, 27);
            this.txtbNhap.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2003|*.xls";
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoanhThu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTKNV;
        private System.Windows.Forms.RadioButton rdXuatExe;
        private System.Windows.Forms.RadioButton rdTKnam;
        private System.Windows.Forms.RadioButton rdTKthang;
        private System.Windows.Forms.Button btunKT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.TextBox txtbNhap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}