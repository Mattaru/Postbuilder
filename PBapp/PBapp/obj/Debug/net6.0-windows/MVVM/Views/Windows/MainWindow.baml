   M S B A M L   `   `   `  ����@  <PBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:PBapp.Infrastructure.BehaviorsPBapp.Infrastructure.Behaviors  5   	   Q-clr-namespace:PBapp.Infrastructure.ComponentsPBapp.Infrastructure.Components  5   	   clr-namespace:PBappPBapp  5	   	   =#clr-namespace:PBapp.MVVM.ViewModelsPBapp.MVVM.ViewModels  5
   	   Q-clr-namespace:PBapp.Infrastructure.ConvertersPBapp.Infrastructure.Converters  5   	       PBapp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   4b,clr-namespace:PBapp.Infrastructure.Behaviors  5   	   >
components-clr-namespace:PBapp.Infrastructure.Components  5   	   localclr-namespace:PBapp  5	   	   ,vm#clr-namespace:PBapp.MVVM.ViewModels  5
   	   =	converter-clr-namespace:PBapp.Infrastructure.Converters  5   	   $	��768��5   	   $
��1280��6   $	��768��5   	   $
��1280��6     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title 5   	   �� *Title+'  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 30Q�6      CornerRadius$ 4��5         GlassFrameThickness$ 0q�5         NonClientFrameEdges$
 None=�5         ResizeBorderThickness$ 5q�5      	   UseAeroCaptionButtons$	 False��5      
 � DataContext
 5      )  #PBapp.MVVM.ViewModels.MainViewModel  5   
    � 	Resources 5       5  /PBapp.Infrastructure.Converters.ParamsConverter   cv��%   &	          5!   
   6$   5"      .��5&      �  J� Effect 5'   
   3  -System.Windows.Media.Effects.DropShadowEffect  5(         
BlurRadius$ 15Q�6      	Direction$	 -90Q�6/      RenderingBias$ Quality=�5)         ShadowDepth$ 2Q�67   ��5,   
   �� 5-       �� ImageSource$ /Imgs/teddy-bear.jpg��6    � RowDefinitions 50   
   �� 51      $��27 �6   6*   �� 52      6   .+�55   
   � $��0��6   .+�56      �� *  $Microsoft.Xaml.Behaviors.Interaction   	Behaviors 57      :  4PBapp.Infrastructure.Behaviors.WindowToolbarBehavior  58      ._�5;      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5<      $��1q�5=      .+�5?      �� $��_��6     ToolbarButton#��[ 5@         IsHitTestVisibleInChrome$
 True��5A       5B      3  -PBapp.Infrastructure.Behaviors.MinimizeWindow  5C      5E      �� 5G      $	��▢��6   #��[ 5H      $
 True��5I       5J      6  0PBapp.Infrastructure.Behaviors.WindowStateChange  5K      5M      �� 5O      $��x��6   #��[ 5P      $
 True��5Q       5R      0	  *PBapp.Infrastructure.Behaviors.CloseWindow	  5S      5U      5V      5W      5X      � 5Z   
   $��1��6    � ColumnDefinitions 5[      �� 5\      $	��100 �6#   61   �� 5]      6%   .+�5`      �� $��0��6   .+�5a      6
   0PBapp.Infrastructure.Components.NavigationButton
   
  	IsChecked$
 True��6.    
  Icon$ 
Solid_Home��5b   .    
  Command 5c   .   �� *SelectCompositionsViewCommand+
  5e      $ Regular_Newspaper��6.    5f   .   �� *SelectNewsViewCommand+5g      �� 5i      $��1��6   $��10,0,0,0q�5k      ��5j      �� *CurrentView+ �� UpdateSourceTrigger$ PropertyChanged=�5k      5l      5m      5o      