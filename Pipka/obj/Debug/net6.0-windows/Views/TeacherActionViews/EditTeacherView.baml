   M S B A M L   `   `   `  ����@  <Pipka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Pipka.Views.TeacherActionViewsPipka.Views.TeacherActionViews  5      c6clr-namespace:Pipka.ViewModels.TeacherActionViewModels(Pipka.ViewModels.TeacherActionViewModels  5      4    .Pipka.Views.TeacherActionViews.EditTeacherView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Pipka.Views.TeacherActionViews     5      Evm6clr-namespace:Pipka.ViewModels.TeacherActionViewModels     5        � DataContext  5      C   =Pipka.ViewModels.TeacherActionViewModels.EditTeacherViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��1.8* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��5* �6   �� 5      .+�5   
   �� $��1��6   $��1��5      ���#2b2b2d.+�5!      �� $��ФИО��5"      
�������$��18(�5$      $
��Left=�5%      $��8q�5&      �� 5(      -   5        $��FIOChangeAllTeachersCmb��5)      $��8q�5*      $��24��5+       �� DisplayMemberPath$ FullName��5-      ��5,      �� *AllTeachers+ �� SelectedItem 5.      �� *SelectedTeacher+�� 50      $��Фамилия��51      
�������$��18(�53      $
��Left=�54      $��8q�55      �� 57      $��8q�58      $��24��59      ��5:      �� *	NLastName+�� 5<      $��Имя��5=      
�������$��18(�5?      $
��Left=�5@      $��8q�5A      �� 5C      $��8q�5D      $��24��5E      ��5F      �� *
NFirstName+�� 5H      $��Отчество��5I      
�������$��18(�5K      $
��Left=�5L      $��8q�5M      �� 5O      $��8q�5P      $��24��5Q      ��5R      �� *NMiddleName+�� 5T      $��8 16 8 8q�5U      $��34��5V      $��Изменить��5W      ��5X      �� *EditTeacherCommand+��5Y      ��  �� ElementName$ FIOChangeAllTeachersCmb��5Z      5[      5^      