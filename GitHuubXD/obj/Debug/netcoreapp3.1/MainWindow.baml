   M S B A M L   `   `   `  ����D  @GitHuubXD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GitHuubXD	GitHuubXD  5   	       GitHuubXD.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GitHuubXD     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��5* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��ListViewXAML��5   4   $��0��6   $��5��6    $��10q�6H   
���   � �� View 5      �� 5      .P�5      �� $
��Name��6%    �� Width$	 100��63    �� DisplayMemberBinding 6?   �� *Name+6g   �� 5      $��Surname��6%   $	 100��66    6B   �� *	Surname+6m   �� 5      $��PESEL��6%   $	 100��64    6@   �� *Pesel+6i   5      5      �� 5    
   -   5        $
��Save��5       $��1��6-   $��2��6:   $	��100��6J   $��50��6V   $��Center=�6b   $��Center=�6}   �� 5!   
   -   5        $��Refresh��5!      $��1��69   $��3��6F   $	��100��6V   $��50��6b   $��Center=�6n   $��Center=�6�   �� 5"   
   -   5        $	��Add��5"      $��1��6+   $��4��68   $	��100��6H   $��50��6T   $��Center=�6`   $��Center=�6{   �� 5#   
   -   5        $
��Load��5#      $��1��6-   $��1��6:   $	��100��6J   $��50��6V   $��Center=�6b   $��Center=�6}   �� 5$   
   -   5        $��DataBase��5$      $��1��61   $��0��6>   $	��100��6N   $��50��6Z   $��Center=�6g   $��Center=�6�   5%      5&      