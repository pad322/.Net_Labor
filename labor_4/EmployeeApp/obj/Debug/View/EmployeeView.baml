   M S B A M L   `   `   `  ����F  BEmployeeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:EmployeeApp.ViewEmployeeApp.View  5      #    EmployeeApp.View.EmployeeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:EmployeeApp.View     5      .��5	      � $��15q�6     � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Employee Management��6   $��0��5      $��0��5      $��2��5      $��20(�5      $
��Bold"�5      $��Center=�5      $	��5,8q�6    �� Padding$ 3q�6,   �� 5   
   $��Id��6   $��1��6   $��0��6+   $	��5,8q�6;   $ 3q�6H   �� 5   
   $
��Name��6   $��2��6    $��0��6-   $	��5,8q�6=   $ 3q�6J   �� 5    
   $	��Age��6   $��3��6   $��0��6,   $	��5,8q�6<   $ 3q�6I   �� 5!   
   -   5         ��Name$ txtBxId��5!      $��1��6#   $��1��60   $	��5,8q�6@   $��3q�6M   ��6Y   ��  �� Path$ CurrentEmployee.Id� �� Mode$ TwoWay=��� 5"   
   -   5        $ 	txtBxName��5"      $��2��6%   $��1��62   $	��5,8q�6B   $��3q�6O   ��6[   �� $ CurrentEmployee.Name�$ TwoWay=��� 5#   
   -   5        $ txtBxAge��5#      $��3��6$   $��1��61   $	��5,8q�6A   $��3q�6N   ��6Z   �� $ CurrentEmployee.Age�$ TwoWay=��� 5$   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��1��6;   .+�5%      �� -   5         ��Name$ btnAdd��5%      $	��Add��6%   $	��5,8q�63   $��3q�6@   ��6L   �� $ SaveCommand��� 5&      -   5        $ 	btnSearch��5&      $��Search��6(   $	��5,8q�69   $��3q�6F   ��6R   �� $ SearchCommand��� 5'      -   5        $ 	btnUpdate��5'      $��Update��6(   $	��5,8q�69   $��3q�6F   ��6R   �� $ UpdateCommand��� 5(      -   5        $ 	btnDelete��5(      $��Delete��6(   $	��5,8q�69   $��3q�6F   ��6R   �� $ DeleteCommand�5)      �� 5*   
   -   5         ��Name$ txtBlckMessage��5*      $��5��6,   $��1��69   $	��5,8q�6I   $ 3q�6V   ��6b   �� $ Message�&   System.Windows.Controls.DataGrid  5+   
   -	   5        	  Name$	 dtGrd��5+      
   AutoGenerateColumns
 .  $��6��6>   $��1��6K   $	��5,8q�6[   $��3q�6h   ��6t   �� $ 	Employees�$ TwoWay=�   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� $ Id�  5.      $
 Name��6%   $
 auto 63    6@   �� $
 Name�  5/      $	 Age��6%   $
 auto 62    6?   �� $	 Age�51      52      53      