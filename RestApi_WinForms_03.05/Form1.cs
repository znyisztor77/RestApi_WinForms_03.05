using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RestApi_WinForms_03._05
{
    public partial class Form1 : Form
    {
        string endPointUrl = "https://retoolapi.dev/KqpqJ9/data";
        /* "id": 1,
           "name": "Hershel Shields",
           "salary": 30903
        */

        /*Endpoint URL -> https://retoolapi.dev/KqpqJ9/data

        HTTP method endpoints:
        GET /KqpqJ9/data
        GET filter /KqpqJ9/data? name = value
        GET by id /KqpqJ9/data/1
        GET paginate /KqpqJ9/data? _page = 2 & _limit = 10
        POST /KqpqJ9/data
        PUT /KqpqJ9/data/1
        PATCH /KqpqJ9/data/1
        DELETE /KqpqJ9/data/1*/

        HttpClient client = new HttpClient();

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


        private void button_beszuras_Click(object sender, EventArgs e)
        {
            //-- kiolvasuukk az adatokat
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Mincs megadva adat!");
                textBox_Nev.Focus();
                return;
            }
            long fizetes;
            if(!long.TryParse(textBoxFizetes.Text,out fizetes))
            {
                MessageBox.Show("Nem megfelelő fizetés értéke!");
                textBoxFizetes.Focus();
                return;
            }

            //-- JSON hozunk létre
            Dolgozo dolgozo = new Dolgozo(adatok[adatok.Count-1].Id+1, textBox_Nev.Text, fizetes);
            string JsonDolgozo = JsonConvert.SerializeObject(dolgozo);           
            //-- JSONStringet csinálunk
            var data = new StringContent(JsonDolgozo, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPointUrl, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres rögzítés!");
                textBoxFizetes.Text = "";
                textBox_Nev.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzítés!");
            }
            restapiAdatok();
            //-- elküldjük a végpontra POST-al
            //-- Visszajelzés a felhasználónak
        }

        private void listBox_Adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dolgozo dolgozo = (Dolgozo)listBox_Adatok.SelectedItem;
            textBox_azonosito.Text = dolgozo.Id.ToString();
            textBox_Nev.Text = dolgozo.Name;
            textBoxFizetes.Text = dolgozo.Salary.ToString();
        }
    }
}
