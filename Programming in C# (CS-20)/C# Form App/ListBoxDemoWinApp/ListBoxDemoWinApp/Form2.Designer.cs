namespace ListBoxDemoWinApp
{
    partial class Form2
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
            this.txt_add = new System.Windows.Forms.TextBox();
            this.lst_left = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_all_right = new System.Windows.Forms.Button();
            this.btn_sel_right = new System.Windows.Forms.Button();
            this.btn_all_left = new System.Windows.Forms.Button();
            this.btn_sel_left = new System.Windows.Forms.Button();
            this.lst_right = new System.Windows.Forms.ListBox();
            this.btn_all_copy_right = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_add
            // 
            this.txt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add.Location = new System.Drawing.Point(12, 12);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(171, 26);
            this.txt_add.TabIndex = 0;
            // 
            // lst_left
            // 
            this.lst_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_left.FormattingEnabled = true;
            this.lst_left.ItemHeight = 20;
            this.lst_left.Location = new System.Drawing.Point(12, 75);
            this.lst_left.Name = "lst_left";
            this.lst_left.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_left.Size = new System.Drawing.Size(171, 264);
            this.lst_left.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_all_right
            // 
            this.btn_all_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all_right.Location = new System.Drawing.Point(189, 130);
            this.btn_all_right.Name = "btn_all_right";
            this.btn_all_right.Size = new System.Drawing.Size(116, 29);
            this.btn_all_right.TabIndex = 4;
            this.btn_all_right.Text = "All >>";
            this.btn_all_right.UseVisualStyleBackColor = true;
            this.btn_all_right.Click += new System.EventHandler(this.btn_all_right_Click);
            // 
            // btn_sel_right
            // 
            this.btn_sel_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sel_right.Location = new System.Drawing.Point(189, 165);
            this.btn_sel_right.Name = "btn_sel_right";
            this.btn_sel_right.Size = new System.Drawing.Size(116, 29);
            this.btn_sel_right.TabIndex = 5;
            this.btn_sel_right.Text = "Selected >>";
            this.btn_sel_right.UseVisualStyleBackColor = true;
            this.btn_sel_right.Click += new System.EventHandler(this.btn_sel_right_Click);
            // 
            // btn_all_left
            // 
            this.btn_all_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all_left.Location = new System.Drawing.Point(189, 200);
            this.btn_all_left.Name = "btn_all_left";
            this.btn_all_left.Size = new System.Drawing.Size(116, 29);
            this.btn_all_left.TabIndex = 6;
            this.btn_all_left.Text = "<< All";
            this.btn_all_left.UseVisualStyleBackColor = true;
            this.btn_all_left.Click += new System.EventHandler(this.btn_all_left_Click);
            // 
            // btn_sel_left
            // 
            this.btn_sel_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sel_left.Location = new System.Drawing.Point(189, 235);
            this.btn_sel_left.Name = "btn_sel_left";
            this.btn_sel_left.Size = new System.Drawing.Size(116, 29);
            this.btn_sel_left.TabIndex = 7;
            this.btn_sel_left.Text = "<< Selected";
            this.btn_sel_left.UseVisualStyleBackColor = true;
            this.btn_sel_left.Click += new System.EventHandler(this.btn_sel_left_Click);
            // 
            // lst_right
            // 
            this.lst_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_right.FormattingEnabled = true;
            this.lst_right.ItemHeight = 20;
            this.lst_right.Location = new System.Drawing.Point(311, 75);
            this.lst_right.Name = "lst_right";
            this.lst_right.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_right.Size = new System.Drawing.Size(171, 264);
            this.lst_right.TabIndex = 8;
            // 
            // btn_all_copy_right
            // 
            this.btn_all_copy_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all_copy_right.Location = new System.Drawing.Point(189, 95);
            this.btn_all_copy_right.Name = "btn_all_copy_right";
            this.btn_all_copy_right.Size = new System.Drawing.Size(116, 29);
            this.btn_all_copy_right.TabIndex = 9;
            this.btn_all_copy_right.Text = "All Copy >>";
            this.btn_all_copy_right.UseVisualStyleBackColor = true;
            this.btn_all_copy_right.Click += new System.EventHandler(this.btn_all_copy_right_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(189, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 356);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_all_copy_right);
            this.Controls.Add(this.lst_right);
            this.Controls.Add(this.btn_sel_left);
            this.Controls.Add(this.btn_all_left);
            this.Controls.Add(this.btn_sel_right);
            this.Controls.Add(this.btn_all_right);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_left);
            this.Controls.Add(this.txt_add);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.ListBox lst_left;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_all_right;
        private System.Windows.Forms.Button btn_sel_right;
        private System.Windows.Forms.Button btn_all_left;
        private System.Windows.Forms.Button btn_sel_left;
        private System.Windows.Forms.ListBox lst_right;
        private System.Windows.Forms.Button btn_all_copy_right;
        private System.Windows.Forms.Button button2;
    }
}

