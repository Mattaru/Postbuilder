   M S B A M L   `   `   `  ���� @  <PBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:PBapp.Infrastructure.BehaviorsPBapp.Infrastructure.Behaviors  Q-clr-namespace:PBapp.Infrastructure.ComponentsPBapp.Infrastructure.Components  clr-namespace:PBappPBapp  =#clr-namespace:PBapp.MVVM.ViewModelsPBapp.MVVM.ViewModels  Q-clr-namespace:PBapp.Infrastructure.ConvertersPBapp.Infrastructure.Converters      PBapp.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  4b,clr-namespace:PBapp.Infrastructure.Behaviors  >
components-clr-namespace:PBapp.Infrastructure.Components  localclr-namespace:PBapp  ,vm#clr-namespace:PBapp.MVVM.ViewModels  =	converter-clr-namespace:PBapp.Infrastructure.Converters  $	��768��$
��1280��$	��768��$
��1280��  � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � Title �� *Title+'  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 30Q�   CornerRadius$ 4��   GlassFrameThickness$ 0q�   NonClientFrameEdges$
 None=�   ResizeBorderThickness$ 5q�	   UseAeroCaptionButtons$	 False��
 � DataContext
 )  #PBapp.MVVM.ViewModels.MainViewModel   � 	Resources 5  /PBapp.Infrastructure.Converters.ParamsConverter   cv��%   &	          .���  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 15Q�   	Direction$	 -90Q�   RenderingBias$ Quality=�   ShadowDepth$ 2Q�����  �� ImageSource$ /imgs/bears.jpg�� j� Stretch$ UniformToFill=� � RowDefinitions �� $��25 ��� �� $��10 �.+�� $��0��.+��� *  $Microsoft.Xaml.Behaviors.Interaction   	Behaviors :  4PBapp.Infrastructure.Behaviors.WindowToolbarBehavior  ._���  �� Orientation$ 
Horizontal=�$��Right=�$��1q�.+��� $��_��  ToolbarButton#��[    IsHitTestVisibleInChrome$
 True�� 3  -PBapp.Infrastructure.Behaviors.MinimizeWindow  �� $	��▢��#��[ $
 True�� 6  0PBapp.Infrastructure.Behaviors.WindowStateChange  �� $��x��#��[ $
 True�� 0	  *PBapp.Infrastructure.Behaviors.CloseWindow	  � $��1�� � ColumnDefinitions �� $	��100 ��� .+��� $��0��
���   �.+�6
   0PBapp.Infrastructure.Components.NavigationButton
   
  	IsChecked$
 True�� 
  Icon$ 
Solid_List�� 
  Command �� *SelectCompositionsViewCommand+
  $ Solid_Hashtag�� �� *SelectTagsViewCommand+
  $ Regular_Newspaper�� �� *SelectNewsViewCommand+�� $��1��$��10,0,0,0q����� *CurrentView+ �� UpdateSourceTrigger$ PropertyChanged=�