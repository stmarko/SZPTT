﻿namespace ServerApp
{
    partial class ServerForma
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
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnPokreni.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnPokreni.FlatAppearance.BorderSize = 4;
            this.btnPokreni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokreni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPokreni.Location = new System.Drawing.Point(12, 31);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(195, 42);
            this.btnPokreni.TabIndex = 0;
            this.btnPokreni.Text = "Pokreni server";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Enabled = false;
            this.btnZaustavi.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnZaustavi.FlatAppearance.BorderSize = 4;
            this.btnZaustavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaustavi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustavi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZaustavi.Location = new System.Drawing.Point(358, 31);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(195, 42);
            this.btnZaustavi.TabIndex = 1;
            this.btnZaustavi.Text = "Zaustavi server";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // ServerForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(565, 109);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Name = "ServerForma";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServerForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnZaustavi;
    }
}

