   M S B A M L   `   `   `  ����H  DInfinityNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:InfinityNotesInfinityNotes  5   	       InfinityNotes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7eo(http://schemas.essentialobjects.com/wpf/     5   	   -localclr-namespace:InfinityNotes     5   	     � Title$  
MainWindow��5
   	   $	��720��6   $
��1280��6)    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      6'     5   
   -   5        $
 Open��5      6(     5   
   -   5        $
 Save��5      6(     5   
   -   5        $ SaveAs��5      6*   .��5      ]� .+�5   
   `� $	��Top=�6   .�5      c� .@�5      �� -   5        $	��New��5      $	��New��6'   65   �� 5      -   5        $
��Open��5      $
��Open��6(   67   �� 5      $
��Save��6   $
��Save��6(   �� 5      -   5        $��SaveAs��5      $��Save As��6*   6<   5      c� 5      .@�5       �� $
��Find��6   $
��Find��6(   �� 5!      $��Replace��6   $��Replace��6+   �� 5"      $��Replace��6   $��Replace All��6+   5#      5$      `� 5%   
   $
��Left=�6    `� Orientation$ Vertical=�6,   .�5&      c� .@�5'      �� $	��Cut��6    � ToolTip$) #Cut selection to Windows Clipboard.��6'   .��5(      �� $��cut.png��6   $
��Fill=�6-   $��16��6<   $��16��6G   $	��Top=�6S   $��0,0,0,0q�6k    �� BitmapScalingMode$ HighQuality=�6|   5)      �� 5*      $
��Copy��6   $* $Copy selection to Windows Clipboard.��6(   .��5+      �� $��copy.png��6   $
��Fill=�6.   $��16��6=   $��16��6H   $	��Top=�6T   $��0,0,0,0q�6l   $ HighQuality=�6}   5,      �� 5-      $��Paste��6   $# Paste from Windows Clipboard.��6)   .��5.      ��  �� Orientation$ 
Horizontal=�6!   .+�5/      �� $��	paste.png��6    $
��Fill=�63   $��16��6B   $��16��6M   $	��Top=�6Y   $��0,0,0,0q�6q   $ HighQuality=�6�   50      51      52      53      R� 55   
   -   5        $��trvStructure��55      $��5,5,5,33q�6U   $��Right=�6i   �� 59   
   -	   5         ��Name$ 
tabControl��59      5;      5K      5M      