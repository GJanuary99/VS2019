using System;
using Microsoft.Win32;
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
using System.Text.RegularExpressions;

namespace GitHuubXD
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        string tmpPesel;
        string tmpSurname;
        string tmpName;

        public Window2(int item)
        {
            int klucz = item;
            InitializeComponent();
            Name.Text = MainWindow.PersonList[klucz].Name;
            Surname.Text = MainWindow.PersonList[klucz].Surname;
            Pesel.Text= MainWindow.PersonList[klucz].Pesel;
            City.Text = MainWindow.PersonList[klucz].City;
            Adress.Text = MainWindow.PersonList[klucz].Adress;
            ImgFile.Source = MainWindow.PersonList[klucz].Img;
            x.Content = klucz;
        }

        private void Modify(object sender, RoutedEventArgs e)
        {
            if (Pesel.Text == "" || Surname.Text == "" || Name.Text == "" || City.Text == "" || Adress.Text == "" || Pesel.Text.Length != 11)
            {
                MessageBox.Show("Pola nie mogą być puste!\n Pesel musi mieć dokładnie 11 cyfr!");
            }
            else
            {

                MainWindow.PersonList[Convert.ToInt32(x.Content)].Name = Name.Text;
                MainWindow.PersonList[Convert.ToInt32(x.Content)].Surname = Surname.Text;
                MainWindow.PersonList[Convert.ToInt32(x.Content)].Pesel = Pesel.Text;
                MainWindow.PersonList[Convert.ToInt32(x.Content)].City = City.Text;
                MainWindow.PersonList[Convert.ToInt32(x.Content)].Adress = Adress.Text;
                MainWindow.PersonList[Convert.ToInt32(x.Content)].Img = (BitmapImage)ImgFile.Source;
                this.Close();
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



