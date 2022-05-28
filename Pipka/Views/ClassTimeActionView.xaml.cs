using Pipka.Data;
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

namespace Pipka.Views
{
    /// <summary>
    /// Логика взаимодействия для ClassTimeActionView.xaml
    /// </summary>
    public partial class ClassTimeActionView : UserControl
    {
        public ClassTimeActionView()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SettValues(1);
        }
        
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            SettValues(2);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            SettValues(3);
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            SettValues(0);
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            SettValues(4);
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            SettValues(5);
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            SettValues(6);
        }

        private void SettValues(int n)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                startTxt.Text = db.ClassTimes.FirstOrDefault(time => time.ClassPos == n).StartTime.TimeOfDay.ToString();
                endTxt.Text = db.ClassTimes.FirstOrDefault(time => time.ClassPos == n).EndTime.TimeOfDay.ToString();
            }
        }
    }
}
