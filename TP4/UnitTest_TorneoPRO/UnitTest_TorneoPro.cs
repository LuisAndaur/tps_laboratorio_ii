using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_TorneoPRO;

namespace UnitTest_TorneoPRO
{
    [TestClass]
    public class UnitTest_TorneoPro
    {
        /// <summary>
        /// Prueba del metodo agregar jugador que no exista el numero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception_NroJugadorYaExiste))]
        public void TestAgregarJugador_NroJugadorExiste_RetornaExceptionNroJugadorYaExiste()
        {
            string nroJugador = "1111";
            string nombre = "Perla";
            string edad = "20";
            string genero = "Female";
            string nacionalidad = "Argentina";
            string especialidad = "S";
            bool primerTorneo = true;

            TorneoPro.AgregarJugador(nroJugador, nombre, edad, genero, nacionalidad, especialidad, primerTorneo);            
        }

        /// <summary>
        /// Prueba el metodo que comprueba si existe jugador
        /// </summary>
        [TestMethod]
        public void TestExisteJugador_RecibeNroJugador_RetornaFalseSiNoExiste()
        {
            int nroJugador = 1;
            bool existe;

            existe = TorneoPro.ExisteJugador(nroJugador);

            Assert.IsFalse(existe);
        }

        /// <summary>
        /// Prueba del metodo editar jugador que la edad esta fuera de rango
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception_EdadInvalida))]
        public void TestEditarJugador_NroJugadorExiste_RetornaExceptionNroJugadorYaExiste()
        {
            Jugador j1 = new Jugador(1234, "Pedro", 11, "Male", "Peru", "S", false);              

            TorneoPro.EditarJugador(j1);
        }
    }
}
