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
    /// Логика взаимодействия для Work.xaml
    /// </summary>
    public partial class Work : Window
    {
        public Work()
        {
            InitializeComponent();
        }
        public bool Case_Check { get; set; }
        public bool Italic { get; set; }
        public bool Border { get; set; }
        public string Word { get; set; }

       

        private void result_btn_Click(object sender, RoutedEventArgs e)
        {
            result_lbl.Content = " ";
            result_lbl.Content = Word;
            if (Italic == true)
            {
                result_lbl.FontStyle = FontStyles.Italic;
            }
            else
            {
                result_lbl.FontStyle = FontStyles.Normal;
            }
            if(Border == true)
            {
                result_lbl.FontWeight = FontWeights.Bold;
            }
            else
            {
                result_lbl.FontWeight = FontWeights.Normal;
            }
            if(Case_Check == true)
            {
                result_lbl.Content = result_lbl.Content.ToString().ToUpper();
            }
            else
            {
                result_lbl.Content = result_lbl.Content.ToString().ToLower();
            }

        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }
    }
}
