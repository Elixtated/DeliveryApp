   M S B A M L   `   `   `  ����F  BDeliveryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:DeliveryApp.OrderCreator.ViewModels#DeliveryApp.OrderCreator.ViewModels  5      G CCommonModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS9clr-namespace:CommonModule.Controls;assembly=CommonModuleCommonModule.Controls 5      6    0DeliveryApp.OrderCreator.Views.OrdersCreatorPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      G	viewModel1clr-namespace:DeliveryApp.OrderCreator.ViewModels     5      Ncontrols9clr-namespace:CommonModule.Controls;assembly=CommonModule     5        N� Title$  OrdersCreatorPage��5
      $	��490��6!   $	��640��6.   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��70 �6   �� 5      $��1* �6   .+�5   
   �� $��Номер заявки��6   $��1��5      $��Right=�5      $��Center=�5      �� 5   
   $��Дата заявки��6   $��2��5      $��Right=�5       $��Center=�5!      �� 5"   
   $4��.Плановая дата выполнения��6   $��3��5#      $��Right=�5$      $��Center=�5%      �� 5&   
   $ ��Ответственный��6   $��4��5'      $��Right=�5(      $��Center=�5)      �� 5*   
   $��О заявке��6   $��5��5+      $��Right=�5,      $��Center=�5-      (  "CommonModule.Controls.DigitTextBox  51   
   $	��100��52      $��20��53      $��1��54      $��1��55      $
��Left=�56      $��Center=�57      $��20 0 0 0q�58      ��59      �� *OrderNumber+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�(  "System.Windows.Controls.DatePicker  5;   
   $��1��6   $��2��5<      $
��Left=�5=      $��Center=�5>      $��20 0 0 0q�5?         Text 5@      �� *	DateOrder+$ TwoWay=�$ PropertyChanged=�  5A   
   $��1��6   $��3��5B      $
��Left=�5C      $��Center=�5D      $��20 0 0 0q�5E       5F      �� *DateComplete+$ TwoWay=�$ PropertyChanged=��� 5G   
   $��1��6   $��4��5H      $
��Left=�5I      $��Center=�5J      $	��100��5K      $��20��5L      $��20 0 0 0q�5M      ��5N      �� *LeaderOrder+$ TwoWay=�$ PropertyChanged=��� 5O   
   $��1��6   $��5��5P      $
��Left=�5Q      $��Center=�5R      $��60��5S      $	��200��5T      $��20 0 0 0q�5U       �� TextWrapping$
 Wrap=�5V      " �� VerticalScrollBarVisibility$ Visible=�5W       �� AcceptsReturn . ��5Y      �� *
AboutOrder+$ TwoWay=�$ PropertyChanged=��� 5Z   
   $��1��5[      $��6��5\      $	��100��5]      $��30��5^      $��Bottom=�5_      $��Right=�5`      $��
0,0,100,30q�5a      $��Сохранить��5b      ��5c      �� *SaveOrderCommand+$ Default=�5e      5f      5g      