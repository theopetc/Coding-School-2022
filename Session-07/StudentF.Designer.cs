namespace Session_07
{
    partial class StudentF
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlAge = new DevExpress.XtraEditors.TextEdit();
            this.ctrlRegNumber = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCourses = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlListBox = new System.Windows.Forms.ListBox();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.bsListBox = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(430, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(392, 5);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(194, 20);
            this.ctrlName.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(268, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(268, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Age";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(268, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Registration Number";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(268, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Courses";
            // 
            // ctrlAge
            // 
            this.ctrlAge.Location = new System.Drawing.Point(392, 39);
            this.ctrlAge.Name = "ctrlAge";
            this.ctrlAge.Size = new System.Drawing.Size(32, 20);
            this.ctrlAge.TabIndex = 9;
            // 
            // ctrlRegNumber
            // 
            this.ctrlRegNumber.Location = new System.Drawing.Point(392, 70);
            this.ctrlRegNumber.Name = "ctrlRegNumber";
            this.ctrlRegNumber.Size = new System.Drawing.Size(74, 20);
            this.ctrlRegNumber.TabIndex = 10;
            // 
            // ctrlCourses
            // 
            this.ctrlCourses.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Course 1", "Course 1"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Course 2", "Course 2"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Course 3", "Course 3"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Course 4", "Course 4"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Course 5", "Course 5")});
            this.ctrlCourses.Location = new System.Drawing.Point(392, 98);
            this.ctrlCourses.Name = "ctrlCourses";
            this.ctrlCourses.Size = new System.Drawing.Size(120, 95);
            this.ctrlCourses.TabIndex = 19;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(268, 209);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 40);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "New...";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(511, 209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            // 
            // ctrlListBox
            // 
            this.ctrlListBox.FormattingEnabled = true;
            this.ctrlListBox.Location = new System.Drawing.Point(12, 12);
            this.ctrlListBox.Name = "ctrlListBox";
            this.ctrlListBox.Size = new System.Drawing.Size(250, 238);
            this.ctrlListBox.TabIndex = 24;
            this.ctrlListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedIndexChanged);
            // 
            // StudentF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.ctrlListBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.ctrlCourses);
            this.Controls.Add(this.ctrlRegNumber);
            this.Controls.Add(this.ctrlAge);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.btnSave);
            this.Name = "StudentF";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.formStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ctrlAge;
        private DevExpress.XtraEditors.TextEdit ctrlRegNumber;
        private DevExpress.XtraEditors.CheckedListBoxControl ctrlCourses;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.ListBox ctrlListBox;
        private System.Windows.Forms.BindingSource bsStudents;
        private System.Windows.Forms.BindingSource bsListBox;
    }
}