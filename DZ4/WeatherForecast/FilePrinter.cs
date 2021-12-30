using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WeatherForecast
{
    public class FilePrinter : IPrinter
    {
        private string filePath;

        public FilePrinter(string filePath)
        {
            this.filePath = filePath;
        }

        public void Print(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
