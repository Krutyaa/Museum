namespace Museum
{
    /// <summary>
    /// Класс посетителей
    /// </summary>
    public class User
    {
        /// <summary>
        /// id посетителя
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя посетителя
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Фамилия посетителя
        /// </summary>
        public string? Surname { get; set; }
        /// <summary>
        /// Дата визита посетителя
        /// </summary>
        public string? DateOfVisit { get; set; }
    }
}