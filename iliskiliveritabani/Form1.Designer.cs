namespace iliskiliveritabani
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmburun = new System.Windows.Forms.ComboBox();
            this.cmbpersonel = new System.Windows.Forms.ComboBox();
            this.txtfıyat = new System.Windows.Forms.TextBox();
            this.btnislemiyap = new System.Windows.Forms.Button();
            this.cmbmusteri = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmusteriadsoyad = new System.Windows.Forms.TextBox();
            this.btnmusterigiris = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txturungiris = new System.Windows.Forms.Button();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txturunstok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txturunalis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txturunsatis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1265, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "URUN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "MUSTERI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "PERSONEL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "FIYAT :";
            // 
            // cmburun
            // 
            this.cmburun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmburun.FormattingEnabled = true;
            this.cmburun.Location = new System.Drawing.Point(148, 28);
            this.cmburun.Name = "cmburun";
            this.cmburun.Size = new System.Drawing.Size(303, 33);
            this.cmburun.TabIndex = 6;
            // 
            // cmbpersonel
            // 
            this.cmbpersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpersonel.FormattingEnabled = true;
            this.cmbpersonel.Location = new System.Drawing.Point(148, 138);
            this.cmbpersonel.Name = "cmbpersonel";
            this.cmbpersonel.Size = new System.Drawing.Size(303, 33);
            this.cmbpersonel.TabIndex = 7;
            // 
            // txtfıyat
            // 
            this.txtfıyat.Location = new System.Drawing.Point(148, 191);
            this.txtfıyat.Name = "txtfıyat";
            this.txtfıyat.Size = new System.Drawing.Size(302, 31);
            this.txtfıyat.TabIndex = 9;
            // 
            // btnislemiyap
            // 
            this.btnislemiyap.Location = new System.Drawing.Point(457, 162);
            this.btnislemiyap.Name = "btnislemiyap";
            this.btnislemiyap.Size = new System.Drawing.Size(101, 65);
            this.btnislemiyap.TabIndex = 10;
            this.btnislemiyap.Text = "İşlemi Yap";
            this.btnislemiyap.UseVisualStyleBackColor = true;
            this.btnislemiyap.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // cmbmusteri
            // 
            this.cmbmusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmusteri.FormattingEnabled = true;
            this.cmbmusteri.Location = new System.Drawing.Point(148, 84);
            this.cmbmusteri.Name = "cmbmusteri";
            this.cmbmusteri.Size = new System.Drawing.Size(303, 33);
            this.cmbmusteri.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnislemiyap);
            this.groupBox1.Controls.Add(this.cmbmusteri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtfıyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbpersonel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmburun);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 233);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış İşlemi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnmusterigiris);
            this.groupBox2.Controls.Add(this.txtmusteriadsoyad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(597, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 233);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Müşteri Girişi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşterinin Adı Soyadı ";
            // 
            // txtmusteriadsoyad
            // 
            this.txtmusteriadsoyad.Location = new System.Drawing.Point(11, 84);
            this.txtmusteriadsoyad.Name = "txtmusteriadsoyad";
            this.txtmusteriadsoyad.Size = new System.Drawing.Size(222, 31);
            this.txtmusteriadsoyad.TabIndex = 1;
            // 
            // btnmusterigiris
            // 
            this.btnmusterigiris.Location = new System.Drawing.Point(70, 172);
            this.btnmusterigiris.Name = "btnmusterigiris";
            this.btnmusterigiris.Size = new System.Drawing.Size(125, 35);
            this.btnmusterigiris.TabIndex = 2;
            this.btnmusterigiris.Text = "Kaydet";
            this.btnmusterigiris.UseVisualStyleBackColor = true;
            this.btnmusterigiris.Click += new System.EventHandler(this.btnmusterigiris_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txturunsatis);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txturunalis);
            this.groupBox3.Controls.Add(this.txturungiris);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txturunstok);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txturunad);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(845, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 233);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Ürün Girişi";
            // 
            // txturungiris
            // 
            this.txturungiris.Location = new System.Drawing.Point(265, 192);
            this.txturungiris.Name = "txturungiris";
            this.txturungiris.Size = new System.Drawing.Size(125, 35);
            this.txturungiris.TabIndex = 2;
            this.txturungiris.Text = "Kaydet";
            this.txturungiris.UseVisualStyleBackColor = true;
            this.txturungiris.Click += new System.EventHandler(this.txturungiris_Click);
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(131, 43);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(259, 31);
            this.txturunad.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ad :";
            // 
            // txturunstok
            // 
            this.txturunstok.Location = new System.Drawing.Point(131, 80);
            this.txturunstok.Name = "txturunstok";
            this.txturunstok.Size = new System.Drawing.Size(259, 31);
            this.txturunstok.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Stok :";
            // 
            // txturunalis
            // 
            this.txturunalis.Location = new System.Drawing.Point(131, 117);
            this.txturunalis.Name = "txturunalis";
            this.txturunalis.Size = new System.Drawing.Size(259, 31);
            this.txturunalis.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Alış Fiyat :";
            // 
            // txturunsatis
            // 
            this.txturunsatis.Location = new System.Drawing.Point(131, 154);
            this.txturunsatis.Name = "txturunsatis";
            this.txturunsatis.Size = new System.Drawing.Size(259, 31);
            this.txturunsatis.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Satış Fiyat :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 631);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlişkili Veri Tabanı Projesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmburun;
        private System.Windows.Forms.ComboBox cmbpersonel;
        private System.Windows.Forms.TextBox txtfıyat;
        private System.Windows.Forms.Button btnislemiyap;
        private System.Windows.Forms.ComboBox cmbmusteri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnmusterigiris;
        private System.Windows.Forms.TextBox txtmusteriadsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txturunsatis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txturunalis;
        private System.Windows.Forms.Button txturungiris;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txturunstok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label7;
    }
}

