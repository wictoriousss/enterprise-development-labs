using System;

namespace TaxiSystem.Domain.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string StartPoint { get; set; }    // Пункт отправления
        public string EndPoint { get; set; }      // Пункт назначения
        public DateTime Date { get; set; }        // Дата и время поездки
        public TimeSpan Duration { get; set; }    // Длительность поездки
        public decimal Cost { get; set; }         // Стоимость (в рублях)

        // Внешние ключи
        public int DriverId { get; set; }
        public int UserId { get; set; }

        // Навигационные свойства
        public Driver Driver { get; set; }       // Водитель
        public User User { get; set; }           // Пассажир
    }
}