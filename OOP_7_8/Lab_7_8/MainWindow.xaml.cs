using System;
using System.Reflection;
using System.Resources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfCustomControlLibrary1;

namespace Lab_7_8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            ViewModel.ViewModel viewModel = new ViewModel.ViewModel(Tasks);
            DataContext = viewModel;
        }

        private static int _style = 1;

        private void Set_Language(string Language)
        {
            string strLanguage = "Lab_7_8.Languages." + Language;
            ResourceManager LocRM = new ResourceManager(strLanguage, Assembly.GetExecutingAssembly());
            Edit_Button.Content = LocRM.GetString("Edit");
            Add_Button.Content = LocRM.GetString("Add");
            Delete_Button.Content = LocRM.GetString("Delete");
            HeaderText.Text = LocRM.GetString("Header");
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            switch (((Slider)sender).Value)
            {
                case 1:
                    Set_Language("English");
                    break;
                case 0:
                    Set_Language("Russian");
                    break;
            }
        }

        private void ChangeStyle(object sender, RoutedEventArgs e)
        {
            Uri uri;
            switch (_style)
            {
                case 0:
                    uri = new Uri("Style/Style.xaml", UriKind.Relative);
                    _style++;
                    break;
                case 1:
                    uri = new Uri("Style/SecondStyle.xaml", UriKind.Relative);
                    _style = 0;
                    break;
                default:
                    uri = new Uri("Style/Style.xaml", UriKind.Relative);
                    break;
            }
            var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void CustomControl1_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
