   M S B A M L   `   `   `  ����J  FCPSC304_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CPSC304_ProjectCPSC304_Project  5   	   $    CPSC304_Project.ViewTaskWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CPSC304_Project     5   	     � WindowStyle$
  None=�5       � Title$ ViewTaskWindow��5   	   $	��300��6    $	��300��6-   .��5	      �� .+�5
   
   �� $��Task Information��6   $��16(�6+   �� 5   
   $��95��6   $��0q�6    
 �� Top$	 -21��6+   $	��246��6<    �� Left$ 4��6H   �� 5   
   -   5        $��CloseButton��5      $��22��6$   $��22��60   $	 254��6;   $ 10��6M   $��X��6]   6i   �� 5   
   $��
Task Name:��6   $��16(�6%   $ 42��63   �� 5   
   $��Description:��6   $��16(�6'   $ 74��65   �� 5   
   $��Assigned to:��6   $��16(�6'   $	 126��65   �� 5   
   -   5        $��TaskNameLabel��5      $�� ��6%   $��16(�60   $ 42��6>   $	 101��6N   �� 5   
   -   5         ��Name$ TaskDescriptionTextBox��5      $��16(�62   $ 74��6@   $	 101��6P    �� 
IsReadOnly . $��47��6t   $	��176��6�   �� 5   
   -   5         ��Name$ AssignedToLabel��5      $�� ��6)   $��16(�64   $	 126��6B   $	 101��6S   �� 5   
   -   5        $��ChangeAssignedUserButton��5      $��Change Assigned User��61   $	 101��6P   $	 195��6b   $��16(�6s   $��30��6�   $	��176��6�   6�   �� 5   
   -   5         ��Name$ DeleteTaskButton��5      $��Delete Task��6+   $	 101��6A   $	 230��6S   $��16(�6d   $��30��6r   $	��176��6~   6�   �� 5   
   $��	Due date:��6   $��16(�6$   $	 158��62   �� 5   
   -   5        $��DueDateLabel��5      $�� ��6$   $��16(�6/   $	 158��6=   $	 101��6N   5      5      