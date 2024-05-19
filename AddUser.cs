using System.Globalization;

namespace Museum
{
    /// <summary>
    /// Форма для добавления нового посетителя в музей.
    /// </summary>
    public partial class AddUser : Form
    {
        /// <summary>
        /// Получает или устанавливает имя посетителя.
        /// </summary>
        public string UserName
        {
            get => textBoxName.Text;
            set => textBoxName.Text = value;
        }

        /// <summary>
        /// Получает или устанавливает фамилию посетителя.
        /// </summary>
        public string UserSurname
        {
            get => textBoxSurname.Text;
            set => textBoxSurname.Text = value;
        }

        /// <summary>
        /// Получает или устанавливает дату посещения посетителя.
        /// </summary>
        public string UserDateOfVisit
        {
            get => textBoxDateOfVisit.Text;
            set => textBoxDateOfVisit.Text = value;
        }

        /// <summary>
        /// Инициализирует новый экземпляр формы для добавления посетителя в музей.
        /// </summary>
        public AddUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить" или "Изменить".
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                UserName = textBoxName.Text;
                UserSurname = textBoxSurname.Text;
                UserDateOfVisit = textBoxDateOfVisit.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Проверяет корректность введенных данных.
        /// </summary>
        /// <returns>Возвращает true, если данные корректны, иначе - false.</returns>
        private bool ValidateInput()
        {
            // Проверка, что поле имени не пустое и состоит только из букв
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!textBoxName.Text.All(char.IsLetter))
            {
                MessageBox.Show("Имя пользователя должно содержать только буквы.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Проверка, что поле фамилии не пустое и состоит только из букв
            if (string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                MessageBox.Show("Пожалуйста, введите фамилию пользователя.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!textBoxSurname.Text.All(char.IsLetter))
            {
                MessageBox.Show("Фамилия пользователя должна содержать только буквы.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Проверка, что поле даты посещения не пустое и содержит корректную дату
            if (string.IsNullOrWhiteSpace(textBoxDateOfVisit.Text))
            {
                MessageBox.Show("Пожалуйста, введите дату посещения пользователя.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!DateTime.TryParseExact(textBoxDateOfVisit.Text, "dd.MM.yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime visitDate))
            {
                MessageBox.Show("Неправильный формат даты посещения. Пожалуйста, введите дату в формате ДД.ММ.ГГ", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (visitDate > DateTime.Now)
            {
                MessageBox.Show("Дата посещения не может быть в будущем.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}