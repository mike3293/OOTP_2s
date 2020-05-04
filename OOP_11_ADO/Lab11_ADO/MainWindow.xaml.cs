using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Lab11_ADO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Planet> _pl;

        public List<Planet> PlanetList
        {
            get { _pl = Database.GetPlanet(); return _pl; }
            set { _pl = value; NotifyPropertyChanged(); }
        }

        private Planet _sp;
        public Planet SelectedPlanet
        {
            get { return _sp; }
            set
            {
                if(value != null)
                _sp = value;
                if (_sp != null)
                {
                    MessageBox.Show(_sp.Name); SatelliteList = SatelliteList;
                    if (Database.GetDescriptions(true, _sp.Name).Count != 0)
                        txt.Text = Database.GetDescriptions(true, _sp.Name)[0].Descriprion;
                }
                NotifyPropertyChanged();
            }
        }

        private bool allSatellite = false;

        private List<Satellite> _sl;

        public List<Satellite> SatelliteList
        {
            get
            {
                if (SelectedPlanet != null) _sl = Database.GetSatellite(allSatellite, SelectedPlanet.Name);
                else _sl = Database.GetSatellite(false, null);
                return _sl;
            }
            set { _sl = value; NotifyPropertyChanged(); }
        }

        public MainWindow()
        {

            InitializeComponent();
            Database.OpenConnection(txt);

            DataContext = this;

            Planets.ItemsSource = Database.GetPlanet();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            allSatellite = !allSatellite;
            Database.DoTransaction();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txt.Text = "";
            var rc = new List<Planet>(PlanetList);
            rc.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
            foreach (Planet planet in rc)
            {
                txt.Text += planet.Name + ' ';
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(SelectedPlanet!=null)
                Database.AddDescription(desc.Text,_sp.Name);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (SelectedPlanet != null)
                Database.UpdateDescription(desc.Text, _sp.Name);
        }
    }
}
