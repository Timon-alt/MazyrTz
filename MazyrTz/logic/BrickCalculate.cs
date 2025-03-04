using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazyrTz.logic
{
    internal class BrickCalculate
    {
        public double Calculate_Amount_Bricks(double length_wall, double width_wall, double thickness_wall, string type_brick)
        {
            double t = 1; // толщина кирпича
            double l = 1; // длина кирпича
            double h = 1; // высота кирпича
            
            switch(type_brick)
            {
                case "Керамический":
                    t = 1;
                    l = 2.5;
                    h = 1.2;
                    t = 0.65;
                    break;
                case "Силикатный":
                    t = 1.25;
                    l = 2.8;
                    h = 1.5;
                    t = 0.8;
                    break;
                case "Огнеупорный":
                    t = 1.75;
                    l = 2.8;
                    h = 1.5;
                    t = 1;
                    break;
            }
            double bricks_amount = Math.Round(((length_wall * width_wall * thickness_wall) / (l + 0.01) * (h + 0.01) * (t + 0.01)) * 1.1);
            return bricks_amount;
        }
    }
}
