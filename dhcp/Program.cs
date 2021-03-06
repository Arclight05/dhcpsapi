﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace dhcp{
    class Program {
        static void Main(string[] args) {


            DhcpOption option = new DhcpOption();
            option.OptionID = 82;
            option.OptionComment = "test";
            option.OptionName = "TestOption";
            option.IntData = new uint[] { DhcpClient.StringToUint("172.22.249.213"), DhcpClient.StringToUint("172.22.249.214") };
            option.OptionType = DHCP_OPTION_TYPE.DhcpArrayTypeOption;
            option.OptionDataType = DHCP_OPTION_DATA_TYPE.DhcpIpAddressOption;
            DhcpOption.DhcpCreateOption("192.168.2.246", option);
            

            //List<DhcpClient> clients = DhcpClient.DhcpEnumSubnetClients("192.168.2.246", "192.168.2.0");
            //foreach (DhcpClient client in clients)
            //{
            //    Console.WriteLine(client.ClientName);
            //    Console.WriteLine(client.ClientLeaseExpires);
            //    Console.WriteLine(client.ClientIpAddress);
            //    Console.WriteLine(client.ClientComment);
            //    Console.WriteLine(client.ClientHardwareAddress);
            //    Console.WriteLine(client.OwnerHost.HostName);
            //    Console.WriteLine(client.OwnerHost.IpAddress);
            //    Console.WriteLine(client.OwnerHost.NetBiosName);
            //    Console.WriteLine(client.SubnetMask);
            //    Console.ReadLine();
            //}




            DhcpClient dhcpClient = new DhcpClient();
            dhcpClient.ClientIpAddress = "192.168.2.48";
            dhcpClient.SubnetMask = "192.168.2.0";
            dhcpClient.ClientComment = "this is a test";
            dhcpClient.ClientName = "test1";
            dhcpClient.ClientHardwareAddress = "0800690201FC";
            dhcpClient.ClientLeaseExpires = DateTime.Now.AddDays(30);
            dhcpClient.OwnerHost.HostName = "MEAN-DEV";
            dhcpClient.OwnerHost.IpAddress = "192.168.2.246";
            DhcpClient.DhcpCreateClientInfo("192.168.2.246", dhcpClient);
        }
    }
}
