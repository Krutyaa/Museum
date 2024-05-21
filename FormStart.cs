namespace Museum
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class FormStart : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр главной формы приложения.
        /// </summary>
        public FormStart()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            GoToUser.Anchor = AnchorStyles.None;
            GoToMuseum.Anchor = AnchorStyles.None;
            ApplicationExit.Anchor = AnchorStyles.None;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Перейти к пользователям".
        /// </summary>
        private void GoToUser_Click(object sender, EventArgs e)
        {
            Hide();
            FormUser formUser = new FormUser();
            formUser.Show();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Перейти к экспонатам".
        /// </summary>
        private void GoToMuseum_Click(object sender, EventArgs e)
        {
            Hide();
            FormMuseum formMuseum = new FormMuseum();
            formMuseum.Show();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Выход из приложения".
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}