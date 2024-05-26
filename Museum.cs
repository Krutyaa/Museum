namespace Museum
{
    /// <summary>
    /// Класс экспонатов
    /// </summary>
    public class Museum
    {
        /// <summary>
        /// id экспоната
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// имя экспоната
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// век экспоната
        /// </summary>
        public string? Era { get; set; }
        /// <summary>
        /// цена экспоната
        /// </summary>
        public string? Price { get; set; }
    }
}