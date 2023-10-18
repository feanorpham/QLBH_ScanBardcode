namespace WindowsFormsApp2
{
    partial class FormInHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInHoaDon));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btunIn = new System.Windows.Forms.Button();
            this.cmbSoHoaDon = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(688, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btunIn);
            this.groupBox1.Controls.Add(this.cmbSoHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btunIn
            // 
            this.btunIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btunIn.Image = ((System.Drawing.Image)(resources.GetObject("btunIn.Image")));
            this.btunIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunIn.Location = new System.Drawing.Point(280, 20);
            this.btunIn.Name = "btunIn";
            this.btunIn.Size = new System.Drawing.Size(68, 40);
            this.btunIn.TabIndex = 3;
            this.btunIn.Text = "In";
            this.btunIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunIn.UseVisualStyleBackColor = true;
            this.btunIn.Click += new System.EventHandler(this.btunIn_Click);
            // 
            // cmbSoHoaDon
            // 
            this.cmbSoHoaDon.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSoHoaDon.FormattingEnabled = true;
            this.cmbSoHoaDon.Location = new System.Drawing.Point(21, 28);
            this.cmbSoHoaDon.Name = "cmbSoHoaDon";
            this.cmbSoHoaDon.Size = new System.Drawing.Size(211, 26);
            this.cmbSoHoaDon.TabIndex = 0;
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInHoaDon";
            this.Load += new System.EventHandler(this.FormInHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSoHoaDon;
        private System.Windows.Forms.Button btunIn;
    }
}