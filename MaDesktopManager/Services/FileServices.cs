using MaDesktopManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaDesktopManager.Services
{
    public class FileServices
    {
        string folder = @"C:\MADesktopManager\";
        string fileName = "settings.txt";
        string fullPath => folder + fileName;
        public void CreateDirectory()
        {
        
            if (!File.Exists(fullPath))
            {
                System.IO.Directory.CreateDirectory(folder);
                File.Create(fullPath);
            }
        }
        public void   setSetting(List<RdpClientModel> server)
        {
            CreateDirectory();

            List<string> model = new List<string>();
            foreach (var item in server)
            {
                var setting = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                model.Add(setting);
            }
             File.WriteAllLines(fullPath, model);
        }

        public List<RdpClientModel> getServers()
        {
            List<RdpClientModel> servers = new List<RdpClientModel>();
            var settings = Properties.Settings.Default.servers;
            if (settings ==null)
            {
                if (File.Exists(fullPath))
                {
                    string[] lines = File.ReadAllLines(fullPath);
                    foreach (var item in lines)
                    {
                        var model = Newtonsoft.Json.JsonConvert.DeserializeObject<RdpClientModel>(item);
                        servers.Add(model);
                    }
                }

            }
            return servers;
        }
    }
}
