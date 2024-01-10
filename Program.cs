// See https://aka.ms/new-console-template for more information
using ConAppAssignment4;

List<Product> products = new List<Product>()
{
    new Product() { PId = 1, PName = " Shampoo", Pprice = 156.30,PBrand="Herbal", MfgDate = new DateTime(day: 11, month: 1, year: 2021),ExpDate=new DateTime(day:11,month:1,year:2022) },
    new Product() { PId = 2, PName = "Soap", Pprice = 56.70,PBrand="Herbal", MfgDate = new DateTime(day: 10, month: 10, year: 2021),ExpDate=new DateTime(day:10,month:10,year:2022) },
    new Product() { PId = 3, PName = " Honey", Pprice = 456.90,PBrand="Herbal", MfgDate = new DateTime(day: 06, month: 01, year: 2024),ExpDate=new DateTime(day:06,month:01,year:2025) },
    new Product() { PId = 4, PName = " Protein", Pprice = 1156.80,PBrand="Herbal", MfgDate = new DateTime(day: 18, month: 11, year: 2011),ExpDate=new DateTime(day:18,month:11,year:2021)},
    new Product() { PId = 5, PName = " BodyWash", Pprice = 456.20,PBrand="Herbal", MfgDate = new DateTime(day: 11, month: 12, year: 2001),ExpDate= new DateTime(day:11,month:12,year:2012) },
};
Console.WriteLine("PId\t PName\t Pprice\t PBrand\t MfgDate\t ExpDate\t");
foreach (Product product in products)
{
    Console.WriteLine(product.PId+"\t \t");
    Console.WriteLine(product.PName + "\t \t");
    Console.WriteLine(product.Pprice + "\t \t");
    Console.WriteLine(product.PBrand + "\t \t");
    Console.WriteLine(product.MfgDate + "\t \t");
    Console.WriteLine(product.ExpDate+ "\t \t");
    Console.WriteLine("\n");
}

    
    