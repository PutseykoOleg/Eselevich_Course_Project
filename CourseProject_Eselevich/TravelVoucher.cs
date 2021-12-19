using System;
using System.Collections.Generic;

namespace CourseProject_Eselevich
{
    // Класс, описывающий туристическую путевку
    public class TravelVoucher
    {
        // Корректная стоимость путевки (не включая стоимости транспорта)
        private float _cost;
        // Корректный период (дата начала и дата конца путевки)
        private DatePeriod _period;

        // Тип меню
        public FoodMenuType menuType { get; set; }
        // Список транспорта, на котором можно добраться до места
        public Transport transport { get; set; }
        // Тип путевки
        public TravelVoucherType type { get; private set; }
        // Название путевки
        public string name { get; private set; }
        // Поле (свойство), через которое происходит обращение к приватному _cost
        public float cost { 
            // При обращении к cost возвращается значение _cost
            get => _cost; 
            // При установлении значения cost, устанавливается откорректированное значение _cost
            private set {
                /** 
                 * Перевод стоимости в формат рублей, т.е.:
                 * 
                 * 1) Если значение меньше нуля, то устанавливается 0
                 * 2) Если после запятой количество цифр больше двух, то округлить до двух (копейки)
                 */
                _cost = value < 0f ? 0f : (float)Math.Round(value, 2);
            }
        }
        // Поле (свойство), через которое происходит обращение к приватному _period
        public DatePeriod period
        {
            // При обращении к period возвращается значение _period
            get => _period;
            // При установлении значения period, устанавливается откорректированное значение _period
            private set
            {
                /**
                 * Если дата начала больше даты конца путевки или хотя бы одна из дат некорректная (значение - default),
                 * то установить обеим дефолтное значение - default (DateTime.MinValue) при помощи вызова конструктора без параметров.
                 * 
                 * Менять местами нельзя, т.к. подразумевается что переданные данные в принципе некорректные и исправление их
                 * таким образом приведет к еще более сильному искажению данных. Вместо этого дефолтное значение означает, что
                 * произошла какая-то ошибка при инициализации.
                 */
                _period = value.from > value.to || !value.IsCorrect() ? new DatePeriod() : value;
            }
        }

        // Конструктор класса
        public TravelVoucher(TravelVoucherType type, string name, float cost, DatePeriod period)
        {
            this.type = type;
            this.name = name;
            this.cost = cost;
            this.period = period;

            // Значения полей "transport" и "menuType" можно установить напрямую из экземпляра класса
        }
    }
}
