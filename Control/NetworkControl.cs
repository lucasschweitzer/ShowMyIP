using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShowMyIP.Control
{
    internal class NetworkControl
    {
        public Boolean getNetworkIpAddress()
        {
            Boolean ret = false;

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            // Get the host name of the local machine
            string hostName = Dns.GetHostName();

            // Resolve the host name to an IP address
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);
            // Display only IPv4 addresses associated with the local machine
            foreach (IPAddress addr in addresses)
            {
                if (addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    foreach (NetworkInterface netInterface in networkInterfaces)
                    {
                        // Check if the IP address belongs to this network interface
                        foreach (UnicastIPAddressInformation ip in netInterface.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.Equals(addr))
                            {
                                MessageBox.Show($"Adaptador de Rede: {netInterface.Name}, IP: {addr}", "Seu IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ret = true;
                                break;
                            }
                        }
                    }
                }
            }
            return ret;
        }
    }
}
