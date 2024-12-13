namespace user_controls.user_control
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
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(237, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 321);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(28, 63);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 1;
            button1.Text = "modify";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
    }
}