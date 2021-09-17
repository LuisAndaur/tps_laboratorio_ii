using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor inicializa a numero en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Construye la entidad con el valor numero
        /// </summary>
        /// <param name="numero">Valor para construir la entidad</param>
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Covierte un string a double correctamente
        /// </summary>
        /// <param name="strNumero">Numero string a convertir</param>
        public Operando(string strNumero) : this()
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Valida el número y lo setea
        /// </summary>
        private string Numero
        {
            set { this.numero = ValidarOperando(value); }            
        }

        /// <summary>
        /// Convierte un número binario a decimal
        /// </summary>
        /// <param name="binario">Número tipo string a convertir</param>
        /// <returns>Retorna el numero convertido a decimal</returns>
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                double numeroASumar = 0;
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] == '1')
                    {
                        int len = binario.Length - 1 - i;
                        numeroASumar += Math.Pow(2, len);
                    }
                }
                return numeroASumar.ToString();
            }
            return "Valor inválido";           
        }

        /// <summary>
        /// Convierte un número decimal tipo double a binario tipo string
        /// </summary>
        /// <param name="numero">Número a convertir</param>
        /// <returns>Número binario tipo string sino el mensaje valor inválido</returns>
        public string DecimalBinario(double numero)
        {
            int auxNumero;
            auxNumero = (int)numero;
            if (auxNumero > -1)
            {
                string binario = string.Empty;
                while (auxNumero > 0)
                {
                    binario = (auxNumero % 2).ToString() + binario;
                    auxNumero = (int)auxNumero / 2;
                }
                return binario;
            }
            return "Valor inválido";
        }

        /// <summary>
        /// Convierte un número decimal string a binario tipo string
        /// </summary>
        /// <param name="numero">Número tipo string a convertir</param>
        /// <returns>Número binario tipo string sino el mensaje valor inválido</returns>
        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double auxNumero))
            {
                return DecimalBinario(auxNumero);
            }
            return "Valor inválido";
        }

        /// <summary>
        /// Conprueba si el dato tipo string este cargado sólo con 0 y/o 1
        /// </summary>
        /// <param name="binario">String a analizar</param>
        /// <returns>True si sólo contiene 0 y/o 1, false si no respeta la condición</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Sobrecarga el operador + sumando Objetos tipo Operando
        /// </summary>
        /// <param name="n1">Primer número a sumar</param>
        /// <param name="n2">Segundo número a sumar</param>
        /// <returns>La suma de ambos números</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador - restando Objetos tipo Operando
        /// </summary>
        /// <param name="n1">Primer número a restar</param>
        /// <param name="n2">Segundo número a restar</param>
        /// <returns>La resta de ambos números</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador * multiplicando Objetos tipo Operando
        /// </summary>
        /// <param name="n1">Primer número a multiplicar</param>
        /// <param name="n2">Segundo número a multiplicar</param>
        /// <returns>La multiplicacion de ambos números</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador / dividiendo Objetos tipo Operando
        /// </summary>
        /// <param name="n1">Primer número a dividir</param>
        /// <param name="n2">Segundo número a dividir</param>
        /// <returns>Si n2 es distinto de 0 la división de ambos números, sino double.MaxValue</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;            
        }

        /// <summary>
        /// Comprueba si el dato recibido es un número, y lo retorna como tipo double
        /// </summary>
        /// <param name="strNumero">Dato tipo string a validar si es número</param>
        /// <returns>Si es un número retorna el dato tipo double, si no es número retorna 0</returns>
        private double ValidarOperando(string strNumero)
        {
            if (!double.TryParse(strNumero, out double auxNumero))
            {
                return 0;
            }
            return auxNumero;
        }

    }
}
