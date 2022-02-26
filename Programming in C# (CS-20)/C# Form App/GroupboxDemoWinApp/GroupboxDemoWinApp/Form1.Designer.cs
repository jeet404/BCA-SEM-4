namespace GroupboxDemoWinApp
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
            this.gb_one = new System.Windows.Forms.GroupBox();
            this.gb_two = new System.Windows.Forms.GroupBox();
            this.rdo_Male = new System.Windows.Forms.RadioButton();
            this.rdo_Female = new System.Windows.Forms.RadioButton();
            this.rdo_gen = new System.Windows.Forms.RadioButton();
            this.rdo_obc = new System.Windows.Forms.RadioButton();
            this.rdo_sc = new System.Windows.Forms.RadioButton();
            this.rdo_st = new System.Windows.Forms.RadioButton();
            this.btn_get = new System.Windows.Forms.Button();
            this.lbl_data = new System.Windows.Forms.Label();
            this.gb_one.SuspendLayout();
            this.gb_two.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_one
            // 
            this.gb_one.Controls.Add(this.rdo_Female);
            this.gb_one.Controls.Add(this.rdo_Male);
            this.gb_one.Location = new System.Drawing.Point(12, 12);
            this.gb_one.Name = "gb_one";
            this.gb_one.Size = new System.Drawing.Size(200, 108);
            this.gb_one.TabIndex = 0;
            this.gb_one.TabStop = false;
            this.gb_one.Text = "Gender";
            // 
            // gb_two
            // 
            this.gb_two.Controls.Add(this.rdo_st);
            this.gb_two.Controls.Add(this.rdo_sc);
            this.gb_two.Controls.Add(this.rdo_obc);
            this.gb_two.Controls.Add(this.rdo_gen);
            this.gb_two.Location = new System.Drawing.Point(270, 12);
            this.gb_two.Name = "gb_two";
            this.gb_two.Size = new System.Drawing.Size(200, 108);
            this.gb_two.TabIndex = 0;
            this.gb_two.TabStop = false;
            this.gb_two.Text = "Category";
            // 
            // rdo_Male
            // 
            this.rdo_Male.AutoSize = true;
            this.rdo_Male.Location = new System.Drawing.Point(6, 16);
            this.rdo_Male.Name = "rdo_Male";
            this.rdo_Male.Size = new System.Drawing.Size(34, 17);
            this.rdo_Male.TabIndex = 0;
            this.rdo_Male.TabStop = true;
            this.rdo_Male.Text = "M";
            this.rdo_Male.UseVisualStyleBackColor = true;
            // 
            // rdo_Female
            // 
            this.rdo_Female.AutoSize = true;
            this.rdo_Female.Location = new System.Drawing.Point(6, 39);
            this.rdo_Female.Name = "rdo_Female";
            this.rdo_Female.Size = new System.Drawing.Size(31, 17);
            this.rdo_Female.TabIndex = 1;
            this.rdo_Female.TabStop = true;
            this.rdo_Female.Text = "F";
            this.rdo_Female.UseVisualStyleBackColor = true;
            // 
            // rdo_gen
            // 
            this.rdo_gen.AutoSize = true;
            this.rdo_gen.Location = new System.Drawing.Point(6, 16);
            this.rdo_gen.Name = "rdo_gen";
            this.rdo_gen.Size = new System.Drawing.Size(62, 17);
            this.rdo_gen.TabIndex = 0;
            this.rdo_gen.TabStop = true;
            this.rdo_gen.Text = "General";
            this.rdo_gen.UseVisualStyleBackColor = true;
            // 
            // rdo_obc
            // 
            this.rdo_obc.AutoSize = true;
            this.rdo_obc.Location = new System.Drawing.Point(6, 39);
            this.rdo_obc.Name = "rdo_obc";
            this.rdo_obc.Size = new System.Drawing.Size(47, 17);
            this.rdo_obc.TabIndex = 1;
            this.rdo_obc.TabStop = true;
            this.rdo_obc.Text = "OBC";
            this.rdo_obc.UseVisualStyleBackColor = true;
            // 
            // rdo_sc
            // 
            this.rdo_sc.AutoSize = true;
            this.rdo_sc.Location = new System.Drawing.Point(6, 60);
            this.rdo_sc.Name = "rdo_sc";
            this.rdo_sc.Size = new System.Drawing.Size(39, 17);
            this.rdo_sc.TabIndex = 2;
            this.rdo_sc.TabStop = true;
            this.rdo_sc.Text = "SC";
            this.rdo_sc.UseVisualStyleBackColor = true;
            // 
            // rdo_st
            // 
            this.rdo_st.AutoSize = true;
            this.rdo_st.Location = new System.Drawing.Point(6, 83);
            this.rdo_st.Name = "rdo_st";
            this.rdo_st.Size = new System.Drawing.Size(39, 17);
            this.rdo_st.TabIndex = 3;
            this.rdo_st.TabStop = true;
            this.rdo_st.Text = "ST";
            this.rdo_st.UseVisualStyleBackColor = true;
            // 
            // btn_get
            // 
            this.btn_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.Location = new System.Drawing.Point(181, 126);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(118, 38);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(12, 203);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_data.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 258);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.gb_two);
            this.Controls.Add(this.gb_one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_one.ResumeLayout(false);
            this.gb_one.PerformLayout();
            this.gb_two.ResumeLayout(false);
            this.gb_two.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_one;
        private System.Windows.Forms.RadioButton rdo_Female;
        private System.Windows.Forms.RadioButton rdo_Male;
        private System.Windows.Forms.GroupBox gb_two;
        private System.Windows.Forms.RadioButton rdo_st;
        private System.Windows.Forms.RadioButton rdo_sc;
        private System.Windows.Forms.RadioButton rdo_obc;
        private System.Windows.Forms.RadioButton rdo_gen;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label lbl_data;
    }
}

