   M S B A M L   `   `   `  ����E  AWPFProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFProject.PagesWPFProject.Pages  5           WPFProject.Pages.DealsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WPFProject.Pages     5        N� Title$  	DealsPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      -   5         ��Name$ SplitterColumn��5   )   $��0 �6   6)   �� 5      -   5        $ ChangeColumn��5   )   $��0 �6   $	��175��6?   �� 5      -   5        $ SplitterColumnTwo��5   )   $��0 �6   6)   �� 5      -   5        $ ChangeColumnTwo��5   )   $��0 �6   $	��175��6B    � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� ���	#FF42992F$��0��6%   $��0��62   $��5��6B   �� 5   
   $��Сделки��6   $��3��6!   $��20(�65   $��Bottom=�5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ AddAreas��5      $��Добавить��6'   $��75��6:   $	��5,5q�6E   6S   �� 5      -   5        $ 	CopyAreas��5      $��Копировать��6(   $��75��6=   $	��5,5q�6H   6U   �� 5      -   5        $ 	EditAreas��5      $��Изменить��6(   $��75��6;   $	��5,5q�6F   6S   �� 5      -   5        $ DeleteAreas��5      $��Удалить��6*   $��75��6<   $	��5,5q�6G   6T   5       &   System.Windows.Controls.DataGrid  5!   
   -	   5          Name$ DealsDataGrid��5!      $��2��6*   $��0��67      AutoGenerateColumns .     CanUserAddRows .  	   Columns	 5"      4  .System.Windows.Controls.DataGridTemplateColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Риэлтор��5&   5      CellTemplate 5'      �� 5(      .R�5)      �� ��6$   �� *PEOPLE.SURNAME+5*      5,        5.      $
 Клиент��51   1    52      �� 53      .R�54      �� ��6    �� *PEOPLE.SURNAME+55      57        59      $
 Предложение��5<   1    5=      �� 5>      .R�5?      �� ��6    �� *PROPOSALS.STREET+5@      5B        5D      $
 Дата сделки��5G   1    5H      �� 5I      .R�5J      �� ��6    �� *
DATA_DEALS+5K      5M        5O         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6)   $'
 !Коммисия риэлтора��5R   5    5S      �� 5T      .R�5U      �� ��6$   �� *	COMM_REAL+5V      5X      5Z      �� 5[   
   $��1��6   $��1��6'   $��2��64   $��Center=�6E   $��5��5\      �� 5]   
   -
   5        $��X��5]      $��2��68   $��1��6H   $��25��6U   $��25��6`   $��Right=�6l   $	��Top=�6�   �� 5^   
   -   5         ��Name$ ProposalsScrollBar��5^   E   $��2��6   $��3��6(   $��2��65   .��5_      �� $ Vertical=�6   .+�5`      �� $%��Фамилия риэлтора��6   
���   �65   �� 5a      -   5         ��Name$ RealComboBox��5a       �� DisplayMemberPath$ SURNAME��61    �� Text 6M   ��  �� ElementName$ DealsDataGrid�� �� Path$! SelectedItem.PEOPLE.SURNAME��� 5b      $%��Фамилия продавца��6   
���   �66   �� 5c      -   5        $ SellerComboBox��5c      $ SURNAME��63    6O   �� $ DealsDataGrid��$! SelectedItem.PEOPLE.SURNAME��� 5d      $��Тип объекта��6   
���   �60   �� 5e      -   5        $ ProposalsComboBox��5e      $ STREET��66    6Q   �� $ DealsDataGrid��$# SelectedItem.PROPOSALS.STREET��� 5f      $��Дата сделки��6   
���   �60   (  "System.Windows.Controls.DatePicker  5g      -   5          Name$ DealsDatePicker��5g         SelectedDateFormat$ Short=�66      SelectedDate 6Q   �� $ DealsDataGrid��$ SelectedItem.DATA_DEALS�   Text 6�   �� $ DealsDataGrid��$ SelectedItem.DATA_DEALS��� 5h      $��Коммисия��6   
���   �6-   �� 5i      -   5         ��Name$ ProposalsCommRealTextBox��5i   d   ��6   �� $ DealsDataGrid��$ SelectedItem.COMM_REAL�6d   �� 5j      -   5        $��25��5j      $��Принять��6%   $��	0 10 0 10q�6U   5k      5l      �� 5n   
   $��3��6   $��1��6'   $��2��64   $��Center=�6E   $��5��5o      �� 5p   
   -   5        $��X��5p      $��4��68   $��1��6H   $��25��6U   $��25��6`   $��Right=�6l   $	��Top=�6�   �� 5q   
   -   5        $ ProposalsScrollBarCopy��5q   E   $��2��6   $��3��6(   $��4��65   .��5r      �� $ Vertical=�6   .+�5s      �� $%��Фамилия риэлтора��6   
���   �65   �� 5t      -   5        $ RealComboBoxCopy��5t       65   �� $ RealComboBox��$
 Text��� 5u      $%��Фамилия продавца��6   
���   �65   �� 5v      -   5        $ SellerComboBoxCopy��5v       67   �� $ SellerComboBox��$
 Text��� 5w      $��Тип объекта��6   
���   �60   �� 5x      -   5        $ ProposalsComboBoxCopy��5x       6;   �� $ DealsDataGrid��$! SelectedItem.PEOPLE.SURNAME� 6�   �� $ ProposalsComboBox��$ SelectedItem��� 5y      $��Дата сделки��6   
���   �60     5z      -   5        $ DealsDatePickerCopy��5z       6:   �� $ DealsDatePicker��$
 Text��� 5{      $��Коммисия��6   
���   �6-   �� 5|      -   5        $" ProposalsCommRealTextBoxCopy��5|   \   ��6   �� $ ProposalsCommRealTextBox��$
 Text�6\   �� 5}      -   5        $��25��5}      $��Принять��6%   $��	0 10 0 10q�6U   5~      5      5�      5�      