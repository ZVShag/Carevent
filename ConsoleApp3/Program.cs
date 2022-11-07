
using ConsoleApp3;

static void Main(string[] args)
        {
            List<Car> zaezd = new List<Car> {new Car {
         Model = Console.ReadLine(),
         Fio = Console.ReadLine(),
         max_speed = int.Parse(Console.ReadLine())
         },
         new Car {
         Model = Console.ReadLine(),
         Fio = Console.ReadLine(),
         max_speed = int.Parse(Console.ReadLine())
         },
         new Car {
         Model = Console.ReadLine(),
         Fio = Console.ReadLine(),
         max_speed = int.Parse(Console.ReadLine())
         },
         new Car {
         Model = Console.ReadLine(),
         Fio = Console.ReadLine(),
         max_speed = int.Parse(Console.ReadLine())
         },
 };
            Rally Dakar = new Rally();
            foreach (Car i in zaezd)
            {
                Car.finishEvent += i.Time;
            }
            teacher.Exam("Math");
        }
    }
}