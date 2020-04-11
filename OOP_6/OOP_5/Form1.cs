using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace OOP_6
{
    public partial class Form1 : Form
    {
        public Building building;
        public Form1()
        {
            InitializeComponent();
            building = new Building();

            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();

           
        }
        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Кол-во объектов: " + listBox1.Items.Count + " | " + DateTime.Now.ToString();
        }

        private void AddHouseToList(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Введите метраж квартиры!!!");
                return;
            }
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Выберите материал!!!");
                return;
            }
            if (textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals("")
                || textBox6.Text.Equals("") || textBox7.Text.Equals(""))
            {
                MessageBox.Show("Все поля адреса квартиры должны быть заполнены!");
                return;
            }

            House currentHouse = new House
            {
                Meter = int.Parse(textBox2.Text),
                Material = comboBox1.Text,
                DateOfBuilt = dateTimePicker1.Value,
                Floor = trackBar1.Value,
                Rooms = numericUpDown1.Value,
                Address = new Address
                {
                    Country = textBox3.Text,
                    City = textBox4.Text,
                    Street = textBox5.Text,
                    Home = int.Parse(textBox6.Text),
                    Apartment = int.Parse(textBox7.Text)
                }
            };

            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(currentHouse.Address);
            if (!Validator.TryValidateObject(currentHouse.Address, context, results, true))
            {
                foreach (ValidationResult error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                return;
            }

            building.Houses.Add(currentHouse);
            listBox1.Items.Add(currentHouse.ToString());
        }

        private void SerializeBuilding(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, building);
            }
        }

        private void DeserializeBulding(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.Open))
            {
                building = serializer.Deserialize(stream) as Building;
            }
            foreach (House house in building.Houses)
            {
                listBox1.Items.Add(house.ToString());
            }
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            DeserializeBulding(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SerializeBuilding(sender, e);
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog(this);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Городилов v0.1");
        }

        private void AreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            IEnumerable<House> ordered = building.Houses.OrderBy(p => p.Meter);
            foreach (House house in ordered)
                listBox1.Items.Add(house.ToString());
        }

        private void PriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            IEnumerable<House> ordered = building.Houses.OrderBy(p => p.Price);
            foreach (House house in ordered)
                listBox1.Items.Add(house.ToString());
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
