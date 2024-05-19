namespace Museum
{
    partial class AddUser
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
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxDateOfVisit = new TextBox();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 63);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 106);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Введите фамилию";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 148);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 2;
            label3.Text = "Введите дату посещения";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.InactiveCaption;
            textBoxName.Location = new Point(290, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(129, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = SystemColors.InactiveCaption;
            textBoxSurname.Location = new Point(290, 98);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(129, 23);
            textBoxSurname.TabIndex = 4;
            // 
            // textBoxDateOfVisit
            // 
            textBoxDateOfVisit.BackColor = SystemColors.InactiveCaption;
            textBoxDateOfVisit.Location = new Point(290, 140);
            textBoxDateOfVisit.Name = "textBoxDateOfVisit";
            textBoxDateOfVisit.Size = new Size(129, 23);
            textBoxDateOfVisit.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Gold;
            buttonAdd.Location = new Point(12, 193);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(212, 31);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить/Изменить посетителя";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 256);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDateOfVisit);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUser";
            Text = "Добавить/Изменить посетителя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxDateOfVisit;
        private Button buttonAdd;
    }
}