using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_Eselevich
{
    public partial class Form1 : Form
    {
        // Список путевок
        private List<TravelVoucher> vouchers = new List<TravelVoucher>();

        // Делегат, определяющий тип обработчика события
        private delegate void PurchaseHandler(string type, string message);
        // Событие, определяющее совершение покупки
        event PurchaseHandler Purchase;

        public Form1()
        {
            InitializeComponent();
        }

        // Метод, выводящий сообщение в консоль
        private void ConsoleLog(string type, string message)
        {
            // Вывод соответствующего диалогового окна
            switch (type)
            {
                case "success":
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "error":
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    break;
            }

            // Вывод сообщения в консоль
            Console.WriteLine(message);
        }

        // Метод, вызывающийся при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация выпадающего списка транспорта
            string[] availableTransports = new string[] { "Автобус", "Такси", "Поезд" };
            transportSelect.Items.AddRange(availableTransports);
            // Отключение редактирования (разрешены значения только из списка)
            transportSelect.DropDownStyle = ComboBoxStyle.DropDownList;

            /**
             * Инициализация выпадающего списка меню
             * 
             * Выбранное по умолчанию значение - "Обычное"
             * 
             * В отличие от инициализации списка транспорта, здесь происходит получение всех значений перечисления
             * FoodMenuType и приведение их к массиву. Это нужно для того чтобы при добавлении или удалении нового
             * значения из перечисления не пришлось редактировать данный массив вручную.
             * 
             * Можно заменить данный блок (2 следующие строчки) на следующий:
             * 
               string[] availableMenuTypes = new string[] { "Обычное", "Вегетарианское", "Веганское", "Религиозное" };
               menuSelect.Items.AddRange(availableMenuTypes);
             */
            FoodMenuType[] availableMenuTypes = Enum.GetValues(typeof(FoodMenuType)).Cast<FoodMenuType>().ToArray();
            menuSelect.Items.AddRange(availableMenuTypes.Select(item => item.ToStrRus()).ToArray());
            // Отключение редактирования (разрешены значения только из списка)
            menuSelect.DropDownStyle = ComboBoxStyle.DropDownList;

            // Добавление обработчика события
            Purchase += ConsoleLog;

            // Инициализация списка путевок
            InitializeVouchers();
            // Инициализация таблицы
            InitializeTable();

            /**
             * Установка дефолтного состояния формы
             * 
             * Отключение кнопок и установка дефолтных значений
             */
            SetDefaultFormState();
        }

        // Метод, инициализирующий список путевок
        private void InitializeVouchers()
        {
            // Добавление в список нового экземпляра туристической путевки
            vouchers.Add(new TravelVoucher(
                type: TravelVoucherType.Relaxation,
                name: "Отдых на море",
                cost: 12500f,
                period: new DatePeriod(new DateTime(2022, 1, 1), new DateTime(2022, 1, 15))
            ));

            vouchers.Add(new TravelVoucher(
                type: TravelVoucherType.Excursion,
                name: "Экскурсия по туристическим местам Санкт-Питербурга",
                cost: 3500f,
                period: new DatePeriod(new DateTime(2022, 3, 9), new DateTime(2022, 3, 11))
            ));

            vouchers.Add(new TravelVoucher(
                type: TravelVoucherType.Cruise,
                name: "Круиз по Черному морю",
                cost: 50000f,
                period: new DatePeriod(new DateTime(2022, 6, 1), new DateTime(2022, 6, 15))
            ));

            vouchers.Add(new TravelVoucher(
                type: TravelVoucherType.Shopping,
                name: "Выезд на закупку в ЦУМе",
                cost: 500f,
                period: new DatePeriod(new DateTime(2022, 1, 4), new DateTime(2022, 1, 4))
            ));

            vouchers.Add(new TravelVoucher(
                type: TravelVoucherType.Treatment,
                name: "Отдых в санатории Лесная ягодка",
                cost: 5500f,
                period: new DatePeriod(new DateTime(2023, 7, 1), new DateTime(2023, 7, 22))
            ));

            // Можно добавить еще...
        }
        
        /**
         * Метод, инициализирующий таблицу путевок
         * 
         * Здесь происходит добавление столбцов и настройка самой таблицы
         */
        private void InitializeTable()
        {
            // Добавление столбцов в таблицу
            table.Columns.Add("number", "№");
            table.Columns.Add("type", "Тип");
            table.Columns.Add("name", "Название");
            table.Columns.Add("cost", "Стоимость");

            // Данные в таблице - только для чтения
            table.ReadOnly = true;
            // Ширина столбца - по содержимому
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Убрать строку, при помощи которой просиходит добавление новой строки
            table.AllowUserToAddRows = false;
            // Убрать возможность одновременного выбора нескольких строк
            table.MultiSelect = false;
        }

        // Метод, устанавливающий дефолтное состояние формы
        private void SetDefaultFormState()
        {
            // Первоначальные значения списков выбора
            transportSelect.SelectedIndex = -1;
            menuSelect.SelectedIndex = menuSelect.Items.IndexOf("Обычное");

            // Значения дат периода по умолчанию минимальное и максимальное
            periodStartPicker.MinDate = DateTime.MinValue;
            periodEndPicker.MaxDate = DateTime.MaxValue;
            periodStartPicker.Value = periodStartPicker.MinDate;
            periodEndPicker.Value = periodEndPicker.MaxDate;
            // Дата конца периода заблокирована до выбора его начала
            periodEndPicker.Enabled = false;

            // Кнопка покупки путевки заблокирована
            buyButton.Enabled = false;

            // Очистка таблицы для добавления всех путевок (обнуление фильтра)
            table.Rows.Clear();

            // Для каждой возможной путевки
            foreach (TravelVoucher voucher in vouchers)
            {
                // Добавить ее в таблицу
                AddRowInTable(voucher);
            }
        }

        // Метод, добавляющий строку в таблицу
        private void AddRowInTable(TravelVoucher voucher)
        {
            // Добавление новой строки, пока что пустой, и вместе с тем получение ее индекса
            int index = table.Rows.Add();

            // Вынос строки в отдельную переменную для удобства
            DataGridViewRow row = table.Rows[index];

            // Инициализация каждой из ячеек строки
            row.Cells["number"].Value = index + 1;
            row.Cells["type"].Value = voucher.type.ToStrRus();
            row.Cells["name"].Value = voucher.name;
            row.Cells["cost"].Value = voucher.cost + " ₽";
        }

        // Метод, вызывающийся при выборе даты начала периода
        private void periodStartPicker_ValueChanged(object sender, EventArgs e)
        {
            // Если дата начала больше даты конца, причем если дата конца уже была установлена
            if(periodEndPicker.Enabled && periodStartPicker.Value > periodEndPicker.Value)
            {
                // Сместить дату конца к дате начала
                periodEndPicker.Value = periodStartPicker.Value;
            }

            // Установить минимальную возможную дату конца
            periodEndPicker.MinDate = periodStartPicker.Value;
            // Разблокировать выбор даты конца
            periodEndPicker.Enabled = true;

            // Отфильтровать таблицу по периоду
            FilterTableByPeriod();
        }

        // Метод, вызывающийся при выборе даты конца периода
        private void periodEndPicker_ValueChanged(object sender, EventArgs e)
        {
            // Проверить возможность покупки и разблокировать кнопку покупки, если она возможна
            buyButton.Enabled = CanBuyVoucher();

            // Отфильтровать таблицу по периоду
            FilterTableByPeriod();
        }

        // Метод, вызывающийся при выборе строки таблицы (при нажатии на ячейку первого столбца)
        private void table_SelectionChanged(object sender, EventArgs e)
        {
            // Если хотя бы одна строка выбрана
            if (table.SelectedRows.Count > 0)
            {
                // Вынос индекса выбранной строки в отдельную переменную для удобства
                int indexOfRow = table.SelectedRows[0].Index;

                // Инициализация информационных полей (номер и стоимость выбранной путевки)
                voucherNumberLabel.Text = (indexOfRow + 1).ToString();
                costLabel.Text = vouchers[indexOfRow].cost.ToString() + " ₽";
            } 
            // Если ни одной строки не выбрано
            else
            {
                // Удаление информации о номере и стоимости путевки
                voucherNumberLabel.Text = "";
                costLabel.Text = "";
            }

            // Проверить возможность покупки и разблокировать кнопку покупки, если она возможна
            buyButton.Enabled = CanBuyVoucher();
        }

        // Метод, вызывающийся при нажатии на кнопку "Купить"
        private void buyButton_Click(object sender, EventArgs e)
        {
            // Вынос выбранной путевки в отдельную переменную для удобства
            TravelVoucher voucher = vouchers[table.SelectedRows[0].Index];

            // Вынос выбранного транспорта в отдельную переменную для удобства
            string selectedTransport = transportSelect.SelectedItem.ToString();

            /**
             * Определение коэффициентов стоимости проезда на различном 
             * 
             * В данном случае стоимость проезда расчитывается следующим образом:
             *  - Берется 10% от стоимости путевки
             *  - Умножается на коэффициент транспорта
             *  
             * Это необходимо для того, чтобы стоимость до одного и того же места к примеру на такси и автобусе не стоила одинаково.
             */
            Dictionary<string, float> costCoefficients = new Dictionary<string, float>()
            {
                { "Автобус", 0.3f },
                { "Такси", 1f },
                { "Поезд", 0.6f },
            };

            // Определение стоимости проезда
            float transportCost = voucher.cost / 10 * costCoefficients[selectedTransport];

            // Инициализация транспорта, привязанного к путевке, соответствующим экземпляром
            switch(selectedTransport)
            {
                case "Автобус": 
                    voucher.transport = new Bus(transportCost); 
                    break;

                case "Такси":
                    voucher.transport = new Taxi(transportCost);
                    break;

                case "Поезд":
                    voucher.transport = new Train(transportCost);
                    break;
                default:
                    break;
            }

            // Вывод диалогового окна о подтверждении покупки
            string caption = "ПОДТВЕРЖДЕНИЕ ПОКУПКИ";
            string message =
                $"Тип: {voucher.type.ToStrRus()}\n" +
                $"Название: {voucher.name}\n" +
                $"Меню: {voucher.menuType.ToStrRus()}\n" +
                $"Стоимость самой путевки: {voucher.cost} ₽\n" +
                $"Транспорт до места: {selectedTransport}\n" +
                $"Стоимость транспорта: {transportCost} ₽\n\n" +
                $"ИТОГОВАЯ СТОИМОСТЬ: {voucher.cost + transportCost} ₽";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // Если нажато "OK"
            if(result == DialogResult.OK)
            {
                // Вывести сообщение об успешной покупке
                Purchase?.Invoke("success", "Путевка успешно приобретена!");
            } else
            {
                // Вывод сообщения об отмене покупки
                Purchase?.Invoke("error", "Покупка путевки отменена");
            }

            // Установить дефолтное состояние формы
            SetDefaultFormState();
        }

        // Метод, вызывающийся при выборе какого-либо транспорта из выпадающего списка
        private void transportSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверить возможность покупки и разблокировать кнопку покупки, если она возможна
            buyButton.Enabled = CanBuyVoucher();
        }

        // Метод проверяющий возможность покупки
        private bool CanBuyVoucher()
        {
            // Если выбран транспорт, меню и путевка то покупка возможна, иначе - нет
            return transportSelect.SelectedIndex >= 0 && menuSelect.SelectedIndex >= 0 && table.SelectedRows.Count > 0;
        }

        // Метод, фильтрующий путевки по периоду
        private void FilterTableByPeriod()
        {
            // Очистить таблицу
            table.Rows.Clear();

            // Для каждой путевки
            foreach(TravelVoucher voucher in vouchers)
            {
                // Если ее период входит в заданный
                if (periodStartPicker.Value <= voucher.period.from && voucher.period.to <= periodEndPicker.Value)
                {
                    // Добавить новую строку
                    AddRowInTable(voucher);
                }
            }
        }
    }
}
