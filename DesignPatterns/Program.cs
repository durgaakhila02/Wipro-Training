using System;
using DesignPatternsAssignment.Singleton;
using DesignPatternsAssignment.Factory;
using DesignPatternsAssignment.Observer;

class Program
{
    static void Main()
    {
        // Singleton demo
        Logger logger = Logger.Instance;
        logger.Log("Application Started");

        // Factory demo
        IDocument pdf = DocumentFactory.CreateDocument("PDF");
        pdf.Open();

        IDocument word = DocumentFactory.CreateDocument("WORD");
        word.Open();

        // Observer demo
        WeatherStation station = new WeatherStation();
        WeatherDisplay display1 = new WeatherDisplay("Display 1");
        WeatherDisplay display2 = new WeatherDisplay("Display 2");

        station.RegisterObserver(display1);
        station.RegisterObserver(display2);

        station.SetTemperature(30.5f);
        station.SetTemperature(28.0f);
    }
}
