namespace MathGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.easybutton = new System.Windows.Forms.Button();
            this.hardbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newtasklabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbutton
            // 
            this.checkbutton.BackColor = System.Drawing.Color.Wheat;
            this.checkbutton.Location = new System.Drawing.Point(306, 271);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(148, 51);
            this.checkbutton.TabIndex = 0;
            this.checkbutton.Text = "Check!";
            this.checkbutton.UseVisualStyleBackColor = false;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // easybutton
            // 
            this.easybutton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.easybutton.Location = new System.Drawing.Point(154, 76);
            this.easybutton.Name = "easybutton";
            this.easybutton.Size = new System.Drawing.Size(173, 79);
            this.easybutton.TabIndex = 3;
            this.easybutton.Text = "Start with easy mode";
            this.easybutton.UseVisualStyleBackColor = false;
            this.easybutton.Click += new System.EventHandler(this.easybutton_Click);
            // 
            // hardbutton
            // 
            this.hardbutton.BackColor = System.Drawing.Color.Salmon;
            this.hardbutton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.hardbutton.Location = new System.Drawing.Point(436, 76);
            this.hardbutton.Name = "hardbutton";
            this.hardbutton.Size = new System.Drawing.Size(178, 79);
            this.hardbutton.TabIndex = 4;
            this.hardbutton.Text = "Start with hard mode";
            this.hardbutton.UseVisualStyleBackColor = false;
            this.hardbutton.Click += new System.EventHandler(this.hardbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHOOSE MODE!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time left: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Highest\r\nscore: ";
            // 
            // newtasklabel
            // 
            this.newtasklabel.AutoSize = true;
            this.newtasklabel.Location = new System.Drawing.Point(320, 206);
            this.newtasklabel.Name = "newtasklabel";
            this.newtasklabel.Size = new System.Drawing.Size(51, 20);
            this.newtasklabel.TabIndex = 9;
            this.newtasklabel.Text = "Task: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Correct answer: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(722, 482);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newtasklabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardbutton);
            this.Controls.Add(this.easybutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkbutton);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button easybutton;
        private System.Windows.Forms.Button hardbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label newtasklabel;
        private System.Windows.Forms.Label label5;
    }
}

