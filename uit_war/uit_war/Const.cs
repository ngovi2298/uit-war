using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace uit_war
{
    class Const
    {
        public static IPAddress IP = IPAddress.Parse(Both.GetLocalIPv4_v2());
        public static int PORT = 9999;
        public static Client client=new Client();
        public static Server server=new Server();
    }
}
