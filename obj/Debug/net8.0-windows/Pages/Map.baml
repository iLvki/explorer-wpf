   M S B A M L   `   `   `  ����C  ?odkrywca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:odkrywca.Pagesodkrywca.Pages  5          odkrywca.Pages.Map   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:odkrywca.Pages     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� 
Background
  ����� N� 
FontFamily$ 	Comfortaa)�5       N� WindowTitle$	 Map��5       � 	Resources 5       �� 
TargetType �� Property �� Value��%}  '��       '�� �     �� 5   
   " ��6   .�5      ��  � ��$
 5,18q�6'   �� 5       � ��$ Center=�6;   �� 5       � ��$ 25(�6)   �� 5       �@J�Opacity$	 100Q�6(   5      �� 5   
   " ��6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��
 �����6+   �� 5       �@��TextDecorations$
 None{�60   5      5      .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$ 0.5,1&�63   .��5      � 	 � Offset$	 0Q�6   
 � Color$
 	#FF34882D��6*   � 5       $	 1Q�6   $
 	#FF569ECC��6*   � 5!      $	 0.333Q�6   $
 	#FF479488��6.   � 5"      $	 0.731Q�6   $
 	#FF7B9447��6.   5#       � ColumnDefinitions 5%   
   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6    � RowDefinitions 5-   
   �� 5.      $��* �6   �� 5/      $��* �6   �� 50      $��* �6   �� 51      $��* �6   �� 52      $��* �6   �� 53      $��* �6   .+�56   
   �� $��0��57      $��0��58      $��15,40q�59      
���   �$��1q�5;       �� CornerRadius$ 20��5<      ��5=      �� 5>       �� Opacity$	 0.5Q�6"    �� Color$ 	LightBlue��60    J� Effect 5@      3  -System.Windows.Media.Effects.DropShadowEffect  5A      ._�5C      �� $��Center=�5D      $��Center=�5E      $��20(�5F      $
��Bold"�5G       J� Opacity$	 0.8Q�5H      .��5I      �� $��../MainWindow.xaml?�6   .�6=   << Powrót do menu6V   5J      5K      �� 5M   
   $��1��5N      $��4��5O      $��15q�5P      
���   �$��1q�5R      $ 20��5S      ��5T      �� 5U      $	 0.5Q�6"   $ 	LightBlue��60    5W        5X      ._�5Z      ��  �� Orientation$ Vertical=�6    5[        5\      .+�5^      �� $��Center=�5_      $��
Kontynenty��5`      $��30(�5a      $
��Bold"�5b      
����� �5c      �� 5d      .��5e      �� -   5         ��Name$ africa��5f      
 � Tag$ africa��5j      .�6&   Afryka5l      5m      �� 5n      .��5o      �� -   5        $ south_america��5p      $ south_america��5t      .�6-   Ameryka Płd.5v      5w      �� 5x      .��5y      �� -   5        $ north_america��5z      $ north_america��5~      .�6-   Ameryka Płn.5�      5�      �� 5�      .��5�      �� -   5        $ 
antarctica��5�      $ 
antarctica��5�      .�6*   
Antarktyda5�      5�      �� 5�      .��5�      �� -   5        $ 	australia��5�      $ 	australia��5�      .�6)   	Australia5�      5�      �� 5�      .��5�      �� -   5        $
 asia��5�      $
 asia��5�      .�6$   Azja5�      5�      �� 5�      .��5�      �� -   5        $ europe��5�      $ europe��5�      .�6&   Europa5�      5�      5�      5�      �� 5�   
   $��0��5�      $��6��5�      $��1��5�      $��5��5�      $��20q�5�       �� Padding$
 0,30q�5�      ._�5�      �� -   5         ��Name$	 map��5�      ��5�      �� 5�       �� ImageSource$ /Assets/continents.png��6!   5�      5�      5�      5�      