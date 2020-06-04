namespace KlijentApp
{
    partial class KreirajTurnir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KreirajTurnir));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUcesnici = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnZapamtiSportistu = new System.Windows.Forms.Button();
            this.txtDatumDO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKlub = new System.Windows.Forms.ComboBox();
            this.txtDatumOd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMesto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKreirajSportistu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDTurnir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKonkurencija = new System.Windows.Forms.TextBox();
            this.txtNazivTurnira = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPobednik = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btnObrisi);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.btnDodaj);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbUcesnici);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.txtDatumDO);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbKlub);
            this.panel2.Controls.Add(this.txtDatumOd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbMesto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtKonkurencija);
            this.panel2.Controls.Add(this.txtNazivTurnira);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 552);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnObrisi
            // 
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnObrisi.FlatAppearance.BorderSize = 3;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Location = new System.Drawing.Point(344, 362);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(172, 41);
            this.btnObrisi.TabIndex = 31;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(451, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(339, 328);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(293, 20);
            this.txtStatus.TabIndex = 29;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Enabled = false;
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnDodaj.FlatAppearance.BorderSize = 3;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(123, 362);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(172, 41);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(616, 140);
            this.dataGridView1.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Location = new System.Drawing.Point(20, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 10);
            this.panel3.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(76, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Dodaj učesnika";
            // 
            // cmbUcesnici
            // 
            this.cmbUcesnici.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUcesnici.FormattingEnabled = true;
            this.cmbUcesnici.Location = new System.Drawing.Point(20, 324);
            this.cmbUcesnici.Name = "cmbUcesnici";
            this.cmbUcesnici.Size = new System.Drawing.Size(291, 24);
            this.cmbUcesnici.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnZapamtiSportistu);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(343, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 124);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zapamti podatke o turniru";
            // 
            // btnZapamtiSportistu
            // 
            this.btnZapamtiSportistu.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnZapamtiSportistu.FlatAppearance.BorderSize = 3;
            this.btnZapamtiSportistu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapamtiSportistu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZapamtiSportistu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZapamtiSportistu.Image = ((System.Drawing.Image)(resources.GetObject("btnZapamtiSportistu.Image")));
            this.btnZapamtiSportistu.Location = new System.Drawing.Point(64, 20);
            this.btnZapamtiSportistu.Name = "btnZapamtiSportistu";
            this.btnZapamtiSportistu.Size = new System.Drawing.Size(172, 71);
            this.btnZapamtiSportistu.TabIndex = 13;
            this.btnZapamtiSportistu.Text = "Zapamti turnir";
            this.btnZapamtiSportistu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnZapamtiSportistu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZapamtiSportistu.UseVisualStyleBackColor = true;
            this.btnZapamtiSportistu.Click += new System.EventHandler(this.btnZapamtiSportistu_Click);
            // 
            // txtDatumDO
            // 
            this.txtDatumDO.Location = new System.Drawing.Point(202, 236);
            this.txtDatumDO.Name = "txtDatumDO";
            this.txtDatumDO.Size = new System.Drawing.Size(111, 20);
            this.txtDatumDO.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(205, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Datum do:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(431, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Konkurencija";
            // 
            // cmbKlub
            // 
            this.cmbKlub.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKlub.FormattingEnabled = true;
            this.cmbKlub.Location = new System.Drawing.Point(339, 256);
            this.cmbKlub.Name = "cmbKlub";
            this.cmbKlub.Size = new System.Drawing.Size(297, 24);
            this.cmbKlub.TabIndex = 19;
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Location = new System.Drawing.Point(20, 236);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.Size = new System.Drawing.Size(111, 20);
            this.txtDatumOd.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Datum od:";
            // 
            // cmbMesto
            // 
            this.cmbMesto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesto.FormattingEnabled = true;
            this.cmbMesto.Location = new System.Drawing.Point(339, 209);
            this.cmbMesto.Name = "cmbMesto";
            this.cmbMesto.Size = new System.Drawing.Size(297, 24);
            this.cmbMesto.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(458, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mesto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnKreirajSportistu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIDTurnir);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 124);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kreiranje novog turnira";
            // 
            // btnKreirajSportistu
            // 
            this.btnKreirajSportistu.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnKreirajSportistu.FlatAppearance.BorderSize = 2;
            this.btnKreirajSportistu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajSportistu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajSportistu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreirajSportistu.Image = ((System.Drawing.Image)(resources.GetObject("btnKreirajSportistu.Image")));
            this.btnKreirajSportistu.Location = new System.Drawing.Point(57, 18);
            this.btnKreirajSportistu.Name = "btnKreirajSportistu";
            this.btnKreirajSportistu.Size = new System.Drawing.Size(172, 71);
            this.btnKreirajSportistu.TabIndex = 12;
            this.btnKreirajSportistu.Text = "Kreiraj ID";
            this.btnKreirajSportistu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKreirajSportistu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKreirajSportistu.UseVisualStyleBackColor = true;
            this.btnKreirajSportistu.Click += new System.EventHandler(this.btnKreirajSportistu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(53, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIDTurnir
            // 
            this.txtIDTurnir.Location = new System.Drawing.Point(86, 97);
            this.txtIDTurnir.Name = "txtIDTurnir";
            this.txtIDTurnir.ReadOnly = true;
            this.txtIDTurnir.Size = new System.Drawing.Size(115, 21);
            this.txtIDTurnir.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(465, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Klub";
            // 
            // txtKonkurencija
            // 
            this.txtKonkurencija.Location = new System.Drawing.Point(341, 163);
            this.txtKonkurencija.Name = "txtKonkurencija";
            this.txtKonkurencija.Size = new System.Drawing.Size(293, 20);
            this.txtKonkurencija.TabIndex = 5;
            // 
            // txtNazivTurnira
            // 
            this.txtNazivTurnira.Location = new System.Drawing.Point(20, 188);
            this.txtNazivTurnira.Name = "txtNazivTurnira";
            this.txtNazivTurnira.Size = new System.Drawing.Size(293, 20);
            this.txtNazivTurnira.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(102, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naziv turnira";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbPobednik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 552);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon: +381 (11) 7121898\r\nwww.teniskisavez.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 62);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(55, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kreiraj turnir";
            // 
            // cmbPobednik
            // 
            this.cmbPobednik.FormattingEnabled = true;
            this.cmbPobednik.Location = new System.Drawing.Point(56, 283);
            this.cmbPobednik.Name = "cmbPobednik";
            this.cmbPobednik.Size = new System.Drawing.Size(121, 21);
            this.cmbPobednik.TabIndex = 32;
            this.cmbPobednik.Visible = false;
            // 
            // KreirajTurnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "KreirajTurnir";
            this.Text = "KreirajTurnir";
            this.Load += new System.EventHandler(this.KreirajTurnir_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUcesnici;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnZapamtiSportistu;
        private System.Windows.Forms.TextBox txtDatumDO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKlub;
        private System.Windows.Forms.TextBox txtDatumOd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKreirajSportistu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDTurnir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKonkurencija;
        private System.Windows.Forms.TextBox txtNazivTurnira;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox cmbPobednik;
    }
}