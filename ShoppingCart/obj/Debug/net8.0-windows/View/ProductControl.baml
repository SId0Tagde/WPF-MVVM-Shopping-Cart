   M S B A M L   `   `   `  ����  ShoppingCart&     ShoppingCart.View.ProductControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  $��0��6   
���� ��$��LeftToRight=�5   &      SelectionMode$ Single=�5   4      CanUserDeleteRows$ False��5         CanUserAddRows$
 True��6-      AutoGenerateColumns$ False��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6/   ��5      �� *
Products+ �� SelectedItem 5      ��  �� Path$ SelectedProduct�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly$
	 True��6%   
   Header$
 Product Name��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *productName+ �� UpdateSourceTrigger$ PropertyChanged=�" �� ValidatesOnNotifyDataErrors$
 True��  5      $
	 True��6%   $
 Price��67    5   %   �� *price+$ PropertyChanged=�$
 True��4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� $	��Add��6%   ��63   �� $ 
AddCommand���6W   �� *	Counter+5      5        5       5       �� 5!      .R�5"      �� $��Remove��6%   ��66   �� $ RemoveCommand���6]   �� *	Counter+5#      5%        5&      $
	 True��6%    67   �� *	Counter+$ PropertyChanged=�$
 True��   ElementStyle 5'      �� 5(       �� 
TargetType" ��6    .�5)      ��  �� Property �@��TextAlignment �� Value$ Center=�6>   5*      5,        5-       5.      �� 5/      .R�50      �� $��Add To Cart��6%   51      53      55      �� 56   
   $��1��6   $��Right=�6   $��Bottom=�6:   $��Center=�57      $��Center=�65   $��Add Product��58      $��LeftToRight=�59      ��58   '   �� $ AddProductCommand�59      5:      5;      