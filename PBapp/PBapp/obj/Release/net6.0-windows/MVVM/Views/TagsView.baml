   M S B A M L   `   `   `  ���� @  <PBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PBapp.MVVM.ViewsPBapp.MVVM.Views  =#clr-namespace:PBapp.MVVM.ViewModelsPBapp.MVVM.ViewModels  ?$clr-namespace:PBapp.Data.CollectionsPBapp.Data.Collections  Q-clr-namespace:PBapp.Infrastructure.ConvertersPBapp.Infrastructure.Converters      PBapp.MVVM.Views.TagsView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:PBapp.MVVM.Views     2vm#clr-namespace:PBapp.MVVM.ViewModels     <collections$clr-namespace:PBapp.Data.Collections     C	converter-clr-namespace:PBapp.Infrastructure.Converters       � DataContext  )  #PBapp.MVVM.ViewModels.TagsViewModel   � 	Resources 5  /PBapp.Infrastructure.Converters.ParamsConverter   cv+  %PBapp.Data.Collections.ModelPrioritys  	Prioritys��%   &	        &	          .��� .+�� -   $��MainGrid��y��� *MainGridVisibility+ � RowDefinitions �� $��5 ��� �� $��5 �.+��� $��0��
������ � $��1�� � ColumnDefinitions �� $	��800 ��� $��10 ��� $	��400 �.+��� $��0��
������� J� Opacity$	 0.7Q�� $��0��$��0,4,0,4q�.+��� -   $��TagsList������ *TManager.Tags+���� .R�A�  A� Columns$ 3������ .R��  �� �� $��20 �.+���  ��Name$	 Tag��$��0��  TagCheckBox_castom#��[ 
 � Tag �� *Name+����  �� ElementName$ TagsList��	 �� Path$	 DataContext.AddTagCommand���`� 
 `� 	Converter#
 [  .1��� $	 Tag��$		 Tag��� $	 Tag��$	 	IsChecked��� $��IngRemoveButton��$��2��$��-��$��20��$	��0.5q�  PrimariBrush#��[ $	 0.5Q�$��Right=�$	��Top=����� $ TagsList��$"	 DataContext.RemoveTagCommand���`� #
 [  .1��� $	 Tag��$		 Tag��� $	 Tag��$	 	IsChecked�� $��2�� �� $��20 ��� $��2 ��� $��20 �.+��� $��0��$��+��$��20��$	��0.5q�$	 0.5Q�  SecondaryBrush#��[ $
��Left=����� *OpenTagFormCommand+���� $ MainGrid��$	 
Visibility��� $��2��
������ � -   $��
AddTagForm��y��� *AddTagFormVisibility+ �� $	��300 ��� �� $	��300 �.+��� $��0��
�������$	 0.7Q��� $��1������  �� ImageSource$ /imgs/hbears.jpg��� $��1�� �� $	��150 ��� �� $	��150 �.+�� $��1�� �� $	��280 ��� $��70 ��� $��50 ��� .+��� -   $��
AddTagName��$��1��$��0,0,0,20q�  	TextField#��[ $
 Name��$��Center=�$��Center=�� $��2��$��0,0,0,20q� �� �� �� .+��� $��0��$
��back��#��[   ActionButton#��[ ���� *BackToTagsCommand+���� $ 
AddTagForm��$	 
Visibility��� $��2��$
��send�� 	 Green#��[ #��[ ���� *AddNewTagCommand+��`� #
 [  .1��� $ 
AddTagName��$
	 Text��� $ 
AddTagForm��$	 
Visibility��� $��2��
�������$	 0.7Q�$��0,0,10,0q�