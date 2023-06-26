using System;
using System.Collections.Generic;
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

namespace WpfApp_PR8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Begin begin;
        Work work;
        
        public MainWindow()
        {
            InitializeComponent();
            this.work = new Work();
            this.begin = new Begin(work);
        }
       

        private void begin_btn_Click(object sender, RoutedEventArgs e)
        {
            
            begin.Show();
        }

        private void work_btn_Clicked(object sender, RoutedEventArgs e)
        {
            work.Show();
        }

        private void close_btn_Close(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void what_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
