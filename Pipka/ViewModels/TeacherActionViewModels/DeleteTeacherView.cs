using Pipka.Core;
using Pipka.Data;
using Pipka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Pipka.ViewModels.TeacherActionViewModels
{
    public class DeleteTeacherView : ViewModel
    {
        public string NLastName { get; set; }
        public string NFirstName { get; set; }
        public string NMiddleName { get; set; }
        public string TFullName { get; set; }
        public Teacher SelectedTeacher { get; set; }


        private List<Teacher> _allTeachers = new List<Teacher>();

        public List<Teacher> AllTeachers
        {
            get { return _allTeachers; }
            set
            {
                _allTeachers = value;
            }
        }

        public DeleteTeacherView()
        {
            AllTeachers = DataManage.AllTeachers;
        }

        private RelayCommand _deleteTeacherCommand;

        public RelayCommand DeleteTeacherCommand
        {
            get
            {
                return _deleteTeacherCommand ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        try
                        {
                            TFullName = SelectedTeacher.FullName;
                            db.Teachers.Remove(SelectedTeacher);
                            DataManage.AllTeachers.Remove(SelectedTeacher);
                            (obj as ComboBox).Items.Refresh();
                            db.SaveChanges();

                            MessageBox.Show($"Успешно! Преподаватель {TFullName} удалён.");
                            SetNullValuesToProperties();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString() + " Ошибка, что-то пошло не так.");
                            SetNullValuesToProperties();
                        }
                    }
                });
            }

        }

        public void SetNullValuesToProperties()
        {
            SelectedTeacher = null;
            NFirstName = null;
            NLastName = null;
            NMiddleName = null;
        }
    }
}
