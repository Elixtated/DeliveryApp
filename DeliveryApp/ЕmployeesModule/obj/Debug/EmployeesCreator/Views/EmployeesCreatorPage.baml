   M S B A M L   `   `   `  ����K  GЕmployeesModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:ЕmployeesModule.EmployeesCreator.Views'ЕmployeesModule.EmployeesCreator.Views  5      B    <ЕmployeesModule.EmployeesCreator.Views.EmployeesCreatorPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:ЕmployeesModule.EmployeesCreator.Views     5      $	��490��5	      $	��640��6     N� 
Background
  ����� � DataContext 5      �� .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $!��ФИО сотрудника��6   $��0��5      $��Right=�5      $��Center=�5      �� 5   
   $%��Номер сотрудника��6   $��1��5      $��Right=�5      $��Center=�5      �� 5   
   $+��%Дожность сотрудника��6   $��2��5       $��Right=�5!      $��Center=�5"      �� 5#   
   $��1��6   $��0��5$      $
��Left=�5%      $��Center=�5&      $	��100��5'      $��20��5(      $��20 0 0 0q�5)      ��5*      �� *EmployeeName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5+   
   $��1��6   $��1��5,      $
��Left=�5-      $��Center=�5.      $	��100��5/      $��20��50      $��20 0 0 0q�51      ��52      �� *EmployeeNumber+$ TwoWay=�$ PropertyChanged=��� 53   
   $��1��6   $��2��54      $
��Left=�55      $��Center=�56      $	��100��57      $��20��58      $��20 0 0 0q�59      ��5:      �� *EmployeePosition+$ TwoWay=�$ PropertyChanged=��� 5;   
   $��1��6   $��3��5<      $	��100��5=      $��30��5>      $��Bottom=�5?      $��Right=�5@      $��
0,0,100,30q�5A      $��Сохранить��5B      ��5C      �� *SaveEmployeeCommand+5D      5E      