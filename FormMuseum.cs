using Newtonsoft.Json;
using System.Data;
using System.Globalization;

namespace Museum
{
    /// <summary>
    /// Главная форма приложения музея, отображающая список экспонатов и предоставляющая функции управления базой данных.
    /// </summary>
    public partial class FormMuseum : Form
    {
        private ApplicationContext context;

        /// <summary>
        /// Конструктор по умолчанию для класса FormMuseum.
        /// </summary>
        public FormMuseum()
        {
            InitializeComponent();
            context = new ApplicationContext();
            context.Database.EnsureCreated();
            LoadData();
            Fon();
        }

        /// <summary>
        /// Загружает данные о музейных экспонатах в DataGridView.
        /// </summary>
        private void LoadData()
        {
            // Настройка отображения DataGridView
            dataExhibit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataExhibit.RowHeadersVisible = false;

            // Загрузка данных из базы данных и привязка их к DataGridView
            dataExhibit.DataSource = context.Museums.ToList();

            // Настройка столбцов DataGridView
            dataExhibit.Columns["Id"].Visible = false;
            dataExhibit.Columns["Name"].HeaderText = "Имя";
            dataExhibit.Columns["Era"].HeaderText = "Век";
            dataExhibit.Columns["Price"].HeaderText = "Стоимость";
        }

        /// <summary>
        /// Настройка внешнего вида формы и её контролов.
        /// </summary>
        private void Fon()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            Control[] controlsToAnchor = {
                dataExhibit,
                buttonFiltering,
                buttonSearch,
                comboBoxExhibit,
                textBoxSearch,
                buttonAdd,
                CreateDatabaseButton,
                DeleteDatabaseButton,
                buttonGoToUser,
                buttonSaveExhibit,
                buttonExit
            };
            foreach (var control in controlsToAnchor)
            {
                control.Anchor = AnchorStyles.None;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить".
        /// Открывает форму для добавления нового экспоната в базу данных.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddExhibit addExhibit = new AddExhibit();
            if (addExhibit.ShowDialog() == DialogResult.OK)
            {
                Museum newMuseum = new Museum
                {
                    Name = addExhibit.MuseumName,
                    Era = addExhibit.MuseumEra,
                    Price = addExhibit.MuseumPrice,
                };
                context.Museums.Add(newMuseum);
                context.SaveChanges();
                LoadData();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Редактировать".
        /// Открывает форму для редактирования выбранного экспоната в базе данных.
        /// </summary>
        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранной строки в DataGridView
            if (dataExhibit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите экспонат для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получение ID выбранного экспоната из ячейки DataGridView
            int selectedId = (int)dataExhibit.SelectedRows[0].Cells["Id"].Value;

            // Поиск экспоната в базе данных по его ID
            Museum selectedMuseum = context.Museums.Find(selectedId);

            // Если экспонат найден
            if (selectedMuseum != null)
            {
                // Создание формы редактирования с предварительным заполнением данными выбранного экспоната
                AddExhibit editExhibitForm = new AddExhibit
                {
                    MuseumName = selectedMuseum.Name,
                    MuseumEra = selectedMuseum.Era,
                    MuseumPrice = selectedMuseum.Price
                };

                // Отображение формы редактирования и ожидание результата
                if (editExhibitForm.ShowDialog() == DialogResult.OK)
                {
                    // Обновление данных выбранного экспоната на основе данных из формы редактирования
                    selectedMuseum.Name = editExhibitForm.MuseumName;
                    selectedMuseum.Era = editExhibitForm.MuseumEra;
                    selectedMuseum.Price = editExhibitForm.MuseumPrice;

                    // Сохранение изменений в базе данных и обновление отображаемых данных в DataGridView
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить экспонаты в файл JSON".
        /// Сохраняет данные об экспонатах из базы данных в файл JSON.
        /// </summary>
        private void buttonSaveExhibit_Click(object sender, EventArgs e)
        {
            // Получение списка экспонатов из базы данных
            var exhibit = context.Museums.ToList();

            // Преобразование списка экспонатов в формат JSON
            string json = JsonConvert.SerializeObject(exhibit, Formatting.Indented);

            // Определение директории для сохранения файла
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dataDirectory = Path.Combine(projectDirectory, "DataExhibit");

            // Проверка существования директории и ее создание, если не существует
            if (!Directory.Exists(dataDirectory))
                Directory.CreateDirectory(dataDirectory);

            // Поиск существующих файлов JSON в директории и сравнение их с текущими данными
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
            string uniqueFileName = $"exhibit_{DateTime.Now:yyyyMMdd_HHmmss}.json";
            string filePath = Path.Combine(dataDirectory, uniqueFileName);
            File.WriteAllText(filePath, json);
            MessageBox.Show($"Данные успешно сохранены в файл {filePath}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
                dataExhibit.DataSource = null;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Поиск".
        /// Производит поиск экспонатов по введенному тексту в поле поиска.
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (context.Database.CanConnect())
            {
                string searchText = textBoxSearch.Text.Trim();

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    string[] searchTerms = searchText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var filteredExhibit = context.Museums.Where(u =>
                        searchTerms.All(term => u.Name.Contains(term) || u.Era.Contains(term))).ToList();

                    dataExhibit.DataSource = filteredExhibit;
                }
                else
                {
                    dataExhibit.DataSource = context.Museums.ToList();
                }
            }
            else
            {
                MessageBox.Show("База данных не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Фильтрация".
        /// </summary>
        private void buttonFiltering_Click(object sender, EventArgs e)
        {
            if (!context.Database.CanConnect())
            {
                MessageBox.Show("База данных не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxExhibit.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите критерий фильтрации из выпадающего списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filterCriteria = comboBoxExhibit.SelectedItem.ToString();
            if (!string.IsNullOrWhiteSpace(filterCriteria))
            {
                List<Museum> filteredExhibit;
                switch (filterCriteria)
                {
                    case "Имя":
                        filteredExhibit = context.Museums.OrderBy(u => u.Name).ToList();
                        break;

                    case "Эра":
                        filteredExhibit = context.Museums.OrderBy(u => u.Era).ToList();
                        break;

                    case "Цена":
                        filteredExhibit = context.Museums.ToList()
                            .Where(u => decimal.TryParse(u.Price, NumberStyles.Currency, CultureInfo.InvariantCulture, out _))
                            .OrderBy(u => decimal.Parse(u.Price, NumberStyles.Currency, CultureInfo.InvariantCulture))
                            .ToList();
                        break;

                    default:
                        filteredExhibit = context.Museums.ToList();
                        break;
                }
                dataExhibit.DataSource = filteredExhibit;
            }
            else
                dataExhibit.DataSource = context.Museums.ToList();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить".
        /// </summary>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataExhibit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите экспонат для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedId = (int)dataExhibit.SelectedRows[0].Cells["Id"].Value;
            Museum selectedMuseum = context.Museums.Find(selectedId);
            if (selectedMuseum != null)
            {
                context.Museums.Remove(selectedMuseum);
                context.SaveChanges();
                LoadData();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Перейти к пользователю".
        /// </summary>
        private void buttonGoToUser_Click(object sender, EventArgs e)
        {
            FormUser userForm = new FormUser();
            userForm.Show();
            Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Выход".
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}