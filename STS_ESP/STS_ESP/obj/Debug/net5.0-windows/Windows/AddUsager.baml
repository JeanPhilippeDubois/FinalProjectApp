   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:STS_ESP.WindowsSTS_ESP.Windows  5          STS_ESP.Windows.AddUsager   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:STS_ESP.Windows     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��500��5	      $
��1000��6     � Title$  Ajouter un usager��5
      .��5      � 
�������.+�5   
   �� $��1q�6   
�������$��75q�68   ._�5      � $��15q�6    � RowDefinitions 5      �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$    � 	Resources 5      ��%    5      .+�5      �� $��Ajoutez un usager��6   $��0��64   $��./#Roboto Regular)�6A   $��24(�6`   $��Center=�6n   $
��Bold"�6�   �� 5      $K��EEntrez les informations du nouveau usager que vous voullez créer ...��6   $��1��6g   $��./#Roboto Regular)�6t   $��12(�6�   $��Center=�6�   �� 5       $��2��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nom complet��6'      
IsFloating$
 True��6T    � Cursor$ IBeam��6�   $��	25,0,25,0q�6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6�   ��6�   �� *
NomComplet+6�   �� 5!      $��3��6   $ Numéro de téléphone��6'   $
 True��6\   $ IBeam��6�   $��	25,0,25,0q�6�   $
 True��6�   ��6�   �� *NoTelephone+6�   �� 5"      $��4��6   $ Addresse Couriel��6'   $
 True��6Y   $ IBeam��6�   $��	25,0,25,0q�6�   $
 True��6�   ��6�   �� *
Courriel+6�   �� 5&      $��3��6   $��5��6+   $
 true��68   $ 
Abonnement��6d   $��	25,0,25,0q�6�    �� SelectedIndex$ 0��6�    �� SelectedItem 6�   �� *TypeAbonnement+.@�5'      �� $��Aucun��6#   �� 5(      $��
Journalier��6#   �� 5)      $��Hebdomadaire��6#   �� 5*      $��Bihebdomadaire��6#   �� 5+      $��Mensuel��6#   �� 5,      $��Trimestriel��6#   �� 5-      $��Annuel��6#   5.      � 51      $��7��6   	 � ColumnDefinitions	 52      �� 53      $��1* �6+   �� 54      $��1* �6+   .+�57      �� $��0��6   $��	50,0,50,0q�6-   ��6@   �� *Button_AddUsager_Click+.��58      �� 
 �� Orientation$
 
Horizontal=�6%   .+�59      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�66   $
��Left=�6Q   $��25��6l   $��25��6w      Kind$ 
AccountAdd=�6�   �� 5:      $��Center=�6$   $
��Left=�6?   
�������.��6m   	Ajouter6v   5;      5<      �� 5>      -   5        $��1��5>      $��	50,0,50,0q�6-   .��5?      �� $
 
Horizontal=�6%   .+�5@        $��Center=�66   $
��Left=�6Q   $��25��6l   $��25��6w   $ 	ArrowBack=�6�   �� 5A      $��Center=�6$   $
��Left=�6?   
�������.��6m   Retour6u   5B      5C      5D      �� 5E      $��10��6   $��./Fonts/#Roboto Regular)�6&   $��10(�6K   $��Center=�6Y   $
��Bold"�6v   ���	#DDF70000��6�   �� *State+5G      5H      5I      5J      