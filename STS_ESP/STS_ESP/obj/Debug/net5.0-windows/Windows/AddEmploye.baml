   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:STS_ESP.WindowsSTS_ESP.Windows  5           STS_ESP.Windows.AddEmploye   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:STS_ESP.Windows     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��900��5	        � Title$  Ajouter un employé��5
      .��5      � 
�������.+�5   
   �� $��1q�6   
�������$��50q�68   ._�5      � $��15q�6    � RowDefinitions 5      �� 5      $��1* �6$   �� 5      $��0.75* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$    � 	Resources 5      ��%    5       .+�5!      �� $��Ajoutez un employé��6   $��0��65   $��./#Roboto Regular)�6B   $��24(�6a   $��Center=�6o   $
��Bold"�6�   �� 5"      $M��GEntrez les informations du nouveau employé que vous voullez créer ...��6   $��1��6h   $��./#Roboto Regular)�6u   $��12(�6�   $��Center=�6�   �� 5%      $��2��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nom complet��6'      
IsFloating$
 True��6T    � Cursor$ IBeam��6�   $��	25,0,25,0q�6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6�   ��6�   �� *
NomComplet+6�   �� 5&      $��3��6   $ Nom d'utilisateur��6'   $
 True��6Z   $ IBeam��6�   $��	25,0,25,0q�6�   $
 True��6�   ��6�   �� *
Username+6�   G� 5'      -   5        $��4��5'       G� 
CaretBrush �	#FF2199E8$ Mot de passe��6B   $
 True��6p   $��	25,0,25,0q�6�   $
 True��6�   6  �� 5(      $��5��6   $ Numéro de téléphone��6'   $
 True��6\   $ IBeam��6�   $��	25,0,25,0q�6�   $
 True��6�   ��6�   �� *NoTelephone+6�   �� 5)      $��6��6   $ Addresse Couriel��6'   $
 True��6Y   $ IBeam��6�   $��	25,0,25,0q�6�   $
 True��6�   ��6�   �� *
Courriel+6�   �� 5*      $��7��6   $
 true��6)   $
 Role��6U   $��	25,0,25,0q�6{    �� SelectedIndex$ 0��6�   	 �� SelectedValue	 6�   �� *Role+.@�5+      �� $��Commis��6#   �� 5,      $��Administrateur��6#   5-      �� 5.      $��8��6   $
 true��6)   $ Statut Compte��6U   $��	25,0,25,0q�6�   $ 0��6�   
 �� SelectedItem
 6�   �� *Statut+.@�5/      �� $��Actif��6#   �� 50      $��Inactif��6#   51      � 54      $��10��6    � ColumnDefinitions 55      �� 56      $��1* �6+   �� 57      $��1* �6+   .+�5:      �� $��0��6   $��	50,0,50,0q�6-   ��6@   �� *Button_AddEmploye_Click+.��5;      ��  �� Orientation$ 
Horizontal=�6%   .+�5<      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�66   $
��Left=�6Q   $��20��6l   $��20��6w      Kind$ 
AccountAdd=�6�   �� 5=      $��Center=�6$   $
��Left=�6?   
�������.��6m   	Ajouter6v   5>      5?      �� 5A      -   5        $��1��5A      $��	50,0,50,0q�6-   .��5B      �� $ 
Horizontal=�6%   .+�5C        $��Center=�66   $
��Left=�6Q   $��20��6l   $��20��6w   $ 	ArrowBack=�6�   �� 5D      $��Center=�6$   $
��Left=�6?   
�������.��6m   Retour6u   5E      5F      5G      �� 5H      $��11��6   $��./Fonts/#Roboto Regular)�6&   $��10(�6K   $��Center=�6Y   $
��Bold"�6v   ���	#DDF70000��6�   �� *State+5J      5K      5L      5M      