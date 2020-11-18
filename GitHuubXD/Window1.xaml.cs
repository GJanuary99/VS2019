using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        private BitmapImage imageyes;
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
                MainWindow.PersonList.Add(new MainWindow.Person() { Name = namefield, Surname = surnamefield, Pesel = peselfield, City = cityfield, Adress = adressfield, Img = imageyes });
            }
            catch(Exception blad)
            {
                MessageBox.Show(blad.Message);
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
    }
}
