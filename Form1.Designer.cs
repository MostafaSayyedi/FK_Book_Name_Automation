namespace FK_Book_Name
{
    partial class frm_Main
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.txt_Book_Name = new System.Windows.Forms.TextBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_Book_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(8, 144);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(1334, 80);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.Location = new System.Drawing.Point(3, 15);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Book_Name.Size = new System.Drawing.Size(125, 25);
            this.lbl_Book_Name.TabIndex = 1;
            this.lbl_Book_Name.Text = "Book Name:";
            // 
            // txt_Book_Name
            // 
            this.txt_Book_Name.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Name.Location = new System.Drawing.Point(138, 12);
            this.txt_Book_Name.Name = "txt_Book_Name";
            this.txt_Book_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Book_Name.Size = new System.Drawing.Size(1204, 33);
            this.txt_Book_Name.TabIndex = 2;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Copy.Location = new System.Drawing.Point(1255, 83);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(87, 31);
            this.btn_Copy.TabIndex = 3;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(3, 83);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Result.Size = new System.Drawing.Size(79, 25);
            this.lbl_Result.TabIndex = 4;
            this.lbl_Result.Text = "Result:";
            // 
            // lbl_Book_Result
            // 
            this.lbl_Book_Result.AutoSize = true;
            this.lbl_Book_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Result.Location = new System.Drawing.Point(133, 89);
            this.lbl_Book_Result.Name = "lbl_Book_Result";
            this.lbl_Book_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Book_Result.Size = new System.Drawing.Size(26, 25);
            this.lbl_Book_Result.TabIndex = 5;
            this.lbl_Book_Result.Text = "\"\"";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 236);
            this.Controls.Add(this.lbl_Book_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.txt_Book_Name);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.btn_Submit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اتوماسیون ایجاد نام برای کتاب ها در سایت فقط کتاب - FaghatKetab.ir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.TextBox txt_Book_Name;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label lbl_Book_Result;
    }
}

