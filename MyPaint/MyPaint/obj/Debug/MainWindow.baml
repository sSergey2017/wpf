   M S B A M L   `   `   `  ����B  >MyPaint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MyPaintMyPaint  5   	       MyPaint.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MyPaint     5   	     � Title$  
MainWindow��5   	   $	��420��6   $	��525��6)   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$
 Blue��6    � Offset$ 0Q�6(   65   � 5      $ White��6   $ 1Q�6)   66   5      .��5      � .+�5   
   �� -   5         ��Name$ 
inkCanvas1��5      $
��Left=�6(   $	��269��6C   $��	10,10,0,0q�6P   $	��Top=�6c   $	��418��6{   �� 5   
   -   5         ��Name$ button_Clear��5      $��Clear��6A   $
��Left=�6Q   $��
433,10,0,0q�6l   $	��Top=�6�   $��75��6�   �� 5   
   -   5        $ button_Close��5      $��Close��6A   $
��Left=�6Q   $��433,259,0,0q�6l   $	��Top=�6�   $��75��6�   �� 5   
   -   5        $ button_Save��5      $
��Save��6?   $
��Left=�6N   $��
433,35,0,0q�6i   $	��Top=�6}   $��75��6�   �� 5   
   -   5         ��Name$ sld_RedColor��5      
���  �� � Minimum$ 0Q�68   	 � Maximum$		 255Q�6D   $
��Left=�6R   $��
25,322,0,0q�6m   $	��Top=�6�   $	��269��6�   6�   �� 5   
   -   5        $ sld_GreenColor��5      
��� � �$ 0Q�6<   $		 255Q�6H   $
��Left=�6V   $��
25,342,0,0q�6q   $	��Top=�6�   $	��269��6�   6�   �� 5   
   -   5        $ sld_BlueColor��5      
����  �$ 0Q�6:   $		 255Q�6F   $
��Left=�6T   $��
25,362,0,0q�6o   $	��Top=�6�   $	��269��6�   6�   �� 5   
   -   5        
 ��Name$

 lbl1��5      $!��Выбранный цвет��6   $
��Left=�67   $��359,333,0,0q�6R   $	��Top=�6g   �� 5   
   -	   5        $ sliderWidth��5      $ 0Q�6&   $	 20Q�62   $
��Left=�6?   $��
25,290,0,0q�6Z   $	��Top=�6n   $	��269��6�   6�   5      5      