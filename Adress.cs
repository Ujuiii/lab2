using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


 public class Address
{
    public int Index = 550;
    public string Country = "Ukraine";
    public string City = "Kiev";
    public string Street = "Popudrenka street";
    public int House = 3;
    public int Apartment = 12;

    private int IndexP = 550;
    private string CountryP = "Ukraine";
    private string CityP = "Kiev";
    private string StreetP = "Popudrenka street";
    private int HouseP = 3;
    private int ApartmentP = 12;
   
   
}
class Address1
{
    public string Eaddress = "qwerty123@gmail.com";
    static void Main(string[] args)
    {
       Address someAddress = new Address();
       Console.WriteLine($"country: {someAddress.Country};\nindex : {someAddress.Index};\ncity: {someAddress.City};\nstreet: {someAddress.Street};\nhouse: {someAddress.House};\napartment: {someAddress.Apartment}\n ");
       Console.ReadKey();
    }
}

