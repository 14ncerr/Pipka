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

namespace Pipka.Views.DisciplineActionViews
{
    /// <summary>
    /// Логика взаимодействия для DeleteDisciplineView.xaml
    /// </summary>
    public partial class DeleteDisciplineView : UserControl, IUIStateUpdate
    {
        public DeleteDisciplineView()
        {
            InitializeComponent();           
        }

        public void StateUpdate()
        {
            allDisciplinesCmb.Items.Refresh();
        }
    }
}
