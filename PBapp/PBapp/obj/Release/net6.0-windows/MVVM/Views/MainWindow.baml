   M S B A M L   `   `   `  ���� @  <PBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PBappPBapp  =#clr-namespace:PBapp.MVVM.ViewModelsPBapp.MVVM.ViewModels  Q-clr-namespace:PBapp.Infrastructure.ConvertersPBapp.Infrastructure.Converters      PBapp.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:PBapp     2vm#clr-namespace:PBapp.MVVM.ViewModels     C	converter-clr-namespace:PBapp.Infrastructure.Converters       � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�$	��768��$
��1280�� � WindowStartupLocation$ CenterScreen=� � Title �� *Title+ � DataContext )  #PBapp.MVVM.ViewModels.MainViewModel   � 	Resources 5  /PBapp.Infrastructure.Converters.ParamsConverter   cv��%   &	          .��� ����  �� ImageSource$ /Imgs/teddy-bear.jpg��.+��  � ColumnDefinitions �� $��25 ��� �� $	��100 �.+�� $��1�� � RowDefinitions �� $��25 ��� �� $��25 �.+��� -   $��0��
������ � $��1�� �� �� �� .+�� $��0�� �� $	��0.5 ��� .+��� 
���   �	 J� Opacity$		 0.5Q��� $��1��.+��� -   $	��Ing��

 � Tag$
 Ретинол��  CheckBox_castom#��[ ���� *AddIngredientCommand+��`�  `� 	Converter# [  .1���  �� ElementName$	 Ing�� �� Path$	 Tag��� $	 Ing��$ 	IsChecked��� -   $
��Ing1��$
 Идебенон��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing1��$	 Tag��� $
 Ing1��$ 	IsChecked��� -   $
��Ing2��$'
 !Комплекс пептидов��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing2��$	 Tag��� $
 Ing2��$ 	IsChecked��� -   $
��Ing3��$ 
 Лактобактерии��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing3��$	 Tag��� $
 Ing3��$ 	IsChecked��� -   $
��Ing4��$
 Пробиотики��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing4��$	 Tag��� $
 Ing4��$ 	IsChecked��� -   $
��Ing5��$9
 3Низкомолекулярный коллаген��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing5��$	 Tag��� $
 Ing5��$ 	IsChecked��� -   $
��Ing6��$6
 0Стволовые клетки растений��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing6��$	 Tag��� $
 Ing6��$ 	IsChecked��� -	   $
��Ing7��$)
 #Технология липосом��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing7��$	 Tag��� $
 Ing7��$ 	IsChecked��� -
   $
��Ing8��$-
 'Гиалуроновой кислоты��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing8��$	 Tag��� $
 Ing8��$ 	IsChecked��� -   $
��Ing9��$
 Керамиды��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $
 Ing9��$	 Tag��� $
 Ing9��$ 	IsChecked��� -   $��Ing10��$
 Ниацинамид��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing10��$	 Tag��� $ Ing10��$ 	IsChecked��� -   $��Ing11��$
 Аденозин��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing11��$	 Tag��� $ Ing11��$ 	IsChecked��� -   $��Ing12��$
 Coenzyme Q10��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing12��$	 Tag��� $ Ing12��$ 	IsChecked��� -   $��Ing13��$
 Цеолит��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing13��$	 Tag��� $ Ing13��$ 	IsChecked�� $��1�� �� $	��0.5 ��� .+��� 
���   �$		 0.5Q��� $��1��.+��� -   $��Ing14��$
 Трегалоза��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing14��$	 Tag��� $ Ing14��$ 	IsChecked��� -   $��Ing15��$
 Глутатион��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing15��$	 Tag��� $ Ing15��$ 	IsChecked��� -   $��Ing16��$
 Экстракт икры��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing16��$	 Tag��� $ Ing16��$ 	IsChecked��� -   $��Ing17��$
 Серебро��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing17��$	 Tag��� $ Ing17��$ 	IsChecked��� -   $��Ing18��$
 Аргинин��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing18��$	 Tag��� $ Ing18��$ 	IsChecked��� -   $��Ing19��$
 Волюфилин��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing19��$	 Tag��� $ Ing19��$ 	IsChecked��� -   $��Ing20��$
 Бетаин��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing20��$	 Tag��� $ Ing20��$ 	IsChecked��� -   $��Ing21��$
 .....��#��[ ���� *AddIngredientCommand+��`� # [  .1��� $ Ing21��$	 Tag��� $ Ing21��$ 	IsChecked�� $��2��
������  �� $	��100 ��� �� $	��100 �.+�� $��0��.+���  �� Orientation$ Vertical=�$
��Left=�$��Bottom=�.+��� $��Закрыть��$��90��$��90��$
��Bold"�$��0q�$		 0.7Q�
����������� *CloseAppCommand+  �� 
TargetType �� Property �� Value��%:   '��       �� " ��.���  �@��CornerRadius$ 50��� $��2��.+��� $ Vertical=�$
��Left=�$	��Top=�.+��� $��Стырить��$��90��$��90��$
��Bold"�$��0q�$		 0.7Q�
����������� *CopyToClipBoardCommand+ ��%:   '��       �� " ��.���  �@��CornerRadius$ 50��