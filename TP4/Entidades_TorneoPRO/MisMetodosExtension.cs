using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public static class MisMetodosExtension
    {
        public static string MiFormato(this string dato, string titulo, int num1, float por1, int num2, float por2)
        {
            return String.Format("{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo, num1, por1, num2, por2);
        }

        public static string MiFormato2(this string dato, string titulo, int num1, float por1, int num2, float por2)
        {
            return String.Format("{0,-20}{1,5} | {2,5:00.000}  ||{3,5} | {4,5:00.000}", titulo, num1, por1, num2, por2);
        }



    }
}
