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

namespace Pipka.Views.GroupActionViews
{
    /// <summary>
    /// Логика взаимодействия для DeleteGroupView.xaml
    /// </summary>
    public partial class DeleteGroupView : UserControl, IUIStateUpdate
    {
        public DeleteGroupView()
        {
            InitializeComponent();
        }

        public void StateUpdate()
        {
            allGroupsCmb.Items.Refresh();
        }
    }
}
