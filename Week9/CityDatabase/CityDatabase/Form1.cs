using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityDatabase
{
    public partial class Form1 : Form
    {
        public List<City> cities;
        public City city;
        Func<City, string, bool> findCity = (ci, tx) => ci.CountryName == tx;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            richTextBox1.Clear();
            string text = textBox1.Text;            

            foreach (City city in cities)
            {
                if (findCity(city, text))
                {
                    richTextBox1.Text += city.CityName + "\n";
                }
            }
            richTextBox1.Text += "...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cities = new List<City>();
            city = new City("Wellington", "New Zealand", 204000);
            cities.Add(city);
            city = new City("Auckland", "New Zealand", 1377000);
            cities.Add(city);
            city = new City("Dunedin", "New Zealand", 127500);
            cities.Add(city);
            city = new City("Brisbane", "Australia", 2099000);
            cities.Add(city);
            city = new City("Sydney", "Australia", 4293000);
            cities.Add(city);
            city = new City("Cairo", "Egypt", 9500000);
            cities.Add(city);
            city = new City("Rome", "Italy", 2627000);
            cities.Add(city);
            city = new City("Florence", "Italy", 2627000);
            cities.Add(city);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            cities.ForEach(ci => ci.Population *= 3);
            foreach (City city in cities)
            {
                richTextBox1.Text += city.toString() + "\n";
            }
        }
    }
}
