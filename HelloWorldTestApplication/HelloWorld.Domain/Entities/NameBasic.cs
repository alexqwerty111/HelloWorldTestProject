namespace HelloWorld.Domain.Entities
{
    /// <summary>
    /// Базовый класс для объектов с именами
    /// </summary>
    public class NameBasic : IdBasic
    {
        /// <summary>
        /// Наименование объекта
        /// </summary>
        public string Name { get; set; }
    }
}
