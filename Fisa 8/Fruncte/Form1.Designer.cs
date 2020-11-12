namespace Fruncte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.măr = new System.Windows.Forms.CheckBox();
            this.morcov = new System.Windows.Forms.CheckBox();
            this.pară = new System.Windows.Forms.CheckBox();
            this.strugure = new System.Windows.Forms.CheckBox();
            this.varză = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alegeți fructele din următoarea listă:";
            // 
            // măr
            // 
            this.măr.AutoSize = true;
            this.măr.Location = new System.Drawing.Point(46, 73);
            this.măr.Name = "măr";
            this.măr.Size = new System.Drawing.Size(47, 19);
            this.măr.TabIndex = 1;
            this.măr.Text = "măr";
            this.măr.UseVisualStyleBackColor = true;
            // 
            // morcov
            // 
            this.morcov.AutoSize = true;
            this.morcov.Location = new System.Drawing.Point(46, 98);
            this.morcov.Name = "morcov";
            this.morcov.Size = new System.Drawing.Size(67, 19);
            this.morcov.TabIndex = 2;
            this.morcov.Text = "morcov";
            this.morcov.UseVisualStyleBackColor = true;
            // 
            // pară
            // 
            this.pară.AutoSize = true;
            this.pară.Location = new System.Drawing.Point(46, 123);
            this.pară.Name = "pară";
            this.pară.Size = new System.Drawing.Size(49, 19);
            this.pară.TabIndex = 3;
            this.pară.Text = "pară";
            this.pară.UseVisualStyleBackColor = true;
            // 
            // strugure
            // 
            this.strugure.AutoSize = true;
            this.strugure.Location = new System.Drawing.Point(46, 148);
            this.strugure.Name = "strugure";
            this.strugure.Size = new System.Drawing.Size(70, 19);
            this.strugure.TabIndex = 4;
            this.strugure.Text = "strugure";
            this.strugure.UseVisualStyleBackColor = true;
            // 
            // varză
            // 
            this.varză.AutoSize = true;
            this.varză.Location = new System.Drawing.Point(46, 173);
            this.varză.Name = "varză";
            this.varză.Size = new System.Drawing.Size(53, 19);
            this.varză.TabIndex = 5;
            this.varză.Text = "varză";
            this.varză.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verifică";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(292, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificare!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sunteți sigur?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DA";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(130, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NU";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.varză);
            this.Controls.Add(this.strugure);
            this.Controls.Add(this.pară);
            this.Controls.Add(this.morcov);
            this.Controls.Add(this.măr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Întrebare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox măr;
        private System.Windows.Forms.CheckBox morcov;
        private System.Windows.Forms.CheckBox pară;
        private System.Windows.Forms.CheckBox strugure;
        private System.Windows.Forms.CheckBox varză;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
    }
}

