using System;

namespace CourseProject_Eselevich
{
    // Класс, опеределяющий период времени
    public class DatePeriod
    {
        // Дата начала
        public DateTime from;
        // Дата конца
        public DateTime to;

        // Конструктор без параметров, устанавливающий дефолтные, означающие некорректные, значения дат
        public DatePeriod()
        {
            this.from = default;
            this.to = default;
        }

        // Конструктор, устанавливающий переданные значения дат
        public DatePeriod(DateTime from, DateTime to)
        {
            this.from = from;
            this.to = to;
        }

        // Метод, возвращающий корректность периода
        public bool IsCorrect()
        {
            // Если хотя бы одна из дат имеет дефолтное (default, то же самое что и DateTime.MinValue) значение, то период некорректен
            return from != default && to != default;
        }
    }
}
