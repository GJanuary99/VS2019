using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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
        private BitmapImage imageyes;

        string tmpPesel;
        string tmpSurname;
        string tmpName;
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Pesel.Text == "" || Surname.Text == "" || Name.Text == "" || City.Text == "" || Adress.Text == ""  || Pesel.Text.Length != 11 )
            {
                MessageBox.Show("Pola nie mogą być puste!\n Pesel musi mieć dokładnie 11 cyfr!");
            }
            else
            {
                namefield = Name.Text;
                surnamefield = Surname.Text;
                peselfield = Pesel.Text;
                cityfield = City.Text;
                adressfield = Adress.Text;

                try
                {
                    MainWindow.PersonList.Add(new MainWindow.Person() { Name = namefield, Surname = surnamefield, Pesel = peselfield, City = cityfield, Adress = adressfield, Img = imageyes });
                }
                catch (Exception blad)
                {
                    MessageBox.Show(blad.Message);
                }
            }
        }

        private void Img_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                string filePath;
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == true)
                {
                    
                    filePath = openFileDialog.FileName;
                    Uri uri1 = new Uri(filePath);
                    ImgFile.Source = new BitmapImage(uri1);
                    imageyes = new BitmapImage(uri1);
                }
            }
        }
        private void CheckPesel(object sender, TextChangedEventArgs e)
        {
            string input = (sender as TextBox).Text;
            if (Pesel.Text.Length > 1)
            {
                if (!Regex.IsMatch(input, @"^[0-9]{1,11}$"))
                {
                    MessageBox.Show("Wpisany przez Ciebie Pesel musi skladac sie dokladnie z 11 cyfr");
                    Pesel.Text = tmpPesel;
                }
                tmpPesel = Pesel.Text;
            }
        }
        private void CheckSurname(object sender, TextChangedEventArgs e)
        {
            string input = (sender as TextBox).Text;

            if (Surname.Text.Length > 1)
            {
                if (!Regex.IsMatch(input, @"^[A-Z]{1}[a-z]{1,48}$"))//najdluzsze zanotowane nazwisko liczylo 48 znakow, a najkrotsze 1 
                {

                    MessageBox.Show("Pole Nazwisko ma limit ustawiony na 50 znakow. \nNie moze zawierac znakow specjalnych i cyfr.\nMusi zaczynac sie z duzej litery");
                    Surname.Text = tmpSurname;
                }
                tmpSurname = Surname.Text;
            }
        }
        private void CheckName(object sender, TextChangedEventArgs e)
        {
            string input = (sender as TextBox).Text;
            if (Name.Text.Length > 1)
            {
                if (!Regex.IsMatch(input, @"^[A-Z]{1}[a-z]{1,81}$"))//najdluzsze imie liczy 81znakow, najkrotsze 1 znak
                {

                    MessageBox.Show("Pole Imie ma limit ustawiony na 50 znakow. \nNie moze zawierac znakow specjalnych i cyfr.\nMusi zaczynac sie z duzej litery");
                    Name.Text = tmpName;
                }
                tmpName = Name.Text;
            }
        }

        private void CheckLetters(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^\p{L}"))
                e.Handled = true;
        }
        private void CheckNumbers(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^\p{N}"))
                e.Handled = true;
        }
    }
}
