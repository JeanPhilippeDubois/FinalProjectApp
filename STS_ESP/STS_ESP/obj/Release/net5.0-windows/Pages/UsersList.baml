   M S B A M L   `   `   `  ���� B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:STS_ESP.PagesSTS_ESP.Pages  7 clr-namespace:STS_ESP.ViewModelsSTS_ESP.ViewModels      STS_ESP.Pages.UsersList   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  'localclr-namespace:STS_ESP.Pages  1
viewmodels clr-namespace:STS_ESP.ViewModels    N� Title$  	UsersList��.��� 
������� � RowDefinitions �� $
��0.5* ��� $��1* ��� $��1* ��� $��6* �.+��� $��Liste des usagers��$��./Fonts/#Roboto Regular)�$��20(�$��0��$
��Bold"��� $��1��$��0,1,0,1q�
�������._�� $��1�� � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��2* ��� $��1* �.+��� $��0��$��	10,0,10,0q����� *Button_AjouterUser_Click+.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$
��Left=�   Kind$ 
AccountAdd=��� $��Center=�$
��Left=�
�������.��	Ajouter�� $��1��$��	10,0,10,0q����� *Button_ModifierUser_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$ 
AccountCog=��� $��Center=�$
��Left=�
�������.��
Modifier�� $��2��$��	10,0,10,0q����� *Button_SupprimerUser_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$ AccountRemove=��� $��Center=�$
��Left=�
�������.��	Supprimer�� $��3��$��Center=�
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Recherche��   
IsFloating$
 True�� � Cursor$ IBeam������ *ChampRecherche+ �� Mode$ TwoWay=��� $��4��$��	10,0,10,0q����� *Button_RechercheUser_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$ Search=��� $��Center=�$
��Left=�
�������.��	Recherche�� $��2��$��0,1,0,1q�
�������._�� $��2�� �� $��1* ��� $��1* ��� $
��0.5* ��� $
��0.5* ��� $
��0.5* �.+��� $��0��$��	10,0,10,0q����� *Button_ModifierAboUser_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$ 
AccessTime=��� $��Center=�$
��Left=�
�������.��Modifier Abonnemment�� $��1��$��	10,0,10,0q����� *" Button_ModifierBalanceUser_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$ Money=��� $��Center=�$
��Left=�
�������.��Modifier Balance�� $��6��$��	10,0,10,0q����� *Button_Actualiser_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$ Refresh=��� $��Center=�$
��Left=�
�������.��
Actualiser�� $��4��$��25q�
�������$��1q�._��� $��2������ *ListeUsagers+	 �� SelectedItem	 �� *SelectUsagers+
 �� View
 �� .P��� $��
No. Usager�� �� Width$
 Auto�� �� DisplayMemberBinding �� *Id+�� $	��Nom��$
 Auto�� �� *
NomComplet+�� $��Courriel��$
 Auto�� �� *EmailAddress+�� $��Type Abonnement��$
 Auto�� �� *Carte.Abo.Type+�� $��No.Carte��$
 Auto�� �� *Carte.NoCarte+�� $��Balance��$
 Auto�� �� *Carte.Balance+