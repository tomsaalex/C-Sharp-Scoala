namespace DB_Test_3
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
            this.codBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.denumireBox = new System.Windows.Forms.TextBox();
            this.pretBox = new System.Windows.Forms.TextBox();
            this.pretMicBox = new System.Windows.Forms.TextBox();
            this.pretMareBox = new System.Windows.Forms.TextBox();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // codBox
            // 
            this.codBox.Location = new System.Drawing.Point(106, 69);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(100, 23);
            this.codBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afisare produse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Introducere produs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Afisare produse din interval";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // denumireBox
            // 
            this.denumireBox.Location = new System.Drawing.Point(106, 98);
            this.denumireBox.Name = "denumireBox";
            this.denumireBox.Size = new System.Drawing.Size(100, 23);
            this.denumireBox.TabIndex = 2;
            // 
            // pretBox
            // 
            this.pretBox.Location = new System.Drawing.Point(106, 134);
            this.pretBox.Name = "pretBox";
            this.pretBox.Size = new System.Drawing.Size(100, 23);
            this.pretBox.TabIndex = 2;
            // 
            // pretMicBox
            // 
            this.pretMicBox.Location = new System.Drawing.Point(106, 357);
            this.pretMicBox.Name = "pretMicBox";
            this.pretMicBox.Size = new System.Drawing.Size(100, 23);
            this.pretMicBox.TabIndex = 2;
            // 
            // pretMareBox
            // 
            this.pretMareBox.Location = new System.Drawing.Point(106, 386);
            this.pretMareBox.Name = "pretMareBox";
            this.pretMareBox.Size = new System.Drawing.Size(100, 23);
            this.pretMareBox.TabIndex = 2;
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(106, 163);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(100, 23);
            this.dataBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 426);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.pretBox);
            this.Controls.Add(this.pretMareBox);
            this.Controls.Add(this.pretMicBox);
            this.Controls.Add(this.denumireBox);
            this.Controls.Add(this.codBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox codBox;
        private System.Windows.Forms.TextBox denumireBox;
        private System.Windows.Forms.TextBox pretBox;
        private System.Windows.Forms.TextBox pretMicBox;
        private System.Windows.Forms.TextBox pretMare;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pretMareBox;
    }
}

