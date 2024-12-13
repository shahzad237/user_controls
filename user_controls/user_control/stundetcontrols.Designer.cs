namespace user_controls.user_control
{
    partial class stundetcontrols
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_name = new Label();
            lbl_age = new Label();
            lbl_grade = new Label();
            name_txt = new TextBox();
            age_text = new TextBox();
            grade_text = new TextBox();
            btnAdd = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(56, 31);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(39, 15);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name";
            //lbl_name.Click += lbl_name_Click;
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Location = new Point(56, 70);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(28, 15);
            lbl_age.TabIndex = 1;
            lbl_age.Text = "Age";
            // 
            // lbl_grade
            // 
            lbl_grade.AutoSize = true;
            lbl_grade.Location = new Point(56, 116);
            lbl_grade.Name = "lbl_grade";
            lbl_grade.Size = new Size(38, 15);
            lbl_grade.TabIndex = 2;
            lbl_grade.Text = "Grade";
            // 
            // name_txt
            // 
            name_txt.Location = new Point(141, 30);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(177, 23);
            name_txt.TabIndex = 3;
            //name_txt.TextChanged += name_txt_TextChanged;
            // 
            // age_text
            // 
            age_text.Location = new Point(141, 70);
            age_text.Name = "age_text";
            age_text.Size = new Size(177, 23);
            age_text.TabIndex = 4;
            // 
            // grade_text
            // 
            grade_text.Location = new Point(141, 113);
            grade_text.Name = "grade_text";
            grade_text.Size = new Size(177, 23);
            grade_text.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(202, 202);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 31);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(202, 275);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 31);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // stundetcontrols
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(grade_text);
            Controls.Add(age_text);
            Controls.Add(name_txt);
            Controls.Add(lbl_grade);
            Controls.Add(lbl_age);
            Controls.Add(lbl_name);
            Name = "stundetcontrols";
            Size = new Size(610, 487);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_age;
        private Label lbl_grade;
        private TextBox name_txt;
        private TextBox age_text;
        private TextBox grade_text;
        private Button btnAdd;
        private Button btnSearch;
    }
}
