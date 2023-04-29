using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_rondanet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                wsRondanet.RondanetClient ws = new wsRondanet.RondanetClient();
                //recuperamo los pedidos del WS de Rondanet
                string[] sRespuesta = ws.obtenerMensajes("user", "pass", "xml");
                Console.WriteLine(sRespuesta[0]);
                Console.ReadLine();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
