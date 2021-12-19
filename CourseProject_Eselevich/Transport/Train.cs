namespace CourseProject_Eselevich
{
    // Класс, определяющий конкретный транспорт - паром
    public class Train : Transport
    {
        public Train(float cost)
        {
            this.typeStr = "Поезд";
            this.cost = cost;
        }
    }
}
