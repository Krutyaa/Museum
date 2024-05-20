using System.Globalization;

namespace Museum
{
    /// <summary>
    /// Форма для добавления нового экспоната в музей.
    /// </summary>
    public partial class AddExhibit : Form
    {
        /// <summary>
        /// Получает или устанавливает имя экспоната.
        /// </summary>
        public string MuseumName
        {
            get => textBoxName.Text;
            set => textBoxName.Text = value;
        }

        /// <summary>
        /// Получает или устанавливает эру эксоната.
        /// </summary>
        public string MuseumEra
        {
            get => textBoxEra.Text;
            set => textBoxEra.Text = value;
        }

        /// <summary>
        /// Получает или устанавливает стоимость экспоната.
        /// </summary>
        public string MuseumPrice
        {
            get => textBoxPrice.Text;
            set => textBoxPrice.Text = value;
        }

        /// <summary>
        /// Получает или устанавливает эру экспоната.
        /// </summary>
        public string MuseumEraType
        {
            get => comboBoxEra.SelectedItem.ToString();
            set => comboBoxEra.SelectedItem = value;
        }


        /// <summary>
        /// Инициализирует новый экземпляр формы для добавления экспоната в музей.
        /// </summary>
        public AddExhibit()
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
                MuseumName = textBoxName.Text;                
                MuseumEraType = comboBoxEra.SelectedItem.ToString();
                MuseumEra = textBoxEra.Text;
                MuseumPrice = textBoxPrice.Text;

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
            // Проверка, что поле имени не пустое и содержит только допустимые символы
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя экспоната.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Проверка выбора эры
            if (comboBoxEra.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите эру.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Проверка, что поле эры не пустое и содержит допустимое значение
            if (string.IsNullOrWhiteSpace(textBoxEra.Text))
            {
                MessageBox.Show("Пожалуйста, введите век экспоната.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(textBoxEra.Text, out int era))
            {
                MessageBox.Show("Пожалуйста, введите целочисленное значение века.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxEra.SelectedItem.ToString() == "Нашей эры" && (era < 0 || era > 21))
            {
                MessageBox.Show("Пожалуйста, введите корректное значение века от 0 до 21 для 'нашей эры'.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxEra.SelectedItem.ToString() == "До нашей эры" && (era < 1 || era > 10000))
            {
                MessageBox.Show("Пожалуйста, введите корректное значение века от 1 до 10000 для 'до нашей эры'.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Проверка, что поле стоимости не пустое и содержит допустимое значение
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Пожалуйста, введите стоимость экспоната.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(textBoxPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal price) || price < 0 || price > 1000000000)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение стоимости в диапазоне от 0 до 1,000,000,000.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}