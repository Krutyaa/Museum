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
                MessageBox.Show("Пожалуйста, введите имя музея.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Проверка, что поле эры не пустое и содержит допустимое значение
            if (string.IsNullOrWhiteSpace(textBoxEra.Text))
            {
                MessageBox.Show("Пожалуйста, введите эру музея.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(textBoxEra.Text, out int era) || era < -10000 || era > 21)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение эры в диапазоне от -10000 до 21.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Проверка, что поле стоимости не пустое и содержит допустимое значение
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Пожалуйста, введите стоимость музея.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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