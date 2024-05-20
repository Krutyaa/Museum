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
            numericUpDownEra = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
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
            label1.Location = new Point(67, 118);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 159);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите век (до нашей эры)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 199);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Введите цену";
            // 
            // numericUpDownEra
            // 
            numericUpDownEra.Location = new Point(228, 151);
            numericUpDownEra.Name = "numericUpDownEra";
            numericUpDownEra.Size = new Size(125, 23);
            numericUpDownEra.TabIndex = 7;
            numericUpDownEra.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(228, 191);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(125, 23);
            numericUpDownPrice.TabIndex = 8;
            numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddExhibit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 299);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownEra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Name = "AddExhibit";
            Text = "Добавить/Изменить эксопнат";
            ((System.ComponentModel.ISupportInitialize)numericUpDownEra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownEra;
        private NumericUpDown numericUpDownPrice;
    }
}