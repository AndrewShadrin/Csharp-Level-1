
namespace Task4
{
    /// <summary>
    /// Представляет ученика/ Фамилия, имя, сумма оценок
    /// для хранения отдельных оценок требуется добавить поля для их хранения, но по условиям задачи это не требуется
    /// </summary>
    struct Pupil
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public byte Sum { get; set; }
    }
}
