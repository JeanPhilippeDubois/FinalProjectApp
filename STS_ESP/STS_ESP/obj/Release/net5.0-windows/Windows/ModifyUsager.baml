   M S B A M L   `   `   `  ���� B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:STS_ESP.WindowsSTS_ESP.Windows  "    STS_ESP.Windows.ModifyUsager   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:STS_ESP.Windows     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��450��$	��800��  � Title$  Modifier un usager��.��� 
�������.+��� $��1q�
�������$��75q�._�� $��15q� � RowDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* � � 	Resources ��%    .+��� $��Modifier un usager��$��0��$��./#Roboto Regular)�$��24(�$��Center=�$
��Bold"��� $/��)Modifiez les informations de l'usager ...��$��1��$��./#Roboto Regular)�$��12(�$��Center=��� $��2��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nom complet��   
IsFloating$
 True�� � Cursor$ IBeam��$��	25,0,25,0q�.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True������ *
NomComplet+�� $��3��$ Numéro de téléphone��$
 True��$ IBeam��$��	25,0,25,0q�$
 True������ *NoTelephone+�� $��4��$ Addresse Couriel��$
 True��$ IBeam��$��	25,0,25,0q�$
 True������ *
Courriel+� $��7�� � ColumnDefinitions �� $��1* ��� $��1* �.+��� $��0��$��	50,0,50,0q����� *Button_ModifierUsager_Click+.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$
��Left=�$��25��$��25��	   Kind$	 AccountSync=��� $��Center=�$
��Left=�
�������.��
Modifier�� -   $��1��$��	50,0,50,0q�.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$��25��$��25��$	 	ArrowBack=��� $��Center=�$
��Left=�
�������.��Retour�� $��9��$��./Fonts/#Roboto Regular)�$��10(�$��Center=�$
��Bold"����	#DDF70000���� *State+