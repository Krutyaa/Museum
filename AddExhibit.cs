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
            get => numericUpDownEra.Text;
            set => numericUpDownEra.Text = value;
        }

        /// <summary>
        /// Получает или устанавливает стоимость экспоната.
        /// </summary>
        public string MuseumPrice
        {
            get => numericUpDownPrice.Text;
            set => numericUpDownPrice.Text = value;
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
                MuseumEra = numericUpDownEra.Text;
                MuseumPrice = numericUpDownPrice.Text;

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
            // Проверка, что поле век содержит только числа от 1 до 100
            if (!int.TryParse(numericUpDownEra.Text, out int era) || era < 1 || era > 100)
            {
                MessageBox.Show("Пожалуйста, введите век в диапазоне от 1 до 100.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(numericUpDownPrice.Text, out int price) || era < 1 || era > 100000000)
            {
                MessageBox.Show("Пожалуйста, введите век в диапазоне от 1 до 100.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}