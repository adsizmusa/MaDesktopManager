using MaDesktopManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static MaDesktopManager.Services.EncryptString;

namespace MaDesktopManager.Services
{
    public class FileServices
    {
        string folder = @"C:\MADesktopManager\";
        string fileName = "servers.txt";
        string password => getPassword();
        string fullPath => folder + fileName;

        public FileServices()
        {
           

        }

        public string getPassword()
        {
            var password =
               (
                   from nic in NetworkInterface.GetAllNetworkInterfaces()
                   where nic.OperationalStatus == OperationalStatus.Up
                   select nic.GetPhysicalAddress().ToString()
               ).FirstOrDefault();
            return password +"Desjsdjs8457e92" + Environment.MachineName;
        }
        public void CreateDirectory()
        {

            if (!File.Exists(fullPath))
            {
                System.IO.Directory.CreateDirectory(folder);
                var myFile = File.Create(fullPath);
                myFile.Close();
            }
        }
        public void setSetting(List<RdpClientModel> server)
        {

            CreateDirectory();
            List<string> model = new List<string>();
            foreach (var item in server)
            {
                try
                {
                    var setting = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                    string encryptedString = StringCipher.Encrypt(setting, password);
                    model.Add(encryptedString);
                }
                catch (Exception ex)
                {


                }

            }
            File.WriteAllLines(fullPath, model);
        }

        public List<RdpClientModel> getServers()
        {
            CreateDirectory();
            List<RdpClientModel> servers = new List<RdpClientModel>();
            var settings = Properties.Settings.Default.servers;
            if (settings == null)
            {
                if (File.Exists(fullPath))
                {
                    string[] lines = File.ReadAllLines(fullPath);
                    foreach (var item in lines)
                    {
                        try
                        {
                            var sds = Environment.CurrentManagedThreadId;
                            string decryptdString = StringCipher.Decrypt(item, password);
                            var model = Newtonsoft.Json.JsonConvert.DeserializeObject<RdpClientModel>(decryptdString);
                            servers.Add(model);
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                }

            }
            return servers;
        }
    }
}
