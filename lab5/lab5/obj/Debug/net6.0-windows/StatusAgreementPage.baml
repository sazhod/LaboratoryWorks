   M S B A M L   `   `   `  ����?  ;lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab5lab5  5          lab5.StatusAgreementPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:lab5     5         Page#��[  5	        N� FontSize$  15(�5
       N� Title$ StatusAgreementPage��5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ local:Commands.Undo��5      5        5   
   -   5        $ local:Commands.New��5      5        5   
   -   5        $ local:Commands.Save��5      5        5   
   -   5        $ local:Commands.Find��5      5        5   
   -   5        $ local:Commands.Edit��5      5         5"   
   -   5        $ local:Commands.Delete��5"      5$      .��5'      �  � ColumnDefinitions 5(   
   �� 5)       � RowDefinitions 5+   
   �� 5,      $��1* �6   �� 5-      $��1* �6   �� 5.      $��1* �6   �� 5/      $	��10* �6   .+�51   
   o� $��0��6   $��0��6     MenuBar#��[ 6,   .@�52      m� $��Действие��6     MenuItem#��[ 6)   .@�53      m� $
��Undo��6    m� Command$ local:Commands.Undo��6)   #��[ 6G   m� 54      $	��New��6   $ local:Commands.New��6(   #��[ 6E   m� 55      $
��Edit��6   $ local:Commands.Edit��6)   #��[ 6G   m� 56      $
��Save��6   $ local:Commands.Save��6)   #��[ 6G   m� 57      $
��Find��6   $ local:Commands.Find��6)   #��[ 6G   m� 58      $��Delete��6   $ local:Commands.Delete��6+   #��[ 6K   59      m� 5:      $��
Отчет��6   #��[ 6&   5;      c� 5=   
   $��0��6   $��1��6"   .@�5>      �� -   5        $
��Undo��5>       � ToolTip$
 Undo��6!   $��local:Commands.Undo��60   .��5?      �� $��Images/Undo.png��6   $��20��61   $��20��6<   5@      �� 5A      -   5        $	��New��5A      $	 Add��6    $��local:Commands.New��6.   .��5B      �� $��Images/New.png��6   $��20��60   $��20��6;   5C      �� 5D      -	   5        $
��Edit��5D      $
 Edit��6!   $��local:Commands.Edit��60   .��5E      �� $��Images/Edit.png��6   $��20��61   $��20��6<   5F      �� 5G      -
   5        $
��Find��5G      $
 Find��6"   $��local:Commands.Find��61   .��5H      �� $��Images/Find.png��6   $��20��61   $��20��6<   5I      �� 5J      -   5        $
��Save��5J      $
 Save��6!   $��local:Commands.Save��60   .��5K      �� $��Images/Save.png��6   $��20��61   $��20��6<   5L      �� 5M      -   5        $��Delete��5M      $ Delete��6#   $��local:Commands.Delete��64   .��5N      �� $��Images/Delete.png��6   $��20��63   $��20��6>   5O      5P      �� 5Q   
   -   5        $��SearchField��5Q      $��5q�6%   $��0��60   $��2��6@   &   System.Windows.Controls.DataGrid  5R   
   -   5        $��DataGrid��5R   0   $��0��6   $��3��6#      AutoGenerateColumns$ False��6@   	   CanUserAddRows$	 False��5S      
   SelectionMode$
 Single=�6*      SelectionUnit$ FullRow=�6A      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y      
IsReadOnly$
 True��5T      ��5R   \   �� *Models.StatusAgrement+   Columns 5U      0  *System.Windows.Controls.DataGridTextColumn  5V      ,  &System.Windows.Controls.DataGridColumn   Header$
 ИД��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5W      $ Статус��6%    65   �� *Status+5Y      5[      5\      