   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:STS_ESPSTS_ESP  5   	       STS_ESP.LoggingWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   !localclr-namespace:STS_ESP  5   	     � Title$  Page de connexion��5	   	   $	��450��6#   $	��400��60   $	��450��6=   $	��400��6M   .��5
      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� ���#2199e8$��0��6#   62   �� 5   
   ���#147cc0$��1��6#   62   � 5   
   $��2��6   $��25q�6    .+�5      �� 
���   �$	��1.5q�6)   ���#fefefe �� CornerRadius$ 25��6T   ._�5      �  5      �� 5      $��3* �6(   �� 5      $��1* �6(   �� 5      $��1* �6(   �� 5      $��1* �6(   �� 5      $��1* �6(   �� 5      $��1* �6(   �� 5      $��1* �6(   .+�5      �� $��STSLogo.svg.png��6   $��15q�65   6C   �� 5       $��2��6    �� 
CaretBrush �	#FF2199E8)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nom d'utilisateur��6B      
IsFloating$
 True��6u    � Cursor$ IBeam��6�   $��	50,0,50,0q�6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6�   ��6�   �� *AccountName+6�   G� 5!      -   5        $��4��5!   "   $ Mot de Passe��6/   $
 True��6]   $
 True��6�   $ IBeam��6�    G� 
CaretBrush �	#FF2199E8$��	50,0,50,0q�6  6(  �� 5"      $��7��6   $��Se connecter��6,   
����  �$��	50,0,50,0q�6U   ��6h   �� *Button_Login_Click+�� 5#      $��8��6   
���  ��$
��Bold"�6:   $��./#Roboto Regular)�6L   $��14(�6k   $��Center=�6y   ��6�   �� *State+5%      5'      5(      5)      5*      