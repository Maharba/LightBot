   M S B A M L   `   `   `  ����J  FLightBotTablero, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LightBotTableroLightBotTablero  5   K       LightBotTablero.Tablero   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9LightBotTableroclr-namespace:LightBotTablero     6K   .��5      � -   5        $��
grdTablero��5        � ShowGridLines  .  � RowDefinitions 5   
   �� 5	      �� 5
      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � Triggers 5   
   :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   [�5      �� 5      ��5      �� 5       �� 
TargetName$ elRobot��6)    �� TargetProperty$6 0(Ellipse.RenderTransform).(TranslateTransform.Y)�6>   .��5   "   W� -   5         W�Name$ 
animacion1��5   ;   	 W� By$	 150X�62   	 g� Duration$	 0:0:1D�6O   5      5      5!      .+�5#   
   A� -   5        $��elRobot��5#      
���   �
��� ���z�5$      T� 5%      5'      5)      5*      