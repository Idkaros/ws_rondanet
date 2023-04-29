using System;
using System.Xml.Serialization;
using ws_rondanet.wsRondanet;

namespace ws_rondanet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RondanetClient ws = new RondanetClient();
                //recuperamo los pedidos del WS de Rondanet
                string[] sRespuesta = ws.obtenerMensajes("user", "pass", "xml");
                Console.WriteLine(sRespuesta[0]);
                XmlSerializer serializer = new XmlSerializer(typeof(EnvelopeRonda));
                EnvelopeRonda XmlRondanet;
                using (System.IO.TextReader reader = new System.IO.StringReader(sRespuesta[0]))
                {
                    XmlRondanet = (EnvelopeRonda)serializer.Deserialize(reader);
                }
                Console.ReadLine();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
