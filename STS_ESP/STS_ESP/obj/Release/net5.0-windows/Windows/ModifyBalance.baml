   M S B A M L   `   `   `  ���� B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:STS_ESP.WindowsSTS_ESP.Windows  #    STS_ESP.Windows.ModifyBalance   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:STS_ESP.Windows     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��500��$	��800��  � Title$%  Modifier la balance d'un usager��.��� 
�������.+��� $��1q�
�������$��75q�._�� $��15q� � RowDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* � � 	Resources ��%    .+��� $%��Modifier la balance d'un usager��$��0��$��./#Roboto Regular)�$��24(�$��Center=�$
��Bold"��� $1��+Effectuez les changements sur la balance...��$��1��$��./#Roboto Regular)�$��12(�$��Center=�� $��3�� � ColumnDefinitions �� $��1* ��� $��1* �.+��� $��Balance actuelle :��$��0��$��Right=�$��./Fonts/#Roboto Regular)�$��16(�$��Center=��� $��1��$��./Fonts/#Roboto Regular)�$��16(�$��Center=�$��	0,0,150,0q� �� 
IsReadOnly$
 True������ *BalanceActuel+� $��4�� �� $��1* ��� $��1* �.+��� $��Nouvelle balance :��$��0��$��Right=�$��./Fonts/#Roboto Regular)�$��16(�$��Center=��� $��1��$��./Fonts/#Roboto Regular)�$��16(�$��Center=�$��	0,0,150,0q� � Cursor$ IBeam��.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True������ *
BalanceNew+� $��7�� �� $��1* ��� $��1* �.+��� $��0��$��	50,0,50,0q����� *Button_Modifier_Click+.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$
��Left=�$��25��$��25��   Kind$ 
AccountAdd=��� $��Center=�$
��Left=�
�������.��
Modifier�� -   $��1��$��	50,0,50,0q�.���� $ 
Horizontal=�.+�  $��Center=�$
��Left=�$��25��$��25��$ 	ArrowBack=��� $��Center=�$
��Left=�
�������.��Retour�� $��8��$��./Fonts/#Roboto Regular)�$��10(�$��Center=�$
��Bold"����	#DDF70000���� *State+