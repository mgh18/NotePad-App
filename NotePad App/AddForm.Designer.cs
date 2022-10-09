namespace NotePad_App
{
    partial class AddForm
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
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_txt = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(27, 53);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(309, 21);
            this.txt_subject.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(27, 264);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(182, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "ذخیره";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "عنوان:";
            // 
            // txt_txt
            // 
            this.txt_txt.Location = new System.Drawing.Point(27, 90);
            this.txt_txt.Multiline = true;
            this.txt_txt.Name = "txt_txt";
            this.txt_txt.Size = new System.Drawing.Size(309, 168);
            this.txt_txt.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Moccasin;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Location = new System.Drawing.Point(261, 264);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "متن:";
            // 
            // txt_newtxt
            // 
            this.txt_newtxt.AutoSize = true;
            this.txt_newtxt.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newtxt.Location = new System.Drawing.Point(137, 19);
            this.txt_newtxt.Name = "txt_newtxt";
            this.txt_newtxt.Size = new System.Drawing.Size(119, 17);
            this.txt_newtxt.TabIndex = 6;
            this.txt_newtxt.Text = "ایجاد یادداشت جدید";
            this.txt_newtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddForm
            // 
            this.AcceptButton = this.btn_back;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(402, 311);
            this.Controls.Add(this.txt_newtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_subject);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_txt;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Label txt_newtxt;
    }
}