namespace Museum
{
    partial class FormMuseum
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuseum));
            buttonExit = new Button();
            dataExhibit = new DataGridView();
            contextMenuStripExhibit = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            buttonAdd = new Button();
            buttonSaveExhibit = new Button();
            CreateDatabaseButton = new Button();
            DeleteDatabaseButton = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            comboBoxExhibit = new ComboBox();
            buttonFiltering = new Button();
            buttonGoToUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataExhibit).BeginInit();
            contextMenuStripExhibit.SuspendLayout();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gold;
            buttonExit.Location = new Point(390, 167);
            buttonExit.Margin = new Padding(3, 2, 3, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(186, 38);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Выйти из приложения";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // dataExhibit
            // 
            dataExhibit.BackgroundColor = SystemColors.ActiveCaption;
            dataExhibit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataExhibit.ContextMenuStrip = contextMenuStripExhibit;
            dataExhibit.Location = new Point(8, 12);
            dataExhibit.Name = "dataExhibit";
            dataExhibit.ReadOnly = true;
            dataExhibit.Size = new Size(304, 145);
            dataExhibit.TabIndex = 1;
            // 
            // contextMenuStripExhibit
            // 
            contextMenuStripExhibit.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem, toolStripMenuItem1 });
            contextMenuStripExhibit.Name = "contextMenuStripExhibit";
            contextMenuStripExhibit.Size = new Size(129, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(128, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(128, 22);
            toolStripMenuItem1.Text = "Изменить";
            toolStripMenuItem1.Click += toolStripMenuItemEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Gold;
            buttonAdd.Location = new Point(8, 167);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(144, 30);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить экспонат";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSaveExhibit
            // 
            buttonSaveExhibit.BackColor = Color.Gold;
            buttonSaveExhibit.Location = new Point(390, 56);
            buttonSaveExhibit.Name = "buttonSaveExhibit";
            buttonSaveExhibit.Size = new Size(186, 34);
            buttonSaveExhibit.TabIndex = 9;
            buttonSaveExhibit.Text = "Сохранить в файл";
            buttonSaveExhibit.UseVisualStyleBackColor = false;
            buttonSaveExhibit.Click += buttonSaveExhibit_Click;
            // 
            // CreateDatabaseButton
            // 
            CreateDatabaseButton.BackColor = Color.Gold;
            CreateDatabaseButton.Location = new Point(390, 109);
            CreateDatabaseButton.Name = "CreateDatabaseButton";
            CreateDatabaseButton.Size = new Size(186, 38);
            CreateDatabaseButton.TabIndex = 10;
            CreateDatabaseButton.Text = "Создать учёт экспанатов";
            CreateDatabaseButton.UseVisualStyleBackColor = false;
            CreateDatabaseButton.Click += CreateDatabaseButton_Click;
            // 
            // DeleteDatabaseButton
            // 
            DeleteDatabaseButton.BackColor = Color.Gold;
            DeleteDatabaseButton.Location = new Point(169, 167);
            DeleteDatabaseButton.Name = "DeleteDatabaseButton";
            DeleteDatabaseButton.Size = new Size(186, 38);
            DeleteDatabaseButton.TabIndex = 11;
            DeleteDatabaseButton.Text = "Удалить учёт экспонатов";
            DeleteDatabaseButton.UseVisualStyleBackColor = false;
            DeleteDatabaseButton.Click += DeleteDatabaseButton_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Gold;
            buttonSearch.Location = new Point(8, 225);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(144, 30);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Поиск экспоната";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = SystemColors.InactiveCaption;
            textBoxSearch.Location = new Point(169, 230);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(120, 23);
            textBoxSearch.TabIndex = 13;
            // 
            // comboBoxExhibit
            // 
            comboBoxExhibit.BackColor = SystemColors.InactiveCaption;
            comboBoxExhibit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExhibit.FormattingEnabled = true;
            comboBoxExhibit.Items.AddRange(new object[] { "Имя", "Век", "Цена" });
            comboBoxExhibit.Location = new Point(169, 283);
            comboBoxExhibit.Name = "comboBoxExhibit";
            comboBoxExhibit.Size = new Size(120, 23);
            comboBoxExhibit.TabIndex = 14;
            // 
            // buttonFiltering
            // 
            buttonFiltering.BackColor = Color.Gold;
            buttonFiltering.Location = new Point(8, 276);
            buttonFiltering.Name = "buttonFiltering";
            buttonFiltering.Size = new Size(144, 30);
            buttonFiltering.TabIndex = 16;
            buttonFiltering.Text = "Фильрация экспонатов";
            buttonFiltering.UseVisualStyleBackColor = false;
            buttonFiltering.Click += buttonFiltering_Click;
            // 
            // buttonGoToUser
            // 
            buttonGoToUser.BackColor = Color.Gold;
            buttonGoToUser.Location = new Point(390, 12);
            buttonGoToUser.Name = "buttonGoToUser";
            buttonGoToUser.Size = new Size(186, 38);
            buttonGoToUser.TabIndex = 19;
            buttonGoToUser.Text = "Перейти к посетителям";
            buttonGoToUser.UseVisualStyleBackColor = false;
            buttonGoToUser.Click += buttonGoToUser_Click;
            // 
            // FormMuseum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(767, 391);
            Controls.Add(buttonGoToUser);
            Controls.Add(buttonFiltering);
            Controls.Add(comboBoxExhibit);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Controls.Add(DeleteDatabaseButton);
            Controls.Add(CreateDatabaseButton);
            Controls.Add(buttonSaveExhibit);
            Controls.Add(buttonAdd);
            Controls.Add(dataExhibit);
            Controls.Add(buttonExit);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMuseum";
            Text = "Экспонаты";
            ((System.ComponentModel.ISupportInitialize)dataExhibit).EndInit();
            contextMenuStripExhibit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private DataGridView dataExhibit;
        private Button buttonAdd;
        private Button buttonSaveExhibit;
        private Button CreateDatabaseButton;
        private Button DeleteDatabaseButton;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private ComboBox comboBoxExhibit;
        private Button buttonFiltering;
        private Button buttonGoToUser;
        private ContextMenuStrip contextMenuStripExhibit;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}