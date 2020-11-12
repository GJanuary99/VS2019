using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GitHuubXD
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        public Window2(int item)
        {
            int klucz = item;
            InitializeComponent();
            Name.Text = MainWindow.PersonList[klucz].Name;
            Surname.Text = MainWindow.PersonList[klucz].Surname;
            Pesel.Text = MainWindow.PersonList[klucz].Pesel;
            City.Text = MainWindow.PersonList[klucz].City;
            Adress.Text = MainWindow.PersonList[klucz].Adress;
            x.Content = klucz;
        }

        private void Modify(object sender, RoutedEventArgs e)
        {
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Name = Name.Text;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Surname = Surname.Text;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Pesel = Pesel.Text;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].City = City.Text;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Adress = Adress.Text;
            this.Close();
        }
    }
}
