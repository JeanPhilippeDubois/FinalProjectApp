   M S B A M L   `   `   `  ����B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:STS_ESP.PagesSTS_ESP.Pages  5          STS_ESP.Pages.Reports   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:STS_ESP.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  Rapport��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��0.25* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Rapport��6   $��./Fonts/#Roboto)�6"   $��24(�6?   $��0��6N   $
��Bold"�6[   $��Center=�6m   � 5   
   $��1��6    5      �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6     � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� $$��Nb. de transaction (7 jours) :��6   $��./Fonts/#Roboto)�6=   $��14(�6Z   $��0��6i   $
��Bold"�6v   $��Right=�6�   �� 5       $��1��6   $��0��6$   $��./Fonts/#Roboto)�61   $��12(�6N   $
��Left=�6\   ��6w   �� *NbTransaction7jours+�� 5!      $"��$ en transaction (7 jours) :��6   $��./Fonts/#Roboto)�6;   $��14(�6X   $��1��6g   $
��Bold"�6t   $��Right=�6�   �� 5"      $��1��6   $��1��6$   $��./Fonts/#Roboto)�61   $��12(�6N   $
��Left=�6\   ��6w   �� *NbTransactionTotal7jours+�� 5#      $%��Nb. de transaction (31 jours) :��6   $��./Fonts/#Roboto)�6>   $��14(�6[   $��2��6j   $
��Bold"�6w   $��Right=�6�   �� 5$      $��1��6   $��2��6$   $��./Fonts/#Roboto)�61   $��12(�6N   $
��Left=�6\   ��6w   �� *NbTransaction31jours+�� 5%      $#��$ en transaction (31 jours) :��6   $��./Fonts/#Roboto)�6<   $��14(�6Y   $��3��6h   $
��Bold"�6u   $��Right=�6�   �� 5&      $��1��6   $��3��6$   $��./Fonts/#Roboto)�61   $��12(�6N   $
��Left=�6\   ��6w   �� *NbTransactionTotal31jours+5'      � 5(   
   $��2��6    5)      �� 5*      $��1* �6    �� 5+      $��1* �6    �� 5,      $��1* �6    �� 5-      $��1* �6    �� 5.      $��1* �6     50      �� 51      $��1* �6#   �� 52      $��1* �6#   .+�56      �� $��Total��6   $��./#Roboto Regular)�6$   $��24(�6C   $��0��6R   $
��Bold"�6_   $��2��6q   $��Center=�6�   �� 57      $��1��6   $��1��6$   $��./#Roboto Regular)�61   $��12(�6P   $
��Left=�6^   ��6y   �� *	NbEmploye+�� 58      $��Nombre d'employés :��6   $��./#Roboto Regular)�62   $��14(�6Q   $��1��6`   $
��Bold"�6m   $��Right=�6   �� 59      $��1��6   $��2��6$   $��./#Roboto Regular)�61   $��12(�6P   $
��Left=�6^   ��6y   �� *
NbUsager+�� 5:      $��Nombre d'usagés :��6   $��./#Roboto Regular)�60   $��14(�6O   $��2��6^   $
��Bold"�6k   $��Right=�6}   �� 5;      $��1��6   $��3��6$   $��./#Roboto Regular)�61   $��12(�6P   $
��Left=�6^   ��6y   �� *NbAbonnement+�� 5<      $"��Nombre d'abonnements actif :��6   $��./#Roboto Regular)�6;   $��14(�6Z   $��3��6i   $
��Bold"�6v   $��Right=�6�   �� 5=      $��1��6   $��4��6$   $��./#Roboto Regular)�61   $��12(�6P   $
��Left=�6^   ��6y   �� *
TotalCarte+ �� StringFormat$ {0:#.##}���� 5>      $��Actifs sur les Cartes :��6   $��./#Roboto Regular)�66   $��14(�6U   $��4��6d   $
��Bold"�6q   $��Right=�6�   5@      5C      5D      