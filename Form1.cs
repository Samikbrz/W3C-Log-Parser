using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace logParser1
{
    public partial class Form1 : Form
    {
        private List<Log> allLogs = new List<Log>();
        private List<PieChartByDate> pieChartByDateLogs = new List<PieChartByDate>();
        private List<PieChartByIP> pieChartByIPLogs = new List<PieChartByIP>();
        private string[] satirlar;

        public Form1()
        {
            InitializeComponent();
            LogGridView.ColumnHeadersVisible = true;
            ReadAllLogsFromTxt();
            PieChartByDate.Series["ChartByDate"].IsValueShownAsLabel = true;
            PieChartByIp.Series["ChartByIp"].IsValueShownAsLabel = true;
            PieChartByDate.Titles.Add("By Date");
            PieChartByIp.Titles.Add("By Ip");
        }

        private void DrawChartByDate()
        {
            foreach (var item in pieChartByDateLogs)
            {
                PieChartByDate.Series["ChartByDate"].Points.AddXY(item.Date, item.Counter);
            }
        }

        private void DrawChartByIp()
        {
            foreach (var item in pieChartByIPLogs)
            {
                PieChartByIp.Series["ChartByIp"].Points.AddXY(item.Ip, item.Counter);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ReadAllLogsFromTxt()
        {
            string dosyayolu = @"access.log";
            satirlar = File.ReadAllLines(dosyayolu, Encoding.GetEncoding("windows-1254"));
 
            for (int i = 0; i < satirlar.Length; i++)
            {
                Log currentLog = new Log();
                string[] kelime = satirlar[i].Split(' ');
                for (int j = 0; j < kelime.Length; j++)
                {
                    if (j == 0)
                    {
                        currentLog.UserIp = kelime[0];
                    }
                    else if (j == 3)
                    {
                        currentLog.Date = kelime[3] + kelime[4];
                        string[] date = kelime[3].Split(':');
                        currentLog.Date = date[0].Substring(1);
                        //date[0]=tarih
                        //date[1],date[2],date[3]=saat
                        //Console.WriteLine("Date="+date[0]+"]");
                        //Console.WriteLine("Time="+date[1] + ":" + date[2] + ":" + date[3]); 
                    }
                    else if (j == 5)
                    {
                        for (int a = 5; a < 6; a += 1)
                        {
                            currentLog.VisitedLink = kelime[a] + kelime[a + 1];
                        }
                    }
                    else if (j == 6)
                    {
                        currentLog.HyperTextTransferProtocol = kelime[7];
                    }
                    else if (j == 10)
                    {
                        //currentLog.VisitedSiteLink = kelime[10];
                    }
                    else if (j == 11)
                    {
                        //currentLog.BrowserName = kelime[11];
                    }
                    else if (j == 12)
                    {
                        if (kelime[12] != "-" && kelime.Length > 13)
                        {
                            string os = null;
                            os = kelime[12] + kelime[13];
                            string temp = null;
                            for (int k = 15; k < kelime.Length - 1; k++)
                            {
                                temp = kelime[k - 1] + kelime[k];
                                kelime[k] = temp;
                            }
                           // currentLog.OperatingSystemInformation = os + temp;
                        }
                    }
                }
                allLogs.Add(currentLog);
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int sayac = 0;
            string[] IP = new string[satirlar.Length];
            foreach (var log in allLogs)
            {
                if (log.UserIp == "::1")
                {
                    log.UserIp = "127.0.0.1";
                }
                IP[sayac] = log.UserIp;
                sayac++;
            }

            string[] array_IP = IP;
            var dict_IP = new Dictionary<string, int>();
            foreach (var currentIp in array_IP)
            {
                if (currentIp != null)
                {
                    if (!dict_IP.ContainsKey(currentIp))
                    {
                        dict_IP.Add(currentIp, 0);
                    }
                    dict_IP[currentIp]++;
                }
            }

            foreach (var kvp in dict_IP)
            {
                PieChartByIP pieChartByIP = new PieChartByIP()
                {
                    Ip = kvp.Key,
                    Counter = Convert.ToString(kvp.Value)
                };
                pieChartByIPLogs.Add(pieChartByIP);
            }


            string[] DateNumber = new string[satirlar.Length];
            sayac = 0;
            foreach (var log in allLogs)
            {
                DateNumber[sayac] = log.Date;
                sayac++;
            }                 

            string[] array = DateNumber;
            var dict = new Dictionary<string, int>();
            foreach (var currentDate in array)
            {
                if (currentDate != null)
                {
                    if (!dict.ContainsKey(currentDate))
                    {
                        dict.Add(currentDate, 0);
                    }
                    dict[currentDate]++;
                }
            }

            foreach (var kvp in dict)
            {
                PieChartByDate pieChartByDate = new PieChartByDate()
                {
                    Date = kvp.Key,
                    Counter = Convert.ToString(kvp.Value)
                };
                pieChartByDateLogs.Add(pieChartByDate);
            }

            NumberOfUsersCountLable.Text = pieChartByIPLogs.Count + " visited my web site";
            LogGridView.DataSource = allLogs;
            DrawChartByIp();
            DrawChartByDate();
        }

        private void LogGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
