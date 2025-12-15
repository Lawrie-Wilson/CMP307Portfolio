namespace ScottishGlenAssetManagement
{
    partial class AddAsset
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
            label1 = new Label();
            SystemNameInput = new TextBox();
            ManufacturerInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ModelInput = new TextBox();
            label4 = new Label();
            DeviceTypeInput = new TextBox();
            IPAddressInput = new TextBox();
            label5 = new Label();
            label6 = new Label();
            PurchaseDateInput = new TextBox();
            NotesInput = new TextBox();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 36);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "System Name:";
            // 
            // SystemNameInput
            // 
            SystemNameInput.Location = new Point(12, 54);
            SystemNameInput.Name = "SystemNameInput";
            SystemNameInput.Size = new Size(100, 23);
            SystemNameInput.TabIndex = 1;
            // 
            // ManufacturerInput
            // 
            ManufacturerInput.Location = new Point(12, 119);
            ManufacturerInput.Name = "ManufacturerInput";
            ManufacturerInput.Size = new Size(100, 23);
            ManufacturerInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Manufacturer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Model:";
            // 
            // ModelInput
            // 
            ModelInput.Location = new Point(12, 179);
            ModelInput.Name = "ModelInput";
            ModelInput.Size = new Size(100, 23);
            ModelInput.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Device Type:";
            // 
            // DeviceTypeInput
            // 
            DeviceTypeInput.Location = new Point(12, 242);
            DeviceTypeInput.Name = "DeviceTypeInput";
            DeviceTypeInput.Size = new Size(100, 23);
            DeviceTypeInput.TabIndex = 7;
            // 
            // IPAddressInput
            // 
            IPAddressInput.Location = new Point(12, 310);
            IPAddressInput.Name = "IPAddressInput";
            IPAddressInput.Size = new Size(100, 23);
            IPAddressInput.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 292);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "IP Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 364);
            label6.Name = "label6";
            label6.Size = new Size(172, 15);
            label6.TabIndex = 10;
            label6.Text = "Purchase Date: (DD/MM/YYYY)";
            // 
            // PurchaseDateInput
            // 
            PurchaseDateInput.Location = new Point(12, 382);
            PurchaseDateInput.Name = "PurchaseDateInput";
            PurchaseDateInput.Size = new Size(100, 23);
            PurchaseDateInput.TabIndex = 11;
            // 
            // NotesInput
            // 
            NotesInput.AcceptsReturn = true;
            NotesInput.Location = new Point(12, 466);
            NotesInput.Multiline = true;
            NotesInput.Name = "NotesInput";
            NotesInput.Size = new Size(300, 120);
            NotesInput.TabIndex = 12;
            NotesInput.Text = "\r\n\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 448);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 14;
            label8.Text = "Additional Notes:";
            // 
            // button1
            // 
            button1.Location = new Point(307, 636);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Add Asset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddAsset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 761);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(NotesInput);
            Controls.Add(PurchaseDateInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(IPAddressInput);
            Controls.Add(DeviceTypeInput);
            Controls.Add(label4);
            Controls.Add(ModelInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ManufacturerInput);
            Controls.Add(SystemNameInput);
            Controls.Add(label1);
            Name = "AddAsset";
            Text = "AddAsset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SystemNameInput;
        private TextBox ManufacturerInput;
        private Label label2;
        private Label label3;
        private TextBox ModelInput;
        private Label label4;
        private TextBox DeviceTypeInput;
        private TextBox IPAddressInput;
        private Label label5;
        private Label label6;
        private TextBox PurchaseDateInput;
        private TextBox NotesInput;
        private Label label8;
        private Button button1;
    }
}