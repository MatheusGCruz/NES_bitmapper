namespace NES_bitmapper
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
            this.palette_btn0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.palette1_dialog = new System.Windows.Forms.ColorDialog();
            this.bit00 = new System.Windows.Forms.Button();
            this.palette2_dialog = new System.Windows.Forms.ColorDialog();
            this.palette3_dialog = new System.Windows.Forms.ColorDialog();
            this.palette0_dialog = new System.Windows.Forms.ColorDialog();
            this.palette_btn1 = new System.Windows.Forms.Button();
            this.palette_btn2 = new System.Windows.Forms.Button();
            this.palette_btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // palette_btn0
            // 
            this.palette_btn0.Location = new System.Drawing.Point(590, 147);
            this.palette_btn0.Name = "palette_btn0";
            this.palette_btn0.Size = new System.Drawing.Size(75, 23);
            this.palette_btn0.TabIndex = 0;
            this.palette_btn0.Text = "Palette0";
            this.palette_btn0.UseVisualStyleBackColor = true;
            this.palette_btn0.Click += new System.EventHandler(this.palette_btn0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Char Palettes";
            // 
            // bit00
            // 
            this.bit00.Location = new System.Drawing.Point(54, 69);
            this.bit00.Name = "bit00";
            this.bit00.Size = new System.Drawing.Size(22, 23);
            this.bit00.TabIndex = 2;
            this.bit00.UseVisualStyleBackColor = true;
            this.bit00.Click += new System.EventHandler(this.bit00_Click);
            // 
            // palette_btn1
            // 
            this.palette_btn1.Location = new System.Drawing.Point(590, 176);
            this.palette_btn1.Name = "palette_btn1";
            this.palette_btn1.Size = new System.Drawing.Size(75, 23);
            this.palette_btn1.TabIndex = 3;
            this.palette_btn1.Text = "Palette1";
            this.palette_btn1.UseVisualStyleBackColor = true;
            this.palette_btn1.Click += new System.EventHandler(this.palette_btn1_Click);
            // 
            // palette_btn2
            // 
            this.palette_btn2.Location = new System.Drawing.Point(590, 205);
            this.palette_btn2.Name = "palette_btn2";
            this.palette_btn2.Size = new System.Drawing.Size(75, 23);
            this.palette_btn2.TabIndex = 4;
            this.palette_btn2.Text = "Palette2";
            this.palette_btn2.UseVisualStyleBackColor = true;
            this.palette_btn2.Click += new System.EventHandler(this.palette_btn2_Click);
            // 
            // palette_btn3
            // 
            this.palette_btn3.Location = new System.Drawing.Point(590, 234);
            this.palette_btn3.Name = "palette_btn3";
            this.palette_btn3.Size = new System.Drawing.Size(75, 23);
            this.palette_btn3.TabIndex = 5;
            this.palette_btn3.Text = "Palette3";
            this.palette_btn3.UseVisualStyleBackColor = true;
            this.palette_btn3.Click += new System.EventHandler(this.palette_btn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.palette_btn3);
            this.Controls.Add(this.palette_btn2);
            this.Controls.Add(this.palette_btn1);
            this.Controls.Add(this.bit00);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.palette_btn0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button palette_btn0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog palette1_dialog;
        private System.Windows.Forms.Button bit00;
        private System.Windows.Forms.ColorDialog palette2_dialog;
        private System.Windows.Forms.ColorDialog palette3_dialog;
        private System.Windows.Forms.ColorDialog palette0_dialog;
        private System.Windows.Forms.Button palette_btn1;
        private System.Windows.Forms.Button palette_btn2;
        private System.Windows.Forms.Button palette_btn3;
    }
}

