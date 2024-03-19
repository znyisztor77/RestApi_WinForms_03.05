﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace RestApi_WinForms_03._05
{
    public partial class Form1 : Form
    {
        string endPointUrl = "https://retoolapi.dev/KqpqJ9/data";
        /* "id": 1,
           "name": "Hershel Shields",
           "salary": 30903
        */

        static List<Dolgozo> adatok = new List<Dolgozo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            restapiAdatok();
            listBox_Adatok.Items.AddRange(adatok.ToArray());
        }
         async void restapiAdatok()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, endPointUrl);
            var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                adatok = Dolgozo.FromJson(jsonString);
                listBox_Adatok.Items.AddRange(adatok.ToArray());
            }

        }
    }
}
