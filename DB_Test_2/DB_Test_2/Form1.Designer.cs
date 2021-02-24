namespace DB_Test_2
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
            this.butonAfisareTot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butonAfisareNVolume = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.textBoxAnAp = new System.Windows.Forms.TextBox();
            this.textBoxNrVol = new System.Windows.Forms.TextBox();
            this.butonInserare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butonAfisareTot
            // 
            this.butonAfisareTot.Location = new System.Drawing.Point(13, 13);
            this.butonAfisareTot.Name = "butonAfisareTot";
            this.butonAfisareTot.Size = new System.Drawing.Size(99, 39);
            this.butonAfisareTot.TabIndex = 0;
            this.butonAfisareTot.Text = "Afisare toate cartile";
            this.butonAfisareTot.UseVisualStyleBackColor = true;
            this.butonAfisareTot.Click += new System.EventHandler(this.butonAfisareTot_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // butonAfisareNVolume
            // 
            this.butonAfisareNVolume.Location = new System.Drawing.Point(12, 150);
            this.butonAfisareNVolume.Name = "butonAfisareNVolume";
            this.butonAfisareNVolume.Size = new System.Drawing.Size(75, 34);
            this.butonAfisareNVolume.TabIndex = 2;
            this.butonAfisareNVolume.Text = "Afisare carti cu n volume";
            this.butonAfisareNVolume.UseVisualStyleBackColor = true;
            this.butonAfisareNVolume.Click += new System.EventHandler(this.butonAfisareNVolume_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(12, 281);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.textBoxISBN.TabIndex = 1;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(12, 307);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutor.TabIndex = 1;
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(12, 333);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitlu.TabIndex = 1;
            // 
            // textBoxAnAp
            // 
            this.textBoxAnAp.Location = new System.Drawing.Point(12, 359);
            this.textBoxAnAp.Name = "textBoxAnAp";
            this.textBoxAnAp.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnAp.TabIndex = 1;
            // 
            // textBoxNrVol
            // 
            this.textBoxNrVol.Location = new System.Drawing.Point(12, 385);
            this.textBoxNrVol.Name = "textBoxNrVol";
            this.textBoxNrVol.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrVol.TabIndex = 1;
            // 
            // butonInserare
            // 
            this.butonInserare.Location = new System.Drawing.Point(12, 415);
            this.butonInserare.Name = "butonInserare";
            this.butonInserare.Size = new System.Drawing.Size(75, 23);
            this.butonInserare.TabIndex = 2;
            this.butonInserare.Text = "Inserare carte";
            this.butonInserare.UseVisualStyleBackColor = true;
            this.butonInserare.Click += new System.EventHandler(this.butonInserare_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(201, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(587, 425);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butonInserare);
            this.Controls.Add(this.butonAfisareNVolume);
            this.Controls.Add(this.textBoxNrVol);
            this.Controls.Add(this.textBoxAnAp);
            this.Controls.Add(this.textBoxTitlu);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butonAfisareTot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonAfisareTot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butonAfisareNVolume;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.TextBox textBoxAnAp;
        private System.Windows.Forms.TextBox textBoxNrVol;
        private System.Windows.Forms.Button butonInserare;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

