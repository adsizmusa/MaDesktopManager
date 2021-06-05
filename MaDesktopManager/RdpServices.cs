using MaDesktopManager.Models;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaDesktopManager
{
   public class RdpServices
    {
       
        public void ConnectRdpServer(RdpClientModel rdpClientModel)
        {
          


            Process rdcProcess = new Process();
            rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
            rdcProcess.StartInfo.Arguments = $"/generic:TERMSRV/{rdpClientModel.ServerIpAddress} /user: {rdpClientModel.ServerUserName} /pass: { rdpClientModel.Password}";
            rdcProcess.Start();

            rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
            rdcProcess.StartInfo.Arguments = $"/v {rdpClientModel.ServerIpAddress}"; // ip or name of computer to connect
            rdcProcess.Start();
        }

        public void AddServer(RdpClientModel rdpClientModel)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(rdpClientModel);
            var serversSettings = MaDesktopManager.Properties.Settings.Default.servers;

            if(serversSettings==null)
            {
                StringCollection list = new StringCollection();

                list.Add(json);
                MaDesktopManager.Properties.Settings.Default.servers = list;
            }
            else
            {
                MaDesktopManager.Properties.Settings.Default.servers.Add(json);
            }

        }

        public List<RdpClientModel> GetServer()
        {
            var serversSettings = MaDesktopManager.Properties.Settings.Default.servers;

            List<RdpClientModel> servers = new List<RdpClientModel>();

            foreach (var item in serversSettings)
            {
                var server = Newtonsoft.Json.JsonConvert.DeserializeObject<RdpClientModel>(item);
                servers.Add(server);
            }
            return servers;
        }
    }
}
