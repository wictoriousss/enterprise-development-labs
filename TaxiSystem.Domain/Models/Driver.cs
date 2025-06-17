namespace TaxiSystem.Domain.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FullName { get; set; }       // ФИО
        public string PassportNumber { get; set; }  // Номер паспорта
        public string Address { get; set; }        // Адрес проживания
        public string Phone { get; set; }          // Контактный телефон

        // Навигационное свойство (один водитель — один автомобиль)
        public Car Car { get; set; }
    }
}