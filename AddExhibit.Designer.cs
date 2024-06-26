﻿namespace Museum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExhibit));
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
            buttonAdd.Location = new Point(27, 324);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(208, 32);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить/Изменить экспонат";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.InactiveCaption;
            textBoxName.Location = new Point(261, 147);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(142, 27);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 150);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "Введите имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 208);
            label2.Name = "label2";
            label2.Size = new Size(204, 20);
            label2.TabIndex = 3;
            label2.Text = "Введите век (до нашей эры)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 262);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 4;
            label3.Text = "Введите цену";
            // 
            // numericUpDownEra
            // 
            numericUpDownEra.Location = new Point(261, 201);
            numericUpDownEra.Margin = new Padding(3, 4, 3, 4);
            numericUpDownEra.Name = "numericUpDownEra";
            numericUpDownEra.Size = new Size(143, 27);
            numericUpDownEra.TabIndex = 7;
            numericUpDownEra.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(261, 255);
            numericUpDownPrice.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(143, 27);
            numericUpDownPrice.TabIndex = 8;
            numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddExhibit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 399);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownEra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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