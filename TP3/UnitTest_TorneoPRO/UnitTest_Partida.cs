using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_TorneoPRO;

namespace UnitTest_TorneoPRO
{
    [TestClass]
    public class UnitTest_Partida
    {
        /// <summary>
        /// Prueba la simulacion del torneo
        /// </summary>
        [TestMethod]
        public void TestSimularPartidas_RecibeListaJugadores_RetornaTrueSimulacionCorrecta()
        {
            Partida partida = new Partida();
            bool simulacionCorrecta;

            simulacionCorrecta = partida.SimularPartidas(TorneoPro.ListaJugadores);

            Assert.IsTrue(simulacionCorrecta);
        }
    }
}
