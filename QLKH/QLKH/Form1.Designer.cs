
namespace QLKH
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tb_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.tb_TongTien = new System.Windows.Forms.TextBox();
            this.tb_MaKH = new System.Windows.Forms.TextBox();
            this.TongTien = new System.Windows.Forms.Label();
            this.NgayLap = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.Label();
            this.tb_MaHD = new System.Windows.Forms.TextBox();
            this.MaHD = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hoá đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 198);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.tb_NgayLap);
            this.groupBox2.Controls.Add(this.tb_TongTien);
            this.groupBox2.Controls.Add(this.tb_MaKH);
            this.groupBox2.Controls.Add(this.TongTien);
            this.groupBox2.Controls.Add(this.NgayLap);
            this.groupBox2.Controls.Add(this.MaKH);
            this.groupBox2.Controls.Add(this.tb_MaHD);
            this.groupBox2.Controls.Add(this.MaHD);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm mới";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thống kê theo tháng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(480, 19);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(149, 64);
            this.bt_them.TabIndex = 9;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_NgayLap
            // 
            this.tb_NgayLap.CustomFormat = "MM/dd/yyyy";
            this.tb_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tb_NgayLap.Location = new System.Drawing.Point(368, 19);
            this.tb_NgayLap.Name = "tb_NgayLap";
            this.tb_NgayLap.Size = new System.Drawing.Size(100, 22);
            this.tb_NgayLap.TabIndex = 7;
            this.tb_NgayLap.ValueChanged += new System.EventHandler(this.tb_NgayLap_ValueChanged);
            // 
            // tb_TongTien
            // 
            this.tb_TongTien.Location = new System.Drawing.Point(368, 61);
            this.tb_TongTien.Name = "tb_TongTien";
            this.tb_TongTien.Size = new System.Drawing.Size(100, 22);
            this.tb_TongTien.TabIndex = 6;
            // 
            // tb_MaKH
            // 
            this.tb_MaKH.Location = new System.Drawing.Point(138, 61);
            this.tb_MaKH.Name = "tb_MaKH";
            this.tb_MaKH.Size = new System.Drawing.Size(100, 22);
            this.tb_MaKH.TabIndex = 5;
            // 
            // TongTien
            // 
            this.TongTien.AutoSize = true;
            this.TongTien.Location = new System.Drawing.Point(291, 64);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(72, 16);
            this.TongTien.TabIndex = 4;
            this.TongTien.Text = "Tổng tiền:";
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSize = true;
            this.NgayLap.Location = new System.Drawing.Point(291, 24);
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Size = new System.Drawing.Size(68, 16);
            this.NgayLap.TabIndex = 3;
            this.NgayLap.Text = "Ngày lập:";
            this.NgayLap.Click += new System.EventHandler(this.NgayLap_Click);
            // 
            // MaKH
            // 
            this.MaKH.AutoSize = true;
            this.MaKH.Location = new System.Drawing.Point(23, 67);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(109, 16);
            this.MaKH.TabIndex = 2;
            this.MaKH.Text = "Mã khách hàng:";
            this.MaKH.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tb_MaHD
            // 
            this.tb_MaHD.Location = new System.Drawing.Point(138, 21);
            this.tb_MaHD.Name = "tb_MaHD";
            this.tb_MaHD.Size = new System.Drawing.Size(100, 22);
            this.tb_MaHD.TabIndex = 1;
            this.tb_MaHD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MaHD
            // 
            this.MaHD.AutoSize = true;
            this.MaHD.Location = new System.Drawing.Point(23, 27);
            this.MaHD.Name = "MaHD";
            this.MaHD.Size = new System.Drawing.Size(88, 16);
            this.MaHD.TabIndex = 0;
            this.MaHD.Text = "Mã hoá đơn:";
            this.MaHD.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(486, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 224);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê theo tháng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 342);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm hoá đơn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label MaHD;
        private System.Windows.Forms.TextBox tb_MaHD;
        private System.Windows.Forms.Label MaKH;
        private System.Windows.Forms.DateTimePicker tb_NgayLap;
        private System.Windows.Forms.TextBox tb_TongTien;
        private System.Windows.Forms.TextBox tb_MaKH;
        private System.Windows.Forms.Label TongTien;
        private System.Windows.Forms.Label NgayLap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

