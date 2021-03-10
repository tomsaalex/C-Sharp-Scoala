
namespace DB_Test_4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idBox = new System.Windows.Forms.TextBox();
            this.destinatieBox = new System.Windows.Forms.TextBox();
            this.durataBox = new System.Windows.Forms.TextBox();
            this.locuriBox = new System.Windows.Forms.TextBox();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(497, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(92, 49);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(193, 23);
            this.idBox.TabIndex = 1;
            // 
            // destinatieBox
            // 
            this.destinatieBox.Location = new System.Drawing.Point(92, 78);
            this.destinatieBox.Name = "destinatieBox";
            this.destinatieBox.Size = new System.Drawing.Size(193, 23);
            this.destinatieBox.TabIndex = 1;
            // 
            // durataBox
            // 
            this.durataBox.Location = new System.Drawing.Point(92, 107);
            this.durataBox.Name = "durataBox";
            this.durataBox.Size = new System.Drawing.Size(193, 23);
            this.durataBox.TabIndex = 1;
            // 
            // locuriBox
            // 
            this.locuriBox.Location = new System.Drawing.Point(92, 136);
            this.locuriBox.Name = "locuriBox";
            this.locuriBox.Size = new System.Drawing.Size(193, 23);
            this.locuriBox.TabIndex = 1;
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(92, 165);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(193, 23);
            this.dataBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destinatia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Locuri libere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data plecarii";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(12, 205);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(273, 23);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "Insereaza";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 258);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(273, 23);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Afiseaza";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.locuriBox);
            this.Controls.Add(this.durataBox);
            this.Controls.Add(this.destinatieBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox destinatieBox;
        private System.Windows.Forms.TextBox durataBox;
        private System.Windows.Forms.TextBox locuriBox;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button displayButton;
    }
}

