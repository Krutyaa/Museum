namespace Museum
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            GoToMuseum = new Button();
            GoToUser = new Button();
            ApplicationExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // GoToMuseum
            // 
            GoToMuseum.BackColor = SystemColors.ActiveCaption;
            GoToMuseum.Location = new Point(65, 180);
            GoToMuseum.Margin = new Padding(3, 4, 3, 4);
            GoToMuseum.Name = "GoToMuseum";
            GoToMuseum.Size = new Size(345, 169);
            GoToMuseum.TabIndex = 0;
            GoToMuseum.Text = "Перейти к экспонатам";
            GoToMuseum.UseVisualStyleBackColor = false;
            GoToMuseum.Click += GoToMuseum_Click;
            // 
            // GoToUser
            // 
            GoToUser.BackColor = SystemColors.ActiveCaption;
            GoToUser.Location = new Point(501, 180);
            GoToUser.Margin = new Padding(3, 4, 3, 4);
            GoToUser.Name = "GoToUser";
            GoToUser.Size = new Size(345, 169);
            GoToUser.TabIndex = 1;
            GoToUser.Text = "Перейти к посетителям";
            GoToUser.UseVisualStyleBackColor = false;
            GoToUser.Click += GoToUser_Click;
            // 
            // ApplicationExit
            // 
            ApplicationExit.BackColor = SystemColors.ActiveCaption;
            ApplicationExit.Location = new Point(640, 501);
            ApplicationExit.Margin = new Padding(3, 4, 3, 4);
            ApplicationExit.Name = "ApplicationExit";
            ApplicationExit.Size = new Size(261, 83);
            ApplicationExit.TabIndex = 2;
            ApplicationExit.Text = "Выйти из приложения";
            ApplicationExit.UseVisualStyleBackColor = false;
            ApplicationExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(319, 89);
            label1.Name = "label1";
            label1.Size = new Size(249, 20);
            label1.TabIndex = 3;
            label1.Text = "КРУТЯКОВ ДАНИИЛ 22ВП2 МУЗЕЙ";
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(ApplicationExit);
            Controls.Add(GoToUser);
            Controls.Add(GoToMuseum);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormStart";
            Text = "Добро пожаловать в Музей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GoToMuseum;
        private Button GoToUser;
        private Button ApplicationExit;
        private Label label1;
    }
}