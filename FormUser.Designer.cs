namespace Museum;

partial class FormUser
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
        dataUser = new DataGridView();
        contextMenuStripUser = new ContextMenuStrip(components);
        изменитьToolStripMenuItem = new ToolStripMenuItem();
        удалитьToolStripMenuItem = new ToolStripMenuItem();
        AddUser = new Button();
        ApplicationExit = new Button();
        CreateDatabaseButton = new Button();
        DeleteDatabaseButton = new Button();
        SaveDataBase = new Button();
        textBoxSearch = new TextBox();
        buttonSearch = new Button();
        buttonGoToExhibit = new Button();
        ((System.ComponentModel.ISupportInitialize)dataUser).BeginInit();
        contextMenuStripUser.SuspendLayout();
        SuspendLayout();
        // 
        // dataUser
        // 
        dataUser.BackgroundColor = SystemColors.ActiveCaption;
        dataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataUser.ContextMenuStrip = contextMenuStripUser;
        dataUser.Location = new Point(26, 35);
        dataUser.Margin = new Padding(3, 4, 3, 4);
        dataUser.Name = "dataUser";
        dataUser.ReadOnly = true;
        dataUser.RowHeadersWidth = 51;
        dataUser.Size = new Size(379, 252);
        dataUser.TabIndex = 0;
        // 
        // contextMenuStripUser
        // 
        contextMenuStripUser.ImageScalingSize = new Size(20, 20);
        contextMenuStripUser.Items.AddRange(new ToolStripItem[] { изменитьToolStripMenuItem, удалитьToolStripMenuItem });
        contextMenuStripUser.Name = "contextMenuStripUser";
        contextMenuStripUser.Size = new Size(148, 52);
        // 
        // изменитьToolStripMenuItem
        // 
        изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
        изменитьToolStripMenuItem.Size = new Size(147, 24);
        изменитьToolStripMenuItem.Text = "Изменить";
        изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
        // 
        // удалитьToolStripMenuItem
        // 
        удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
        удалитьToolStripMenuItem.Size = new Size(147, 24);
        удалитьToolStripMenuItem.Text = "Удалить";
        удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
        // 
        // AddUser
        // 
        AddUser.BackColor = Color.Gold;
        AddUser.Location = new Point(26, 305);
        AddUser.Margin = new Padding(3, 4, 3, 4);
        AddUser.Name = "AddUser";
        AddUser.Size = new Size(166, 52);
        AddUser.TabIndex = 1;
        AddUser.Text = "Добавить посетителя";
        AddUser.UseVisualStyleBackColor = false;
        AddUser.Click += AddUser_Click;
        // 
        // ApplicationExit
        // 
        ApplicationExit.BackColor = Color.Gold;
        ApplicationExit.Location = new Point(420, 257);
        ApplicationExit.Margin = new Padding(3, 4, 3, 4);
        ApplicationExit.Name = "ApplicationExit";
        ApplicationExit.Size = new Size(182, 47);
        ApplicationExit.TabIndex = 9;
        ApplicationExit.Text = "Выйти из приложения";
        ApplicationExit.UseVisualStyleBackColor = false;
        ApplicationExit.Click += ApplicatuinExit_Click;
        // 
        // CreateDatabaseButton
        // 
        CreateDatabaseButton.BackColor = Color.Gold;
        CreateDatabaseButton.ForeColor = SystemColors.ControlText;
        CreateDatabaseButton.Location = new Point(206, 305);
        CreateDatabaseButton.Margin = new Padding(3, 4, 3, 4);
        CreateDatabaseButton.Name = "CreateDatabaseButton";
        CreateDatabaseButton.Size = new Size(182, 52);
        CreateDatabaseButton.TabIndex = 10;
        CreateDatabaseButton.Text = "Создать учёт посетителей";
        CreateDatabaseButton.UseVisualStyleBackColor = false;
        CreateDatabaseButton.Click += CreateDatabaseButton_Click;
        // 
        // DeleteDatabaseButton
        // 
        DeleteDatabaseButton.BackColor = Color.Gold;
        DeleteDatabaseButton.Location = new Point(420, 182);
        DeleteDatabaseButton.Margin = new Padding(3, 4, 3, 4);
        DeleteDatabaseButton.Name = "DeleteDatabaseButton";
        DeleteDatabaseButton.Size = new Size(182, 52);
        DeleteDatabaseButton.TabIndex = 11;
        DeleteDatabaseButton.Text = "Удалить учёт посетителей";
        DeleteDatabaseButton.UseVisualStyleBackColor = false;
        DeleteDatabaseButton.Click += DeleteDatabaseButton_Click;
        // 
        // SaveDataBase
        // 
        SaveDataBase.BackColor = Color.Gold;
        SaveDataBase.Location = new Point(420, 104);
        SaveDataBase.Margin = new Padding(3, 4, 3, 4);
        SaveDataBase.Name = "SaveDataBase";
        SaveDataBase.Size = new Size(182, 47);
        SaveDataBase.TabIndex = 12;
        SaveDataBase.Text = "Сохранить в файл";
        SaveDataBase.UseVisualStyleBackColor = false;
        SaveDataBase.Click += SaveDataBase_Click;
        // 
        // textBoxSearch
        // 
        textBoxSearch.BackColor = SystemColors.InactiveCaption;
        textBoxSearch.Location = new Point(206, 385);
        textBoxSearch.Margin = new Padding(3, 4, 3, 4);
        textBoxSearch.Name = "textBoxSearch";
        textBoxSearch.Size = new Size(165, 27);
        textBoxSearch.TabIndex = 13;
        // 
        // buttonSearch
        // 
        buttonSearch.BackColor = Color.Gold;
        buttonSearch.Location = new Point(26, 373);
        buttonSearch.Margin = new Padding(3, 4, 3, 4);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new Size(166, 52);
        buttonSearch.TabIndex = 14;
        buttonSearch.Text = "Поиск посетителя";
        buttonSearch.UseVisualStyleBackColor = false;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // buttonGoToExhibit
        // 
        buttonGoToExhibit.BackColor = Color.Gold;
        buttonGoToExhibit.Location = new Point(420, 35);
        buttonGoToExhibit.Margin = new Padding(3, 4, 3, 4);
        buttonGoToExhibit.Name = "buttonGoToExhibit";
        buttonGoToExhibit.Size = new Size(182, 47);
        buttonGoToExhibit.TabIndex = 17;
        buttonGoToExhibit.Text = "Перейти к эспокнатам";
        buttonGoToExhibit.UseVisualStyleBackColor = false;
        buttonGoToExhibit.Click += buttonGoToExhibit_Click;
        // 
        // FormUser
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        ClientSize = new Size(914, 600);
        Controls.Add(buttonGoToExhibit);
        Controls.Add(buttonSearch);
        Controls.Add(textBoxSearch);
        Controls.Add(SaveDataBase);
        Controls.Add(DeleteDatabaseButton);
        Controls.Add(CreateDatabaseButton);
        Controls.Add(ApplicationExit);
        Controls.Add(AddUser);
        Controls.Add(dataUser);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormUser";
        Text = "Посетители";
        ((System.ComponentModel.ISupportInitialize)dataUser).EndInit();
        contextMenuStripUser.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataUser;
    private Button AddUser;
    private Button ApplicationExit;
    private Button CreateDatabaseButton;
    private Button DeleteDatabaseButton;
    private Button SaveDataBase;
    private TextBox textBoxSearch;
    private Button buttonSearch;
    private Button buttonGoToExhibit;
    private ContextMenuStrip contextMenuStripUser;
    private ToolStripMenuItem изменитьToolStripMenuItem;
    private ToolStripMenuItem удалитьToolStripMenuItem;
}