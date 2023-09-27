using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjEvaluaciones
{
    public class PromedioProgramacion:Promedio
    {
        public double PromedioRegular()
        {
            double suma = 0;
            for (int i = 0; i < 4; i++)
            {

                suma += evaluEstudiante[i];


            }
            return (double)suma / 4;
        }
        public double PromedioPregrado()
        {
            double eva1 = evaluEstudiante[0]*0.012;
            double eva2 = evaluEstudiante[1]*0.0225;
            double eva3 = evaluEstudiante[2]*0.033;
            double aptitud = evaluEstudiante[3]*0.1;
            return eva1+eva2+ eva3+aptitud/4;

        }
    }
}
