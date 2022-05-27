using Microsoft.EntityFrameworkCore;
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

namespace Pipka.ViewModels.DisciplineActionViewModels
{
    public class AddNewDisciplineViewModel : ViewModel
    {
        public string DName { get; set; }
        public Teacher SelectedTeacher { get; set; }
        public Discipline SelectedDiscipline { get; set; }


        private List<Teacher> _allTeachers = new List<Teacher>();

        public List<Teacher> AllTeachers
        {
            get { return _allTeachers; }
            set
            {
                _allTeachers = value;
            }
        }

        public AddNewDisciplineViewModel()
        {
            AllTeachers = DataManage.AllTeachers;
        }

        private RelayCommand _addNewDisciplineCommand;

        public RelayCommand AddNewDisciplineCommand
        {
            get
            {
                return _addNewDisciplineCommand ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        try
                        {

                            Discipline discipline = new()
                            {
                                Name = DName
                            };
                            db.Disciplines.Add(discipline);
                            db.SaveChanges();

                            TeacherAndDiscipline teacherAndDiscipline = new()
                            {
                                TeacherId = SelectedTeacher.Id,
                                DisciplineId = discipline.Id,
                                
                            };
                            db.TeacherAndDisciplines.Add(teacherAndDiscipline);
                            db.SaveChanges();     
                            
                            DataManage.AllDisciplines.Add(discipline);
                            teacherAndDiscipline.Teacher = SelectedTeacher;
                            teacherAndDiscipline.Discipline = discipline;
                            DataManage.AllTeacherAndDisciplines.Add(teacherAndDiscipline);
                        

                            MessageBox.Show($"Успешно! Дисциплина {discipline.Name} добавлена.");
                            SetNullValuesToProperties();
                            (obj as ComboBox).SelectedItem = null;
                        }
                        catch (DbUpdateException)
                        {
                            MessageBox.Show("Введённые данные не корректны.");
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
            DName = null;
            SelectedTeacher = null;
            SelectedDiscipline = null;
        }
    }
}
