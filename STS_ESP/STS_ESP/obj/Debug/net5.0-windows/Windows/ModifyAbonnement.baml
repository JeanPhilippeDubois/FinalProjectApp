   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:STS_ESP.WindowsSTS_ESP.Windows  5      &     STS_ESP.Windows.ModifyAbonnement   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      )localclr-namespace:STS_ESP.Windows  5      $	��450��5	      $	��800��6     � Title$'  !Modifier l'abonnement d'un usager��5
      .��5      � 
�������.+�5   
   �� $��1q�6   
�������$��75q�68   ._�5      � $��15q�6    � RowDefinitions 5      �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$    � 	Resources 5      ��%    5      .+�5      �� $ ��Modifier Abonnement Usager��6   $��0��6=   $��./#Roboto Regular)�6J   $��24(�6i   $��Center=�6w   $
��Bold"�6�   �� 5       $?��9Effectuez les changements sur l'abonnement de l'usager...��6   $��1��6\   $��./#Roboto Regular)�6i   $��12(�6�   $��Center=�6�   � 5"      $��3��6    � ColumnDefinitions 5#      �� 5$      $��1* �6+   �� 5%      $��1* �6+   �� 5&      $��1* �6+   .+�5)      �� $��Abonnement :��6   $��0��63   $��Right=�6D   $��./Fonts/#Roboto Regular)�6`   $��16(�6�   $��Center=�6�   �� 5+      $��1��69   $��./Fonts/#Roboto Regular)�6I   $��16(�6n   $��Center=�6|    �� 
IsReadOnly$
 True��6�   ��6   �� *	AboActuel+6�   �� 5-      $��3��6   $��	25,0,25,0q�6-   ��6@   �� *Button_Supprimer_Click+.��5.      ��  �� Orientation$ 
Horizontal=�6%   .+�5/      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�66   $
��Left=�6Q   $��25��6l   $��25��6w      Kind$ Delete=�6�   �� 50      $��Center=�6$   $
��Left=�6?   
�������.��6m   	Supprimer6x   51      52      55      � 57      $��5��6    58      �� 59      $��1* �6+   �� 5:      $��1* �6+   �� 5;      $��1* �6+   .+�5>      �� $��Nouvel Abonnement :��6   $��0��6:   $��Right=�6K   $��./Fonts/#Roboto Regular)�6g   $��16(�6�   $��Center=�6�   �� 5?      $��1��6   $��5��6/   )  #MaterialDesignThemes.Wpf.HintAssist   
IsFloating$
 true��6<      Hint$ 
Abonnement��6h   	 �� SelectedIndex$	 0��6�   
 �� SelectedValue
 6�   �� *AboNew+.@�5@      �� $��Aucun��6'   �� 5A      $��
Journalier��6'   �� 5B      $��Hebdomadaire��6'   �� 5C      $��Bihebdomadaire��6'   �� 5D      $��Mensuel��6'   �� 5E      $��Trimestriel��6'   �� 5F      $��Annuel��6'   5G      �� 5I      $��3��6   $��	25,0,25,0q�6-   ��6@   �� *Button_Ajouter_Click+.��5J      �� $ 
Horizontal=�6%   .+�5K        $��Center=�66   $
��Left=�6Q   $��25��6l   $��25��6w   $ Delete=�6�   �� 5L      $��Center=�6$   $
��Left=�6?   
�������.��6m   	Ajouter6v   5M      5N      5Q      � 5W      $��8��6    5X      �� 5Y      $��1* �6+   .+�5\      �� -   5        $��1��5\      $��150,0,150,0q�6-   .��5]      �� $ 
Horizontal=�6%   .+�5^        $��Center=�66   $
��Left=�6Q   $��25��6l   $��25��6w   $ 	ArrowBack=�6�   �� 5_      $��Center=�6$   $
��Left=�6?   
�������.��6m   Retour6u   5`      5a      5b      �� 5d      $��9��6   $��./Fonts/#Roboto Regular)�6%   $��10(�6J   $��Center=�6X   $
��Bold"�6u   ���	#DDF70000��6�   �� *State+5e      5f      5g      5h      