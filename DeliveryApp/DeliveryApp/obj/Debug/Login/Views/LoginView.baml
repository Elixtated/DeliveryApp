   M S B A M L   `   `   `  ����F  BDeliveryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DeliveryApp.Login.ViewModelsDeliveryApp.Login.ViewModels  5   	   '    !DeliveryApp.Login.Views.LoginView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   @	viewModel*clr-namespace:DeliveryApp.Login.ViewModels     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Login��5   	   $	��400��6   $	��300��6$   $��14(�60   
��� E��.��5      �� 
������� �� CornerRadius$ 20��5      $��5q�5      ._�5   
   �� $��20q�6   .+�5      �� $��Авторизация��6   
���   �$��25(�5      $��Center=�5      63   �� 5      �� 5      $��
Логин��6   
���   �5   )   �� 5      -   5        $��tbLogin��5      
�������
���   �$��18(�5      ��5      �� *
EnterLogin+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5   M   �� 5      $��Пароль��6   
���   �5    )   �� 5!      -   5        $��
tbPassword��5!      
�������
���   �$��18(�5$      ��5%      �� *EnterPassword+$ TwoWay=�$ PropertyChanged=�5'   M   �� 5(      -   5        $��	btnSubmit��5(      $��
Войти��5)      $��60q�5*      
��� E��
���   �$��18(�5-       � Cursor$
 Hand��5/      ��5.      �� *LoginCommand+5/   %   50      51      52      