   M S B A M L   `   `   `  ����A  =Kartka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KartkaKartka  5   	       Kartka.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Kartka     5   	     � Title$  
MainWindow��5   	   $	��750��6   $	��550��6)    � 	Resources 5	         MyImageBrush �� ImageSource   Kartka.MainWindow �� 
TargetType �� Property �� Value  	Christmas  Christmas_insc �� BasedOn  ControlBaseStyle �� Triggers :� RoutedEvent	 g� 	BeginTime
 g� RepeatBehavior g� AutoReverse �� TargetProperty �� From	 �� To g� Duration��%�  &	        '  �     7   &	     &	 �    7  &	 	    '	� 3    �� 5   
   $i cC:/Users/Grzegorz Kielian/Desktop/Studia semestr III/Programowanie 3/GitHubpublic/Kartka/img/bg.png��6*   6�   �� 5   
   "  6   .�5      ��  � ��8   6S   �� 5       � ��
 �����6;   �� 5       � ��$ 20q�60   6=   5      �� 5   
   " ��6"   .�5      ��  � ��
 � E��6?   �� 5       � ��$ Center=�64   6E   �� 5       � ��$
 Bold"�6+   6:   5      �� 5   
   " ��6'   8   .�5      ��  � ��$ 44(�6)   66   5      �� 5    
   " ��6)   .�5!      ��  � ��$ 20q�6'   �� 5"       � ��$ 0q�6(   �� 5#       � ��$ 80��6'   �� 5$       � ��$ 80��6&   �� 5%       � ��$ Bottom=�62   �� 5&       � ��$ 44(�6)   �� 5'       � ��$ 	ExtraBold"�6+   5(      �� 5+   
   " 	�6    5,      :� 5-      $ RadioButton.Loaded��6   [�5.      �� 5/      .��50      �� 	 00:00:006)   $
 Forever��6>   $
 True��6W   $* $(Background).(SolidColorBrush.Color)�51   9   .��52   "   ��  Blue61   
 Orange6=   $ 0:0:2D�6I   53      54      56      58      5:      .��5;      � .+�5<   
   �� #��[ 6   $��20q�6<   Wesołych Świąt6X   �� 5>   
   #��[ 6   $
��Left=�6;   
��� ���
��� ���.��6~   *6�   �� 5?   
   #��[ 6   $��right=�6:   
���q�<�
����+��.��6�   #6�   �� 5@   
   .+�5A      	� 
 �� Top$	 120��6    �� Left$	 140��6+   6?   	� 5B      $	 150��6   $	 200��6+   6?   	� 5C      $	 180��6   $	 260��6+   6?   	� 5E      $	 320��6   $	 140��6+   6?   	� 5F      $	 280��6   $	 230��6+   6?   	� 5G      $	 240��6   $	 300��6+   6?   	� 5I      $	 420��6   $	 140��6+   6?   	� 5J      $	 460��6   $	 230��6+   6?   	� 5K      $	 500��6   $	 340��6+   6?   5L      5M      5N      