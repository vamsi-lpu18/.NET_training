using System;
using System.Text.RegularExpressions;

class Shipment
{
    public string ShipmentCode { get; set; }
    public string TransportMode { get; set; }
    public double Weight { get; set; }
    public int StorageDays { get; set; }
}

class ShipmentDetails : Shipment
{
    public bool ValidateShipmentCode()
    {
        string pat = @"^GC#\d{4}$";
        return Regex.IsMatch(ShipmentCode, pat);
    }

    public double CalculateTotalCost()
    {
        double rpk = 0;

        switch (TransportMode)
        {
            case "Sea":
                rpk = 15.0;
                break;
            case "Air":
                rpk = 50.0;
                break;
            case "Land":
                rpk = 25.0;
                break;
            default:
                return 0.0;
        }

        double cost = (Weight * rpk) + Math.Sqrt(StorageDays);
        return Math.Round(cost, 2);
    }
}

class Program
{
    public static void Main()
    {
        ShipmentDetails shipment = new ShipmentDetails();

        Console.WriteLine("Enter shipment code:");
        shipment.ShipmentCode = Console.ReadLine();

        if (!shipment.ValidateShipmentCode())
        {
            Console.WriteLine("Invalid shipment code");
            return;
        }

        Console.WriteLine("Enter transport mode:");
        shipment.TransportMode = Console.ReadLine();

        Console.WriteLine("Enter weight:");
        shipment.Weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter storage days:");
        shipment.StorageDays = int.Parse(Console.ReadLine());

        Console.WriteLine($"The total shipping cost is {shipment.CalculateTotalCost():F2}");
    }
}
