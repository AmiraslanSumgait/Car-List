using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List_Winform
{
    public partial class Form1 : Form
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public int Index { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Cars.Add(new Car(Properties.Resources.Bmw_m4, "M4", "Bmw", 2020, 3.1));
            Cars.Add(new Car(Properties.Resources.Hyundai_Elantra, "Elantra", "Hyundai", 2013, 1.8));
            Cars.Add(new Car(Properties.Resources.Lexus_Rx350, "Rx350", "Lexus", 2015, 3.5));
            Cars.Add(new Car(Properties.Resources.Mercedes_Benz_Cls, "Cls", "Mercedes Benz", 2018, 4.7));
            Cars.Add(new Car(Properties.Resources.Kia_Sportage, "Sportage", "Kia", 2019, 3.4));
            Cars.Add(new Car(Properties.Resources.Ford_Focus, "Focus", "Ford", 2020, 2.3));

        }

        private void btn_ChangeCar_Click(object sender, EventArgs e)
        {
            if (Index == Cars.Count) Index = 0;
            lbl_Model.Text = Cars[Index].Model;
            lbl_Vendor.Text = Cars[Index].Vendor;
            lbl_Year.Text = Cars[Index].Year.ToString();
            lbl_Engine.Text = Cars[Index].Engine.ToString();
            picbox_Car.Image = Cars[Index].Picture;
            Index += 1;
        }
    }
}
