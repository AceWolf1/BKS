   M S B A M L   `   `   `  ����>  :BKS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BKSBKS  5   	       BKS.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:BKS     5   	   -   5          � Title$  
MainWindow��5   	   $	��470��5	   	   $	��800��5
   	   ���	#FF4BAA5D � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��119* �6   �� 5      $
��681* �6    � RowDefinitions 5   
   �� 5      $	��13* �6   �� 5      $	��62* �6   .+�5   
   �� -   5         ��Name$ 	CloseMain��5      $��1��5      $��30��5       $��30��5!      $
��Left=�5"      $��Center=�5#      
������ 
������ $��0q�5&      $��x��5'         secondaryButton#��[  5(      $
��Bold"�5)      $��24(�5*      $��	651,0,0,0q�6/   5,      �� 5-   
   -   5        $ CollapseBtnMainWindow��5.      $��1��5/      $��30��50      $��30��51      $
��Left=�52      $��Center=�53      
������ 
������ $��0q�56      $��-��57      $��	626,0,0,0q�58      #��[  59      $
��Bold"�5:      $��24(�5;      5=      �� 5>   
   $��/rec/Гайка.png��6   �� 5?   
   $��Midas��6   $��Center=�5@      $	��Top=�5A      $
��Bold"�5B      $��24(�5C      $��1��5D      ���	#FFF9BE50$��31��5E   /   $��70��6;   5G      �� 5H   
   $��1��6   $��10,55,10,28q�6"   .+�5J      �� -   5        $ Corzina��5J      $��Корзина��5K      $��0q�5L      
������ #��[  5N      
������ $��18(�5P      $
��Left=�5R       � Cursor$
 Hand��5S      5U      �� 5V      -   5        $ Product��5V      $��
Товар��5W      $��0q�5X      
������ $��0 20 0 0q�5Z      #��[  5[      
������ $
��Left=�5^      $��18(�5_      $
 Hand��5`      5c      5d      �� 5e   
   $��/rec/Saw.png��6   $��1��6&   $
��Left=�66   $	��100��6Q   $��	31,16,0,0q�6^   $��1��6q   $	��Top=�6~   $	��100��6�   �� 5f   
   $��/rec/Drill.png��6   $��1��6(   $
��Left=�68   $	��100��6S   $��
230,16,0,0q�6`   $��1��6t   $	��Top=�6�   $	��100��6�   �� 5g   
   $��/rec/Hammer.png��6   $��1��6)   $
��Left=�69   $	��100��6T   $��
448,16,0,0q�6a   $��1��6u   $	��Top=�6�   $	��100��6�   �� 5h   
   $��/rec/Nails.png��6   $��1��6(   $
��Left=�68   $	��100��6S   $��
31,200,0,0q�6`   $��1��6t   $	��Top=�6�   $	��100��6�   �� 5i   
   $��/rec/Tools.png��6   $��1��6(   $
��Left=�68   $	��100��6S   $��230,200,0,0q�6`   $��1��6u   $	��Top=�6�   $	��100��6�   �� 5j   
   $��/rec/Pliers.png��6   $��1��6)   $
��Left=�69   $	��100��6T   $��448,200,0,0q�6a   $��1��6v   $	��Top=�6�   $	��100��6�   �� 5l   
   $��Цена : 1500��6   $��1��5m      $��1��5n      $��16(�5o      
�������$��30,120,550,225q�5q       �� TextAlignment$ Center=�5r      5t      �� 5v   
   $��Цена : 3500��6   $��1��5w      $��1��5x      $��16(�5y      
�������$��260,120,326,225q�5{      5}      �� 5~   
   $��Цена : 1000��6   $��1��5      $��1��5�      $��16(�5�      
�������$��470,120,106,225q�5�      5�      �� 5�   
   $��Цена : 100��6   $��1��5�      $��1��5�      $��16(�5�      
�������$��30,320,573,43q�5�      5�      �� 5�   
   $��Цена : 500��6   $��1��5�      $��1��5�      $��16(�5�      
�������$��260,320,340,43q�5�      5�      �� 5�   
   $��Цена : 1200��6   $��1��5�      $��1��5�      $��16(�5�      
�������$��470,320,106,43q�5�      5�      �� 5�   
   -   5        $
 But1��5�   ^   $��1��6   $��1��6!   $	��100��6.   $��30��6:   $��30,147,551,195q�6F   6l   �� 5�   
   -   5        $
 But2��5�   _   $��1��6   $��1��6!   $	��100��6.   $��30��6:   $��251,147,330,195q�6F   6m   �� 5�   
   -   5        $
 But3��5�   _   $��1��6   $��1��6!   $	��100��6.   $��30��6:   $��470,147,111,195q�6F   6m   �� 5�   
   -	   5        $
 But4��5�   \   $��1��6   $��1��6!   $	��100��6.   $��30��6:   $��30,351,562,8q�6F   6j   �� 5�   
   -
   5        $
 But5��5�   ]   $��1��6   $��1��6!   $	��100��6.   $��30��6:   $��251,351,330,8q�6F   6k   �� 5�   
   -   5        $
 But6��5�   ]   $��1��6   $��1��6!   $	��100��6.   $��30��6:   $��470,351,111,8q�6F   6k   5�      5�      