using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class PhepToan
    {
        public string GiaiPhuongTrinhBacHai(double a, double b, double c, ref double x1, ref double x2)
        {
            double denta;
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        return "Phương trình vô số nghiệm";
                    else
                        return "Phương trình vô nghiệm";
                else
                {
                    x1 = c / b;
                    return "Phương trình có 1 nghiệm";
                }
            else
            {
                denta = b * b - 4 * a * c;
                if (denta < 0)
                    return "Phương trình vô nghiệm";
                else
                    if (denta == 0)
                {
                    x1 = -b / (2 * a);
                    return "Phương trình có 1 nghiệm";
                }
                else
                {
                    x1 = (b + Math.Sqrt(denta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(denta)) / (2 * a);
                    return "Phương trình có 2 nghiệm";
                }
            }
        }
        public string GiaiHPTBacNhat2An(double a1, double b1, double c1, double a2, double b2, double c2, ref double x, ref double y)
        {
            double d, d1, d2;
            d = a1 * b2 - a2 * b1;
            d1 = c1 * b2 - c2 * b1;
            d2 = a1 * c2 - a2 * c1;
            if ((d == 0) && (d1 == 0) && (d2 == 0))
                return "Hệ phương trình vô số nghiệm";
            else if (((d == 0) && (d1 != 0) && (d2 != 0)))
                return "Hệ phương trình vô nghiệm";
            else
            {
                x = d1 / d;
                y = d2 / d;
                return "Hệ phương trình có 1 nghiệm";

            }
        }
        public string GiaiHPTBacNhat3An(double a1, double b1, double c1, double d1, double a2, double b2, double c2, double d2, double a3, double b3, double c3, double d3, ref double x, ref double y, ref double z)
        {
            double d, dx, dy, dz;
            d = a1 * b2 * c3 - a1 * c2 * b3 + b1 * a2 * c3 - b1 * c2 * a3 + c1 * a2 * b3 - c1 * a3 * b2;
            dx = d1 * b2 * c3 - d1 * c2 * b3 + b1 * d2 * c3 - b1 * c2 * d3 + c1 * d2 * b3 - c1 * d3 * b2;
            dy = a1 * d2 * c3 - a1 * c2 * d3 + d1 * a2 * c3 - d1 * c2 * a3 + c1 * a2 * d3 - c1 * a3 * d2;
            dz = a1 * b2 * d3 - a1 * d2 * b3 + b1 * a2 * d3 - b1 * d2 * a3 + d1 * a2 * b3 - d1 * a3 * b2;
            if (d == 0 && dx == 0 && dy == 0 && dz == 0)
                return "Hệ phương trình vô số nghiệm";
            if (d == 0)
                if (dx != 0 || dy != 0 || dz != 0)
                    return "Hệ phương trình vô nghiệm";
                else if (d != 0)
                {
                    x = dx / d;
                    y = dy / d;
                    z = dz / d;

                }
            return "Hệ phương trình có 1 nghiệm";

        }


    }
}
