namespace FontDialogBoxDemo
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
            this.btn_font = new System.Windows.Forms.Button();
            this.lbl_line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_font
            // 
            this.btn_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_font.Location = new System.Drawing.Point(94, 197);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(83, 40);
            this.btn_font.TabIndex = 0;
            this.btn_font.Text = "Font";
            this.btn_font.UseVisualStyleBackColor = true;
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // lbl_line
            // 
            this.lbl_line.AutoSize = true;
            this.lbl_line.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.Location = new System.Drawing.Point(89, 90);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(88, 27);
            this.lbl_line.TabIndex = 1;
            this.lbl_line.Text = "India";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 249);
            this.Controls.Add(this.lbl_line);
            this.Controls.Add(this.btn_font);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_font;
        private System.Windows.Forms.Label lbl_line;
    }
}

