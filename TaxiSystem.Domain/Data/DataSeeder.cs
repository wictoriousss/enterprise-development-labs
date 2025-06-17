using System;
using System.Collections.Generic;
using System.Linq;
using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.InMemory;

namespace TaxiSystem.Domain.Data
{
    // Простой контекст для тестирования
    public class TaxiSystemDbContext
    {
        public DriverRepository Drivers { get; } = new DriverRepository();
        public CarRepository Cars { get; } = new CarRepository();
        public UserRepository Users { get; } = new UserRepository();
        public TripRepository Trips { get; } = new TripRepository();

        public void SaveChanges()
        {
            // В InMemory-репозиториях не требуется реальное сохранение
        }
    }

    public static class DataSeeder
    {
        public static void Seed(TaxiSystemDbContext context)
        {
            if (!context.Drivers.GetDrivers().Any())
            {
                // Добавление водителей
                var drivers = new List<Driver>
                {
                    new Driver
                    {
                        FullName = "Иванов Иван Иванович",
                        PassportNumber = "4501123456",
                        Address = "г. Москва, ул. Ленина, д. 10",
                        Phone = "+79001234567"
                    },
                    new Driver
                    {
                        FullName = "Петров Петр Петрович",
                        PassportNumber = "4501654321",
                        Address = "г. Москва, ул. Пушкина, д. 5",
                        Phone = "+79007654321"
                    }
                };
                drivers.ForEach(d => context.Drivers.Add(d));

                // Добавление автомобилей
                var cars = new List<Car>
                {
                    new Car
                    {
                        LicensePlate = "А123БВ777",
                        Model = "Toyota Camry",
                        Color = "Черный",
                        DriverId = drivers[0].Id
                    },
                    new Car
                    {
                        LicensePlate = "У456КХ123",
                        Model = "Hyundai Solaris",
                        Color = "Белый",
                        DriverId = drivers[1].Id
                    }
                };
                cars.ForEach(c => context.Cars.Add(c));

                // Добавление пользователей
                var users = new List<User>
                {
                    new User
                    {
                        FullName = "Сидоров Алексей",
                        Phone = "+79161234567"
                    },
                    new User
                    {
                        FullName = "Кузнецова Мария",
                        Phone = "+79169876543"
                    }
                };
                users.ForEach(u => context.Users.Add(u));

                // Добавление поездок
                var trips = new List<Trip>
                {
                    new Trip
                    {
                        StartPoint = "ул. Тверская, д. 1",
                        EndPoint = "Красная площадь",
                        Date = DateTime.Now.AddDays(-5),
                        Duration = TimeSpan.FromMinutes(15),
                        Cost = 350.50m,
                        DriverId = drivers[0].Id,
                        UserId = users[0].Id
                    },
                    new Trip
                    {
                        StartPoint = "м. Охотный ряд",
                        EndPoint = "аэропорт Шереметьево",
                        Date = DateTime.Now.AddDays(-2),
                        Duration = TimeSpan.FromMinutes(45),
                        Cost = 1200.00m,
                        DriverId = drivers[1].Id,
                        UserId = users[1].Id
                    }
                };
                trips.ForEach(t => context.Trips.Add(t));

                context.SaveChanges();
            }
        }

       
    }
}