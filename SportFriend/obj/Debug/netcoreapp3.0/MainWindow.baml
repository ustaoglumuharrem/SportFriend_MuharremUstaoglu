   M S B A M L   `   `   `  ����F  BSportFriend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SportFriendSportFriend  5   	       SportFriend.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SportFriend     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��180px �6   60   �� 5      6!   �� 5      $��180px �6   6/    � RowDefinitions 5   
   �� 5      $	��150 �6   6,   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      $	��150 �6   6,   .+�5   
   �� $��2��6   $��1��6!   $��	User Name��61   $��Center=�6C   $��20(�6^   $
��Bold"�6l   �� 5   
   $��3��6   $��1��6!   $��Password��61   $��Center=�6A   $��20(�6\   $
��Bold"�6j   �� 5   
   $��0��6   $��1��6!   $��Sport Friend��61   $��Bottom=�6E   $��Center=�6`   $��36(�6}   $
��Bold"�6�   �� 5   
   $��1��6   $��1��6!   $��SIGN IN��61   $��Center=�6@   $��Center=�6[   $��30(�6x   $
��Bold"�6�   ���	#FF2F4FD96�   �� 5   
   -   5        $��txtUserName��5   /   $��1��6   $��1��6   ���	#FFF4F4F4$��20(�6[   $��
104,70,0,0q�6i   $��2��6}   G� 5   
   -   5        $��txtUserPassword��5   4   $��2��6   $��1��6#   ���	#FFF4F4F4$��
104,70,0,0q�6b   $��2��6v   �� 5    
   $��3q�6   
�������$��3��68   $
��Left=�6L   $	��385��6g   $��
170,95,0,0q�6t   $��6��6�   $	��Top=�6�   $	��455��6�   �� 5!   
   -   5        $��btnLogin��5!   /   $��4��6   $��1��6   $��Login��6?   $��30(�6O   $��Center=�6^   $��Center=�6y   $
��Bold"�6�   
����������	#FF5B965B$	��200��6�   �� 5#   
   -   5         ��Name$ 	btnSignUp��5#      $��5��6$   $��1��61   $	��Top=�6A   $��Center=�6Y   $��Sign Up��6}   $
��Bold"�6�   $��28(�6�   
�������$��0 5 0 10q�6�   ���	#FF2F4FD96�   5$      5%      