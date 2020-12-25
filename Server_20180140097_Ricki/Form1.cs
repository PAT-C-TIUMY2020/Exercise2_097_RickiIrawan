using Service_20180140097_Ricki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_20180140097_Ricki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void btON_Click_1(object sender, EventArgs e)
        {
            {
                ServiceHost hostObjek = null;

                try
                {
                    hostObjek = new ServiceHost(typeof(TI_UMY));
                    hostObjek.Open();
                    label1.Text = "Server ON";
                    label2.Text = "Klik OFF Untuk Mematikan Server";
                    btON.Enabled = false;
                    btOFF.Enabled = true;
                }
                catch (Exception ex)
                {
                    hostObjek = null;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }

        private void btOFF_Click_1(object sender, EventArgs e)
        {
            ServiceHost hostObjek;

            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY));
                hostObjek.Close();
                label1.Text = "Server OFF";
                label2.Text = "Klik ON Untuk Menghidupkan Server";
                btON.Enabled = true;
                btOFF.Enabled = false;
            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            {
                btON.Enabled = true;
                btOFF.Enabled = false;
            }
        }
    }
}