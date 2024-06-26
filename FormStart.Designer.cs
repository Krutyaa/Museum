﻿namespace Museum
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
            SuspendLayout();
            // 
            // GoToMuseum
            // 
            GoToMuseum.BackColor = SystemColors.ActiveCaption;
            GoToMuseum.Location = new Point(57, 135);
            GoToMuseum.Name = "GoToMuseum";
            GoToMuseum.Size = new Size(302, 127);
            GoToMuseum.TabIndex = 0;
            GoToMuseum.Text = "Перейти к экспонатам";
            GoToMuseum.UseVisualStyleBackColor = false;
            GoToMuseum.Click += GoToMuseum_Click;
            // 
            // GoToUser
            // 
            GoToUser.BackColor = SystemColors.ActiveCaption;
            GoToUser.Location = new Point(438, 135);
            GoToUser.Name = "GoToUser";
            GoToUser.Size = new Size(302, 127);
            GoToUser.TabIndex = 1;
            GoToUser.Text = "Перейти к посетителям";
            GoToUser.UseVisualStyleBackColor = false;
            GoToUser.Click += GoToUser_Click;
            // 
            // ApplicationExit
            // 
            ApplicationExit.BackColor = SystemColors.ActiveCaption;
            ApplicationExit.Location = new Point(560, 376);
            ApplicationExit.Name = "ApplicationExit";
            ApplicationExit.Size = new Size(228, 62);
            ApplicationExit.TabIndex = 2;
            ApplicationExit.Text = "Выйти из приложения";
            ApplicationExit.UseVisualStyleBackColor = false;
            ApplicationExit.Click += buttonExit_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(ApplicationExit);
            Controls.Add(GoToUser);
            Controls.Add(GoToMuseum);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStart";
            Text = "Добро пожаловать в Музей";
            ResumeLayout(false);
        }

        #endregion

        private Button GoToMuseum;
        private Button GoToUser;
        private Button ApplicationExit;
    }
}