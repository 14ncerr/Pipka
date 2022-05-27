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
    public class EditTeacherViewModel : ViewModel
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

        public EditTeacherViewModel()
        {
            AllTeachers = DataManage.AllTeachers;
        }

        private RelayCommand _editTeacherCommand;

        public RelayCommand EditTeacherCommand
        {
            get
            {
                return _editTeacherCommand ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        try
                        {
                            SelectedTeacher = db.Teachers.FirstOrDefault(teacher => teacher.Id == SelectedTeacher.Id);
                            SelectedTeacher.LastName = NLastName;
                            SelectedTeacher.FirstName = NFirstName;
                            SelectedTeacher.MiddleName = NMiddleName;
                            db.SaveChanges();




                            MessageBox.Show($"Успешно! Данные о работнике {SelectedTeacher.LastName} {SelectedTeacher.FirstName} {SelectedTeacher.MiddleName}обновлены.");
                            SetNullValuesToProperties();
                            (obj as ComboBox).SelectedItem = null;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString() + " Ошибка, что-то пошло не так.");
                            SetNullValuesToProperties();
                            (obj as ComboBox).SelectedItem = null;
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
