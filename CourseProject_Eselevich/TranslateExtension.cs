using System.Collections.Generic;

namespace CourseProject_Eselevich
{
    /**
     * Класс, определяющий расширение для перечисления TravelVoucherType
     * 
     * При помощи расширения можно добавить новые методы в какие-либо классы, типы и тд.
     * Для создания расширения необходим статический класс, который будет содержать эти методы.
     * Затем нужно объявить эти методы, они должны быть так же статическими.
     * 
     * В качестве первого параметра методы расширения всегда принимают параметр вида "this [расширяемый класс/тип/...] [название параметра]",
     * и при вызове это метода с экземпляра [расширяемый класс/тип/...] первый параметр указывать не нужно.
     * 
     * Пример метода:
       public static void WriteToConsole(this string str) {
           Console.WriteLine(str);
       }
     *
     * Пример вызова этого метода:
       string someStr = "Some string";
       someStr.WriteToConsole();
     * 
     * После чего в консоль выведется "Some string"
     * 
     * Подробнее о расширениях: https://metanit.com/sharp/tutorial/3.18.php
     */
    public static class TranslateExtension
    {
        // Словарь, представляющий пары "тип путевки - русский перевод"
        private static Dictionary<TravelVoucherType, string> _voucherTypesRus = new Dictionary<TravelVoucherType, string>()
        {
            { TravelVoucherType.Relaxation, "Отдых" },
            { TravelVoucherType.Excursion, "Экскурсия" },
            { TravelVoucherType.Treatment, "Лечение" },
            { TravelVoucherType.Shopping, "Шоппинг" },
            { TravelVoucherType.Cruise, "Круиз" },
        };

        // Словарь, представляющий пары "тип меню - русский перевод"
        private static Dictionary<FoodMenuType, string> _menuTypesRus = new Dictionary<FoodMenuType, string>()
        {
            { FoodMenuType.Vegeterian, "Вегетарианское" },
            { FoodMenuType.Vegan, "Веганское" },
            { FoodMenuType.Regular, "Обычное" },
            { FoodMenuType.Religious, "Религиозное" },
        };

        /**
         * Метод, возвращающий перевод типа путевки
         * 
         * Пример применения:
         * 
           TravelVoucherType someType = TravelVoucherType.Cruise;
           string str = someType.ToStrRus();
         *
         * Переменная str после этого будет содержать "Круиз"
         */
        public static string ToStrRus(this TravelVoucherType type)
        {
            return _voucherTypesRus[type];
        }

        /**
         * Метод, возвращающий перевод типа меню
         * 
         * Применение аналогично предущему методу
         */
        public static string ToStrRus(this FoodMenuType type)
        {
            return _menuTypesRus[type];
        }

        /**
         * Метод, делающий обратный перевод: из русского перевода в тип путевки
         * 
         * Знак "?" у возвращаемого типа означает, что значение может быть равно "null". Это необходимо, т.к. данный метод
         * можно вызывать из любого экземпляра строки, а не только с русского перевода типа путевки.
         */
        public static TravelVoucherType? ToTravelVoucherType(this string str)
        {
            // Проход по словарю "тип путевки - русский перевод"
            foreach(KeyValuePair<TravelVoucherType, string> pair in _voucherTypesRus)
            {
                // Если перевод найден, то вернуть тип путевки
                if(str == pair.Value)
                {
                    return pair.Key;
                }
            }
            // Если перевод так и не был найден, то вернуть null
            return null;
        }
    }
}
