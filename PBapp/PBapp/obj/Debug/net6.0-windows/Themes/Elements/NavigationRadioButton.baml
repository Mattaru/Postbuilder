   M S B A M L   `   `   `  ����@  <PBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:PBapp.Infrastructure.ComponentsPBapp.Infrastructure.Components  5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089X TFontAwesome5.Net, Version=2.1.11.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8  �� BasedOn �� 
TargetType   MTNavigation_rb �� Property  TransparentBrush �� Value  PrimariBrush �� 
TargetType � ColumnDefinitions   FontAwesome5.ImageAwesome   Name    
Foreground    Icon	 �� RelativeSource
 �� AncestorType
 � Tag J� SnapsToDevicePixels ��Name  SecondaryBrush �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   	Direction   RenderingBias   ShadowDepth �� Triggers �� EndPoint �� 
StartPoint � Color � Offset�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .fa%http://schemas.fontawesome.com/icons/  5      <
components-clr-namespace:PBapp.Infrastructure.Components  5      %`  &	        7d�7  7  7  7  �� 5      8    " 	�6=   �5   
   �� 5	       � ��8  6+   �� 5
       � ��$ 0q�60   �� 5       � ��$
 Bold"�6+   �� 5       � ��8  6+   �� 5       � ��$ 16(�6)   �� 5       � �� 5      �� 5      " 	�6&   .R�5      � $��Stretch=�6   $��Stretch=�5      #��z��5      $��50��5       5      �� 5   "   $��70 �63   �� 5   "   .+�5         $ faIcon��5   .   $��0��5   .   $��Right=�5   .   
 �����$��20��5    .   $��0,0,10,0q�5!   .    5   >   �� *Icon+	 �� 
 components:NavigationButton5!   .   �� 5#      $��2��6/   $|�False��6?   #��z 5$   -   $
��Left=�5%   -   #��z��5&   -   $
��True��5'   -   # z 5(   -   #��z��5)   -   �� 5+      $ IsChecedBorder��5,   %   $��0��5+   %   $
��Left=�5-   %   $��Stretch=�6@   8�� $��50��5/   %   $��0,0,8,0q�50   %   $ 0,4,4,0��51   %   $��8��52   %   $y�Hidden=�53   %   55       57      P� 58       �@d�	IsChecked$
 TrueY�6;   . �59   "   �� $ faIcon��6?   8   �@  
Foreground6S   �� 5:   "   $ IsChecedBorder��6?    � y�$ Visible=�6[   �� 5;   "   $ faIcon��6;    �@J�Effect 5<   &     5=   *   $ 15Q�6;   $	 -90Q�5>   ;   $ Quality=�5?   ;   $ 2Q�5@   ;   5B   #   5C      5F      5H       5K   
   P� 5L       �@d�	IsChecked$
 TrueY�6+   . �5M      ��  � �� 5N      �� 5O      $ 0.2,1&�6.   $ 0.7,0&�6?   .��5P      � $ #CFCFCF��6+   $ 0Q�5Q   /   � 5R      $ 	#FF76B3BB��6+   $ 1Q�5S   /   5T      5V      �� 5W       � �� 5X      �� 5Y      $ 0.6,0&�6.   $ 0.0,1&�6?   .��5Z      � $ #252525��6+   $ 0Q�5[   /   � 5\      $
 Gray��6+   $ 1Q�5]   /   5^      5`      5a      5d      5e      