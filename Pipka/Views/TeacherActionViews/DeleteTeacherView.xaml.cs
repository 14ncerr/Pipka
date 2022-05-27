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

namespace Pipka.Views.TeacherActionViews
{
    /// <summary>
    /// Логика взаимодействия для DeleteTeacherView.xaml
    /// </summary>
    public partial class DeleteTeacherView : UserControl, IUIStateUpdate
    {
        public DeleteTeacherView()
        {
            InitializeComponent();
        }

        public void StateUpdate()
        {
            DeleteAllTeachersCmb.Items.Refresh();
        }
    }
}
