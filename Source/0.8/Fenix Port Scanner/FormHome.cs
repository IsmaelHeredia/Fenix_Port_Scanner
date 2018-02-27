// Fenix Port Scanner 0.8
// © Ismael Heredia , Argentina , 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Media;

namespace Fenix_Port_Scanner
{
    public partial class FormHome : Form
    {

        public FormHome()
        {
            InitializeComponent();
            
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

            SoundPlayer sound1 = new SoundPlayer(Fenix_Port_Scanner.Properties.Resources.click);
            sound1.Play();

            lbPortFounds.Items.Clear();

            gbPortsFound.Text = "Ports Found";

            string regex = "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9‌​]{2}|2[0-4][0-9]|25[0-5])$";    

            Regex checkip = new Regex(regex, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match isip = checkip.Match(txtIP.Text);

            if (!isip.Success)
            {
                try
                {
                    IPAddress[] find = Dns.GetHostAddresses(txtIP.Text);
                    string ip = find[0].ToString();
                    txtIP.Text = ip;
                }
                catch
                {
                    //
                } 
            }

            if (rbCheckPortsRange.Checked)
            {

                for (int port = Convert.ToInt32(udPortStart.Value); port <= Convert.ToInt32(upPortEnd.Value); port++)
                {

                    status.Text = "[+] Scanning port [" + port+"]";
                    this.Refresh();

                    TcpClient socket = new TcpClient();
                    IPAddress ip = IPAddress.Parse(txtIP.Text);

                    try
                    {
                        socket.SendTimeout = 500;
                        socket.ReceiveTimeout = 500;
                        socket.Connect(ip, port);

                        if (socket.Connected)
                        {
                            lbPortFounds.Items.Add("[+] Port : " + port + "\n");
                            socket.Close();
                        }
                    }
                    catch
                    {
                        socket.Close();
                    }

                    socket.Close();
                }

                status.Text = "[+] Finished";
                this.Refresh();

            }
            else
            {

                List<string> puertos = new List<string> {"21","22","25","80","110","3306"};
                List<string> servicios = new List<string> {"FTP","SSH","SMTP","HTTP","POP3","MYSQL"};

                for (int i = 0; i <= puertos.Count - 1; i++)
                {

                    status.Text = "[+] Scanning port [" + puertos[i] + "]";
                    this.Refresh();

                    TcpClient socket = new TcpClient();
                    IPAddress ip = IPAddress.Parse(txtIP.Text);

                    try
                    {
                        socket.SendTimeout = 500;
                        socket.ReceiveTimeout = 500;
                        socket.Connect(ip, Convert.ToInt32(puertos[i]));

                        if (socket.Connected)
                        {
                            lbPortFounds.Items.Add("[+] Port : " + puertos[i] + " -> " + servicios[i] + "\n");
                            socket.Close();
                        }
                    }
                    catch
                    {
                        socket.Close();
                    }

                    socket.Close();

                }
            
            }

            if (lbPortFounds.Items.Count == 0)
            {
                MessageBox.Show("Not Found");
            }

            gbPortsFound.Text = "Ports Found [" + lbPortFounds.Items.Count + "]";

            status.Text = "[+] Finished";
            this.Refresh();

            SoundPlayer sound2 = new SoundPlayer(Fenix_Port_Scanner.Properties.Resources.scanfin);
            sound2.Play();

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Fenix_Port_Scanner.Properties.Resources.formcreate);
            sound.Play();
        }
    }
}
