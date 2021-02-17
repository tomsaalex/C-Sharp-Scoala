namespace DB_Test_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAfisareLocatari = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butonAfisareAngajati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAfisareLocatari
            // 
            this.buttonAfisareLocatari.Location = new System.Drawing.Point(45, 45);
            this.buttonAfisareLocatari.Name = "buttonAfisareLocatari";
            this.buttonAfisareLocatari.Size = new System.Drawing.Size(218, 72);
            this.buttonAfisareLocatari.TabIndex = 0;
            this.buttonAfisareLocatari.Text = "Afisare locatoari";
            this.buttonAfisareLocatari.UseVisualStyleBackColor = true;
            this.buttonAfisareLocatari.Click += new System.EventHandler(this.buttonAfisareLocatari_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(429, 328);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // butonAfisareAngajati
            // 
            this.butonAfisareAngajati.Location = new System.Drawing.Point(45, 143);
            this.butonAfisareAngajati.Name = "butonAfisareAngajati";
            this.butonAfisareAngajati.Size = new System.Drawing.Size(218, 72);
            this.butonAfisareAngajati.TabIndex = 0;
            this.butonAfisareAngajati.Text = "Afisare angajati";
            this.butonAfisareAngajati.UseVisualStyleBackColor = true;
            this.butonAfisareAngajati.Click += new System.EventHandler(this.butonAfisareAngajati_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butonAfisareAngajati);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAfisareLocatari);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAfisareLocatari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butonAfisareAngajati;
    }
}

