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

namespace Pipka.ViewModels
{
    public class GroupActionViewModel : ViewModel
    {

        public string GName { get; set; }
        public Group SelectedGroup { get; set; }

        private List<Group> _allGroups = new List<Group>();

        public  List<Group> AllGroups
        {
            get { return _allGroups; }
            set
            {
                _allGroups = value;
            }
        }

        public GroupActionViewModel()
        {
            _allGroups = DataManage.AllGroups;
        }

        private RelayCommand _addNewGroupCommand;

        public RelayCommand AddNewGroupCommand
        {
            get
            {
                return _addNewGroupCommand ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        try
                        {

                            Group group = new()
                            {
                                Name = GName
                            };

                            db.Groups.Add(group);
                            DataManage.AllGroups.Add(group);
                            db.SaveChanges();
                            (obj as ComboBox).Items.Refresh();
                            MessageBox.Show($"Успешно! Группа {group.Name} добавлена.");
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

        private RelayCommand _deleteGroupCommand;

        public RelayCommand DeleteGroupCommand
        {
            get
            {
                return _deleteGroupCommand ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        try
                        {
                         
                            db.Groups.Remove(SelectedGroup);
                            DataManage.AllGroups.Remove(SelectedGroup);
                            (obj as ComboBox).Items.Refresh();
                            db.SaveChanges();

                            MessageBox.Show($"Успешно! Группа {GName} удалена.");
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
            GName = null;
        }



    }
}
