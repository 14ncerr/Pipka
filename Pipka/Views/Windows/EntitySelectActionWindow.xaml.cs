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

namespace Pipka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddNewEntityWindow.xaml
    /// </summary>
    public partial class EntitySelectActionWindow : Window
    {
        public EntitySelectActionWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Border_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            DragMove();
        }

        
    }
}
