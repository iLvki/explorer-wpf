   M S B A M L   `   `   `  ����C  ?odkrywca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:odkrywcaodkrywca  5          odkrywca.MainWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:odkrywca     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� 
Background
  ����� N� 
FontFamily$ 	Comfortaa)�5       N� ShowsNavigationUI$ False��5       N� WindowHeight$
 1080Q�5       N� WindowTitle$
 Menu��5       N� WindowWidth$
 1920Q�5       � 	Resources 5       �� 
TargetType �� Property	 �� Value
 �� Opacity �� Color �� Triggers P� Property P� Value��%5  '��       �� 5   
   " ��6   .�5      ��  � ��	 5      �� 5      $	
 0.3Q�6&   $ 	LightBlue��64   5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � ��	 5      �� 5      $	
 0.6Q�6.   $ 	LightBlue��6<   5       5!      5#      5$      .��5%      � ��5&   
   �� 5'       �� ImageSource$ /background.png��6    � ColumnDefinitions 5)   
   �� 5*      $��* �6   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��* �6   �� 5.      $��* �6    � RowDefinitions 50   
   �� 51      $��* �6   �� 52      $��* �6   �� 53      $��* �6   �� 54      $��* �6   �� 55      $��* �6   .+�59   
   �� $��2��5:      $��1��5;      $��3��5<      $��Center=�5=      $��Center=�5>      $��O D K R Y W C A��5?      $��	Comfortaa)�5@      $	��100(�5A      $
��Bold"�5B       J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D      ��5F      �� 5G       �� 
StartPoint$	 0,0&�6&    �� EndPoint$ 0.5,1&�67   .��5H      �  � Offset$ 0Q�6#    � Color$ 	#FF1BB24B��6.   � 5I      $ 1Q�6#   $ 	#FFE19726��6.   5J      5L      �� 5N   
   $��2��5O      $��2��5P      $	��300��5Q      $	��105��5R       �� Padding$ 4q�5S      
�������$��2q�5U       �� CornerRadius$ 10��5V       5W        5X      ._�5Z      �� -   5         ��Name$ mapBtn��5[      
������ $��0q�5]      $��40(�5^      $
��Bold"�5_      .��5`      �� $��/Pages/Map.xaml?�6   .�6:   Mapa6@   5a      5b      �� 5d   
   $��3��5e      $��2��5f      $	��300��5g      $	��105��5h      $ 4q�5i      
�������$��2q�5k      $ 10��5l       5m        5n      ._�5p      �� -   5        $ 	sourceBtn��5q      
������ $��0q�5s      $��40(�5t      $
��Bold"�5u      .��5v      �� $��/Pages/Sources.xaml?�6   .�6>   	Źródła6F   5w      5x      �� 5z   
   $��4��5{      $��2��5|      $	��300��5}      $	��105��5~      $ 4q�5      
�������$��2q�5�      $ 10��5�       5�        5�      ._�5�      �� -   5        $ closeBtn��5�      
������ $��0q�5�      $��Wyjdź��5�       � Cursor$
 Hand��5�      $��40(�5�      $
��Bold"�5�      5�      5�      5�      