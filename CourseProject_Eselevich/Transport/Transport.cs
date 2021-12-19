namespace CourseProject_Eselevich
{
    // Абстрактный класс, определяющий некоторый транспорт
    public abstract class Transport
    {
        // Тип транспорта (постфикс Str добавлен для того, чтобы не было путаницы с типом поля type у класса TravelVoucher)
        public string typeStr { get; protected set; }
        // Стоимость проезда
        public float cost { get; protected set; }
    }
}
