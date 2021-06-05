using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaDesktopManager.Models
{
   public class RdpClientModel
    {
        public int id { get; set; }
        public string ServerName { get; set; }
        public string ServerIpAddress { get; set; }
        public string ServerUserName { get; set; }
        public string Password { get; set; }
    }
}
