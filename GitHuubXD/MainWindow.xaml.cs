using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace GitHuubXD
{
    public partial class MainWindow : Window
    {
        [XmlArray("DataGridXAML"), XmlArrayItem(typeof(List<Person>), ElementName = "Person")]
        public static List<Person> PersonList = new List<Person>();

        public MainWindow()
        {
            InitializeComponent(); 
        }
  
        private void Save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            {
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == true)
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
                    try
                    {
                        using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            ser.Serialize(fs, PersonList);
                        }
                    }
                    catch (Exception blad)
                    {
                        MessageBox.Show(blad.Message);
                    }
                }
            }
        }

        private void Refreshwindow(object sender, RoutedEventArgs e)
        {
            ListViewXAML.ItemsSource = null;
            ListViewXAML.ItemsSource = PersonList;
        }
        private void listView_Click(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedIndex;
            if (item > -1)
            {
                Window2 win3 = new Window2(item);
                win3.Show();
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Pesel { get; set; }
            public string City { get; set; }
            public string Adress { get; set; }
            [XmlIgnore()]
            public BitmapImage Img { get; set; }
            [XmlElement("Imgxml")]
            public string imgxml { get { return Img.UriSource.ToString(); } set { Img = new BitmapImage(new Uri(value)); } }
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == true)
                {
                    try
                    {
                        var mySerializer = new XmlSerializer(typeof(List<Person>));
                        var myFileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                        PersonList = (List<Person>)mySerializer.Deserialize(myFileStream);
                        ListViewXAML.ItemsSource = PersonList;
                    }
                    catch (Exception blad)
                    {
                        MessageBox.Show(blad.Message);
                    }
                }
            }
        }
    }
}
