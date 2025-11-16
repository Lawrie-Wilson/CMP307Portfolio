using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;


namespace ScottishGlenAssetManagement
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            SignUpButton = new Button();
            LogInButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(476, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Scottish Glen Asset Management application";
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(77, 166);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(75, 23);
            SignUpButton.TabIndex = 1;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += this.SignUpButton_Click;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(341, 166);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(75, 23);
            LogInButton.TabIndex = 2;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 88);
            label2.Name = "label2";
            label2.Size = new Size(408, 30);
            label2.TabIndex = 3;
            label2.Text = "If this is your first time using this program, please press the 'Sign Up' button,\r\notherwise please press the 'Log In' button.";
            // 
            // WelcomeScreen
            // 
            ClientSize = new Size(497, 264);
            Controls.Add(label2);
            Controls.Add(LogInButton);
            Controls.Add(SignUpButton);
            Controls.Add(label1);
            Name = "WelcomeScreen";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
        private Button SignUpButton;
        private Button LogInButton;
        private Label label2;

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp f2 = new SignUp();
            f2.Show();
            this.Hide();

        }
    }
}
