   M S B A M L   `   `   `  ���� @  <PBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:PBapp.Infrastructure.ComponentsPBapp.Infrastructure.Components  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089X TFontAwesome5.Net, Version=2.1.11.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8  �� BasedOn �� 
TargetType   MTNavigation_rb �� Property  TransparentBrush �� Value  PrimariBrush �� 
TargetType � ColumnDefinitions   FontAwesome5.ImageAwesome   Name    
Foreground    Icon	 �� RelativeSource
 �� AncestorType
 � Tag J� SnapsToDevicePixels ��Name  SecondaryBrush �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   	Direction   RenderingBias   ShadowDepth �� Triggers �� EndPoint �� 
StartPoint � Color � Offset�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     .fa%http://schemas.fontawesome.com/icons/  <
components-clr-namespace:PBapp.Infrastructure.Components  %  &	        7d�7  7  7  7  �� 8    " 	����  � ��8  ��  � ��$ 0q���  � ��$
 Bold"���  � ��8  ��  � ��$ 16(���  � �� �� " 	�.R�� $��Stretch=�$��Stretch=�#��z��$��50�� �� $��70 ��� .+�   $ faIcon��$��0��$��Right=�
 �����$��20��$��0,0,10,0q� �� *Icon+	 �� 
 components:NavigationButton�� $��2��$|�False��#��z $
��Left=�#��z��$
��True��# z #��z���� $ IsChecedBorder��$��0��$
��Left=�$��Stretch=�8�� $��50��$��0,0,8,0q�$ 0,4,4,0��$��8��$y�Hidden=� P�  �@d�	IsChecked$
 TrueY�. ��� $ faIcon��8   �@  
Foreground�� $ IsChecedBorder�� � y�$ Visible=��� $ faIcon�� �@J�Effect   $ 15Q�$	 -90Q�$ Quality=�$ 2Q� P�  �@d�	IsChecked$
 TrueY�. ���  � �� �� $ 0.2,1&�$ 0.7,0&�.��� $ #CFCFCF��$ 0Q�� $ 	#FF76B3BB��$ 1Q���  � �� �� $ 0.6,0&�$ 0.0,1&�.��� $ #252525��$ 0Q�� $
 Gray��$ 1Q�