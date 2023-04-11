namespace LiseYonetim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStudentName = new TextBox();
            txtStudentLastName = new TextBox();
            dgStudent = new DataGridView();
            cbCourseName = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgTeacher = new DataGridView();
            txtTeacherLastName = new TextBox();
            txtTeacherName = new TextBox();
            label7 = new Label();
            label9 = new Label();
            cbTeacherName = new ComboBox();
            dgCourse = new DataGridView();
            txtCourseName = new TextBox();
            txtStudentEmail = new TextBox();
            label4 = new Label();
            btnStudentCreate = new Button();
            btnTeacherCreate = new Button();
            btnCourseCreate = new Button();
            txtTeacherEmail = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCourse).BeginInit();
            SuspendLayout();
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(161, 12);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(208, 27);
            txtStudentName.TabIndex = 0;
            // 
            // txtStudentLastName
            // 
            txtStudentLastName.Location = new Point(161, 59);
            txtStudentLastName.Name = "txtStudentLastName";
            txtStudentLastName.Size = new Size(208, 27);
            txtStudentLastName.TabIndex = 0;
            // 
            // dgStudent
            // 
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Location = new Point(397, 12);
            dgStudent.Name = "dgStudent";
            dgStudent.RowHeadersWidth = 51;
            dgStudent.RowTemplate.Height = 29;
            dgStudent.Size = new Size(822, 172);
            dgStudent.TabIndex = 1;
            // 
            // cbCourseName
            // 
            cbCourseName.FormattingEnabled = true;
            cbCourseName.Location = new Point(161, 153);
            cbCourseName.Name = "cbCourseName";
            cbCourseName.Size = new Size(208, 28);
            cbCourseName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Student Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "Student LastName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 3;
            label3.Text = "Class Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 316);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 9;
            label5.Text = "Teacher LastName :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 260);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 10;
            label6.Text = "Teacher Name :";
            // 
            // dgTeacher
            // 
            dgTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTeacher.Location = new Point(397, 257);
            dgTeacher.Name = "dgTeacher";
            dgTeacher.RowHeadersWidth = 51;
            dgTeacher.RowTemplate.Height = 29;
            dgTeacher.Size = new Size(822, 140);
            dgTeacher.TabIndex = 6;
            // 
            // txtTeacherLastName
            // 
            txtTeacherLastName.Location = new Point(161, 313);
            txtTeacherLastName.Name = "txtTeacherLastName";
            txtTeacherLastName.Size = new Size(208, 27);
            txtTeacherLastName.TabIndex = 4;
            // 
            // txtTeacherName
            // 
            txtTeacherName.Location = new Point(161, 257);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(208, 27);
            txtTeacherName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 566);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 15;
            label7.Text = "Teacher :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 512);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 17;
            label9.Text = "Class Name :";
            // 
            // cbTeacherName
            // 
            cbTeacherName.FormattingEnabled = true;
            cbTeacherName.Location = new Point(161, 563);
            cbTeacherName.Name = "cbTeacherName";
            cbTeacherName.Size = new Size(208, 28);
            cbTeacherName.TabIndex = 14;
            // 
            // dgCourse
            // 
            dgCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCourse.Location = new Point(397, 509);
            dgCourse.Name = "dgCourse";
            dgCourse.RowHeadersWidth = 51;
            dgCourse.RowTemplate.Height = 29;
            dgCourse.Size = new Size(822, 140);
            dgCourse.TabIndex = 13;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(161, 509);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(208, 27);
            txtCourseName.TabIndex = 12;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Location = new Point(161, 106);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(208, 27);
            txtStudentEmail.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Student Email :";
            // 
            // btnStudentCreate
            // 
            btnStudentCreate.Location = new Point(275, 187);
            btnStudentCreate.Name = "btnStudentCreate";
            btnStudentCreate.Size = new Size(94, 40);
            btnStudentCreate.TabIndex = 18;
            btnStudentCreate.Text = "KAYIT";
            btnStudentCreate.UseVisualStyleBackColor = true;
            btnStudentCreate.Click += btnStudentCreate_Click;
            // 
            // btnTeacherCreate
            // 
            btnTeacherCreate.Location = new Point(275, 411);
            btnTeacherCreate.Name = "btnTeacherCreate";
            btnTeacherCreate.Size = new Size(94, 40);
            btnTeacherCreate.TabIndex = 18;
            btnTeacherCreate.Text = "KAYIT";
            btnTeacherCreate.UseVisualStyleBackColor = true;
            btnTeacherCreate.Click += btnTeacherCreate_Click;
            // 
            // btnCourseCreate
            // 
            btnCourseCreate.Location = new Point(275, 609);
            btnCourseCreate.Name = "btnCourseCreate";
            btnCourseCreate.Size = new Size(94, 40);
            btnCourseCreate.TabIndex = 18;
            btnCourseCreate.Text = "KAYIT";
            btnCourseCreate.UseVisualStyleBackColor = true;
            btnCourseCreate.Click += btnCourseCreate_Click;
            // 
            // txtTeacherEmail
            // 
            txtTeacherEmail.Location = new Point(161, 370);
            txtTeacherEmail.Name = "txtTeacherEmail";
            txtTeacherEmail.Size = new Size(208, 27);
            txtTeacherEmail.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 373);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 9;
            label8.Text = "Teacher Email :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 681);
            Controls.Add(btnCourseCreate);
            Controls.Add(btnTeacherCreate);
            Controls.Add(btnStudentCreate);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(cbTeacherName);
            Controls.Add(dgCourse);
            Controls.Add(txtCourseName);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dgTeacher);
            Controls.Add(txtTeacherEmail);
            Controls.Add(txtTeacherLastName);
            Controls.Add(txtTeacherName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbCourseName);
            Controls.Add(dgStudent);
            Controls.Add(txtStudentEmail);
            Controls.Add(txtStudentLastName);
            Controls.Add(txtStudentName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgTeacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtStudentName;
        private TextBox txtStudentLastName;
        private DataGridView dgStudent;
        private ComboBox cbCourseName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private DataGridView dgTeacher;
        private TextBox txtTeacherLastName;
        private TextBox txtTeacherName;
        private Label label7;
        private Label label9;
        private ComboBox cbTeacherName;
        private DataGridView dgCourse;
        private TextBox txtCourseName;
        private TextBox txtStudentEmail;
        private Label label4;
        private Button btnStudentCreate;
        private Button btnTeacherCreate;
        private Button btnCourseCreate;
        private TextBox txtTeacherEmail;
        private Label label8;
    }
}