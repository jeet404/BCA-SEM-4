namespace RadioBtnDemo
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
            this.lbl_selected = new System.Windows.Forms.Button();
            this.rbtn_red = new System.Windows.Forms.RadioButton();
            this.rbtn_yellow = new System.Windows.Forms.RadioButton();
            this.rbtn_blue = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_selected
            // 
            this.lbl_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selected.Location = new System.Drawing.Point(12, 231);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(252, 34);
            this.lbl_selected.TabIndex = 0;
            this.lbl_selected.Text = "U have select";
            this.lbl_selected.UseVisualStyleBackColor = true;
            // 
            // rbtn_red
            // 
            this.rbtn_red.AutoSize = true;
            this.rbtn_red.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_red.Location = new System.Drawing.Point(12, 53);
            this.rbtn_red.Name = "rbtn_red";
            this.rbtn_red.Size = new System.Drawing.Size(61, 24);
            this.rbtn_red.TabIndex = 1;
            this.rbtn_red.TabStop = true;
            this.rbtn_red.Text = "RED";
            this.rbtn_red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_red.UseVisualStyleBackColor = true;
            this.rbtn_red.CheckedChanged += new System.EventHandler(this.rbtn_red_CheckedChanged);
            // 
            // rbtn_yellow
            // 
            this.rbtn_yellow.AutoSize = true;
            this.rbtn_yellow.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_yellow.Location = new System.Drawing.Point(12, 83);
            this.rbtn_yellow.Name = "rbtn_yellow";
            this.rbtn_yellow.Size = new System.Drawing.Size(96, 24);
            this.rbtn_yellow.TabIndex = 2;
            this.rbtn_yellow.TabStop = true;
            this.rbtn_yellow.Text = "YELLOW";
            this.rbtn_yellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_yellow.UseVisualStyleBackColor = true;
            this.rbtn_yellow.CheckedChanged += new System.EventHandler(this.rbtn_yellow_CheckedChanged);
            // 
            // rbtn_blue
            // 
            this.rbtn_blue.AutoSize = true;
            this.rbtn_blue.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_blue.Location = new System.Drawing.Point(12, 113);
            this.rbtn_blue.Name = "rbtn_blue";
            this.rbtn_blue.Size = new System.Drawing.Size(69, 24);
            this.rbtn_blue.TabIndex = 3;
            this.rbtn_blue.TabStop = true;
            this.rbtn_blue.Text = "BLUE";
            this.rbtn_blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_blue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 277);
            this.Controls.Add(this.rbtn_blue);
            this.Controls.Add(this.rbtn_yellow);
            this.Controls.Add(this.rbtn_red);
            this.Controls.Add(this.lbl_selected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbl_selected;
        private System.Windows.Forms.RadioButton rbtn_red;
        private System.Windows.Forms.RadioButton rbtn_yellow;
        private System.Windows.Forms.RadioButton rbtn_blue;
    }
}

