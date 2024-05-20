using Newtonsoft.Json;

namespace Museum;

public partial class FormUser : Form
{
    private ApplicationContext context;
    public FormUser()
    {
        InitializeComponent();
        context = new ApplicationContext();
        context.Database.EnsureCreated();
        LoadData();
        Fon();
    }

    private void LoadData()
    {
        dataUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataUser.RowHeadersVisible = false;

        dataUser.DataSource = context.Users.ToList();

        dataUser.Columns["Id"].Visible = false;
        dataUser.Columns["Name"].HeaderText = "Имя";
        dataUser.Columns["Surname"].HeaderText = "Фамилия";
        dataUser.Columns["DateOfVisit"].HeaderText = "Дата посещения";
    }

    private void Fon()
    {
        BackgroundImageLayout = ImageLayout.Stretch;
        Control[] controlsToAnchor = {
        buttonGoToExhibit,
        AddUser,
        ApplicationExit,
        dataUser,
        CreateDatabaseButton,
        SaveDataBase,
        textBoxSearch,
        buttonSearch,
        DeleteDatabaseButton };
        foreach (var control in controlsToAnchor)
        {
            control.Anchor = AnchorStyles.None;
        }
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Добавить посетителя".
    /// Создает нового посетителя на основе введенных данных и сохраняет его в базе данных.
    /// </summary>
    private void AddUser_Click(object sender, EventArgs e)
    {
        if (context.Database.CanConnect())
        {
            AddUser addUser = new AddUser();

            if (addUser.ShowDialog() == DialogResult.OK)
            {
                User newUser = new User
                {
                    Name = addUser.UserName,
                    Surname = addUser.UserSurname,
                    DateOfVisit = addUser.UserDateOfVisit,
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                LoadData();
            }
        }
        else
        {
            MessageBox.Show("База данных не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Редактировать".
    /// Открывает форму для редактирования выбранного посетителя в базе данных.
    /// </summary>
    private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // Проверка наличия выбранной строки в DataGridView
        if (dataUser.SelectedRows.Count == 0)
        {
            MessageBox.Show("Пожалуйста, выберите пользователя для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Получение ID выбранного посетителя из ячейки DataGridView
        int selectedId = (int)dataUser.SelectedRows[0].Cells["Id"].Value;

        // Поиск посетителя в базе данных по его ID
        User selectedUser = context.Users.Find(selectedId);

        // Если посетитель найден
        if (selectedUser != null)
        {
            // Создание формы редактирования с предварительным заполнением данными выбранного посетителя
            AddUser editUser = new AddUser
            {
                UserName = selectedUser.Name,
                UserSurname = selectedUser.Surname,
                UserDateOfVisit = selectedUser.DateOfVisit
            };

            // Отображение формы редактирования и ожидание результата
            if (editUser.ShowDialog() == DialogResult.OK)
            {
                // Обновление данных выбранного посетителя на основе данных из формы редактирования
                selectedUser.Name = editUser.UserName;
                selectedUser.Surname = editUser.UserSurname;
                selectedUser.DateOfVisit = editUser.UserDateOfVisit;

                // Сохранение изменений в базе данных и обновление отображаемых данных в DataGridView
                context.SaveChanges();
                LoadData();
            }
        }
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Создать базу данных".
    /// </summary>
    /// <summary>
    /// Обработчик нажатия кнопки "Создать базу данных".
    /// </summary>
    private void CreateDatabaseButton_Click(object sender, EventArgs e)
    {
        if (context.Database.CanConnect())
            MessageBox.Show("База данных уже существует.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
        {
            context.Database.EnsureCreated();
            MessageBox.Show("База данных успешно создана.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Удалить базу данных".
    /// </summary>
    private void DeleteDatabaseButton_Click(object sender, EventArgs e)
    {
        if (!context.Database.CanConnect())
            MessageBox.Show("База данных не существует.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
        {
            context.Database.EnsureDeleted();
            MessageBox.Show("База данных успешно удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataUser.DataSource = null;
        }
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Сохранить экспонаты в файл JSON".
    /// Сохраняет данные об экспонатах из базы данных в файл JSON.
    /// </summary>
    private void SaveDataBase_Click(object sender, EventArgs e)
    {
        if (context.Database.CanConnect())
        {
            var users = context.Users.ToList();
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);

            // Путь к папке "Data" внутри вашего проекта
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dataDirectory = Path.Combine(projectDirectory, "DataUsers");

            // Убедитесь, что папка "Data" существует
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }

            // Проверьте, существует ли файл с такими же данными
            var existingFiles = Directory.GetFiles(dataDirectory, "*.json");
            foreach (var existingFile in existingFiles)
            {
                var existingJson = File.ReadAllText(existingFile);
                if (existingJson == json)
                {
                    MessageBox.Show($"Файл с такими же данными уже существует: {Path.GetFileName(existingFile)}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Создайте новый файл с уникальным именем
            string uniqueFileName = $"users_{DateTime.Now:yyyyMMdd_HHmmss}.json";
            string filePath = Path.Combine(dataDirectory, uniqueFileName);

            File.WriteAllText(filePath, json);

            MessageBox.Show($"Данные успешно сохранены в файл {filePath}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("База данных не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Поиск".
    /// Производит поиск посетителей по введенному тексту в поле поиска.
    /// </summary>
    private void buttonSearch_Click(object sender, EventArgs e)
    {
        if (context.Database.CanConnect())
        {
            string searchText = textBoxSearch.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string[] searchTerms = searchText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var filteredUsers = context.Users.Where(u =>
                    searchTerms.All(term => u.Name.Contains(term) || u.Surname.Contains(term) || u.DateOfVisit.Contains(term))).ToList();

                dataUser.DataSource = filteredUsers;
            }
            else
                dataUser.DataSource = context.Users.ToList();
            dataUser.ClearSelection();
        }
        else
            MessageBox.Show("База данных не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Удалить".
    /// </summary>
    private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (dataUser.SelectedRows.Count == 0)
        {
            MessageBox.Show("Пожалуйста, выберите пользователя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int selectedId = (int)dataUser.SelectedRows[0].Cells["Id"].Value;
        User selectedUser = context.Users.Find(selectedId);

        if (selectedUser != null)
        {
            context.Users.Remove(selectedUser);
            context.SaveChanges();
            LoadData();
        }
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Перейти к экспонатам".
    /// </summary>
    private void buttonGoToExhibit_Click(object sender, EventArgs e)
    {
        FormMuseum exhibitForm = new FormMuseum();
        exhibitForm.Show();
        Close();
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Выход".
    /// </summary>
    private void ApplicatuinExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}