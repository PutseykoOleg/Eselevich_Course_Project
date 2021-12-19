namespace CourseProject_Eselevich
{
    // Класс, определяющий конкретный транспорт - автобус
    public class Bus: Transport
    {
        public Bus(float cost)
        {
            this.typeStr = "Автобус";
            this.cost = cost;
        }
    }
}
