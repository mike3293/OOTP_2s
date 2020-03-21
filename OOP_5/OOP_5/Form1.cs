using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace OOP_5
{
    public partial class Form1 : Form
    {
        public Building building;
        public Form1()
        {
            InitializeComponent();
            building = new Building();
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
            currentHouse.Price = decimal.ToInt32(currentHouse.Rooms) * 10000 - currentHouse.Floor * 54;
            building.Houses.Add(currentHouse);
            currentHouse.Result = currentHouse.Address.Street + ": " + currentHouse.Rooms + "-комн., " +
                currentHouse.Floor + " этаж, " + currentHouse.Material + ", " +
                currentHouse.Meter + " кв.м";
            if (checkBox1.Checked)
            {
                currentHouse.Result += " + кухня";
            }

            if (checkBox2.Checked)
            {
                currentHouse.Result += " + ванная";
            }

            if (checkBox3.Checked)
            {
                currentHouse.Result += " + балкон";
            }

            if (checkBox4.Checked)
            {
                currentHouse.Result += " + туалет";
            }

            currentHouse.Result += "\r\nЦена: " + currentHouse.Price + " $";

            listBox1.Items.Add(currentHouse.Result);
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
                listBox1.Items.Add(house.Result);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
