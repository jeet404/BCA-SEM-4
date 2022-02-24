namespace FileDialogBoxDemo
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
            this.btn_file = new System.Windows.Forms.Button();
            this.lst_filenm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_file
            // 
            this.btn_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.Location = new System.Drawing.Point(88, 12);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(187, 42);
            this.btn_file.TabIndex = 0;
            this.btn_file.Text = "Open File Dialog";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // lst_filenm
            // 
            this.lst_filenm.FormattingEnabled = true;
            this.lst_filenm.Location = new System.Drawing.Point(12, 60);
            this.lst_filenm.Name = "lst_filenm";
            this.lst_filenm.Size = new System.Drawing.Size(331, 160);
            this.lst_filenm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 229);
            this.Controls.Add(this.lst_filenm);
            this.Controls.Add(this.btn_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.ListBox lst_filenm;
    }
}

