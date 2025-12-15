namespace ScottishGlenAssetManagement
{
    partial class SignUp
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
            SubmitSignUp = new Button();
            FirstNameInput = new TextBox();
            LastNameInput = new TextBox();
            EMailInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DepartmentInput = new ComboBox();
            PasswordInput = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // SubmitSignUp
            // 
            SubmitSignUp.Location = new Point(238, 509);
            SubmitSignUp.Name = "SubmitSignUp";
            SubmitSignUp.Size = new Size(75, 23);
            SubmitSignUp.TabIndex = 0;
            SubmitSignUp.Text = "Sign Up ->";
            SubmitSignUp.UseVisualStyleBackColor = true;
            SubmitSignUp.Click += SubmitSignUp_Click;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(13, 77);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(100, 23);
            FirstNameInput.TabIndex = 1;
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(13, 176);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(100, 23);
            LastNameInput.TabIndex = 2;
            // 
            // EMailInput
            // 
            EMailInput.Location = new Point(12, 274);
            EMailInput.Name = "EMailInput";
            EMailInput.Size = new Size(100, 23);
            EMailInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 158);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 59);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "First Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 256);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 417);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Department:";
            // 
            // DepartmentInput
            // 
            DepartmentInput.AllowDrop = true;
            DepartmentInput.FormattingEnabled = true;
            DepartmentInput.Items.AddRange(new object[] { "Finance", "Human Resources", "Operations", "Sales", "Information Technology" });
            DepartmentInput.Location = new Point(12, 435);
            DepartmentInput.Name = "DepartmentInput";
            DepartmentInput.Size = new Size(121, 23);
            DepartmentInput.TabIndex = 8;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(12, 350);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(100, 23);
            PasswordInput.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 332);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 561);
            Controls.Add(label5);
            Controls.Add(PasswordInput);
            Controls.Add(DepartmentInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EMailInput);
            Controls.Add(LastNameInput);
            Controls.Add(FirstNameInput);
            Controls.Add(SubmitSignUp);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitSignUp;
        private TextBox FirstNameInput;
        private TextBox LastNameInput;
        private TextBox EMailInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox DepartmentInput;
        private TextBox PasswordInput;
        private Label label5;
    }
}