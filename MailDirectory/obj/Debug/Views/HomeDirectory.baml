   M S B A M L   `   `   `  ����H  DMailDirectory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MailDirectoryMailDirectory  5      !    MailDirectory.HomeDirectory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MailDirectory     5        N� Title$'  !Домашняя страница��5	       � 	Resources 5
         buttonStyle �� 
TargetType �� Property �� Value  DGridHeader=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	 3    �� 5   
   " ��6$   .�5      ��  � ��$ 5,5,5,5q�6'   �� 5       � ��$ 30��6'   �� 5       � ��$	 175��6&   �� 5       � ��$ 14(�6)   �� 5       � ��$ Times New Roman)�6+   �� 5       � ��
 �   �6+   �� 5       � ��# � ��6+   5      �� 5   
   "  6$   .�5      ��  � ��$ Center=�6A   �� 5       � ��$ 18(�6/   �� 5       � ��$ Times New Roman)�61   5      5      .��5      � $��10,10,10,10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��250 �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   .+�5#   
   �� $��0��5$      $��5,5,5,5q�5%      $��Times New Roman)�5&      $
��Bold"�6*   $��26(�6<   ���	#FF5276D4$��Italic$�6a   $��КАТАЛОГ ПИСЕМ��5'      &   System.Windows.Controls.DataGrid  5)   
      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5*      $��1��5+         SelectionUnit$ FullRow=�5,         
IsReadOnly . 	   ColumnHeaderStyle#	 [ 50      $��14(�52      
   AutoGenerateColumns
 .     SelectionMode$ Single=�53   )    �� SelectedItem 5.      �� *SelectedLetter+��5/      �� *	Letters+��51      Z�    Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата��6>      Width$ 80 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Date+6L     56      $ Тема письма��6A   $	 150 6V    6%   �� *	Subject+6V     57      $ Отправитель��6@   $	 150 6U    6%   �� *Sender+6U     58      $ Получатель��6C   $	 150 6W    6%   �� *	Recipient+6W   5:      �� 5<   
   $��2��5=      $��14(�5>      $	��100��5?       �� 
IsReadOnly . $��Times New Roman)�5B   T    �� TextWrapping$
 Wrap=�6q    � DataContext 5A      �� *SelectedLetter+��5B      ��  �� Path$ TextMessage� �� UpdateSourceTrigger$ PropertyChanged=�6q   �� 5D   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5F      �� #��[  5G      ��5H      �� *OpenPageAddLetterCommand+��5I      �� *AddLetterViewMode+.��6@   Добавить письмо6Q   �� 5K      #��[  5L      ��5M      �� *RemoveLetter+.��62   Удалить письмо6B   �� 5O      #��[  5P      ��5Q      �� *OpenPageAddEmployeeCommand+��5R      �� *AddEmployeeViewMode+.��6B   '%Добавить сотрудника6W   5T      5U      5V      