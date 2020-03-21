using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string n, int a)
            {
                Name = n;
                Age = a;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }

        private static string[] NamesArr = {"Katrin", "Alexandra", "Olga", "Darya", "Lizaveta", "Nastya",
        "Eygen", "Alexey", "Dmitriy", "Nikita", "James", "John", "Mary", "Anna", "Daniil", "Kirill",
        "Vlada", "Kostya", "Chloe", "Max", "Egor", "Galina", "Artem", "Polina", "Julia"};

        private int Number;

        private string Letter;

        private List<Person> People = new List<Person>();

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            People.Clear();
            listViewCol.Clear();
            if (string.IsNullOrEmpty(textBoxColSize.Text))
            {
                return;
            }

            try
            {
                Number = int.Parse(textBoxColSize.Text);
            }
            catch
            {
                textBoxColSize.Clear();
                MessageBox.Show("Invalid number");
            }

            if (Number > 0 && Number < 20)
            {
                for (int x = 0; x < Number; x++)
                {
                    Thread.Sleep(30); // For random
                    People.Add(new Person(NamesArr[new Random().Next(0, NamesArr.Length)], new Random().Next(2, 90)));
                    listViewCol.Items.Add(People[x].ToString());
                }
            }

        }

        private void ButtonOrderByAsc_Click(object sender, EventArgs e)
        {
            listViewOrdCol.Clear();
            IOrderedEnumerable<Person> OrderedCollection = People.OrderBy(a => a.Age);
            foreach (Person item in OrderedCollection)
            {
                listViewOrdCol.Items.Add(item.ToString());
            }
        }

        private void ButtonOrderByDesc_Click(object sender, EventArgs e)
        {
            listViewOrdCol.Clear();
            IOrderedEnumerable<Person> OrderedCollection = People.OrderByDescending(a => a.Age);
            foreach (Person item in OrderedCollection)
            {
                listViewOrdCol.Items.Add(item.ToString());
            }
        }

        private void buttonLINQ1_Click(object sender, EventArgs e)
        {
            listViewLINQ1.Clear();
            IEnumerable<Person> FilteredCollection = People.Where(a => a.Age < 40);
            foreach (Person item in FilteredCollection)
            {
                listViewLINQ1.Items.Add(item.ToString());
            }
        }

        private void ButtonLINQ2_Click(object sender, EventArgs e)
        {
            listViewLINQ2.Clear();
            IEnumerable<Person> FilteredCollection = People.Where(a => a.Name.Length < 5);
            foreach (Person item in FilteredCollection)
            {
                listViewLINQ2.Items.Add(item.ToString());
            }
        }

        private void ButtonLINQ3_Click(object sender, EventArgs e)
        {
            Letter = textBox1.Text;
            listViewLINQ3.Clear();
            if (!string.IsNullOrEmpty(Letter))
            {
                IEnumerable<Person> FilteredCollection = People.Where(a => a.Name.StartsWith(Letter));
                foreach (Person item in FilteredCollection)
                {
                    listViewLINQ3.Items.Add(item.ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listViewLINQ1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
