   M S B A M L   `   `   `  ����C  ?WpfApp20, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp20WpfApp20  5   	       WpfApp20.UpdateBook   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp20     5   	     � Title$&   Обновление книги.��5   	   $	��400��6#   $	��400��60    � WindowStartupLocation$ CenterScreen=�6<    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius	 ��Name
 J� Opacity
 � Tag ��Name ��Name �� Triggers :� RoutedEvent �� TargetProperty g� AutoReverse W� From	 W� To g� Duration W� EasingFunction.  (System.Windows.Media.Animation.CubicEase P� Property P� Value �� 
TargetName �� ElementName �� Path��%�  '��       �� 5
   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   $ 5��61   #��z��6B   #��z��6l   ._�5      � $
��10,0q�6#   .+�5   "   �� $	 	watermark��6,   $��Center=�6?   $y�	Collapsed=�6Z   #��z��6q   $	
 0.4Q�6�   #��z 6�   6�   �� 5   "   $ PART_ContentHost��6/   $��Center=�6I   6f   �� 5   "   $
 rect��6,   
������ $��2��6M   $��Bottom=�6X   $��Stretch=�6s   $	��0,3q�6�   6�   5      5       5      :� 5      $ GotFocus��6+   .[�5   "   �� .��5   &   �� .��5   *   W� $ Width�6:    . $	 250X�6o   $	 255X�6z   $ 0:0:0.15D�6�    5   .     5   2   6?   5   +   W� 5   *   $ Height�6:    . $ 40X�6p   $ 45X�6z   $ 0:0:0.15D�6�    5   .     5    2   6?   5"   +   5#   '   5$   #   5%      P� 5&       �@J�	IsFocused . . �5'   "   �� $
 rect��6)    6K   �� $ border��$ BorderBrush� � ��6�   5(      P� 5)       � ��$  ��66   . �5*   "   �� $ 	watermark��6)    � y�$ Visible=�6V   6h   5+      5-      5/      50      51      .��55      � .+�56   
   �� -   5         ��Name$ TitleTxt��56   "   $ Название��6   $
��Left=�64   $��23��6O   $��
143,34,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $��93��6�   �� 57   
   -   5        $ YearPublishtxt��57   (   $! Год публикации��6   $
��Left=�6@   $��23��6[   $��
143,62,0,0q�6g   $
 Wrap=�6{   $	��Top=�6�   $��93��6�   �� 58   
   -   5        $ CountPagetxt��58   '   $  Кол-во страниц��6   $
��Left=�6>   $��23��6Y   $��
143,90,0,0q�6e   $
 Wrap=�6y   $	��Top=�6�   $��93��6�   �� 59   
   -   5         ��Name$ 
SectionTxt��59      $
��Left=�6(   $��25��6C   $��141,127,0,0q�6O   $	��Top=�6d   $��95��6|   �� 5:   
   -   5        $ 	AuthorTxt��5:      $
��Left=�6'   $��25��6B   $��141,157,0,0q�6N   $	��Top=�6c   $��95��6{   �� 5;   
   -   5        $��Обновить��5;      $
��Left=�6$   $��25��6?   $��135,195,0,0q�6K   $	��Top=�6`   $	��105��6x   6�   5=      5>      