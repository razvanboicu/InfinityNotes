   M S B A M L   `   `   `  ����H  DInfinityNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:InfinityNotesInfinityNotes  5   	       InfinityNotes.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:InfinityNotes     5   	     � Title$  
MainWindow��5	   	   $	��720��6   $
��1280��6)    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      6'     5   
   -   5        $
 Open��5      6(     5   
   -   5        $
 Save��5      6(   .��5      ]� .+�5   
   `� $	��Top=�6   .�5      c� .@�5      �� -   5        $	��New��5      $	��New��6'   65   �� 5      $
��Open��6   $
��Open��6(   �� 5      -   5        $
��Save��5      $
��Save��6(   67   �� 5      $��SaveAs��6   $��Save As��6*   5      c� 5      .@�5      �� $
��Find��6   $
��Find��6(   �� 5      $��Replace��6   $��Replace��6+   �� 5      $��Replace��6   $��Replace All��6+   5      5      `� 5   
   $
��Left=�6    `� Orientation$ Vertical=�6,   .�5      c� .@�5       �� $	��Cut��6    � ToolTip$) #Cut selection to Windows Clipboard.��6'   .��5!      �� $��cut.png��6   $
��Fill=�6-   $��16��6<   $��16��6G   $	��Top=�6S   $��0,0,0,0q�6k    �� BitmapScalingMode$ HighQuality=�6|   5"      �� 5#      $
��Copy��6   $* $Copy selection to Windows Clipboard.��6(   .��5$      �� $��copy.png��6   $
��Fill=�6.   $��16��6=   $��16��6H   $	��Top=�6T   $��0,0,0,0q�6l   $ HighQuality=�6}   5%      �� 5&      $��Paste��6   $# Paste from Windows Clipboard.��6)   .��5'      ��  �� Orientation$ 
Horizontal=�6!   .+�5(      �� $��	paste.png��6    $
��Fill=�63   $��16��6B   $��16��6M   $	��Top=�6Y   $��0,0,0,0q�6q   $ HighQuality=�6�   5)      5*      5+      5,      �� 5.   
   $ 
Horizontal=�6   $��Bottom=�6.   $	��2,5q�6F   .+�5/      �� -   5        $��btnPreviousTab��5/      .��6H   Prev.6O   �� 50      -   5        $��
btnNextTab��50      .��6@   Next6F   �� 51      -   5        $��btnSelectedTab��51      .��6H   
Selected6R   52      �� 54   
   -	   5        $��
tabControl��54      55      56      58      