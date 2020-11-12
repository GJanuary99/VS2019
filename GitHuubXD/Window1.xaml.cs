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

    public partial class Window1 : Window
    {
        private string namefield;
        private string surnamefield;
        private string peselfield;
        private string cityfield;
        private string adressfield;
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            namefield = Name.Text;
            surnamefield = Surname.Text;
            peselfield = Pesel.Text;
            cityfield = City.Text;
            adressfield = Adress.Text;
            try
            {
                MainWindow.PersonList.Add(new MainWindow.Person() { Name = namefield, Surname = surnamefield, Pesel = peselfield, City = cityfield, Adress = adressfield });
            }
            catch(Exception blad)
            {
                MessageBox.Show(blad.Message);
            }
        }
    }
}
