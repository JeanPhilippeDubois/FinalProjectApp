   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:STS_ESP.PagesSTS_ESP.Pages  5      7 clr-namespace:STS_ESP.ViewModelsSTS_ESP.ViewModels  61       STS_ESP.Pages.UsersList   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:STS_ESP.Pages  5      1
viewmodels clr-namespace:STS_ESP.ViewModels  61     N� Title$  	UsersList��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��6* �6   .+�5   
   �� $��Liste des usagers��6   $��	./#Roboto)�6,   $��20(�6C   $��0��6R   $
��Bold"�6_   �� 5   
   $��1��6   $��0,1,0,1q�6   
�������._�5      � $��1��6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��2* �6#   �� 5      $��1* �6#   .+�5      �� $��0��6   $��	10,0,10,0q�6)   ��6<   �� *Button_AjouterUser_Click+.��5       ��  �� Orientation$ 
Horizontal=�6!   .+�5!      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�62   $
��Left=�6M      Kind$ 
AccountAdd=�6i   �� 5"      $��Center=�6    $
��Left=�6;   
�������.��6i   	Ajouter6r   5#      5$      �� 5'      $��1��6   $��	10,0,10,0q�6)   ��6<   �� *Button_ModifierUser_Click+.��5(      �� $ 
Horizontal=�6!   .+�5)        $��Center=�62   $
��Left=�6M   $ 
AccountCog=�6i   �� 5*      $��Center=�6    $
��Left=�6;   
�������.��6i   
Modifier6s   5+      5,      �� 5.      $��2��6   $��	10,0,10,0q�6)   ��6<   �� *Button_SupprimerUser_Click+.��5/      �� $ 
Horizontal=�6!   .+�50        $��Center=�62   $
��Left=�6M   $ AccountRemove=�6i   �� 51      $��Center=�6    $
��Left=�6;   
�������.��6i   	Supprimer6t   52      53      �� 54      $��3��6   $��Center=�6*   
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Recherche��6Y      
IsFloating$
 True��6�    � Cursor$ IBeam��6�   ��6�   �� *ChampRecherche+ �� Mode$ TwoWay=��� 56      $��4��6   $��	10,0,10,0q�6)   ��6<   �� *Button_RechercheUser_Click+.��57      �� $ 
Horizontal=�6!   .+�58        $��Center=�62   $
��Left=�6M   $ Search=�6i   �� 59      $��Center=�6    $
��Left=�6;   
�������.��6i   	Recherche6t   5:      5;      5<      5=      �� 5?   
   $��2��6   $��0,1,0,1q�6   
�������._�5@      � $��2��6    5A      �� 5B      $��1* �6'   �� 5C      $��1* �6'   �� 5D      $
��0.5* �6'   �� 5E      $
��0.5* �6'   �� 5F      $
��0.5* �6'   .+�5H      �� $��0��6   $��	10,0,10,0q�6)   ��6<   �� *Button_ModifierAboUser_Click+.��5I      �� $ 
Horizontal=�6!   .+�5J        $��Center=�62   $
��Left=�6M   $ 
AccessTime=�6i   �� 5K      $��Center=�6    $
��Left=�6;   
�������.��6i   Modifier Abonnemment6   5L      5M      �� 5N      $��1��6   $��	10,0,10,0q�6)   ��6<   �� *" Button_ModifierBalanceUser_Click+.��5O      �� $ 
Horizontal=�6!   .+�5P        $��Center=�62   $
��Left=�6M   $ Money=�6h   �� 5Q      $��Center=�6    $
��Left=�6;   
�������.��6i   Modifier Balance6{   5R      5S      �� 5V      $��6��6   $��	10,0,10,0q�6)   ��6<   �� *Button_Actualiser_Click+.��5W      �� $ 
Horizontal=�6!   .+�5X        $��Center=�62   $
��Left=�6M   $ Refresh=�6h   �� 5Y      $��Center=�6    $
��Left=�6;   
�������.��6i   
Actualiser6u   5Z      5[      5]      5^      �� 5_   
   $��4��6   $��25q�6   
�������$��1q�6=   ._�5`      �� $��2��6<   ��6   �� *ListeUsagers+	 �� SelectedItem	 6I   �� *SelectUsagers+
 �� View
 5a      �� 5b      .P�5c      �� $��
No. Usager��6M    �� Width$
 Auto��6a    �� DisplayMemberBinding 6)   �� *Id+6a   �� 5d      $	��Nom��6U   $
 Auto��6b    6)   �� *
NomComplet+6b   �� 5e      $��Courriel��6W   $
 Auto��6i    6)   �� *EmailAddress+6i   �� 5f      $��Type Abonnement��6Y   $
 Auto��6r    6)   �� *Carte.Abo.Type+6r   �� 5g      $��No.Carte��6X   $
 Auto��6j    6)   �� *Carte.NoCarte+6j   �� 5h      $��Balance��6X   $
 Auto��6i    6)   �� *Carte.Balance+6i   5i      5k      5l      5m      5n      