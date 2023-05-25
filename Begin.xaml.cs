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
using System.Windows.Shapes;

namespace WpfApp_PR8
{
    /// <summary>
    /// Логика взаимодействия для Begin.xaml
    /// </summary>
    public partial class Begin : Window
    {
        Work work;
        public Begin(Work work)
        {
            this.work = work;
            InitializeComponent();
        }
        bool case_check;
        private void uc_cb_Checked(object sender, RoutedEventArgs e)
        {
            work.Case_Check = true;
            lc_cb.IsChecked = false;
        }

        private void lc_cb_Checked(object sender, RoutedEventArgs e)
        {
            work.Case_Check = false;
            uc_cb.IsChecked = false;
        }

        private void border_cb_Checked(object sender, RoutedEventArgs e)
        {
            work.Border = false;
            work.Border = !work.Border;
        }

        private void italic_cb_Checked(object sender, RoutedEventArgs e)
        {
            work.Italic = false;
            work.Italic = !work.Italic;
        }

        private void save_btn_Click(object sender, RoutedEventArgs e)
        {
            work.Word = word_tb.Text;
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }
    }
}
