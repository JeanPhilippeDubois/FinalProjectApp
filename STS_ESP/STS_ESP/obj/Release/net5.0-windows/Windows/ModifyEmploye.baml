   M S B A M L   `   `   `  ���� B  >STS_ESP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:STS_ESP.WindowsSTS_ESP.Windows  #    STS_ESP.Windows.ModifyEmploye   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:STS_ESP.Windows     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��650��$	��800��  � Title$  Modifier un employé��.��� 
�������.+��� $��1q�
�������$��50q�._�� $��15q� � RowDefinitions �� $��1* ��� $��0.75* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* � � 	Resources ��%    .+��� $��Modifiez un employé��$��0��$��./#Roboto Regular)�$��24(�$��Center=�$
��Bold"��� $M��GEntrez les informations du nouveau employé que vous voullez créer ...��$��1��$��./#Roboto Regular)�$��12(�$��Center=��� $��2��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nom complet��   
IsFloating$
 True�� � Cursor$ IBeam��$��	25,0,25,0q�.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True������ *
NomComplet+�� $��3��$ Nom d'utilisateur��$
 True��$ IBeam��$��	25,0,25,0q�$
 True������ *
Username+G� -   $��4�� G� 
CaretBrush �	#FF2199E8$ Mot de passe��$
 True��$��	25,0,25,0q�$
 True���� $��5��$ Numéro de téléphone��$
 True��$��	25,0,25,0q�$
 True������ *NoTelephone+�� $��6��$ Addresse Couriel��$
 True��$��	25,0,25,0q�$
 True������ *
Courriel+�� $��7��$
 true��$
 Role��$��	25,0,25,0q� �� Text �� *Role+.@��� $��Commis���� $��Administrateur���� $��8��$
 true��$ Statut Compte��$��	25,0,25,0q� �� *Statut+.@��� $��Actif���� $��Inactif��� $��10��	 � ColumnDefinitions	 �� $��1* ��� $��1* �.+��� $��0��$��	50,0,50,0q����� *Button_ModifierEmploye_Click+.���� 
 �� Orientation$
 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�$
��Left=�$��20��$��20��   Kind$ AccountSwitch=��� $��Center=�$
��Left=�
�������.��
Modifier�� -   $��1��$��	50,0,50,0q�.���� $
 
Horizontal=�.+�  $��Center=�$
��Left=�$��20��$��20��$ 	ArrowBack=��� $��Center=�$
��Left=�
�������.��Retour�� $��12��$��./Fonts/#Roboto Regular)�$��12(�$��Center=�$
��Bold"����	#DDF70000���� *State+