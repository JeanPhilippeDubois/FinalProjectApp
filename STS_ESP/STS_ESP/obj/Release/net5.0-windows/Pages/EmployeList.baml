   M S B A M L   `   `   `  ���� B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:STS_ESP.PagesSTS_ESP.Pages      STS_ESP.Pages.EmployeList   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  'localclr-namespace:STS_ESP.Pages    N� Title$  EmployeList��.��� 
������� � RowDefinitions �� $
��0.5* ��� $��1* ��� $��1* ��� $��6* �.+��� $��2��$��0,1,0,1q�
�������._�� $��2�� � ColumnDefinitions �� $��2* ��� $
��0.5* �.+��� $��6��$��	10,0,10,0q����� *Button_Actualiser_Click+.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$
��Left=�   Kind$ Refresh=��� $��Center=�$
��Left=�
�������.��
Actualiser�� $��Liste des employés��$��./Fonts/#Roboto Regular)�$��20(�$��0��$
��Bold"��� $��1��$��0,1,0,1q�
�������._�� $��1�� �� $��1* ��� $��1* ��� $��1* ��� $��2* ��� $��1* �.+��� $��0��$��	10,0,10,0q����� *Button_AjouterEmploye_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$
��Auto��$
��Auto��$ 
AccountAdd=��� $��Center=�$
��Left=�
�������.��	Ajouter�� $��1��$��	10,0,10,0q����� *Button_ModifierEmploye_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$
��Auto��$
��Auto��$ 
AccountCog=��� $��Center=�$
��Left=�
�������.��
Modifier�� $��2��$��	10,0,10,0q����� *Button_SupprimerEmploye_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$
��Auto��$
��Auto��$ AccountRemove=��� $��Center=�$
��Left=�
�������.��	Supprimer�� $��3��$��Center=�
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Recherche������ *ChampRecherche+�� $��4��$��	10,0,10,0q����� *Button_RechercheEmploye_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$
��Auto��$
��Auto��$ Search=��� $��Center=�$
��Left=�
�������.��	Recherche�� $��4��$��25q�
�������$��1q�._��� $��2������ *ListEmploye+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem �� *SelectEmploye+ �� View �� .P��� $��No. Employé��	 �� Width$
	 Auto��
 �� DisplayMemberBinding
 �� *Id+$ PropertyChanged=��� $	��Nom��$
	 Auto��
 �� *
NomComplet+$ PropertyChanged=��� $��Nom du compte��$
	 Auto��
 �� *
Username+$ PropertyChanged=��� $��Courriel��$
	 Auto��
 �� *EmailAddress+$ PropertyChanged=��� $��Statut��$
	 Auto��
 �� *StatutCompte+$ PropertyChanged=��� $
��Role��$
	 Auto��
 �� *Role+$ PropertyChanged=�