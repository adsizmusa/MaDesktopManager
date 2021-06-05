using MaDesktopManager.Models;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaDesktopManager.Services

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




    }
}
