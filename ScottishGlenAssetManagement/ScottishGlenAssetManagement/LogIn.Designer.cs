
namespace ScottishGlenAssetManagement
{
    partial class LogIn
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

        private Button GetLogInButton()
        {
            return LogInButton;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EMailInput = new TextBox();
            PasswordInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LogInButton = new Button();
            SuspendLayout();
            // 
            // EMailInput
            // 
            EMailInput.Location = new Point(12, 184);
            EMailInput.Name = "EMailInput";
            EMailInput.Size = new Size(100, 23);
            EMailInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(12, 297);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(100, 23);
            PasswordInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 279);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(353, 363);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(75, 23);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log In ->";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click_1;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogInButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordInput);
            Controls.Add(EMailInput);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox EMailInput;
        private TextBox PasswordInput;
        private Label label2;
        private Label label3;
        private Button LogInButton;
    }
}