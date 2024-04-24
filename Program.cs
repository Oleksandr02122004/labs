using System;
using System.Text;

class Planet
{
    public string Name;
    public string Galaxy;
    public double Diameter; // діаметр планети
    public double Gravity; // гравітація планети
    public double Temperature; // середня температура планети
    public bool Rings; // наявність кілець
    public bool Field; // наявність магнітного поля
    public bool Habited; // чи заселена планета
    

    public double CVolume()
    {
        return (4 / 3) * Math.PI * Math.Pow(Diameter / 2, 3);
    }
   
    //public string GetPlanetType()
    //{
    //    // реалізація методу для визначення типу планети
    //    if (Diameter >= 13000)
    //        return "Газовий гігант";
    //    else if (Diameter >= 5000)
    //        return "Лише планета";
    //    else
    //        return "Супутник або карликова планета";
    //}

    public void DisplayPlanetInfo()
    {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Галактика: {Galaxy}");
        Console.WriteLine($"Діаметр: {Diameter} км");
        Console.WriteLine($"Гравітація: {Gravity} м/с²");
        Console.WriteLine($"Середня температура: {Temperature} °C");
        Console.WriteLine($"Має кільця: {(Rings ? "Так" : "Ні")}");
        Console.WriteLine($"Має магнітне поле: {(Field ? "Так" : "Ні")}");
        Console.WriteLine($"Планета заселена: {(Habited ? "Так" : "Ні")}");
    }

   
    
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть інформацію про планету:");
      
        Console.Write("Введіть назву планети: ");
        string name = Console.ReadLine();

        Console.Write("Введіть назву галактики: ");
        string galaxy = Console.ReadLine();

        Console.Write("Введіть діаметр планети (у кілометрах): ");
        double diameter = double.Parse(Console.ReadLine());

        Console.Write("Введіть гравітацію планети (у м/с²): ");
        double gravity = double.Parse(Console.ReadLine());


        Console.Write("Введіть середню температуру планети (у °C): ");
        double temperature = double.Parse(Console.ReadLine());


        Console.Write("Чи має планета кільця (так/ні): ");
        bool rings = Console.ReadLine().ToLower() == "так";

        Console.Write("Чи має планета магнітне поле (так/ні): ");
        bool field = Console.ReadLine().ToLower() == "так";

        Console.Write("Чи заселена планета (так/ні): ");
        bool habited = Console.ReadLine().ToLower() == "так";

        Planet planet = new Planet();

        planet.Diameter = diameter;
        planet.Temperature=temperature;
        planet.Habited= habited;
        planet.Name = name;
        planet.Galaxy = galaxy;
        planet.Rings = rings;
        planet.Gravity = gravity;
        planet.Field = field;   

       
        Console.WriteLine("\nІнформація про планету:");
        planet.DisplayPlanetInfo();
        Console.WriteLine("\nОбчислення об'єму планети:");
        double volume = planet.CVolume();
        Console.WriteLine($"Об'єм планети: {volume} куб. км");

        
    }
}
