   M S B A M L   `   `   `  ����@  <Pipka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Pipka.Views.TeacherActionViewsPipka.Views.TeacherActionViews  5      c6clr-namespace:Pipka.ViewModels.TeacherActionViewModels(Pipka.ViewModels.TeacherActionViewModels  5      6    0Pipka.Views.TeacherActionViews.AddNewTeacherView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Pipka.Views.TeacherActionViews     5      Evm6clr-namespace:Pipka.ViewModels.TeacherActionViewModels     5        � DataContext  5      E   ?Pipka.ViewModels.TeacherActionViewModels.AddNewTeacherViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��1.8* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��5* �6   �� 5      .+�5   
   �� $��1��6   $��1��5      ���#2b2b2d.+�5!      �� $��Фамилия��5"      
�������$��18(�5$      $
��Left=�5%      $��8q�5&      �� 5(      $��8q�5)      $��24��5*      ��5+      �� *	NLastName+�� 5-      $��Имя��5.      
�������$��18(�50      $
��Left=�51      $��8q�52      �� 54      $��8q�55      $��24��56      ��57      �� *
NFirstName+�� 59      $��Отчество��5:      
�������$��18(�5<      $
��Left=�5=      $��8q�5>      �� 5@      $��8q�5A      $��24��5B      ��5C      �� *NMiddleName+�� 5E      $��8 16 8 8q�5F      $��34��5G      $��Добавить��5H      ��5I      �� *AddNewTeacherCommand+5J      5K      5N      