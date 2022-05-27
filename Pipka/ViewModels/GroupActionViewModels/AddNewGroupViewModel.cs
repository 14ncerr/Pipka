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

namespace Pipka.ViewModels.GroupActionViewModels
{
    public class AddNewGroupViewModel : ViewModel
    {

        public string GName { get; set; }

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

        public void SetNullValuesToProperties()
        {
            GName = null;
        }
    }
}
