namespace StringOperationsWinApp
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
            this.txt_one = new System.Windows.Forms.TextBox();
            this.txt_two = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_append = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_one
            // 
            this.txt_one.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_one.Location = new System.Drawing.Point(12, 62);
            this.txt_one.Multiline = true;
            this.txt_one.Name = "txt_one";
            this.txt_one.Size = new System.Drawing.Size(383, 381);
            this.txt_one.TabIndex = 0;
            // 
            // txt_two
            // 
            this.txt_two.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_two.Location = new System.Drawing.Point(401, 62);
            this.txt_two.Multiline = true;
            this.txt_two.Name = "txt_two";
            this.txt_two.ReadOnly = true;
            this.txt_two.Size = new System.Drawing.Size(387, 381);
            this.txt_two.TabIndex = 1;
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(14, 12);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(81, 30);
            this.btn_copy.TabIndex = 2;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cut.Location = new System.Drawing.Point(101, 12);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(81, 30);
            this.btn_cut.TabIndex = 3;
            this.btn_cut.Text = "Cut";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paste.Location = new System.Drawing.Point(188, 12);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(81, 30);
            this.btn_paste.TabIndex = 4;
            this.btn_paste.Text = "Paste";
            this.btn_paste.UseVisualStyleBackColor = true;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_append
            // 
            this.btn_append.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_append.Location = new System.Drawing.Point(275, 12);
            this.btn_append.Name = "btn_append";
            this.btn_append.Size = new System.Drawing.Size(81, 30);
            this.btn_append.TabIndex = 5;
            this.btn_append.Text = "Append";
            this.btn_append.UseVisualStyleBackColor = true;
            this.btn_append.Click += new System.EventHandler(this.btn_append_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(362, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 30);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_append);
            this.Controls.Add(this.btn_paste);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.txt_two);
            this.Controls.Add(this.txt_one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_one;
        private System.Windows.Forms.TextBox txt_two;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_append;
        private System.Windows.Forms.Button btn_clear;
    }
}

