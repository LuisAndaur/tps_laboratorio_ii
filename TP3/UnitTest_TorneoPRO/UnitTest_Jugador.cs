using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_TorneoPRO;
using System.Collections.Generic;

namespace UnitTest_TorneoPRO
{
    [TestClass]
    public class UnitTest_Jugador
    {
        /// <summary>
        /// Prueba que el campeon retorna null
        /// </summary>
        [TestMethod]
        public void TestCampeon_RecibeListavacia_RetornaNull()
        {
            List<Jugador> lista = new List<Jugador>();
            Jugador campeon;

            campeon = Jugador.Campeon(lista);

            Assert.IsNull(campeon);
        }
    }
}
