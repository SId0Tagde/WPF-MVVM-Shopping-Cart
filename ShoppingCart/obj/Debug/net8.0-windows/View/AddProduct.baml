   M S B A M L   `   `   `  ����G  CShoppingCart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ShoppingCart.ViewShoppingCart.View  5   	   "    ShoppingCart.View.AddProduct   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ShoppingCart.View     5   	     � Title$  
AddProduct��5   	   $	��100��6   $	��200��6,   $	��500��6<   $	��600��6K   .��5
      �� 
��� d �._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    .+�5      � $��12q�6   $��0��6    5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��6   $��0��6)   
�������$��Product Name��6L    �� TextAlignment$
 Left=�6`   �� 5       $��1��6   $��0��6)   
�������$��Product Price��6L   $
 Left=�6a   �� 5!      $��0��6   $��1��6'   
���������6J   ��  �� Path$ Product.productName��� 5"      $��1��6   $��1��6'   
���������6J   �� $ Product.price�5#      �� 5$      $
��Save��6   $��1��6$   $��Bottom=�61   $��2��6L   $��Right=�6`   $
��55px��6|   ��5%      �� $ SaveCommand���6:   ��  �� RelativeSource ��  �� AncestorType
 Window5&      5'      5(      