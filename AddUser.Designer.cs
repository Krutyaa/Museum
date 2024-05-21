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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
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
            label1.Location = new Point(152, 84);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 141);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите фамилию";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 197);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 2;
            label3.Text = "Введите дату посещения";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.InactiveCaption;
            textBoxName.Location = new Point(331, 73);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(147, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = SystemColors.InactiveCaption;
            textBoxSurname.Location = new Point(331, 131);
            textBoxSurname.Margin = new Padding(3, 4, 3, 4);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(147, 27);
            textBoxSurname.TabIndex = 4;
            // 
            // textBoxDateOfVisit
            // 
            textBoxDateOfVisit.BackColor = SystemColors.InactiveCaption;
            textBoxDateOfVisit.Location = new Point(331, 187);
            textBoxDateOfVisit.Margin = new Padding(3, 4, 3, 4);
            textBoxDateOfVisit.Name = "textBoxDateOfVisit";
            textBoxDateOfVisit.Size = new Size(147, 27);
            textBoxDateOfVisit.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Gold;
            buttonAdd.Location = new Point(14, 257);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(242, 41);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить/Изменить посетителя";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 341);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDateOfVisit);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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