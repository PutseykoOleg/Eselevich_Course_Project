namespace CourseProject_Eselevich
{
    // Класс, определяющий конкретный транспорт - паром
    public class Taxi : Transport
    {
        public Taxi(float cost)
        {
            this.typeStr = "Такси";
            this.cost = cost;
        }
    }
}
