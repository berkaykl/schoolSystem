﻿namespace schoolSystem
{
    partial class FrmOgrenci
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
            this.btnOgrenciList = new System.Windows.Forms.Button();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrenciPosta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenciTelno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrenciSinif = new System.Windows.Forms.TextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciAra = new System.Windows.Forms.Button();
            this.frmBtnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnOgrenciList
            // 
            this.btnOgrenciList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnOgrenciList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciList.Location = new System.Drawing.Point(12, 204);
            this.btnOgrenciList.Name = "btnOgrenciList";
            this.btnOgrenciList.Size = new System.Drawing.Size(250, 30);
            this.btnOgrenciList.TabIndex = 1;
            this.btnOgrenciList.Text = "Öğrencileri Listele";
            this.btnOgrenciList.UseVisualStyleBackColor = false;
            this.btnOgrenciList.Click += new System.EventHandler(this.btnOgrenciList_Click);
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(114, 12);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(148, 20);
            this.txtOgrenciId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci Adı:";
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(114, 38);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(148, 20);
            this.txtOgrenciAdi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Öğrenci Soyadı:";
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(114, 62);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(148, 20);
            this.txtOgrenciSoyadi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Öğrenci Numarası:";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(114, 88);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(148, 20);
            this.txtOgrenciNo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Öğrenci E-Posta:";
            // 
            // txtOgrenciPosta
            // 
            this.txtOgrenciPosta.Location = new System.Drawing.Point(114, 114);
            this.txtOgrenciPosta.Name = "txtOgrenciPosta";
            this.txtOgrenciPosta.Size = new System.Drawing.Size(148, 20);
            this.txtOgrenciPosta.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Öğrenci Telefon No:";
            // 
            // txtOgrenciTelno
            // 
            this.txtOgrenciTelno.Location = new System.Drawing.Point(114, 141);
            this.txtOgrenciTelno.Name = "txtOgrenciTelno";
            this.txtOgrenciTelno.Size = new System.Drawing.Size(148, 20);
            this.txtOgrenciTelno.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Öğrenci Sınıfı:";
            // 
            // txtOgrenciSinif
            // 
            this.txtOgrenciSinif.Location = new System.Drawing.Point(114, 168);
            this.txtOgrenciSinif.Name = "txtOgrenciSinif";
            this.txtOgrenciSinif.Size = new System.Drawing.Size(148, 20);
            this.txtOgrenciSinif.TabIndex = 14;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnOgrenciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(12, 276);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(250, 30);
            this.btnOgrenciEkle.TabIndex = 16;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnOgrenciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciSil.Location = new System.Drawing.Point(12, 312);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(250, 30);
            this.btnOgrenciSil.TabIndex = 17;
            this.btnOgrenciSil.Text = "Öğrenci Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = false;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnOgrenciGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(12, 348);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(250, 30);
            this.btnOgrenciGuncelle.TabIndex = 18;
            this.btnOgrenciGuncelle.Text = "Öğrenci Güncelle";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = false;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // btnOgrenciAra
            // 
            this.btnOgrenciAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnOgrenciAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciAra.Location = new System.Drawing.Point(12, 240);
            this.btnOgrenciAra.Name = "btnOgrenciAra";
            this.btnOgrenciAra.Size = new System.Drawing.Size(250, 30);
            this.btnOgrenciAra.TabIndex = 19;
            this.btnOgrenciAra.Text = "Öğrenci Ara";
            this.btnOgrenciAra.UseVisualStyleBackColor = false;
            this.btnOgrenciAra.Click += new System.EventHandler(this.btnOgrenciAra_Click);
            // 
            // frmBtnGeri
            // 
            this.frmBtnGeri.BackColor = System.Drawing.Color.Maroon;
            this.frmBtnGeri.ForeColor = System.Drawing.Color.White;
            this.frmBtnGeri.Location = new System.Drawing.Point(12, 420);
            this.frmBtnGeri.Name = "frmBtnGeri";
            this.frmBtnGeri.Size = new System.Drawing.Size(59, 30);
            this.frmBtnGeri.TabIndex = 21;
            this.frmBtnGeri.Text = "Geri Dön";
            this.frmBtnGeri.UseVisualStyleBackColor = false;
            this.frmBtnGeri.Click += new System.EventHandler(this.frmBtnGeri_Click);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 461);
            this.Controls.Add(this.frmBtnGeri);
            this.Controls.Add(this.btnOgrenciAra);
            this.Controls.Add(this.btnOgrenciGuncelle);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOgrenciSinif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOgrenciTelno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOgrenciPosta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrenciSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciId);
            this.Controls.Add(this.btnOgrenciList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenciList;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrenciPosta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenciTelno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOgrenciSinif;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.Button btnOgrenciAra;
        private System.Windows.Forms.Button frmBtnGeri;
    }
}

