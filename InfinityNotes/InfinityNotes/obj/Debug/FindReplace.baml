   M S B A M L   `   `   `  ����H  DInfinityNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:InfinityNotesInfinityNotes  5   	       InfinityNotes.FindReplace   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7eo(http://schemas.essentialobjects.com/wpf/     5   	   -localclr-namespace:InfinityNotes     5   	     � Title$  Find/Replace��5
   	   $	��150��6   $	��300��6+   .��5      � $
��Left=�6   .+�5   
   �� -   5         ��Name$ stack1��5      .+�5      �� $��	15,15,0,0q�6    �� Orientation$ 
Horizontal=�6,   .+�5      �� -   5         ��Name$ textBoxFind��5      $
��Left=�6/   $��20��6J   $��80��6V   6c   �� 5      -   5         ��Name$ previousFindButton��5   F   $��
5, 0, 0, 0q�6   
������  � ToolTip$ Previous result��6b   .��5      �� $��	/left.png��6   $
��Fill=�6/   $��16��6>   $��16��6I   $	��Top=�6U   $��0,0,0,0q�6m    �� BitmapScalingMode$ HighQuality=�6~   6�   5      �� 5      -   5        $ nextFindButton��5   G   $��21, 0, 0, 0q�6   
������ $ Next result��6_   .��5      �� $��
/right.png��6   $
��Fill=�60   $��16��6?   $��16��6J   $	��Top=�6V   $��0,0,0,0q�6n   $ HighQuality=�6   6�   5      �� 5      -   5        $ 
findButton��5   l   $��25, 0, 0, 0q�63   
������ $��60��6a   $ Find results��6�   .��5      �� $��	/find.png��6   $
��Fill=�6/   $��16��6>   $��16��6I   $	��Top=�6U   $��0,0,0,0q�6m   $ HighQuality=�6~   6�   5      �� 5      -   5         ��Name$ searchEverywhereCheckBox��5      $��15,0,0,0q�6=   $��16��6P   $��16��6[   $ Search everywhere��6g   6�   5      �� 5      $��	15,15,0,0q�6   $ 
Horizontal=�6,   .+�5      �� $��0,0,5,0q�6   $��Italic$�6-   Old6E   �� 5      -   5        $ 
textBoxOld��5      $
��Left=�6.   $��20��6I   $��50��6U   6b   �� 5      $��5,0,5,0q�6   $��Italic$�6-   New6E   �� 5       -   5        $ 
textBoxNew��5       $
��Left=�6.   $��20��6I   $��50��6U   6b   �� 5!      -	   5        $ replaceButton��5!   �   $��Italic$�67   $��15, 0, 0, 0q�6J   
������ $��60��6x   $ Find results��6�   .��6�   	Replace6�   �� 5"      -
   5        $ replaceAllCheckBox��5"      $��15,0,0,0q�67   $��16��6J   $��16��6U   $ Replace All��6a   6y   5#      5%      5&      5*      