   M S B A M L   `   `   `  ����@  <Pipka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PipkaPipka  5   	   3clr-namespace:Pipka.ViewModelsPipka.ViewModels  5   	       Pipka.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Pipka     5   	   -vmclr-namespace:Pipka.ViewModels     5   	     � Title$  Расписание��5	   	   $	��450��5
   	   $	��800��5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � DataContext 5      '   !Pipka.ViewModels.StarterViewModel  5   
   .��5      �� -   5        ���#25252b �� CornerRadius$ 	0 0 20 20��5      ._�5   
   �  � RowDefinitions 5      �� 5      $
��0.1* �6    �� 5      $��0.15* �6    �� 5      .+�5!      �  � ColumnDefinitions 5"      �� 5#      $	��160 �6'   �� 5$      �� 5%      $��50 �6'   .+�5(      �� -   5        $��2��5)         
ExitButton#��[  5*      5+      �� 5-      $��0��5.      $)��#Режим конструктора��5/      $��4q�50      $	��160��51      $��0q�52      ��53      �� *!EntitySelectActionWindowCommand+55      �� 58      $��1��59       �� Orientation$ 
Horizontal=�5:      .+�5;      �� $��	Дата:��5<      
�������$��14(�5>      $
��Left=�5?      $��8q�5@      (  "System.Windows.Controls.DatePicker  5B      $	��140��5C      $��50��5D      $��8q�5E      	   SelectedDate	 5F      �� *SelectedDate+�� 5H      $��Группа:��5I      
�������$��14(�5K      $
��Left=�5L      $��Center=�5M      $��8q�5N      �� 5P      $	��200��5Q      $��8q�5R      $��Center=�5S      $��24��5T      
 �� DisplayMemberPath$

 Name��5V      ��5U      �� *	AllGroups+ �� SelectedItem 5W      �� *SelectedGroup+�� 5Y      $��8q�5Z      $��Сортировка��5[      $��80��5\      $��0q�5]      ��5^      �� *ApplyFilters+��5_      ��  �� ElementName$ ScheduleListView���� 5a      $��8q�5b      $��
Сброс��5c      $��80��5d      $��0q�5e      ��5f      �� *DeleteFilters+��5g      �� $ ScheduleListView��5h      �� 5o      -   5         ��Name$ ScheduleListView��5p      $��2��5q      
���   �
���������5t      �� *AllSchedules+ 5u      �� *SelectedItem+ �� View 5x      �� 5y      .P�5{      ��  �� Width$ 80��5}   !    �� DisplayMemberBinding 5|   !   �� *Date+ �� StringFormat$ 
dd/MM/yyyy��.��5~      �� ._�5   "   �� $��Дата��5�   )   $
��Bold"�5�   )   $��16(�5�   )   5�      5�      �� 5�      $	 160��5�   !    5�   !   �� *ClassTime.FullView+.��5�   "   �� ._�5�   &   �� $��
Время��5�   )   $
��Bold"�5�   )   $��16(�5�   )   5�   #   5�      �� 5�      $ 80��5�   !    5�   !   �� *
Group.Name+.��5�   "   �� ._�5�   &   �� $��Группа��5�   %   $
��Bold"�5�   %   $��16(�5�   %   5�   #   5�      �� 5�      $	 180��5�   !    5�   !   �� *.,TeacherAndDiscipline.TeacherFIOAndDiscipline+.��5�   "   �� ._�5�   &   �� $��Дисциплина��5�   )   $
��Bold"�5�   )   $��16(�5�   )   5�   #   5�      5�      5�      5�      5�      5�      