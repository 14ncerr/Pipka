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
    public class DeleteDisciplineViewModel
    {
        public TeacherAndDiscipline SelectedTeacherAndDiscipline { get; set; }
        public Discipline SelectedDiscipline { get; set; }
        public string SelectedTADFIOstring { get; set; }

        private List<TeacherAndDiscipline> _allTeacherAndDisciplines = new List<TeacherAndDiscipline>();
        public List<TeacherAndDiscipline> AllTeacherAndDisciplines
        {
            get { return _allTeacherAndDisciplines; }
            set
            {
                _allTeacherAndDisciplines = value;
            }
        }

        public DeleteDisciplineViewModel()
        {
            AllTeacherAndDisciplines = DataManage.AllTeacherAndDisciplines;
        }

        private RelayCommand _deleteTeacherAndDisciplineCommand;

        public RelayCommand DeleteTeacherAndDisciplineCommand
        {
            get
            {
                return _deleteTeacherAndDisciplineCommand ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        try
                        {
                            SelectedTADFIOstring = SelectedTeacherAndDiscipline.TeacherFIOAndDiscipline;

                            db.TeacherAndDisciplines.Remove(SelectedTeacherAndDiscipline);
                            SelectedDiscipline = SelectedTeacherAndDiscipline.Discipline;
                            db.Disciplines.Remove(SelectedDiscipline);

                            DataManage.AllTeacherAndDisciplines.Remove(SelectedTeacherAndDiscipline);
                            DataManage.AllDisciplines.Remove(SelectedDiscipline);

                            (obj as ComboBox).Items.Refresh();
                            db.SaveChanges();

                            MessageBox.Show($"Запись: {SelectedTADFIOstring} удалена.");
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
            SelectedDiscipline = null;
            SelectedTeacherAndDiscipline = null;
        }
    }
}
