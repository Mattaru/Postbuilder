   M S B A M L   `   `   `  ����@  <PBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PBapp.MVVM.ViewsPBapp.MVVM.Views  5      =#clr-namespace:PBapp.MVVM.ViewModelsPBapp.MVVM.ViewModels  5      ?$clr-namespace:PBapp.Data.CollectionsPBapp.Data.Collections  5      Q-clr-namespace:PBapp.Infrastructure.ConvertersPBapp.Infrastructure.Converters  5	          PBapp.MVVM.Views.TagsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PBapp.MVVM.Views     5      2vm#clr-namespace:PBapp.MVVM.ViewModels     5      <collections$clr-namespace:PBapp.Data.Collections     5      C	converter-clr-namespace:PBapp.Infrastructure.Converters     5	        � DataContext  5      )  #PBapp.MVVM.ViewModels.TagsViewModel  5   
    � 	Resources 5      5  /PBapp.Infrastructure.Converters.ParamsConverter   cv+  %PBapp.Data.Collections.ModelPrioritys  	Prioritys��%:   &	        &	        5   
   6$     5   
   6%   5      .��5      � .+�5   
   � -   5        $��MainGrid��5      y�5      �� *MainGridVisibility+ � RowDefinitions 5      �� 5      $��5 �6    �� 5      �� 5      $��5 �6    .+�5      �� $��0��6   
������ 6"   � 5!      $��1��6    � ColumnDefinitions 5"      �� 5#      $	��800 �6'   �� 5$      $��10 �6'   �� 5%      $	��400 �6'   .+�5(      �� $��0��6   
������� J� Opacity$	 0.7Q�5*      � 5,      $��0��6   $��0,4,0,4q�5-      .+�5.      �� -   5        $��TagsList��5.   #   ��5/   #   �� *TManager.Tags+��51      �� 52      .R�53   "   A�  A� Columns$ 3��6.   54      ��57      �� 58      .R�59   "   �  5:   &   �� 5;   *   �� 5<   *   $��20 �6;   .+�5?   &   ��  ��Name$	 Tag��5A   /   $��0��5?   /     TagCheckBox_castom#��[ 5B   /   
 � Tag 5@   /   �� *Name+��5C   /   ��  �� ElementName$ TagsList��	 �� Path$	 DataContext.AddTagCommand���5D   *   `� 5E   .   
 `� 	Converter#
 [  6;   .1�5F   2   �� $	 Tag��6:   $		 Tag�6L   �� 5G   2   $	 Tag��6:   $	 	IsChecked�6L   5H   /   5J   '   �� 5L   &   $��IngRemoveButton��5M   -   $��2��5L   -   $��-��5N   -   $��20��5O   -   $	��0.5q�5P   -     PrimariBrush#��[ 5Q   -   $	 0.5Q�5R   -   $��Right=�5S   -   $	��Top=�5T   -   ��5U   -   �� $ TagsList��$"	 DataContext.RemoveTagCommand���5V   *   `� 5W   .   #
 [  6;   .1�5X   2   �� $	 Tag��6:   $		 Tag�6L   �� 5Y   2   $	 Tag��6:   $	 	IsChecked�6L   5Z   /   5\   '   5]   #   5^      5`      5a      � 5c      $��2��6    5d      �� 5e      $��20 �6(   �� 5f      $��2 �6(   �� 5g      $��20 �6(   .+�5j      �� $��0��6   $��+��5k      $��20��5l      $	��0.5q�5m      $	 0.5Q�5n        SecondaryBrush#��[ 5o      $
��Left=�5p      ��5q      �� *OpenTagFormCommand+��5r      �� $ MainGrid��$	 
Visibility�5s      5t      �� 5v      $��2��6   
������ 6"   5w      � 5y   
   -   5        $��
AddTagForm��5y      y�5z      �� *AddTagFormVisibility+ 5{      �� 5|      $	��300 �6#   �� 5}      �� 5~      $	��300 �6#   .+�5�      �� $��0��6   
�������$	 0.7Q�68   �� 5�      $��1��6   ��5�      �� 5�       �� ImageSource$ /imgs/hbears.jpg��6!   5�      � 5�      $��1��6    5�      �� 5�      $	��150 �6'   �� 5�      �� 5�      $	��150 �6'   .+�5�      � $��1��6    5�      �� 5�      $	��280 �6(   �� 5�      $��70 �6(   �� 5�      $��50 �6(   �� 5�      .+�5�      �� -   5        $��
AddTagName��5�      $��1��5�      $��0,0,0,20q�5�        	TextField#��[ 5�      $
 Name��5�      $��Center=�5�      $��Center=�5�      ��5�      �� *	TagName+ �� UpdateSourceTrigger$ PropertyChanged=�5�      � 5�      $��2��6   $��0,0,0,20q�5�       5�      �� 5�      �� 5�      �� 5�      .+�5�      �� $��0��6!   $
��back��5�   !   #��[ 5�   !     ActionButton#��[ 5�   !   ��5�   !   �� *BackToTagsCommand+��5�   !   �� $ 
AddTagForm��$	 
Visibility��� 5�      $��2��6!   $
��send��5�   !    	 Green#��[ 5�   !   #��[ 5�   !   ��5�   !   �� *AddNewTagCommand+��5�      `� 5�   "   #
 [  6/   .1�5�   &   �� $ 
AddTagName��6.   $
	 Text�6G   �� 5�   &   $ 
AddTagForm��6.   $	 
Visibility�6G   5�   #   5�      5�      5�      5�      �� 5�      $��2��6   
�������$	 0.7Q�68   $��0,0,10,0q�6F   5�      5�      5�      