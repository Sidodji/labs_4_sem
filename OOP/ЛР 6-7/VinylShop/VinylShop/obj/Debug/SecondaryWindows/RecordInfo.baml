   M S B A M L   `   `   `  ����D  @VinylShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:VinylShop.EntityVinylShop.Entity  5   	   +    %VinylShop.SecondaryWindows.RecordInfo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:VinylShop.Entity     5   	     � Title$  
RecordInfo��5   	   $	��650��6   $	��800��6)    � DataContext 5	      "   VinylShop.Entity.VinylRecord  5
   
    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $  /Styles/AppDictionary.xaml?�6%   %    5      .��5      � -   5         �Name$ mainGrid��5       � Cursor$ /Resources/cursor.cur��6    � RowDefinitions 5   
   �� 5      $
��2.2* �6   6,   �� 5      $��2* �6   6*   �� 5      $
��0.5* �6   6,   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��2* �6#   60   .+�5!      �� -   5        	 ��Name$	 RecordImage_image��5!      ��6/   �� 
 �� Path$
 	ImagePath��� 5#      -   5         ��Name$ RecordInfo_stackPanel��5#   )   $��1��6   .+�5%      �� -   5         ��Name$ EditVinylRecord_button��5%         EditButton_RI#���   69   $��
0,10,20, 0q�6c   $��15(�6w   $��Right=�6�     
LinkButton#��[ 6�   6�   �� 5'      $��50(�67   $
��Left=�6E   $��10, 5, 0 ,0q�6`   ��6   �� $

 Name�6`   �� 5(      $��25(�69   $
��Left=�6G   $��50, 0, 0, 0q�6b   ��6   �� $
 Artist�6b   �� 5)      $��15(�68   $
��Left=�6F   $��200, 0, 0, 0q�6a   ��6   �� $
 Jenre�6a   �� 5+      $��20(�6a   $
��Left=�6o   $��10, 0, 30, 0q�6�   ��6   �� $
 Duration� �� StringFormat$ Descripion: {0:mm:ss}��6�   �� 5,      $��20(�6T   $
��Left=�6b   $��10, 0, 30, 0q�6}   ��6   �� $
 Lable�$ Lable: {0:}��6}   �� 5-      $��20(�6X   $
��Left=�6f   $��10, 0, 30, 0q�6�   ��6   �� $
 Country�$ Country: {0:}��6�   �� 5.      $��20(�6k   $
��Left=�6y   $��10, 0, 30, 0q�6�   ��6   �� $
 ReleaseDate�$" Release date: {0:dd.MM.yyyy}��6�   �� 5/      $��20(�6V   $
��Left=�6d   $��10, 0, 30, 0q�6   ��6   �� $
 Rating�$ Rating: {0:}��6   50      51      �� 52   
   $��1��6   .+�53      ��   Description_MW#���  6   $��25(�6?   $
��Left=�6M   $��10q�6h   �� 54      $��15(�6:   $
��Left=�6H   $��10, 0q�6c   ��6   �� $
 Description�6c   55      �� 57   
   -   5        $  OtherRecordInfo_stackPanel��57   "   $��2��6   .+�58      �� $��15(�6P   $
��Left=�6^   $��10, 5q�6y   ��6   �� $
 Price�$ Price: {0:}��6y   �� 59      $��15(�6V   $
��Left=�6d   $��10, 5q�6   ��6   �� $
 Quantity�$ Quantity: {0:}��6   5:      5;      5<      