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

namespace Pipka.ViewModels.TeacherActionViewModels
{
    public class AddNewTeacherViewModel
    {

        public string NLastName { get; set; }
        public string NFirstName { get; set; }
        public string NMiddleName { get; set; }
        public string TFullName { get; set; }
        public Teacher SelectedTeacher { get; set; }

        private RelayCommand _addNewTeacherCommand;

        public RelayCommand AddNewTeacherCommand
        {
            get
            {
                return _addNewTeacherCommand ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        try
                        {

                            Teacher teacher = new()
                            {
                                LastName = NLastName,
                                FirstName = NFirstName,
                                MiddleName = NMiddleName
                            };

                            db.Teachers.Add(teacher);
                            DataManage.AllTeachers.Add(teacher);
                            db.SaveChanges();
                            MessageBox.Show($"Успешно! Преподаватель {teacher.FullName} добавлен.");
                            SetNullValuesToProperties();
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
            SelectedTeacher = null;
            NFirstName = null;
            NLastName = null;
            NMiddleName = null;
        }

    }
}
