   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:STS_ESP.WindowsSTS_ESP.Windows  5      "    STS_ESP.Windows.ModifyUsager   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:STS_ESP.Windows     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��450��5	      $	��800��6     � Title$  Modifier un usager��5
      .��5      � 
�������.+�5   
   �� $��1q�6   
�������$��75q�68   ._�5      � $��15q�6    � RowDefinitions 5      �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$    � 	Resources 5      ��%    5      .+�5      �� $��Modifier un usager��6   $��0��65   $��./#Roboto Regular)�6B   $��24(�6a   $��Center=�6o   $
��Bold"�6�   �� 5      $/��)Modifiez les informations de l'usager ...��6   $��1��6L   $��./#Roboto Regular)�6Y   $��12(�6x   $��Center=�6�   �� 5       $��2��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nom complet��6'      
IsFloating$
 True��6T    � Cursor$ IBeam��6�   $��	25,0,25,0q�6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6�   ��6�   �� *
NomComplet+6�   �� 5!      $��3��6   $ Numéro de téléphone��6'   $
 True��6\   $ IBeam��6�   $��	25,0,25,0q�6�   $
 True��6�   ��6�   �� *NoTelephone+6�   �� 5"      $��4��6   $ Addresse Couriel��6'   $
 True��6Y   $ IBeam��6�   $��	25,0,25,0q�6�   $
 True��6�   ��6�   �� *
Courriel+6�   � 5$      $��7��6    � ColumnDefinitions 5%      �� 5&      $��1* �6+   �� 5'      $��1* �6+   .+�5*      �� $��0��6   $��	50,0,50,0q�6-   ��6@   �� *Button_ModifierUsager_Click+.��5+      ��  �� Orientation$ 
Horizontal=�6%   .+�5,      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�66   $
��Left=�6Q   $��25��6l   $��25��6w   	   Kind$	 AccountSync=�6�   �� 5-      $��Center=�6$   $
��Left=�6?   
�������.��6m   
Modifier6w   5.      5/      �� 51      -   5        $��1��51      $��	50,0,50,0q�6-   .��52      �� $ 
Horizontal=�6%   .+�53        $��Center=�66   $
��Left=�6Q   $��25��6l   $��25��6w   $	 	ArrowBack=�6�   �� 54      $��Center=�6$   $
��Left=�6?   
�������.��6m   Retour6u   55      56      57      �� 58      $��9��6   $��./Fonts/#Roboto Regular)�6%   $��10(�6J   $��Center=�6X   $
��Bold"�6u   ���	#DDF70000��6�   �� *State+5:      5;      5<      5=      