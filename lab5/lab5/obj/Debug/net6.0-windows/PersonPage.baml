   M S B A M L   `   `   `  ����?  ;lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab5lab5  5          lab5.PersonPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:lab5     5        N� Title$  
PersonPage��5	       � 	Resources 5         lab5.DateConverter   DateConverter��%   &	          5   
   6   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ local:Commands.Undo��5      5        5   
   -   5        $ local:Commands.New��5      5        5   
   -   5        $ local:Commands.Save��5      5        5   
   -   5        $ local:Commands.Find��5      5        5    
   -   5        $ local:Commands.Edit��5       5"        5$   
   -   5        $ local:Commands.Delete��5$      5&      .��5)      � 
������� � ColumnDefinitions 5*   
   �� 5+       � RowDefinitions 5-   
   �� 5.      $��1* �6   �� 5/      $��1* �6   �� 50      $��1* �6   �� 51      $	��10* �6   .+�53   
   o� $��0��6   $��0��6   .@�54      m� $��Действие��6   .@�55      m� $��Отменить��6    m� Command$ local:Commands.Undo��6-   �� 56      m� 57      $��Создать��6   $ local:Commands.New��6,   m� 58      $ ��Редактировать��6   $ local:Commands.Edit��62   m� 59      $��Сохранить��6   $ local:Commands.Save��6.   m� 5:      $��
Найти��6   $ local:Commands.Find��6*   �� 5;      m� 5<      $��Удалить��6   $ local:Commands.Delete��6,   5=      m� 5>      $��
Отчет��6   5?      c� 5A   
   $��0��6   $��1��6"   .@�5B      �� -   5        $
��Undo��5B       � ToolTip$ Отменить��6!   $��local:Commands.Undo��64   .��5C      �� $��Images/Undo.png��6   $��20��61   $��20��6<   5D      �� 5E      -   5        $	��New��5E      $ Добавить��6    $��local:Commands.New��63   .��5F      �� $��Images/New.png��6   $��20��60   $��20��6;   5G      �� 5H      -	   5        $
��Edit��5H      $  Редактировать��6!   $��local:Commands.Edit��69   .��5I      �� $��Images/Edit.png��6   $��20��61   $��20��6<   5J      �� 5K      -
   5        $
��Find��5K      $ 
Найти��6"   $��local:Commands.Find��62   .��5L      �� $��Images/Find.png��6   $��20��61   $��20��6<   5M      �� 5N      -   5        $
��Save��5N      $ Сохранить��6!   $��local:Commands.Save��65   .��5O      �� $��Images/Save.png��6   $��20��61   $��20��6<   5P      �� 5Q      -   5        $��Delete��5Q      $ Удалить��6#   $��local:Commands.Delete��65   .��5R      �� $��Images/Delete.png��6   $��20��63   $��20��6>   5S      5T      �� 5U   
   -   5        $��SearchField��5U      $��5q�6%   $��0��60   $��2��6@   &   System.Windows.Controls.DataGrid  5V   
   -   5        $��DataGrid��5V   0   $��0��6   $��3��6#      AutoGenerateColumns$ False��6@   	   CanUserAddRows$	 False��5W      
   SelectionMode$
 Single=�6*      SelectionUnit$ FullRow=�6A      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y      
IsReadOnly$
 True��5X      ��6%   �� *Models.Person+   Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Header$ Код��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Id+  5[      $ ИНН��6%    62   �� *Inn+  5\      $ Тип��6%    62   �� *Type+  5]      $ Шифр��6%    63   �� *Shifer+  5^      $ Дата��6%    63   �� *Date+ �� 	Converter# [  5`      5b      5c      