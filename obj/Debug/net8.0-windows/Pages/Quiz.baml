   M S B A M L   `   `   `  ����C  ?odkrywca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:odkrywca.Pagesodkrywca.Pages  5          odkrywca.Pages.Quiz   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:odkrywca.Pages     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$
  Quiz��5       N� 
Background
 ��ح� N� 
FontFamily$ 	Comfortaa)�5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��5       $��0��5!      $��2��5"      $��20,40q�5#      $
��Left=�5$      $	��Top=�5%      $��20(�5&      $
��Bold"�5'       J� Opacity$	 0.8Q�5(      .��5)      �� -   5        
���   �.�5)   <   << Powrót do kontynentu5+      5,      �� 5.   
   -   5         ��Name$ score��5/      $��0��50      $��2��51      $��Center=�52      $��Center=�53      $	��0/2��54      $��40(�55      � 57   
   -   5         �Name$ qGrid��58      $��1��59      $��3��5:      $��1��5;      $��3��5<       5=      �� 5>      $��* �6    �� 5?      $��* �6    �� 5@      $��* �6     5B      �� 5C      $��* �6#   �� 5D      $��* �6#   .+�5G      �� -   5         ��Name$ questionText��5H      $��0��5I      $��3��5J      $��Center=�5K      $��24(�5L      $
��Bold"�5M      $
��test��5N      	 �� TextAlignment$	 Center=�5O      $
��Wrap=�5P      5Q      �� 5S   
   -   5        
 ��Name$
 prevQBtn��5T      $��4��5U      $��3��5V      $��<< Poprzednie pytanie��5X       � Cursor$
 Hand��5Y      $��22(�5Z      $
��Bold"�5[      
���   �5\      �� 5^   
   -   5        $
 nextQBtn��5_      $��4��5`      $��4��5a      $��Następne pytanie >>��5c      $
 Hand��5d      $��22(�5e      $
��Bold"�5f      
���   �5g      5h      5i      