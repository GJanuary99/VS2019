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

        public Window2(int item)
        {
            int klucz = item;
            InitializeComponent();
            Name.Text = MainWindow.PersonList[klucz].Name;
            Surname.Text = MainWindow.PersonList[klucz].Surname;
            Pesel.CaretIndex= MainWindow.PersonList[klucz].Pesel;
            City.Text = MainWindow.PersonList[klucz].City;
            Adress.Text = MainWindow.PersonList[klucz].Adress;
            ImgFile.Source = MainWindow.PersonList[klucz].Img;
            x.Content = klucz;
        }

        private void Modify(object sender, RoutedEventArgs e)
        {
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Name = Name.Text;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Surname = Surname.Text;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Pesel = Pesel.CaretIndex;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].City = City.Text;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Adress = Adress.Text;
            MainWindow.PersonList[Convert.ToInt32(x.Content)].Img = (BitmapImage)ImgFile.Source;
            this.Close();
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

        private void CheckText(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^\p{L}"))
            {
                e.Handled = true;
            }
        }

        private void CheckPesel(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^\p{N}"))
            {
                e.Handled = true;
            }
        }

        

    }
}
