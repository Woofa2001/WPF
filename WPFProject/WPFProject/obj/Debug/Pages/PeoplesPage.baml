   M S B A M L   `   `   `  ����E  AWPFProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFProject.PagesWPFProject.Pages  5      "    WPFProject.Pages.PeoplesPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WPFProject.Pages     5        N� Title$  
PeoplePage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      -   5         ��Name$ SplitterColumn��5   )   $��0 �6   6)   �� 5      -   5        $ ChangeColumn��5   )   $��0 �6   $	��175��6?    � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� ���	#FF42992F$��0��6%   $��0��62   $��5��6B   �� 5   
   $��Люди��6   $��3��6   $��20(�63   $��Bottom=�5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ 	AddPeople��5      $��Добавить��6(   $��75��6;   $	��5,5q�6F   6T   �� 5      -   5        $ 
CopyPeople��5      $��Копировать��6)   $��75��6>   $	��5,5q�6I   6V   �� 5      -   5        $ 
EditPeople��5      $��Изменить��6)   $��75��6<   $	��5,5q�6G   6U   �� 5      -   5        $ DeletePeople��5      $��Удалить��6+   $��75��6=   $	��5,5q�6H   6U   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PeopleDataGrid��5      $��2��6+   $��0��68      AutoGenerateColumns .     CanUserAddRows .  	   Columns	 5       4  .System.Windows.Controls.DataGridTemplateColumn  5!      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Фамилия��5$   5      CellTemplate 5%      �� 5&      .R�5'      �� ��6$   �� *	SURNAME+5(      5*        5+      $
 Имя��5.   5    5/      �� 50      .R�51      �� ��6$   �� *NAME+52      54        55         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6)   $
 Отчество��58   5    59      �� 5:      .R�5;      �� ��6$   �� *	MIDNAME+5<      5>      5A      �� 5C   
   $��1��6   $��1��6'   $��2��64   $��Center=�6E   $��5��5D      �� 5F   
   -   5        $��X��5F      $��2��68   $��1��6H   $��25��6U   $��25��6`   $��Right=�6l   $	��Top=�6�   �� 5G   
   $��2��6   $��8��6'   $��2��64   $ Vertical=�6D   .+�5H      �� $��Фамилия��6   
���   �6&   �� 5I      -	   5         ��Name$ PeopleFTextBox��5I   ]   ��6   ��  �� ElementName$ PeopleDataGrid�� �� Path$ SelectedItem.SURNAME�6]   �� 5J      $��Имя��6   
���   �6"   �� 5K      -
   5        $ PeopleITextBox��5K   Z   ��6   �� $ PeopleDataGrid��$ SelectedItem.NAME�6Z   �� 5L      $��Отчество��6   
���   �6'   �� 5M      -   5        $ PeopleOTextBox��5M   ]   ��6   �� $ PeopleDataGrid��$ SelectedItem.MIDNAME�6]   �� 5N      -   5        $��25��5N      $��Принять��6!   $��	0 10 0 10q�6N   5O      5P      5Q      