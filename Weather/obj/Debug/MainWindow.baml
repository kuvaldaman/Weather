   M S B A M L   `   `   `  ����B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WeatherWeather  5   	       Weather.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Weather     5   	     � Title$  Weather��5   	   $	��350��6   $	��525��6&    � Icon$* $4d25109c1dba325bd065d512f6490e5f.png��62   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF141983��6    � Offset$ 0Q�61   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   �� -   5         ��Name$ latitudeTextBox��5      $
��Left=�6+   $��23��6F   $��
134,49,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $��50.8267��6�   6�   �� 5   
   -   5        $ longitudeTextBox��5      $
��Left=�6,   $��23��6G   $��
134,98,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   $��50.4234��6�   6�   �� 5   
   -   5         ��Name$ latitudeLabel��5      $��Широта��6'   $
��Left=�68   $��	28,46,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ longitudeLabel��5      $��Долгота��6(   $
��Left=�6:   $��	28,96,0,0q�6U   $	��Top=�6h   �� 5   
   -   5        	 ��Name$
	 show��5      $��Показать��6   $
��Left=�62   $��
28,154,0,0q�6M   $	��Top=�6a   $��75��6y   6�   �� 5   
   -   5        $ temperature��5      $
��Left=�6'   $��23��6B   $��134,153,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   {�.  6�   5      5      