   M S B A M L   `   `   `  ����A  =DemoEx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DemoEx.PagesDemoEx.Pages  5      5clr-namespace:DemoEx.ViewModelsDemoEx.ViewModels  5          DemoEx.Pages.MaterialPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:DemoEx.Pages     5      .vmclr-namespace:DemoEx.ViewModels     5        N� Title$  MaterialPage��5      $	��800��6   .��5      �� -   5         �� SelectedItem 5   :   �� *	Current+��6[   �� *	Materials+��5   
   �� 5       �� DataType)   #DemoEx.ViewModels.MaterialViewModel"  6   .R�5      �� $��20q�6    �� Orientation$ 
Horizontal=�6)   .+�5      �� $	��125��6   $	��125��6)   $��20 20 20 20q�65   ��6J   �� *Image+6e   � 5      $��50 0 0 0q�6   $	��400��6.    � RowDefinitions 5      �� 5      6.   �� 5      $��* �6,   69   �� 5      6.    � ColumnDefinitions 5      �� 5      61   �� 5      61   .+�5      �� $��
Sans Serif)�6$   $��16(�6<   $��0��6K   $��0��6X   ��6i   �� *MaterialType+6�   �� 5       $��
Sans Serif)�6$   $��12(�6<   $��1��6K   $��0��6X   .,Минимальное количество:6�   �� 5!      $
��Bold"�6$   $��
Sans Serif)�66   $��12(�6N   $��2��6\   $��0��6i   Поставщики6�   �� 5#      $��
Sans Serif)�6$   $��16(�6<   $��0��6K   $��1��6X   ��6i   �� *MaterialName+6�   �� 5$      $��
Sans Serif)�6$   $��12(�6<   $��1��6K   $��1��6X   ��6h   �� *CountInPack+6�   �� 5%      $
��Wrap=�6$   $
��Bold"�68   $��
Sans Serif)�6J   $��12(�6b   $��2��6p   $��1��6}   ��6�   �� *	Suppliers+6�   5&      �� 5'      $ 
Horizontal=�6!   $��Right=�6:   .+�5(      �� $��Right=�6    $��10 0 0 0q�6<   $��
Sans Serif)�6N   $��12(�6f   Остаток:6~   �� 5)      $��Right=�6    $��10 0 0 0q�6<   $��
Sans Serif)�6N   $��12(�6f   ��6t   �� *CountInStock+6�   5*      5+      5,      5.      5/      