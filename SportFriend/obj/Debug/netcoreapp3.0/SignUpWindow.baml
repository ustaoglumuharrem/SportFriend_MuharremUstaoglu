   M S B A M L   `   `   `  ����F  BSportFriend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SportFriendSportFriend  5   	       SportFriend.SignUpWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SportFriend     5   	     � Title$  SignUpWindow��5   	   $	��400��6   $	��600��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��0��6!   ���#FF715261   �� 5   
   $��0��6   $��0��6!   $��Sport Friend��62   $��24(�6F   $
��Bold"�6T   $��Center=�6f   $��Center=�6�   �� 5"   
   $��1��6   $��0��6!   $��2��61   $��Create User��6E   $��24(�6X   $
��Bold"�6f   $��Center=�6x   $��Center=�6�   �� 5#   
   $��2��6   $��0��6!   $
��Name��61   $��22(�6=   $
��Bold"�6K   $��Center=�6]   $
��Left=�6x   $��20 0 0 0q�6�   �� 5$   
   $��3��6   $��0��6!   $��Surname��61   $��22(�6@   $
��Bold"�6N   $��Center=�6`   $
��Left=�6{   $��20 0 0 0q�6�   �� 5%   
   $��4��6   $��0��6!   $��UserName��61   $��22(�6A   $
��Bold"�6O   $��Center=�6a   $
��Left=�6|   $��20 0 0 0q�6�   �� 5&   
   $��5��6   $��0��6!   $��Password��61   $��22(�6A   $
��Bold"�6O   $��Center=�6a   $
��Left=�6|   $��20 0 0 0q�6�   �� 5'   
   $��6��6   $��0��6!   $��Again Password��61   $��22(�6G   $
��Bold"�6U   $��Center=�6g   $
��Left=�6�   $��20 0 0 0q�6�   �� 5)   
   $��7��6   $��0��6!   $��
Birth Date��61   $��22(�6C   $
��Bold"�6Q   $��Center=�6c   $
��Left=�6~   $��20 0 0 0q�6�   �� 5-   
   -   5         ��Name$ txtName��5-   /   $��2��6   $��1��6   $��	204,0,0,0q�6@   �� 5.   
   -   5        $ 
txtSurname��5.   /   $��3��6   $��1��6   $��	204,0,0,0q�6C   �� 5/   
   -   5        $ txtUserName��5/   /   $��4��6   $��1��6   $��	204,0,0,0q�6D   G� 50   
   -   5         G�Name$ txtpassword1��50   3   $��5��6   $��1��6#   $��	204,0,0,0q�6I   G� 51   
   -   5        $ txtpassword2��51   3   $��6��6   $��1��6#   $��	204,0,0,0q�6I   (  "System.Windows.Controls.DatePicker  53   
   -   5          Name$ 	datebirth��53   2   $��7��6   $��1��6"   $��	204,0,0,0q�6E   �� 56   
   -   5         ��Name$ btnCreateUser��56      $��8��6   $��141,3,153,0q�65   $��Create��6J   $��24(�6[   $
��Bold"�6i   ���#4461C76�   58      59      