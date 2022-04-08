namespace TeiasCountInfo
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
            this.btnSayacBilgi = new System.Windows.Forms.Button();
            this.btnSayacBilgileriGonder = new System.Windows.Forms.Button();
            this.dtpBasTar = new System.Windows.Forms.DateTimePicker();
            this.dtpBitTar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vhsBodyGridView = new System.Windows.Forms.DataGridView();
            this.dgvVhsBody = new System.Windows.Forms.DataGridView();
            this.lstBoxEicCode = new System.Windows.Forms.ListBox();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExcelAl = new System.Windows.Forms.Button();
            this.selectExcel = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dgvVhsBody2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vhsBodyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVhsBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVhsBody2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSayacBilgi
            // 
            this.btnSayacBilgi.Location = new System.Drawing.Point(12, 32);
            this.btnSayacBilgi.Name = "btnSayacBilgi";
            this.btnSayacBilgi.Size = new System.Drawing.Size(123, 28);
            this.btnSayacBilgi.TabIndex = 0;
            this.btnSayacBilgi.Text = "Sayac Bilgileri Getir";
            this.btnSayacBilgi.UseVisualStyleBackColor = true;
            this.btnSayacBilgi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSayacBilgileriGonder
            // 
            this.btnSayacBilgileriGonder.Location = new System.Drawing.Point(956, 504);
            this.btnSayacBilgileriGonder.Name = "btnSayacBilgileriGonder";
            this.btnSayacBilgileriGonder.Size = new System.Drawing.Size(123, 28);
            this.btnSayacBilgileriGonder.TabIndex = 1;
            this.btnSayacBilgileriGonder.Text = "Günlük Veri Al";
            this.btnSayacBilgileriGonder.UseVisualStyleBackColor = true;
            this.btnSayacBilgileriGonder.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpBasTar
            // 
            this.dtpBasTar.Location = new System.Drawing.Point(12, 505);
            this.dtpBasTar.Name = "dtpBasTar";
            this.dtpBasTar.Size = new System.Drawing.Size(200, 20);
            this.dtpBasTar.TabIndex = 2;
            this.dtpBasTar.ValueChanged += new System.EventHandler(this.dtpBasTar_ValueChanged);
            // 
            // dtpBitTar
            // 
            this.dtpBitTar.Location = new System.Drawing.Point(253, 504);
            this.dtpBitTar.Name = "dtpBitTar";
            this.dtpBitTar.Size = new System.Drawing.Size(200, 20);
            this.dtpBitTar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baslangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Periyod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "EIC Kod (Sayac Etso Kodu):";
            // 
            // vhsBodyGridView
            // 
            this.vhsBodyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vhsBodyGridView.Location = new System.Drawing.Point(12, 76);
            this.vhsBodyGridView.Name = "vhsBodyGridView";
            this.vhsBodyGridView.Size = new System.Drawing.Size(1253, 260);
            this.vhsBodyGridView.TabIndex = 9;
            this.vhsBodyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vhsBodyGridView_CellContentClick);
            // 
            // dgvVhsBody
            // 
            this.dgvVhsBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVhsBody.Location = new System.Drawing.Point(12, 682);
            this.dgvVhsBody.Name = "dgvVhsBody";
            this.dgvVhsBody.Size = new System.Drawing.Size(700, 227);
            this.dgvVhsBody.TabIndex = 10;
            // 
            // lstBoxEicCode
            // 
            this.lstBoxEicCode.FormattingEnabled = true;
            this.lstBoxEicCode.Location = new System.Drawing.Point(615, 505);
            this.lstBoxEicCode.Name = "lstBoxEicCode";
            this.lstBoxEicCode.Size = new System.Drawing.Size(309, 108);
            this.lstBoxEicCode.TabIndex = 12;
            this.lstBoxEicCode.SelectedIndexChanged += new System.EventHandler(this.lstBoxEicCode_SelectedIndexChanged);
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "15 Dakika",
            "1 Saat"});
            this.cmbPeriod.Location = new System.Drawing.Point(477, 503);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriod.TabIndex = 13;
            this.cmbPeriod.Text = "Süre Seçiniz";
            this.cmbPeriod.SelectedIndexChanged += new System.EventHandler(this.cmbPeriod_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 403);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(253, 403);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "15 Dakika",
            "1 Saat"});
            this.comboBox3.Location = new System.Drawing.Point(477, 403);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.Text = "Süre Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Periyod:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ay Seçiniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Yıl Seçiniz :";
            // 
            // btnExcelAl
            // 
            this.btnExcelAl.Location = new System.Drawing.Point(15, 640);
            this.btnExcelAl.Name = "btnExcelAl";
            this.btnExcelAl.Size = new System.Drawing.Size(123, 23);
            this.btnExcelAl.TabIndex = 22;
            this.btnExcelAl.Text = "Excel Al";
            this.btnExcelAl.UseVisualStyleBackColor = true;
            this.btnExcelAl.Click += new System.EventHandler(this.btnExcelAl_Click);
            // 
            // selectExcel
            // 
            this.selectExcel.Location = new System.Drawing.Point(145, 640);
            this.selectExcel.Name = "selectExcel";
            this.selectExcel.Size = new System.Drawing.Size(145, 23);
            this.selectExcel.TabIndex = 25;
            this.selectExcel.Text = "Seçilenleri Excele Al";
            this.selectExcel.UseVisualStyleBackColor = true;
            this.selectExcel.Click += new System.EventHandler(this.selectExcel_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(378, 938);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 26;
            this.btnFile.Text = "Gözat";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 948);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Dosya Yolu";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(79, 948);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 13);
            this.lblFile.TabIndex = 28;
            // 
            // dgvVhsBody2
            // 
            this.dgvVhsBody2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVhsBody2.Location = new System.Drawing.Point(784, 682);
            this.dgvVhsBody2.Name = "dgvVhsBody2";
            this.dgvVhsBody2.Size = new System.Drawing.Size(623, 227);
            this.dgvVhsBody2.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 1061);
            this.Controls.Add(this.dgvVhsBody2);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.selectExcel);
            this.Controls.Add(this.btnExcelAl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.lstBoxEicCode);
            this.Controls.Add(this.dgvVhsBody);
            this.Controls.Add(this.vhsBodyGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBitTar);
            this.Controls.Add(this.dtpBasTar);
            this.Controls.Add(this.btnSayacBilgileriGonder);
            this.Controls.Add(this.btnSayacBilgi);
            this.Name = "Form1";
            this.Text = "TEIAŞ SAYAC BİLGİLERİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vhsBodyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVhsBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVhsBody2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayacBilgi;
        private System.Windows.Forms.Button btnSayacBilgileriGonder;
        private System.Windows.Forms.DateTimePicker dtpBasTar;
        private System.Windows.Forms.DateTimePicker dtpBitTar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView vhsBodyGridView;
        private System.Windows.Forms.DataGridView dgvVhsBody;
        private System.Windows.Forms.ListBox lstBoxEicCode;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExcelAl;
        private System.Windows.Forms.Button selectExcel;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dgvVhsBody2;
    }
}

