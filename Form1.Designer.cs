namespace GeheugenSpel
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
            this.btnKaart1 = new System.Windows.Forms.Button();
            this.btnKaart2 = new System.Windows.Forms.Button();
            this.btnKaart3 = new System.Windows.Forms.Button();
            this.btnKaart4 = new System.Windows.Forms.Button();
            this.btnOpnieuw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaart1
            // 
            this.btnKaart1.Location = new System.Drawing.Point(24, 24);
            this.btnKaart1.Name = "btnKaart1";
            this.btnKaart1.Size = new System.Drawing.Size(115, 145);
            this.btnKaart1.TabIndex = 0;
            this.btnKaart1.Text = "kaart1";
            this.btnKaart1.UseVisualStyleBackColor = true;
            this.btnKaart1.Click += new System.EventHandler(this.flipCard);
            // 
            // btnKaart2
            // 
            this.btnKaart2.Location = new System.Drawing.Point(145, 24);
            this.btnKaart2.Name = "btnKaart2";
            this.btnKaart2.Size = new System.Drawing.Size(115, 145);
            this.btnKaart2.TabIndex = 1;
            this.btnKaart2.Text = "kaart2";
            this.btnKaart2.UseVisualStyleBackColor = true;
            this.btnKaart2.Click += new System.EventHandler(this.flipCard);
            // 
            // btnKaart3
            // 
            this.btnKaart3.Location = new System.Drawing.Point(24, 175);
            this.btnKaart3.Name = "btnKaart3";
            this.btnKaart3.Size = new System.Drawing.Size(115, 145);
            this.btnKaart3.TabIndex = 2;
            this.btnKaart3.Text = "kaart3";
            this.btnKaart3.UseVisualStyleBackColor = true;
            this.btnKaart3.Click += new System.EventHandler(this.flipCard);
            // 
            // btnKaart4
            // 
            this.btnKaart4.Location = new System.Drawing.Point(145, 175);
            this.btnKaart4.Name = "btnKaart4";
            this.btnKaart4.Size = new System.Drawing.Size(115, 145);
            this.btnKaart4.TabIndex = 3;
            this.btnKaart4.Text = "kaart4";
            this.btnKaart4.UseVisualStyleBackColor = true;
            this.btnKaart4.Click += new System.EventHandler(this.flipCard);
            // 
            // btnOpnieuw
            // 
            this.btnOpnieuw.Location = new System.Drawing.Point(24, 327);
            this.btnOpnieuw.Name = "btnOpnieuw";
            this.btnOpnieuw.Size = new System.Drawing.Size(236, 42);
            this.btnOpnieuw.TabIndex = 4;
            this.btnOpnieuw.Text = "Opnieuw Spelen";
            this.btnOpnieuw.UseVisualStyleBackColor = true;
            this.btnOpnieuw.Click += new System.EventHandler(this.btnOpnieuw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpnieuw);
            this.Controls.Add(this.btnKaart4);
            this.Controls.Add(this.btnKaart3);
            this.Controls.Add(this.btnKaart2);
            this.Controls.Add(this.btnKaart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaart1;
        private System.Windows.Forms.Button btnKaart2;
        private System.Windows.Forms.Button btnKaart3;
        private System.Windows.Forms.Button btnKaart4;
        private System.Windows.Forms.Button btnOpnieuw;
    }
}

