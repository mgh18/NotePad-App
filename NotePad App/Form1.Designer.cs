namespace NotePad_App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_new = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grdList = new System.Windows.Forms.DataGridView();
            this.NoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_new,
            this.btn_edit,
            this.btn_delete,
            this.btn_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(68, 20);
            this.btn_new.Text = "یادداشت ";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(54, 20);
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(44, 20);
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(44, 20);
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_time
            // 
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(118, 17);
            this.lbl_time.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdList.BackgroundColor = System.Drawing.Color.IndianRed;
            this.grdList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoteID,
            this.Subject,
            this.CreateDate,
            this.EditDate});
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.Location = new System.Drawing.Point(0, 24);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(511, 243);
            this.grdList.TabIndex = 2;
            // 
            // NoteID
            // 
            this.NoteID.DataPropertyName = "NoteID";
            this.NoteID.HeaderText = "کد";
            this.NoteID.Name = "NoteID";
            this.NoteID.ReadOnly = true;
            this.NoteID.Visible = false;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "عنوان";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "تاریخ ایجاد";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // EditDate
            // 
            this.EditDate.DataPropertyName = "EditDate";
            this.EditDate.HeaderText = "تاریخ ویرایش";
            this.EditDate.Name = "EditDate";
            this.EditDate.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 289);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "یادداشت";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_new;
        private System.Windows.Forms.ToolStripMenuItem btn_edit;
        private System.Windows.Forms.ToolStripMenuItem btn_delete;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditDate;
    }
}

