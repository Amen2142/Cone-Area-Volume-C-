/* Project:         Assignment Set 1 - Program 2
 * Date created:    September 8, 2020
 * Date modified:   September 13, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      Cone   
 * Description:     Business Logic class for calculating the area and volume of a cone
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZineddinProgram1
{
    class Cone
    {
        //Calculate and return the surface area of cone
        public double CalculateArea(int Radius, int Height)
        {
            return Math.PI * Radius * (Radius + Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2)));
        }

        //Calculate and return the volume of cone
        public double CalculateVolume(int Radius, int Height)
        {
            return Math.PI * Math.Pow(Radius, 2) * Height / 3;
        }
    }
}
