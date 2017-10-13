using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWP_NeubertBrandon
{
    class CustWindow
    {
        public double width { get; set; }
        public double height { get; set; }
        public double woodLength { get; set; }
        public double glassArea { get; set; }
        public int quantity { get; set; }
        public MainPage.Color ColorSelection { get; set; }
        public DateTime CurrentDate { get; set; }
        public static object Current { get; internal set; }

        public CustWindow(double width, double height, double woodLength, double glassArea, int quantity, MainPage.Color colorSelection, DateTime currentDate)
        {
            this.width = width;
            this.height = height;
            this.woodLength = woodLength;
            this.glassArea = glassArea;
            this.quantity = quantity;
            ColorSelection = colorSelection;
            CurrentDate = currentDate;
        }
    }

    
}
