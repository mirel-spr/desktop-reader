   M S B A M L   `   `   `  ����G  CHalachaNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HalachaNotesHalachaNotes  5   	   7 clr-namespace:HalachaNotes.ViewsHalachaNotes.Views  5   	   +clr-namespace:HalachaNotesHalachaNotes  5   	       HalachaNotes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:HalachaNotes     5   	   /uc clr-namespace:HalachaNotes.Views     5   	   ,Viewsclr-namespace:HalachaNotes     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65   .��5      � $��12,0,-12.4,0q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   "   HalachaNotes.Views.TextPanel  -   5          Name$ txtTextPanel��5   $   $��1��6      Title$ Enter title:��6:      	MaxLength$ 30��6O   $��50��6^   %   HalachaNotes.Views.OptionsPanel  5   
   -   5          Name$ pnlOptionsPanel��5      5      5      