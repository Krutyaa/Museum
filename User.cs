namespace Museum
{
    /// <summary>
    /// ����� �����������
    /// </summary>
    public class User
    {
        /// <summary>
        /// id ����������
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ��� ����������
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// ������� ����������
        /// </summary>
        public string? Surname { get; set; }
        /// <summary>
        /// ���� ������ ����������
        /// </summary>
        public string? DateOfVisit { get; set; }
    }
}