   M S B A M L   `   `   `  ���� B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:STS_ESPSTS_ESP  7 clr-namespace:STS_ESP.ViewModelsSTS_ESP.ViewModels  _ [Microsoft.Win32.Registry, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aS?clr-namespace:Microsoft.Win32;assembly=Microsoft.Win32.RegistryMicrosoft.Win32     STS_ESP.MenuWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  !localclr-namespace:STS_ESP  1
viewmodels clr-namespace:STS_ESP.ViewModels  KWin32?clr-namespace:Microsoft.Win32;assembly=Microsoft.Win32.Registry    � Title$
  Menu��$	��600��$
��1400��$	��600��$
��1400��.���  � ColumnDefinitions �� -    ��Name$ MenuLeft��$	��275 ��� $��1* �.+�� $
��Left=����#147cc0$��0�� � RowDefinitions �� $��3* ��� $��0.75* ��� $��0.75* ��� $��0.75* ��� $��0.75* ��� $��2* ��� $��0.70* ��� $��0.70* �.+��� $��0�����#2199e8�� -    ��Name$
 Logo��$��Assets/STSLogo.svg.png��$��15q��� -    ��Name$ ButtonClose��$��Right=�$	��Top=���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�
���   �$��15��$��15���� -   $ 
ButtonOpen��$
��Left=�$	��Top=�$��0��$y�Hidden=���Z� ��Z� .��  $
 Menu=�
���   �$��15��$��15���� $��1��$
��Bold"�$��0,0,0,0q�$
��Left=���Z� ��Z� ���� *Button_Usager_Click+.����  �� Orientation$ 
Horizontal=�$
��10 0q�.+�  $ PeopleGroup=�$��25��$��25��
�������$��0,0,1,0q�$��0,0,5,0q��� -    ��Name$ 
UsagerText��$��Gestion des usagers��$��./Fonts/#Roboto Regular)�$��Center=�$
��Bold"�$��14(�
�������$��5,0,0,0q��� $��2��$
��Bold"�$��0,0,0,0q�$
��Left=���Z� ��Z� ���� *Button_Billet_Click+.���� $ 
Horizontal=�$
��10 0q�.+�  $ Money=�$��25��$��25��
�������$��0,0,1,0q�$��0,0,5,0q��� -   $ VenteBillet��$��Vente de billet��$��./Fonts/#Roboto Regular)�$��Center=�$
��Bold"�$��14(�
�������$��5,0,0,0q��� $��3��$
��Bold"�$��0,0,0,0q�$
��Left=���Z� ��Z� ���� *Button_Employer_Click+y��� *
Visibility+.���� $ 
Horizontal=�$
��10 0q�.+�  $ People=�$��25��$��25��
�������$��0,0,1,0q�$��0,0,5,0q��� -   $ GestionText��$��Gestion des employés��$��./Fonts/#Roboto Regular)�$��Center=�$
��Bold"�$��14(�
�������$��5,0,0,0q��� $��4��$
��Bold"�$��0,0,0,0q�$��0q�$
��Left=���Z� ��Z� ���� *Button_Rapport_Click+y��� *
Visibility+.���� $ 
Horizontal=�$
��10 0q�.+�  $ GoogleSpreadsheet=�$��25��$��25��
�������$��0,0,1,0q�$��0,0,5,0q��� -   $ RapportText��$��Rapports��$��./Fonts/#Roboto Regular)�$��Center=�$
��Bold"�$��14(�
�������$��5,0,0,0q��� $��6��$
��Bold"�$��0,0,0,0q�$
��Left=���Z� ��Z� ���� *Button_Compte_Click+.���� $ 
Horizontal=�$
��10 0q�.+�  $ 
AccountCog=�$��25��$��25��
�������$��0,0,5,0q��� -	   $ GestionCompteText��$��Gestion du compte��$��./Fonts/#Roboto Regular)�$��Center=�$
��Bold"�$��14(�
�������$��5,0,0,0q��� -
   $��7��$
��Bold"�$��0,0,0,0q�$
��Left=�	 � Cursor$
	 Hand����Z� ��Z� .���� $ 
Horizontal=�$
��10 0q�.+�  $ 
AccountOff=�$��25��$��25��$��0,0,5,0q�
���  ���� -   $ DecoText��$��Se déconnecter��$��./Fonts/#Roboto Regular)�$��Center=�$
��Bold"�$��14(�
�������$��5,0,0,0q�� $��1��.+� � 
  � NavigationUIVisibility$
 Hidden=����� *CurrentPage+