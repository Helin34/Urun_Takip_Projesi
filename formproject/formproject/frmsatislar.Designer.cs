
namespace formproject
{
    partial class frmsatislar
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
            this.button4 = new System.Windows.Forms.Button();
            this.hesapla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txttoplam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmusteri = new System.Windows.Forms.TextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 37);
            this.button4.TabIndex = 14;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(60, 405);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(205, 37);
            this.hesapla.TabIndex = 13;
            this.hesapla.Text = "hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(101, 153);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(182, 24);
            this.txtfiyat.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fiyat:";
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(101, 121);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(182, 24);
            this.txtadet.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msktarih);
            this.groupBox1.Controls.Add(this.txtmusteri);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttoplam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.hesapla);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtfiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtadet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(607, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 521);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(101, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(182, 24);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satış ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 508);
            this.dataGridView1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 26);
            this.comboBox1.TabIndex = 15;
            // 
            // txttoplam
            // 
            this.txttoplam.Location = new System.Drawing.Point(101, 183);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.Size = new System.Drawing.Size(182, 24);
            this.txttoplam.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Toplam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tarih:";
            // 
            // txtmusteri
            // 
            this.txtmusteri.Location = new System.Drawing.Point(101, 89);
            this.txtmusteri.Name = "txtmusteri";
            this.txtmusteri.Size = new System.Drawing.Size(182, 24);
            this.txtmusteri.TabIndex = 21;
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(101, 214);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(182, 24);
            this.msktarih.TabIndex = 22;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // frmsatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmsatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsatislar";
            this.Load += new System.EventHandler(this.frmsatislar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttoplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmusteri;
        private System.Windows.Forms.MaskedTextBox msktarih;
    }
}