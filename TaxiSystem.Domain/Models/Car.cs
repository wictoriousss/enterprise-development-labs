namespace TaxiSystem.Domain.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }   // Гос. номер (например, "А123БВ777")
        public string Model { get; set; }         // Модель (например, "Toyota Camry")
        public string Color { get; set; }         // Цвет

        // Внешний ключ для связи с водителем
        public int DriverId { get; set; }

        // Навигационное свойство
        public Driver Driver { get; set; }
    }
}