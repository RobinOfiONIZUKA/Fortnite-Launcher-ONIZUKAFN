using DiscordRPC;
using FluentNHibernate.Conventions.Instances;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using Template_Launcher.Util;

namespace Template_Launcher
{
    public partial class Form1 : MetroSuite.MetroForm
    {

        public Form1()
        {
            InitializeComponent();




            label3.Text = Configuracion.Server.Global.VERSION;



            {
                Version.Text = "Fortnite v" + Configuracion.Server.GetFNVer();
            }

            string en = Configuracion.Server.GetFNPath();
            {
                Version.Text = "Fortnite v" + Configuracion.Server.GetFNVer();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RichPresenceClient.Start();
            Random r = new Random(DateTime.Now.Millisecond);
            int al1 = r.Next(1, 255);
            int al2 = r.Next(1, 255);
            int al3 = r.Next(1, 255);
            label1.ForeColor = Color.FromArgb(al1, al2, al3);
        }


        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox24_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Random r = new Random(DateTime.Now.Millisecond);
            int al1 = r.Next(1, 255);
            int al2 = r.Next(1, 255);
            int al3 = r.Next(1, 255);
            label1.ForeColor = Color.FromArgb(al1, al2, al3);
        }


        private void Version_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RichPresenceClient.UpdatePresence("Made by @lolperoi123", $"Installing Server");
            Configuracion.Server.InstallSv();
            Configuracion.Server.InstallDll();
            Thread.Sleep(1200);
            Configuracion.Server.StartFortnite();
            RichPresenceClient.UpdatePresence("Made by @lolperoi123", $"In ONIZUKΛFN");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int al1 = r.Next(1, 255);
            int al2 = r.Next(1, 255);
            int al3 = r.Next(1, 255);
            label1.ForeColor = Color.FromArgb(al1, al2, al3);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/hybrid");
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Configuracion.Server.Verify();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}




