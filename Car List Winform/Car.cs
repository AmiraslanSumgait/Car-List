using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_List_Winform
{
    public class Car
    {
        public Image Picture { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public double Engine { get; set; }
        public string Vendor { get; set; }
        public Car(Image picture,string model, string vendor, int year, double engine )
        {
            Model = model;
            Vendor = vendor;
            Engine = engine;
            Picture = picture;
            Year = year;
        }
       
    }
}
