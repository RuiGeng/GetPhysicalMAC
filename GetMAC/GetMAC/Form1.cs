using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace GetMAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GET The network interface
        /// The status is up, physical or virtual
        /// Not ordered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGetMAC1_Click(object sender, EventArgs e)
        {
            richTextBoxMAC1.Clear();

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            if (networkInterfaces.Length > 0)
            {
                IEnumerable<PhysicalAddress> addresses = networkInterfaces
                    .Where(nic => nic.OperationalStatus == OperationalStatus.Up)
                    .Select(nic => nic.GetPhysicalAddress());

                if (addresses.Count() > 0)
                {
                    foreach (var address in addresses)
                    {
                        string formattedAddress = "";
                        byte[] bytes = address.GetAddressBytes();

                        for (int i = 0; i < bytes.Length; i++)
                        {
                            formattedAddress += bytes[i].ToString("X2");
                            if (i != bytes.Length - 1)
                            {
                                formattedAddress += "-";
                            }
                        }

                        richTextBoxMAC1.AppendText($"You available address is {formattedAddress} {System.Environment.NewLine}");
                    }
                }
            }
        }

        private void ButtonGetMAC2_Click(object sender, EventArgs e)
        {
            richTextBoxMAC2.Clear();

            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            richTextBoxMAC2.AppendText(
                string.Format("Interface information for {0}.{1}     ",
                    computerProperties.HostName, computerProperties.DomainName)
                    );

            if (nics == null || nics.Length < 1)
            {
                richTextBoxMAC2.AppendText(System.Environment.NewLine);
                richTextBoxMAC2.AppendText("  No network interfaces found.");
                return;
            }

            Console.WriteLine("  Number of interfaces .................... : {0}", nics.Length);
            foreach (NetworkInterface adapter in nics)
            {
                // GetIPInterfaceProperties();
                IPInterfaceProperties properties = adapter.GetIPProperties();
                richTextBoxMAC2.AppendText(System.Environment.NewLine);
                richTextBoxMAC2.AppendText(adapter.Description);
                richTextBoxMAC2.AppendText(System.Environment.NewLine);
                richTextBoxMAC2.AppendText(String.Empty.PadLeft(adapter.Description.Length, '='));
                richTextBoxMAC2.AppendText(System.Environment.NewLine);
                richTextBoxMAC2.AppendText($"  Interface type .......................... : {adapter.NetworkInterfaceType}");
                richTextBoxMAC2.AppendText(System.Environment.NewLine);
                richTextBoxMAC2.AppendText("  Physical address ........................ : ");

                PhysicalAddress address = adapter.GetPhysicalAddress();
                byte[] bytes = address.GetAddressBytes();
                richTextBoxMAC2.AppendText(System.Environment.NewLine);
                for (int i = 0; i < bytes.Length; i++)
                {
                    // Display the physical address in hexadecimal.
                    richTextBoxMAC2.AppendText($"{bytes[i].ToString("X2")}");
                    // Insert a hyphen after each byte, unless we are at the end of the
                    // address.
                    if (i != bytes.Length - 1)
                    {
                        richTextBoxMAC2.AppendText("-");
                    }
                }
                richTextBoxMAC2.AppendText(System.Environment.NewLine);
            }
        }

        /// <summary>
        /// GET The network interface
        /// whatever it's status is up or down, physical only
        /// ordered by index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetMAC3_Click(object sender, EventArgs e)
        {
            richTextBoxMAC3.Clear();

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            if (networkInterfaces != null && networkInterfaces.Length > 0)
            {
                //Get all the physical network adapter addresses
                //Which support IPV4, NOT virtual, has physical address
                //And ordered by device index
                IEnumerable<PhysicalAddress> addresses = networkInterfaces
                    .Where(adapter =>
                            adapter.Supports(NetworkInterfaceComponent.IPv4) == true &&
                            adapter.GetIPProperties().GetIPv4Properties() != null &&
                            adapter.Description.Contains("Virtual") != true &&
                            adapter.GetPhysicalAddress().ToString() != "")
                    .OrderBy(adapter => adapter.GetIPProperties().GetIPv4Properties().Index)
                    .Select(nic => nic.GetPhysicalAddress());

                if (addresses != null && addresses.Count() > 0)
                {
                    addresses.ToList().ForEach(

                        address =>
                        {
                            string formattedAddress = "";

                            byte[] bytes = address.GetAddressBytes();

                            for (int i = 0; i < bytes.Length; i++)
                            {
                                formattedAddress += bytes[i].ToString("X2");
                                if (i != bytes.Length - 1)
                                {
                                    formattedAddress += "-";
                                }
                            }

                            richTextBoxMAC3.AppendText($"Your physical device MAC address is {formattedAddress} {System.Environment.NewLine}");
                        });
                }
            }
        }
    }
}