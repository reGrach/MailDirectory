   M S B A M L   `   `   `  ����H  DMailDirectory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MailDirectoryMailDirectory  5      #    MailDirectory.PageAddEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MailDirectory     5        N� Title$#  Новый сотрудник��5	       � 	Resources 5         	plainText �� 
TargetType �� Property �� Value  
inputStyle��%  &	        &	 �     �� 5   
   " ��6"   .�5      ��  � ��$ 0,5,0,5q�6'   �� 5       � ��$ Black"�6+   �� 5       � ��$ Italic$�6*   �� 5       � ��$ 20(�6)   �� 5       � ��$ Times New Roman)�6+   5      �� 5   
   " ��6#   .�5      ��  � ��$	 180��6&   �� 5       � ��$ 0,5,0,5q�6'   �� 5       � ��$ Stretch=�64   �� 5       � ��$ Normal"�6+   �� 5       � ��$ 20(�6)   �� 5       � ��$ Times New Roman)�6+   5      5      .��5      � $��10,10,10,10q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       $
��Auto �6    � RowDefinitions 5#   
   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   .+�5)   
   �� $��0��6   $��5��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   .+�5*      �� $��0,10,5,5q�5+      $��Times New Roman)�5,      $
��Bold"�6.   $��26(�6@   ���	#FF5276D4$��Italic$�6e   $#��НОВЫЙ СОТРУДНИК��5-      �� 5/      $��5,5,5,5q�51      $��40��52      $��40��6   ��50      �� *AddEmployee+��53      Z� ��6)   Z� ��6@   Z� .��54      �� $��plus.ico��6   55      57      �� 5:   
   $��0��5;      $��1��6   $��Фамилия:��5<      #��[  5=      �� 5?   
   $��0��5@      $��2��6   $��Имя:��5A      #��[  5B      �� 5D   
   $��1��5F      $��1��6   #��[ 5G      ��5E      �� *InputSecondName+5G      �� 5J   
   $��1��5L      $��2��6   #��[ 5M      ��5K      �� *InputFirstName+5M      5N      5O      