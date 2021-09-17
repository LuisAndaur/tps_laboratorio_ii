
namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza las operaciones básicas de una calculadora
        /// </summary>
        /// <param name="num1">Primer número para operar</param>
        /// <param name="num2">Segundo número para operar</param>
        /// <param name="operador">Operador seleccionado para calcular</param>
        /// <returns>El resultado de la operación realizada</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida si el operador es correcto
        /// </summary>
        /// <param name="operador">Operadores válidos: +,-,*,/.</param>
        /// <returns>El operador correcto, caso contrario el '+' por defecto </returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            return '+';
        }
    }
}
