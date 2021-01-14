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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Shapes;

namespace GitHuubXD
{
    /// <summary>
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        int x = 1;
        public Window3()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClassBase.readBase();
            myDataGrid.ItemsSource = ClassBase.dataTable.DefaultView;
        }

        private void SaveToBase(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
