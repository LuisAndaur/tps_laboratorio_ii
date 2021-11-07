using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_TorneoPRO;
using System.Collections.Generic;

namespace UnitTest_TorneoPRO
{
    [TestClass]
    public class UnitTest_SerializacionJson
    {
        [TestMethod]
        [ExpectedException(typeof(Exception_SerializacionJson))]
        public void TestLeer_RecibeNombreArchivo_RetornaExceptionSerializacionJson()
        {
            string archivo = "noExiste.json";

            SerializacionJson<List<Jugador>>.Leer(archivo);
        }
    }
}
