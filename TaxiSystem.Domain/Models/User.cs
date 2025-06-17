using System.Collections.Generic;

namespace TaxiSystem.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Phone { get; set; }         // Телефон (уникальный идентификатор)
        public string FullName { get; set; }      // ФИО

        // Навигационное свойство (один пассажир — много поездок)
        public List<Trip> Trips { get; set; } = new List<Trip>();
    }
}