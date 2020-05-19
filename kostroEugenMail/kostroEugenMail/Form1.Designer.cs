namespace kostroEugenMail
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
            this.textBoxPrima = new System.Windows.Forms.TextBox();
            this.richTextBoxPoruka = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1Posalji = new System.Windows.Forms.Button();
            this.textBoxSubjekt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPrima
            // 
            this.textBoxPrima.Location = new System.Drawing.Point(288, 67);
            this.textBoxPrima.Name = "textBoxPrima";
            this.textBoxPrima.Size = new System.Drawing.Size(349, 22);
            this.textBoxPrima.TabIndex = 0;
            // 
            // richTextBoxPoruka
            // 
            this.richTextBoxPoruka.Location = new System.Drawing.Point(288, 211);
            this.richTextBoxPoruka.Name = "richTextBoxPoruka";
            this.richTextBoxPoruka.Size = new System.Drawing.Size(349, 193);
            this.richTextBoxPoruka.TabIndex = 2;
            this.richTextBoxPoruka.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prima";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subjekt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poruka";
            // 
            // button1Posalji
            // 
            this.button1Posalji.Location = new System.Drawing.Point(671, 372);
            this.button1Posalji.Name = "button1Posalji";
            this.button1Posalji.Size = new System.Drawing.Size(89, 32);
            this.button1Posalji.TabIndex = 6;
            this.button1Posalji.Text = "Pošalji";
            this.button1Posalji.UseVisualStyleBackColor = true;
            this.button1Posalji.Click += new System.EventHandler(this.button1Posalji_Click);
            // 
            // textBoxSubjekt
            // 
            this.textBoxSubjekt.Location = new System.Drawing.Point(288, 151);
            this.textBoxSubjekt.Name = "textBoxSubjekt";
            this.textBoxSubjekt.Size = new System.Drawing.Size(349, 22);
            this.textBoxSubjekt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSubjekt);
            this.Controls.Add(this.button1Posalji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxPoruka);
            this.Controls.Add(this.textBoxPrima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrima;
        private System.Windows.Forms.RichTextBox richTextBoxPoruka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1Posalji;
        private System.Windows.Forms.TextBox textBoxSubjekt;
    }
}

