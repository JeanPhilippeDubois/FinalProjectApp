   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:STS_ESP.PagesSTS_ESP.Pages  5          STS_ESP.Pages.EmployeList   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:STS_ESP.Pages  5        N� Title$  EmployeList��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��6* �6   .+�5   
   �� $��2��6   $��0,1,0,1q�6   
�������._�5      � $��2��6    � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $
��0.5* �6'   .+�5      �� $��6��6   $��	10,0,10,0q�6)   ��6<   �� *Button_Actualiser_Click+.��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�62   $
��Left=�6M      Kind$ Refresh=�6h   �� 5      $��Center=�6    $
��Left=�6;   
�������.��6i   
Actualiser6u   5      5       5"      5#      �� 5$   
   $��Liste des employés��6   $��./Fonts/#Roboto)�6-   $��20(�6J   $��0��6Y   $
��Bold"�6f   �� 5&   
   $��1��6   $��0,1,0,1q�6   
�������._�5'      � $��1��6    5(      �� 5)      $��1* �6'   �� 5*      $��1* �6'   �� 5+      $��1* �6'   �� 5,      $��2* �6'   �� 5-      $��1* �6'   .+�5/      �� $��0��6   $��	10,0,10,0q�6)   ��6<   �� *Button_AjouterEmploye_Click+.��50      �� $ 
Horizontal=�6!   .+�51        $��Center=�62   $
��Left=�6M   $
��Auto��6h   $
��Auto��6u   $ 
AccountAdd=�6�   �� 52      $��Center=�6    $
��Left=�6;   
�������.��6i   	Ajouter6r   53      54      �� 57      $��1��6   $��	10,0,10,0q�6)   ��6<   �� *Button_ModifierEmploye_Click+.��58      �� $ 
Horizontal=�6!   .+�59        $��Center=�62   $
��Left=�6M   $
��Auto��6h   $
��Auto��6u   $ 
AccountCog=�6�   �� 5:      $��Center=�6    $
��Left=�6;   
�������.��6i   
Modifier6s   5;      5<      �� 5>      $��2��6   $��	10,0,10,0q�6)   ��6<   �� *Button_SupprimerEmploye_Click+.��5?      �� $ 
Horizontal=�6!   .+�5@        $��Center=�62   $
��Left=�6M   $
��Auto��6h   $
��Auto��6u   $ AccountRemove=�6�   �� 5A      $��Center=�6    $
��Left=�6;   
�������.��6i   	Supprimer6t   5B      5C      �� 5D      $��3��6   $��Center=�6*   
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Recherche��6Y   ��6�   �� *ChampRecherche+�� 5F      $��4��6   $��	10,0,10,0q�6)   ��6<   �� *Button_RechercheEmploye_Click+.��5G      �� $ 
Horizontal=�6!   .+�5H        $��Center=�62   $
��Left=�6M   $
��Auto��6h   $
��Auto��6u   $ Search=�6�   �� 5I      $��Center=�6    $
��Left=�6;   
�������.��6i   	Recherche6t   5J      5K      5L      5M      �� 5Q   
   $��4��6   $��25q�6   
�������$��1q�6=   ._�5R      �� $��2��6`   ��6   �� *ListEmploye+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6n   �� *SelectEmploye+ �� View 5S      �� 5T      .P�5U      �� $��No. Employé��6r   	 �� Width$
	 Auto��6�   
 �� DisplayMemberBinding
 6)   �� *Id+$ PropertyChanged=�6�   �� 5V      $	��Nom��6z   $
	 Auto��6�   
 6)   �� *
NomComplet+$ PropertyChanged=�6�   �� 5W      $��Nom du compte��6x   $
	 Auto��6�   
 6)   �� *
Username+$ PropertyChanged=�6�   �� 5X      $��Courriel��6|   $
	 Auto��6�   
 6)   �� *EmailAddress+$ PropertyChanged=�6�   �� 5Y      $��Statut��6|   $
	 Auto��6�   
 6)   �� *StatutCompte+$ PropertyChanged=�6�   �� 5Z      $
��Role��6t   $
	 Auto��6�   
 6)   �� *Role+$ PropertyChanged=�6�   5\      5^      5_      5`      5a      