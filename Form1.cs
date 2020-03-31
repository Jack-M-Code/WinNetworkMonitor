using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Echevil;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Management;

namespace WinNetworkMonitor {
	public partial class Form1:Form {
		public Form1() {
			InitializeComponent();
		}

		private NetworkAdapter[] adapters;
		private NetworkMonitor monitor;
		private void Form1_Load(object sender, EventArgs e) {
                     monitor = new NetworkMonitor();
                     this.adapters = monitor.Adapters;

                     if(adapters.Length == 0) {
                            this.ListAdapters.Enabled = false;
                            MessageBox.Show("No network adapters found on this computer.");
                            return;
                     }

                     this.ListAdapters.Items.AddRange(this.adapters);

                     this.ListAdapters.SelectedIndex = 0;

              }


              private void ListAdapters_SelectedIndexChanged_1(object sender, EventArgs e) {
                     this.TimerCounter.Stop();


                     if(this.ListAdapters.SelectedIndex > -1) {



                            this.MACAddress.Text = "MAC Address：" + GetMACAddress();

                            this.ipAddress.Text = "IP Address：" + getIdAddress().ToString();

                            monitor.StopMonitoring();
                            monitor.StartMonitoring(adapters[this.ListAdapters.SelectedIndex]);
                            this.TimerCounter.Start();

                     }
              }

              private void TimerCounter_Tick(object sender, EventArgs e) {

                    //NetworkInterface[] adcart = NetworkInterface.GetAllNetworkInterfaces();

                     NetworkAdapter adapter = this.adapters[this.ListAdapters.SelectedIndex];


                     //String NetworkCard = adcart[this.ListAdapters.SelectedIndex].Description.ToString();




                     //String.Format("{0:n} kbps", adapter.DownloadSpeedKbps);

                     this.LableDownloadValue.Text = "DownloadSpeed：" + FormatSizeBinary(Convert.ToInt64(adapter.DownloadSpeedKbps));


                     // String.Format("{0:n} kbps", adapter.UploadSpeedKbps);
                     this.LabelUploadValue.Text = "UploadSpeed：" + FormatSizeBinary(Convert.ToInt64(adapter.UploadSpeedKbps));

              }

              public string GetMACAddress() {
                     NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                     String sMacAddress = string.Empty;
                     foreach(NetworkInterface adapter in nics) {
                            if(sMacAddress == String.Empty)// only return MAC Address from first card
                            {
                                   IPInterfaceProperties properties = adapter.GetIPProperties();
                                   sMacAddress = adapter.GetPhysicalAddress().ToString();
                            }
                     }
                     return sMacAddress;
              }


              private IPAddress getIdAddress() {


                     IPAddress ipAddr = null;
                     IPAddress[] arrIP = Dns.GetHostAddresses(Dns.GetHostName());
                     foreach(IPAddress ip in arrIP) {
                            if(System.Net.Sockets.AddressFamily.InterNetwork.Equals(ip.AddressFamily)) {
                                   ipAddr = ip;
                            } else if(System.Net.Sockets.AddressFamily.InterNetworkV6.Equals(ip.AddressFamily)) {
                                   ipAddr = ip;
                            }
                     }
                     return ipAddr;
              }


                     //解析位元組 轉換
              private string FormatSizeBinary(Int64 size, Int32 decimals = 2) {

                     string[] sizes = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
                     double formattedSize = size;
                     Int32 sizeIndex = 0;
                     while(formattedSize >= 1024 & sizeIndex < sizes.Length) {

                            formattedSize /= 1024;
                            sizeIndex += 1;
                     }
                     return string.Format("{0} {1}", Math.Round(formattedSize, decimals).ToString(), sizes[sizeIndex]);
              }


       }
}
