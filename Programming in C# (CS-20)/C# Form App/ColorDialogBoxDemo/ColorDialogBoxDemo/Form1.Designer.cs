namespace ColorDialogBoxDemo
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
            this.btn_bcolor = new System.Windows.Forms.Button();
            this.lbl_line = new System.Windows.Forms.Label();
            this.btn_fcolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_bcolor
            // 
            this.btn_bcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bcolor.Location = new System.Drawing.Point(82, 181);
            this.btn_bcolor.Name = "btn_bcolor";
            this.btn_bcolor.Size = new System.Drawing.Size(111, 35);
            this.btn_bcolor.TabIndex = 1;
            this.btn_bcolor.Text = "BackColor";
            this.btn_bcolor.UseVisualStyleBackColor = true;
            this.btn_bcolor.Click += new System.EventHandler(this.btn_bcolor_Click);
            // 
            // lbl_line
            // 
            this.lbl_line.AutoSize = true;
            this.lbl_line.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.Location = new System.Drawing.Point(70, 67);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(139, 28);
            this.lbl_line.TabIndex = 2;
            this.lbl_line.Text = "Hello World";
            this.lbl_line.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_fcolor
            // 
            this.btn_fcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fcolor.Location = new System.Drawing.Point(82, 140);
            this.btn_fcolor.Name = "btn_fcolor";
            this.btn_fcolor.Size = new System.Drawing.Size(111, 35);
            this.btn_fcolor.TabIndex = 0;
            this.btn_fcolor.Text = "ForeColor";
            this.btn_fcolor.UseVisualStyleBackColor = true;
            this.btn_fcolor.Click += new System.EventHandler(this.btn_fcolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 260);
            this.Controls.Add(this.lbl_line);
            this.Controls.Add(this.btn_bcolor);
            this.Controls.Add(this.btn_fcolor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bcolor;
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.Button btn_fcolor;
    }
}

