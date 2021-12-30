using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecast
{
    public class ConsolePrinter : IPrinter
    {
        private ConsoleColor printerColor;

        public ConsolePrinter(ConsoleColor printerColor)
        {
            this.printerColor = printerColor;
        }

        public void Print(string message)
        {
            Console.ForegroundColor = this.printerColor;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
