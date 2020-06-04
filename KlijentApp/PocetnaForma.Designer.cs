namespace KlijentApp
{
    partial class PocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKreirajKlub = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKreirajTurnir = new System.Windows.Forms.Button();
            this.btnPretraziTurnir = new System.Windows.Forms.Button();
            this.btnPretragaSportiste = new System.Windows.Forms.Button();
            this.btnKreirajSportistu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 483);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 425);
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
            this.label1.Location = new System.Drawing.Point(25, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistem za praćenje\r\nteniskih turnira u Srbiji\r\n\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.btnKreirajKlub);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnPretragaSportiste);
            this.panel2.Controls.Add(this.btnKreirajSportistu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 483);
            this.panel2.TabIndex = 1;
            // 
            // btnKreirajKlub
            // 
            this.btnKreirajKlub.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnKreirajKlub.FlatAppearance.BorderSize = 0;
            this.btnKreirajKlub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajKlub.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajKlub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreirajKlub.Image = ((System.Drawing.Image)(resources.GetObject("btnKreirajKlub.Image")));
            this.btnKreirajKlub.Location = new System.Drawing.Point(41, 184);
            this.btnKreirajKlub.Name = "btnKreirajKlub";
            this.btnKreirajKlub.Size = new System.Drawing.Size(172, 71);
            this.btnKreirajKlub.TabIndex = 6;
            this.btnKreirajKlub.Text = "Kreiraj klub";
            this.btnKreirajKlub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKreirajKlub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKreirajKlub.UseVisualStyleBackColor = true;
            this.btnKreirajKlub.Click += new System.EventHandler(this.btnKreirajKlub_Click);
            this.btnKreirajKlub.MouseLeave += new System.EventHandler(this.btnKreirajKlub_MouseLeave);
            this.btnKreirajKlub.MouseHover += new System.EventHandler(this.btnKreirajKlub_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.btnKreirajTurnir);
            this.panel3.Controls.Add(this.btnPretraziTurnir);
            this.panel3.Location = new System.Drawing.Point(12, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 193);
            this.panel3.TabIndex = 6;
            // 
            // btnKreirajTurnir
            // 
            this.btnKreirajTurnir.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnKreirajTurnir.FlatAppearance.BorderSize = 0;
            this.btnKreirajTurnir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajTurnir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajTurnir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreirajTurnir.Image = ((System.Drawing.Image)(resources.GetObject("btnKreirajTurnir.Image")));
            this.btnKreirajTurnir.Location = new System.Drawing.Point(29, 21);
            this.btnKreirajTurnir.Name = "btnKreirajTurnir";
            this.btnKreirajTurnir.Size = new System.Drawing.Size(172, 75);
            this.btnKreirajTurnir.TabIndex = 2;
            this.btnKreirajTurnir.Text = "Kreiraj turnir";
            this.btnKreirajTurnir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKreirajTurnir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKreirajTurnir.UseVisualStyleBackColor = true;
            this.btnKreirajTurnir.Click += new System.EventHandler(this.button3_Click);
            this.btnKreirajTurnir.MouseLeave += new System.EventHandler(this.btnKreirajTurnir_MouseLeave);
            this.btnKreirajTurnir.MouseHover += new System.EventHandler(this.btnKreirajTurnir_MouseHover);
            // 
            // btnPretraziTurnir
            // 
            this.btnPretraziTurnir.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnPretraziTurnir.FlatAppearance.BorderSize = 0;
            this.btnPretraziTurnir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraziTurnir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziTurnir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretraziTurnir.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraziTurnir.Image")));
            this.btnPretraziTurnir.Location = new System.Drawing.Point(29, 102);
            this.btnPretraziTurnir.Name = "btnPretraziTurnir";
            this.btnPretraziTurnir.Size = new System.Drawing.Size(172, 75);
            this.btnPretraziTurnir.TabIndex = 5;
            this.btnPretraziTurnir.Text = "Pretraži turnire";
            this.btnPretraziTurnir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPretraziTurnir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPretraziTurnir.UseVisualStyleBackColor = true;
            this.btnPretraziTurnir.Click += new System.EventHandler(this.btnPretraziTurnir_Click);
            this.btnPretraziTurnir.MouseLeave += new System.EventHandler(this.btnPretraziTurnir_MouseLeave);
            this.btnPretraziTurnir.MouseHover += new System.EventHandler(this.btnPretraziTurnir_MouseHover);
            // 
            // btnPretragaSportiste
            // 
            this.btnPretragaSportiste.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnPretragaSportiste.FlatAppearance.BorderSize = 0;
            this.btnPretragaSportiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretragaSportiste.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretragaSportiste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretragaSportiste.Image = ((System.Drawing.Image)(resources.GetObject("btnPretragaSportiste.Image")));
            this.btnPretragaSportiste.Location = new System.Drawing.Point(41, 98);
            this.btnPretragaSportiste.Name = "btnPretragaSportiste";
            this.btnPretragaSportiste.Size = new System.Drawing.Size(172, 71);
            this.btnPretragaSportiste.TabIndex = 4;
            this.btnPretragaSportiste.Text = "Pretraži sportiste";
            this.btnPretragaSportiste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPretragaSportiste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPretragaSportiste.UseVisualStyleBackColor = true;
            this.btnPretragaSportiste.Click += new System.EventHandler(this.btnPretragaSportiste_Click);
            this.btnPretragaSportiste.MouseLeave += new System.EventHandler(this.btnPretragaSportiste_MouseLeave);
            this.btnPretragaSportiste.MouseHover += new System.EventHandler(this.btnPretragaSportiste_MouseHover);
            // 
            // btnKreirajSportistu
            // 
            this.btnKreirajSportistu.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnKreirajSportistu.FlatAppearance.BorderSize = 0;
            this.btnKreirajSportistu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajSportistu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajSportistu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreirajSportistu.Image = ((System.Drawing.Image)(resources.GetObject("btnKreirajSportistu.Image")));
            this.btnKreirajSportistu.Location = new System.Drawing.Point(41, 12);
            this.btnKreirajSportistu.Name = "btnKreirajSportistu";
            this.btnKreirajSportistu.Size = new System.Drawing.Size(172, 71);
            this.btnKreirajSportistu.TabIndex = 0;
            this.btnKreirajSportistu.Text = "Kreiraj sportistu";
            this.btnKreirajSportistu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKreirajSportistu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKreirajSportistu.UseVisualStyleBackColor = true;
            this.btnKreirajSportistu.Click += new System.EventHandler(this.btnKreirajSportistu_Click);
            this.btnKreirajSportistu.MouseLeave += new System.EventHandler(this.btnKreirajSportistu_MouseLeave);
            this.btnKreirajSportistu.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PocetnaForma";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PocetnaForma_FormClosed);
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKreirajSportistu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKreirajTurnir;
        private System.Windows.Forms.Button btnPretragaSportiste;
        private System.Windows.Forms.Button btnPretraziTurnir;
        private System.Windows.Forms.Button btnKreirajKlub;
        private System.Windows.Forms.Panel panel3;
    }
}

