namespace TASKClass
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery = new Gallery();
            int choise;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Car elave etmek.");
                Console.WriteLine("2.Butun Car'lara baxmaq.");
                Console.WriteLine("3.ID ile axtaris.");
                Console.WriteLine("4.CarCode ile axtaris.");
                Console.WriteLine("5.Speed'e gore axtaris.");
                Console.WriteLine("0. Proqrami bitir");
                int.TryParse(Console.ReadLine(), out choise);
                switch (choise)
                {
                    case 1:
                        Car[] car = new Car[0];
                        Console.WriteLine("Name:");
                        string name = Console.ReadLine();

                        string speedStr = "";
                        int speed;
                        do
                        {
                            Console.WriteLine("Speed:");
                            speedStr = Console.ReadLine();
                        } while (!int.TryParse(speedStr, out speed));
                        Console.WriteLine("CarCode:");
                        string carCode = Console.ReadLine();
                        gallery.AddCAr(new Car(1, name, speed, carCode));
                        break;
                    case 2:
                        gallery.ShowAllCars();
                        break;
                    case 3:
                        Console.WriteLine("ID daxil edin:");
                        int id;
                        int.TryParse(Console.ReadLine(), out id);
                        Car foundcar = gallery.FindCarById(id);
                        if (foundcar != null)
                        {
                            Console.WriteLine($" ID:{foundcar.Id},Name:{foundcar.Name}, Speed:{foundcar.Speed}, CarCode:{foundcar.CarCode}");
                        }
                        else
                        {
                            Console.WriteLine("Bu ID ile masin yoxdu");
                        }

                        break;
                    case 4:
                        Console.WriteLine("CarCode daxil et:");
                        string carcode = Console.ReadLine();
                        Car searchedcar = gallery.FindCarByCarCode(carcode);
                        if (searchedcar != null)
                        {
                            Console.WriteLine($" ID:{searchedcar.Id},Name:{searchedcar.Name}, Speed:{searchedcar.Speed}, CarCode:{searchedcar.CarCode}");
                        }
                        else
                        {
                            Console.WriteLine("Bu carcode ile masin yoxdu");
                        }
                        break;
                    case 5:

                        string minSpeedStr = "";
                        int minSpeed;
                        do
                        {
                            Console.WriteLine("min speed daxil et:");
                            minSpeedStr = Console.ReadLine();
                        } while (!int.TryParse(minSpeedStr, out minSpeed));
                        string maxSpeedStr = "";
                        int maxSpeed;
                        do
                        {
                            Console.WriteLine("max speed daxil et:");
                            maxSpeedStr = Console.ReadLine();
                        } while (!int.TryParse(maxSpeedStr, out maxSpeed));
                        Car[] newcars = gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed);
                        for (int i = 0; i < newcars.Length; i++)
                        {
                            Car newcar = newcars[i];
                            gallery.ShowAllCars();
                        }
                        break;
                    case 0:
                        Console.WriteLine(" Proqram bitdi");
                        break;
                    default:
                        Console.WriteLine("Duzgun eded daxil edin");
                        break;
                }
            } while (choise != 0);
        }
    }
}