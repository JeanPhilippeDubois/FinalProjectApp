   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:STS_ESPSTS_ESP  5   	   7 clr-namespace:STS_ESP.ViewModelsSTS_ESP.ViewModels  6-   _ [Microsoft.Win32.Registry, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aS?clr-namespace:Microsoft.Win32;assembly=Microsoft.Win32.RegistryMicrosoft.Win32 6a       STS_ESP.MenuWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   !localclr-namespace:STS_ESP  5   	   1
viewmodels clr-namespace:STS_ESP.ViewModels  6-   KWin32?clr-namespace:Microsoft.Win32;assembly=Microsoft.Win32.Registry  6a     � Title$
  Menu��5
   	   $	��600��6   $
��1400��6'   $	��600��5   	   $
��1400��6   .��5      �  � ColumnDefinitions 5   
   �� 5      -   5         ��Name$ MenuLeft��5      $	��275 �61   �� 5      $��1* �6   .+�5   
   � $
��Left=�6   ���#147cc0$��0��6?    � RowDefinitions 5      �� 5      $��3* �6    �� 5      $��0.75* �6    �� 5      $��0.75* �6    �� 5      $��0.75* �6    �� 5      $��0.75* �6    �� 5      $��2* �6    �� 5      $��0.70* �6    �� 5      $��0.70* �6    .+�5!      �� $��0��6   ���#2199e86%   �� 5"      -   5         ��Name$
 Logo��5"   /   $��STSLogo.svg.png��6   $��15q�6=   �� 5$      -   5         ��Name$ ButtonClose��5$      $��Right=�6W   $	��Top=�6s   ��6*   Z� ��6@   Z� .��5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6*   
���   �$��15��6J   $��15��6U   5&      �� 5(      -   5        $ 
ButtonOpen��5(      $
��Left=�6V   $	��Top=�6q   $��0��6�   $y�Hidden=�6�   ��6)   Z� ��6?   Z� .��5)        $
 Menu=�6*   
���   �$��15��6I   $��15��6T   5*      �� 5,      $��1��6   $
��Bold"�6O   $��0,0,0,0q�6b   $
��Left=�6t   ��6"   Z� ��68   Z� ��6�   �� *Button_Usager_Click+.��5-      ��  �� Orientation$ 
Horizontal=�6   $
��10 0q�67   .+�5.        $ PeopleGroup=�6.   $��25��6A   $��25��6M   
�������$��0,0,1,0q�6l   $��0,0,5,0q�6~   �� 5/      -   5         ��Name$ 
UsagerText��5/   !   $��Gestion des usagers��65   $��./#Roboto Regular)�6P   $��Center=�6o   $
��Bold"�6�   $��14(�6�   
�������$��5,0,0,0q�6�   50      51      �� 53      $��2��6   $
��Bold"�6O   $��0,0,0,0q�6b   $
��Left=�6t   ��6"   Z� ��68   Z� ��6�   �� *Button_Billet_Click+.��54      �� $ 
Horizontal=�6   $
��10 0q�67   .+�55        $ Money=�6.   $��25��6;   $��25��6G   
�������$��0,0,1,0q�6f   $��0,0,5,0q�6x   �� 56      -   5        $ VenteBillet��56       $��Vente de billet��65   $��./#Roboto Regular)�6L   $��Center=�6k   $
��Bold"�6�   $��14(�6�   
�������$��5,0,0,0q�6�   57      58      �� 5;      $��3��6   $
��Bold"�6O   $��0,0,0,0q�6b   $
��Left=�6t   ��6"   Z� ��68   Z� ��6�   �� *Button_Employer_Click+y�6�   �� *
Visibility+.��5<      �� $ 
Horizontal=�6   $
��10 0q�67   .+�5=        $ People=�6.   $��25��6<   $��25��6H   
�������$��0,0,1,0q�6g   $��0,0,5,0q�6y   �� 5>      -   5        $ GestionText��5>       $��Gestion des employés��65   $��./#Roboto Regular)�6Q   $��Center=�6p   $
��Bold"�6�   $��14(�6�   
�������$��5,0,0,0q�6�   5?      5@      �� 5C      $��4��6   $
��Bold"�6O   $��0,0,0,0q�6b   $��0q�6u   $
��Left=�6�   ��6"   Z� ��68   Z� ��6�   �� *Button_Rapport_Click+y�6�   �� *
Visibility+.��5D      �� $ 
Horizontal=�6   $
��10 0q�67   .+�5E        $ GoogleSpreadsheet=�6.   $��25��6G   $��25��6S   
�������$��0,0,1,0q�6r   $��0,0,5,0q�6�   �� 5F      -   5        $ RapportText��5F       $��Rapports��65   $��./#Roboto Regular)�6E   $��Center=�6d   $
��Bold"�6�   $��14(�6�   
�������$��5,0,0,0q�6�   5G      5H      �� 5J      $��6��6   $
��Bold"�6O   $��0,0,0,0q�6b   $
��Left=�6t   ��6"   Z� ��68   Z� ��6�   �� *Button_Compte_Click+.��5K      �� $ 
Horizontal=�6   $
��10 0q�67   .+�5L        $ 
AccountCog=�6.   $��25��6@   $��25��6L   
�������$��0,0,5,0q�6l   �� 5M      -	   5        $ GestionCompteText��5M       $��Gestion du compte��6;   $��./#Roboto Regular)�6T   $��Center=�6s   $
��Bold"�6�   $��14(�6�   
�������$��5,0,0,0q�6�   5N      5O      �� 5Q      -
   5        $��7��5Q      $
��Bold"�6O   $��0,0,0,0q�6b   $
��Left=�6t   	 � Cursor$
	 Hand��6�   ��6"   Z� ��68   Z� .��5R      �� $ 
Horizontal=�6   $
��10 0q�67   .+�5S        $ 
AccountOff=�6.   $��25��6@   $��25��6L   $��0,0,5,0q�6Y   
���  ��6j   �� 5T      -   5        $ DecoText��5T       $��Se déconnecter��62   $��./#Roboto Regular)�6H   $��Center=�6g   $
��Bold"�6�   $��14(�6�   
�������$��5,0,0,0q�6�   5U      5V      5Y      � 5Z   
   $��1��6   .+�5[       � 
  � NavigationUIVisibility$
 Hidden=�64   ��6   �� *CurrentPage+5]      5^      5_      5`      