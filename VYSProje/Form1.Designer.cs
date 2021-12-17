
namespace VYSProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cksbtn = new System.Windows.Forms.Button();
            this.txtAid = new System.Windows.Forms.TextBox();
            this.txtAsfr = new System.Windows.Forms.TextBox();
            this.txtAshbid = new System.Windows.Forms.TextBox();
            this.txtAmrk = new System.Windows.Forms.TextBox();
            this.txtAmdl = new System.Windows.Forms.TextBox();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblAID = new System.Windows.Forms.Label();
            this.lblAS = new System.Windows.Forms.Label();
            this.lblAModel = new System.Windows.Forms.Label();
            this.lblAMarka = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.btngncl = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsbid = new System.Windows.Forms.TextBox();
            this.txtprsnltp = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 495);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cksbtn);
            this.tabPage1.Controls.Add(this.txtAid);
            this.tabPage1.Controls.Add(this.txtAsfr);
            this.tabPage1.Controls.Add(this.txtAshbid);
            this.tabPage1.Controls.Add(this.txtAmrk);
            this.tabPage1.Controls.Add(this.txtAmdl);
            this.tabPage1.Controls.Add(this.lblAP);
            this.tabPage1.Controls.Add(this.lblAID);
            this.tabPage1.Controls.Add(this.lblAS);
            this.tabPage1.Controls.Add(this.lblAModel);
            this.tabPage1.Controls.Add(this.lblAMarka);
            this.tabPage1.Controls.Add(this.btnara);
            this.tabPage1.Controls.Add(this.btngncl);
            this.tabPage1.Controls.Add(this.btnsil);
            this.tabPage1.Controls.Add(this.btnekle);
            this.tabPage1.Controls.Add(this.btnlist);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cksbtn
            // 
            this.cksbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cksbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cksbtn.Location = new System.Drawing.Point(838, 435);
            this.cksbtn.Name = "cksbtn";
            this.cksbtn.Size = new System.Drawing.Size(101, 34);
            this.cksbtn.TabIndex = 37;
            this.cksbtn.Text = "ÇIKIŞ";
            this.cksbtn.UseVisualStyleBackColor = false;
            this.cksbtn.Click += new System.EventHandler(this.cksbtn_Click);
            // 
            // txtAid
            // 
            this.txtAid.Location = new System.Drawing.Point(109, 444);
            this.txtAid.Name = "txtAid";
            this.txtAid.Size = new System.Drawing.Size(100, 20);
            this.txtAid.TabIndex = 36;
            // 
            // txtAsfr
            // 
            this.txtAsfr.Location = new System.Drawing.Point(109, 362);
            this.txtAsfr.Name = "txtAsfr";
            this.txtAsfr.Size = new System.Drawing.Size(100, 20);
            this.txtAsfr.TabIndex = 35;
            // 
            // txtAshbid
            // 
            this.txtAshbid.Location = new System.Drawing.Point(109, 403);
            this.txtAshbid.Name = "txtAshbid";
            this.txtAshbid.Size = new System.Drawing.Size(100, 20);
            this.txtAshbid.TabIndex = 34;
            this.txtAshbid.TextChanged += new System.EventHandler(this.txtAshbid_TextChanged);
            // 
            // txtAmrk
            // 
            this.txtAmrk.Location = new System.Drawing.Point(109, 280);
            this.txtAmrk.Name = "txtAmrk";
            this.txtAmrk.Size = new System.Drawing.Size(100, 20);
            this.txtAmrk.TabIndex = 33;
            // 
            // txtAmdl
            // 
            this.txtAmdl.Location = new System.Drawing.Point(109, 321);
            this.txtAmdl.Name = "txtAmdl";
            this.txtAmdl.Size = new System.Drawing.Size(100, 20);
            this.txtAmdl.TabIndex = 32;
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(14, 407);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(93, 13);
            this.lblAP.TabIndex = 31;
            this.lblAP.Text = "ARAÇ SAHİBİ NO";
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Location = new System.Drawing.Point(14, 447);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(55, 13);
            this.lblAID.TabIndex = 30;
            this.lblAID.Text = "ARAÇ NO";
            // 
            // lblAS
            // 
            this.lblAS.AutoSize = true;
            this.lblAS.Location = new System.Drawing.Point(14, 367);
            this.lblAS.Name = "lblAS";
            this.lblAS.Size = new System.Drawing.Size(79, 13);
            this.lblAS.TabIndex = 29;
            this.lblAS.Text = "SEFER SAYISI";
            // 
            // lblAModel
            // 
            this.lblAModel.AutoSize = true;
            this.lblAModel.Location = new System.Drawing.Point(14, 327);
            this.lblAModel.Name = "lblAModel";
            this.lblAModel.Size = new System.Drawing.Size(45, 13);
            this.lblAModel.TabIndex = 28;
            this.lblAModel.Text = "MODEL";
            // 
            // lblAMarka
            // 
            this.lblAMarka.AutoSize = true;
            this.lblAMarka.Location = new System.Drawing.Point(14, 287);
            this.lblAMarka.Name = "lblAMarka";
            this.lblAMarka.Size = new System.Drawing.Size(87, 13);
            this.lblAMarka.TabIndex = 27;
            this.lblAMarka.Text = "ARAÇ MARKASI";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnara.Location = new System.Drawing.Point(276, 321);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 26;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.arabtn_Click);
            // 
            // btngncl
            // 
            this.btngncl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btngncl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngncl.Location = new System.Drawing.Point(276, 403);
            this.btngncl.Name = "btngncl";
            this.btngncl.Size = new System.Drawing.Size(75, 23);
            this.btngncl.TabIndex = 25;
            this.btngncl.Text = "GÜNCELLE";
            this.btngncl.UseVisualStyleBackColor = false;
            this.btngncl.Click += new System.EventHandler(this.gncbtn_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsil.Location = new System.Drawing.Point(276, 444);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 24;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnekle.Location = new System.Drawing.Point(276, 362);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 23;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlist.Location = new System.Drawing.Point(276, 280);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(75, 23);
            this.btnlist.TabIndex = 22;
            this.btnlist.Text = "LİSTELE";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.listbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 268);
            this.dataGridView1.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtprsnltp);
            this.tabPage2.Controls.Add(this.txtsbid);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txttel);
            this.tabPage2.Controls.Add(this.txtid);
            this.tabPage2.Controls.Add(this.txtad);
            this.tabPage2.Controls.Add(this.txtsyad);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(837, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 54;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(360, 309);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 53;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(96, 387);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 52;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(96, 305);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 50;
            // 
            // txtsyad
            // 
            this.txtsyad.Location = new System.Drawing.Point(96, 346);
            this.txtsyad.Name = "txtsyad";
            this.txtsyad.Size = new System.Drawing.Size(100, 20);
            this.txtsyad.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "TEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "KİŞİ İD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "SOYADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "ADI";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(498, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(498, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(498, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "SİL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(498, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "EKLE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(498, 301);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 39;
            this.button6.Text = "LİSTELE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(887, 266);
            this.dataGridView2.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "PERSONEL TİPİ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "SUBE İD";
            // 
            // txtsbid
            // 
            this.txtsbid.Location = new System.Drawing.Point(360, 387);
            this.txtsbid.Name = "txtsbid";
            this.txtsbid.Size = new System.Drawing.Size(100, 20);
            this.txtsbid.TabIndex = 58;
            // 
            // txtprsnltp
            // 
            this.txtprsnltp.Location = new System.Drawing.Point(360, 348);
            this.txtprsnltp.Name = "txtprsnltp";
            this.txtprsnltp.Size = new System.Drawing.Size(100, 20);
            this.txtprsnltp.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cksbtn;
        private System.Windows.Forms.TextBox txtAid;
        private System.Windows.Forms.TextBox txtAsfr;
        private System.Windows.Forms.TextBox txtAshbid;
        private System.Windows.Forms.TextBox txtAmrk;
        private System.Windows.Forms.TextBox txtAmdl;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.Label lblAS;
        private System.Windows.Forms.Label lblAModel;
        private System.Windows.Forms.Label lblAMarka;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btngncl;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtprsnltp;
        private System.Windows.Forms.TextBox txtsbid;
    }
}

