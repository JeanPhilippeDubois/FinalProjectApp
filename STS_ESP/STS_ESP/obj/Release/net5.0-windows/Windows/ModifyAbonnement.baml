   M S B A M L   `   `   `  ���� B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:STS_ESP.WindowsSTS_ESP.Windows  &     STS_ESP.Windows.ModifyAbonnement   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  )localclr-namespace:STS_ESP.Windows  $	��450��$	��800��  � Title$'  !Modifier l'abonnement d'un usager��.��� 
�������.+��� $��1q�
�������$��75q�._�� $��15q� � RowDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* � � 	Resources ��%    .+��� $ ��Modifier Abonnement Usager��$��0��$��./#Roboto Regular)�$��24(�$��Center=�$
��Bold"��� $?��9Effectuez les changements sur l'abonnement de l'usager...��$��1��$��./#Roboto Regular)�$��12(�$��Center=�� $��3�� � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* �.+��� $��Abonnement :��$��0��$��Right=�$��./Fonts/#Roboto Regular)�$��16(�$��Center=��� $��1��$��./Fonts/#Roboto Regular)�$��16(�$��Center=� �� 
IsReadOnly$
 True������ *	AboActuel+�� $��3��$��	25,0,25,0q����� *Button_Supprimer_Click+.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$
��Left=�$��25��$��25��   Kind$ Delete=��� $��Center=�$
��Left=�
�������.��	Supprimer� $��5�� �� $��1* ��� $��1* ��� $��1* �.+��� $��Nouvel Abonnement :��$��0��$��Right=�$��./Fonts/#Roboto Regular)�$��16(�$��Center=��� $��1��$��5��)  #MaterialDesignThemes.Wpf.HintAssist   
IsFloating$
 true��   Hint$ 
Abonnement��	 �� SelectedIndex$	 0��
 �� SelectedValue
 �� *AboNew+.@��� $��Aucun���� $��
Journalier���� $��Hebdomadaire���� $��Bihebdomadaire���� $��Mensuel���� $��Trimestriel���� $��Annuel���� $��3��$��	25,0,25,0q����� *Button_Ajouter_Click+.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$��25��$��25��$ Delete=��� $��Center=�$
��Left=�
�������.��	Ajouter� $��8�� �� $��1* �.+��� -   $��1��$��150,0,150,0q�.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$��25��$��25��$ 	ArrowBack=��� $��Center=�$
��Left=�
�������.��Retour�� $��9��$��./Fonts/#Roboto Regular)�$��10(�$��Center=�$
��Bold"����	#DDF70000���� *State+