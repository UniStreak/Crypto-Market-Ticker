//EMRE ASLAN
//
//Crypto coin ticker -- Cryptocoin price index and market cap
//
//Every 10 seconds, it displays crypto coin information from ticker url.

using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text += " (" + DateTime.Now.ToShortDateString() + ")";   //to view the date in the title bar
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Func();
        }

        public int a = 0; //for selection of coins
        public int b = 0; //for loop
        public String[] coins = { "BTC", "ETH", "LTC", "DASH", "DOGE", "XRP" }; //Names of coins, headlines of ticker
        public String[] cats = { "name", "current", "currency", "change_amount", "change_percentage", "high", "low", "volume" }; //subtitles of ticker

        public void Func()
        {            
            string adres = "https://koineks.com/ticker"; //ticker url
            WebRequest istek = HttpWebRequest.Create(adres); //url request
            WebResponse cevap; //url response
            cevap = istek.GetResponse(); //url response
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream()); //incoming information
            string bilgilerial = donenBilgiler.ReadToEnd(); //incoming info to string
            dynamic coin = JObject.Parse(bilgilerial); //incoming info to parsing
            
            if (coin[coins[a]][cats[3]] < 0) //Visibility of Green and Red arrows
            {
                    r0.Visible = true;
                    g0.Visible = false;
                }
            else if (coin[coins[a]][cats[3]] > 0)
                {
                    r0.Visible = false;
                    g0.Visible = true;
                
                }
            values.Text = ""; //For clear previous text
            for (b=0;b<=7;b++) //For writing subtitles of ticker
            {
                values.Text += coin[coins[a]][cats[b]] + " \n";
            }           
        }

        private void Timer1_Tick(object sender, EventArgs e) //Timer
        {            
            if (a < 5)
                a++;
            else
                a = 0;
            Func();
        }
    }
}
