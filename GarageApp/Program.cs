using System;
using GarageLibrary;

namespace GarageApp
{
    // Главный класс приложения GarageApp (Автор: Бережной Кирилл)
    class Program
    {
        static void Main(string[] args)
        {
  
            Garage garage = new Garage("ул. Ленина, 1");


            garage.AddCar(new Car("Иванов И.И.", "А123БВ77"));
            garage.AddCar(new Car("Петров П.П.", "С456ДЕ99"));
            garage.AddCar(new Car("Сидоров С.С.", "К789МН150"));
            garage.AddCar(new Car("Алексеев А.А.", "Р012СТ199"));

        
            Console.WriteLine("Вывод автомобилей отсортированных по номеру:");
            garage.ShowAll((car1, car2) => String.Compare(car1.Number, car2.Number, StringComparison.Ordinal));


            Console.WriteLine("\nВывод всех автомобилей:");
            garage.ShowAll();

            Console.ReadKey();

        }
    }
}
