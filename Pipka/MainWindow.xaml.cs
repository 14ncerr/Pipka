using Microsoft.EntityFrameworkCore;
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

namespace Pipka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                DataManage.AllGroups = db.Groups.ToList();
                DataManage.AllTeachers = db.Teachers.ToList();
                DataManage.AllDisciplines = db.Disciplines.ToList();

                DataManage.AllTeacherAndDisciplines = db.TeacherAndDisciplines.Include(tAD => tAD.Teacher)
                    .Include(tAD => tAD.Discipline).ToList();

                DataManage.AllClassTimes = db.ClassTimes.ToList();
                DataManage.AllSchedules = db.Schedules.Include(s => s.Group)
                    .Include(s => s.ClassTime)
                    .Include(s => s.TeacherAndDiscipline)
                    .ToList();
            }
                
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
