   M S B A M L   `   `   `  ���� @  <PBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:PBapp.Infrastructure.ComponentsPBapp.Infrastructure.Components  =#clr-namespace:PBapp.MVVM.ViewModelsPBapp.MVVM.ViewModels  3clr-namespace:PBapp.MVVM.ViewsPBapp.MVVM.Views      PBapp.MVVM.Views.NewsView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     D
components-clr-namespace:PBapp.Infrastructure.Components     2vm#clr-namespace:PBapp.MVVM.ViewModels     0localclr-namespace:PBapp.MVVM.Views       � DataContext  )  #PBapp.MVVM.ViewModels.NewsViewModel  .���  � ColumnDefinitions �� $	��250 ��� .+�� $��0�� J� Opacity$	 0.8Q� � RowDefinitions �� �� $	��200 �.+��� $��0��$��Center=�.+�	� 
 � Tag$
 Ohui��   HTForm_b#��[  ���� *GetSourceDataCommand+���� *Ohui+	� $ Sum37��#��[  ���� *GetSourceDataCommand+���� *Sum37+	� $ Medipeel��#��[  ���� *GetSourceDataCommand+���� *
Medipeel+	� $
 Iope��#��[  ���� *GetSourceDataCommand+���� *Iope+	� $ Labonita��#��[  ���� *GetSourceDataCommand+���� *
Labonita+� $��1��$	��Top=�.+��� $��	10,0,0,10q�$��2,0,0,0q�  PrimariBrush#��[ ._���  �� Orientation$ Vertical=�.+��� $��Stretch=� 	 HLink#��[ �� -    �� TextDecorations$
 None{����� *whoo+.�.��� $��TheHystoryOfWhoo��$	��300��$
��Left=�$��14(�  BlackFontBrush#��[ �� $��Stretch=�#��[ �� -   $
 None{����� *	snpmall+.�.��� $��SNPmall��$	��300��$
��Left=�$��14(�#��[ � $��1��$��Stretch=� �� �� $��25 �.+��� $��0��$��Stretch=�$��Stretch=�y��� *SpinnerVisibility+._�4   .PBapp.Infrastructure.Components.LoadingSpinner     Diameter$ 70��   Color1$ Transparent��	   Color2$	 Black���� $��0��
������ 
 �� SelectedIndex$
 0��$��Visible=�$��Disabled=�$��Stretch=�$��Stretch=�$��False������ *SelectedSource.News+y��� *NewsListVisibility+���� .R���   TransparentBrush#��[ $	��400�� �� CornerRadius$ 4��._��  �� �� $	��300 �.+��� $��0��$ 4�����#CFCFCF$��10q�$��2q�#��[ ._��� $��6q����� *
ImageUrl+� $��1�� �� $
�� 200 ��� .+��� $��0��$��	0,10,10,0q�  SecondaryBrush#��[ ._��� $
��Wrap=�#��[ $��Center=�$��Center=�$��18(����� *Text+�� $��1��$ 50��$��80��$��80��#��[ $��2q����#CFCFCF._��� 
������ $��80��$��80��$��Center=�$��Center=��� -   $
 None{����� *Url+.�.��� $
��Read��$��80��$��80��#��[ $��14(�$
��Bold"�$��Center=�$��Center=��� $��1��
������ 