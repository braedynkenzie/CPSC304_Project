   M S B A M L   `   `   `  ����J  FCPSC304_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CPSC304_ProjectCPSC304_Project  5   	   #    CPSC304_Project.NewUserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CPSC304_Project     5   	     � WindowStyle$
  None=�5       � Title$ NewUserWindow��5   	   $	��200��6   $	��400��6,   .��5	      � $��0,0,3.4,3.6q�6   .+�5
   
   �� -   5        $��	0,0,0.2,0q�5
   +   �� 5   
   -   5        $��	0,0,0.2,0q�5       K� ZIndex$ 0��6B   � 5   
   -   5        $��UsernameGrid��5      $��-124,30,42.2,124q�6#    � ColumnDefinitions 5      �� 5      �� 5       � RowDefinitions 5      �� 5      .+�5      �� $��
Username: ��6   $��16(�6)   $��Right=�67   $��Center=�6S   �� 5      -   5        $��UsernameTextBox��5      $��16(�6-   $��1��6;   $��30��6K   5      � 5   
   -   5        $��PasswordGrid��5      $��-124,71,42.2,79q�6#    5      �� 5      �� 5       5      �� 5      .+�5      �� $��Password:  ��6   $��16(�6*   $��Right=�68   $��Center=�6T   �� 5       -   5        $��PasswordTextbox��5       $��16(�6-   $��1��6;   $��30��6K   5!      �� 5"   
   -   5        $��CreateNewUserButton��5"      $��Create��6,   $��16(�6=   $��273,117,42.2,24q�6K   6d   �� 5#   
   -   5         ��Name$ 
BackButton��5#      $
��Back��6%   $��16(�64   $��213,117,122.2,23q�6B   6\   �� 5$   
   -	   5        $��IsManagerCheckBox��5$      $��Manager��6,    d� 	IsChecked$ FalseY�6>   $��112,117,175.2,40q�6P   5%      5'      