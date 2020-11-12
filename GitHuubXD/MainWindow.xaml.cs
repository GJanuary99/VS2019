using System;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [XmlArray("DataGridXAML"), XmlArrayItem(typeof(List<Person>), ElementName = "Person")]
        public static List<Person> PersonList = new List<Person>();
        Window1 window1 = new Window1();
        public MainWindow()
        {
            InitializeComponent();
            var mySerializer = new XmlSerializer(typeof(List<Person>));
            var myFileStream = new FileStream("../../xml/sertest.xml", FileMode.Open);
            PersonList = (List<Person>)mySerializer.Deserialize(myFileStream);
            ListViewXAML.ItemsSource = PersonList;
            window1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Person>));

            using (FileStream fs = new FileStream("../../xml/sertest.xml", FileMode.Create))
            {
                ser.Serialize(fs, PersonList);
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
        }


    }
}
