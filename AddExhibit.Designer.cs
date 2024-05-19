namespace Museum
{
    partial class AddExhibit
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
            buttonAdd = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxEra = new TextBox();
            textBoxPrice = new TextBox();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Gold;
            buttonAdd.Location = new Point(24, 243);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(182, 24);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить/Изменить экспонат";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.InactiveCaption;
            textBoxName.Location = new Point(228, 110);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 23);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 118);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 159);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите век";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 199);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Ввеидте цену";
            // 
            // textBoxEra
            // 
            textBoxEra.BackColor = SystemColors.InactiveCaption;
            textBoxEra.Location = new Point(228, 151);
            textBoxEra.Name = "textBoxEra";
            textBoxEra.Size = new Size(124, 23);
            textBoxEra.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.InactiveCaption;
            textBoxPrice.Location = new Point(228, 191);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 23);
            textBoxPrice.TabIndex = 6;
            // 
            // AddExhibit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 299);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxEra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Name = "AddExhibit";
            Text = "Добавить/Изменить эксопнат";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxEra;
        private TextBox textBoxPrice;
    }
}