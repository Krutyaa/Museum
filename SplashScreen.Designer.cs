namespace Museum
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            labelInfo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = SystemColors.ActiveCaption;
            labelInfo.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo.Location = new Point(127, 49);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(504, 73);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Даниил Крутяков";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(70, 222);
            label1.Name = "label1";
            label1.Size = new Size(629, 55);
            label1.TabIndex = 1;
            label1.Text = "Тема курсовой работы: Музей";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashScreen";
            Text = "Приветственное окно";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private Label label1;
    }
}