// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Abstractclass;


Console.WriteLine("Hello, World!");

ElectronicProduct newObject = new ElectronicProduct();
newObject.ProductID = 101;
newObject.ProductName = "Laptop";
newObject.DisplayProductNameDetails();  
newObject.ShowElectronicProductDetails();

IDiscountTable discountTable1 = new ElectronicProduct();
double discount1 = discountTable1.CalculateDiscount(50000);
Console.WriteLine("Discount on Electronic Product: " + discount1);



FurnitureProduct furniture = new FurnitureProduct();
furniture.ProductID = 201;
furniture.ProductName = "Chair";
furniture.DisplayProductNameDetails();
furniture.ShowFurnitureProductDetails();

double furnitureDiscount = furniture.CalculateDiscount(20000); // pass the price here
Console.WriteLine("Discount on Furniture Product: " + furnitureDiscount); 



class ElectronicProduct: Product
{
    public override void DisplayProductNameDetails()
    {
        Console.WriteLine("Electronic Product Name: " + ProductName);
        Console.WriteLine("Electronic Product ID: " + ProductID);
    }
     public void ShowElectronicProductDetails()
    {
        Console.WriteLine("this is an electronic product from child class");
    }
    public override double CalculateDiscount(double price)
    {
        double discountRate=0.15;
        return price * discountRate;
    }
}

class FurnitureProduct: Product
{
    public override void DisplayProductNameDetails()
    {
        Console.WriteLine("Furniture Product Name: " + ProductName);
        Console.WriteLine("Furniture Product ID: " + ProductID);
    }
    public void ShowFurnitureProductDetails()
    {
        Console.WriteLine("this is a furniture product from child class");
    }
    public  override double CalculateDiscount(double price)
    {
        double discountRate=0.15;
        return price * discountRate;
    }
}