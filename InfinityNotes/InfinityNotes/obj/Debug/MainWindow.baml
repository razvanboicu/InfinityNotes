   M S B A M L   `   `   `  ����H  DInfinityNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:InfinityNotesInfinityNotes  5   	       InfinityNotes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7eo(http://schemas.essentialobjects.com/wpf/     5   	   -localclr-namespace:InfinityNotes     5   	   
������   � Title$  
MainWindow��5   	   $	��720��6   $
��1280��6)    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      6'     5   
   -   5        $
 Open��5      6(     5   
   -   5        $
 Save��5      6(     5   
   -   5        $ SaveAs��5      6*     5   
   -   5        $
 Find��5      6(   .��5      �� -   5         ��Name$ myBorder��5       �� CornerRadius$ 5��6   ��5   
   �� 5       �� 
StartPoint$ 0.3, 0&�6"    �� EndPoint$ 0.6, 1&�66   .��5      �  � Color$ #5b0e2d��6    � Offset$ 1Q�6/   � 5      $ #ffe042��6   $ 0Q�6/   5      ._�5      ]� .+�5       `� $	��Top=�6   .�5!      c� 
������ .@�5"      �� -   5        $	��New��5"      $	��New��6+   69   �� 5#      -   5        $
��Open��5#      $
��Open��6,   6;   �� 5$      -	   5        $
��Save��5$      $
��Save��6,   6;   �� 5%      -
   5        $��SaveAs��5%      $��Save As��6.   6@   5&      c� 5'      
������ .@�5(      �� -   5        $
��Find��5(      $��Find/Replace��6,   6C   �� 5)      -   5        $��About me��5)      60   5*      5+      `� 5,      $
��Left=�6   	 `� Orientation$	 Vertical=�60   
 `� 
Background

 ���� .�5-      c� .@�5.      �� $	��Cut��6    � ToolTip$) #Cut selection to Windows Clipboard.��6+   .��5/      �� $��/cut.png��6    $
��Fill=�62   $��16��6A   $��16��6L   $	��Top=�6X   $��0,0,0,0q�6p    �� BitmapScalingMode$ HighQuality=�6�   50      �� 51      $
��Copy��6   $* $Copy selection to Windows Clipboard.��6,   .��52      �� $��	/copy.png��6    $
��Fill=�63   $��16��6B   $��16��6M   $	��Top=�6Y   $��0,0,0,0q�6q   $ HighQuality=�6�   53      �� 54      $��Paste��6   $# Paste from Windows Clipboard.��6-   .��55      ��  �� Orientation$ 
Horizontal=�6%   .+�56      �� $��	paste.png��6$   $
��Fill=�67   $��16��6F   $��16��6Q   $	��Top=�6]   $��0,0,0,0q�6u   $ HighQuality=�6�   57      58      59      5:      R� 5<      -   5        $��trvStructure��5<      $��	5,27,5,12q�6Y   $��Right=�6n   �� 5>      -   5         ��Name$ 
tabControl��5>      5@      5B      5D      5G      