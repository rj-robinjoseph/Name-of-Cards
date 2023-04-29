namespace Practical_1
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
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            this.SuspendLayout();
            // 
            // card5
            // 
            this.card5.Image = global::Practical_1.Properties.Resources._4_Spades;
            this.card5.Location = new System.Drawing.Point(668, 78);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(160, 213);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card5.TabIndex = 4;
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.card5_Click);
            // 
            // card4
            // 
            this.card4.Image = global::Practical_1.Properties.Resources._7_Hearts;
            this.card4.Location = new System.Drawing.Point(502, 78);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(160, 213);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 3;
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.card4_Click);
            // 
            // card3
            // 
            this.card3.Image = global::Practical_1.Properties.Resources._10_Spades;
            this.card3.Location = new System.Drawing.Point(336, 78);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(160, 213);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card3_Click);
            // 
            // card2
            // 
            this.card2.Image = global::Practical_1.Properties.Resources._2_Clubs;
            this.card2.Location = new System.Drawing.Point(170, 78);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(160, 213);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card2_Click);
            // 
            // card1
            // 
            this.card1.Image = global::Practical_1.Properties.Resources._8_Diamonds;
            this.card1.Location = new System.Drawing.Point(4, 78);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(160, 213);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(350, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(809, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "\r\n";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(362, 401);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 27);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Click a Card to See It\'s Name.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
    }
}

