namespace Controle_Financeiro
{
    partial class Login
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
            inputName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            inputPwd = new TextBox();
            label3 = new Label();
            inputConfirmPwd = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // inputName
            // 
            inputName.Font = new Font("Verdana", 9F);
            inputName.Location = new Point(32, 61);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Como gostaria de ser chamado?";
            inputName.Size = new Size(249, 22);
            inputName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F);
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 1;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F);
            label2.Location = new Point(32, 104);
            label2.Name = "label2";
            label2.Size = new Size(164, 17);
            label2.TabIndex = 2;
            label2.Text = "Cadastre uma senha :";
            // 
            // inputPwd
            // 
            inputPwd.Location = new Point(32, 125);
            inputPwd.Name = "inputPwd";
            inputPwd.PasswordChar = '•';
            inputPwd.Size = new Size(249, 23);
            inputPwd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F);
            label3.Location = new Point(32, 164);
            label3.Name = "label3";
            label3.Size = new Size(202, 17);
            label3.TabIndex = 4;
            label3.Text = "Confirme a senha digitada :";
            // 
            // inputConfirmPwd
            // 
            inputConfirmPwd.Location = new Point(32, 185);
            inputConfirmPwd.Name = "inputConfirmPwd";
            inputConfirmPwd.PasswordChar = '•';
            inputConfirmPwd.Size = new Size(249, 23);
            inputConfirmPwd.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(inputConfirmPwd);
            groupBox1.Controls.Add(inputName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(inputPwd);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 283);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Verdana", 10F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(135, 223);
            button1.Name = "button1";
            button1.Size = new Size(146, 30);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(345, 300);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox inputName;
        private Label label1;
        private Label label2;
        private TextBox inputPwd;
        private Label label3;
        private TextBox inputConfirmPwd;
        private GroupBox groupBox1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
