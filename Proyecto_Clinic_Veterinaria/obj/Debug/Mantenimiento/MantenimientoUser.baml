   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento)Proyecto_Clinic_Veterinaria.Mantenimiento  5      A    ;Proyecto_Clinic_Veterinaria.Mantenimiento.MantenimientoUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento     5      $	��650��5      $	��655��6+   $
��Auto=�68     � 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%w  '��       �� 5	   
   " ��6   .�5
      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5   "   �� .+�5   &   �� $ errorControl��6@   5   #   5      �� 5      
���  ��$	��8.5(�6|   $
��Auto��6�   ��6(   �� *AdornedElement.ToolTip+$ errorControl��6�   5      5      5       5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5      5      5       .��5!      � .+�5"   
   �� -   5         ��Name$ label7_Copy1��5"      $��Busqueda��6&   $
��Left=�69   $��
129,10,0,0q�6T   $	��Top=�6h   �� 5#   
   -   5         ��Name$ SearchTextbox��5#      $
��Left=�6)   $��26��6D   $��
208,10,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��190��6�   �� 5$   
   -   5         ��Name$ SearchcomboBox��5$      $
��Left=�6+   $��
403,10,0,0q�6F   $	��Top=�6Z   $	��111��6r   $��26��6~    �� SelectedItem$ SearchBy��6�   .@�5%      �� $��Nombre��6   �� 5&      $��	Apellidos��6   �� 5'      $��Tipo de Usuario��6   5(      �� 5)   
   -   5         ��Name$ SearchButton��5)      $��26��6'   $��26��62   $��521,10,107,619q�6>   ��5*      �� 5+       �� ImageSource$? 9/Proyecto_Clinic_Veterinaria;component/Icon/Search-48.png��6   5-      �� 5/   
   -   5        $ label12��5/      $��
Id Usuario��6!   $
��Left=�66   $��	41,77,0,0q�6Q   $	��Top=�6d   �� 50   
   -   5        $ label1��50      $��Nombre��6    $
��Left=�61   $��
52,127,0,0q�6L   $	��Top=�6`   �� 51   
   -   5        $ label2��51      $��	Apellidos��6    $
��Left=�64   $��
46,186,0,0q�6O   $	��Top=�6c   �� 52   
   -   5        $ label3��52      $��	Direccion��6    $
��Left=�64   $��
370,77,0,0q�6O   $	��Top=�6c   �� 53   
   -	   5        $ label4��53      $��Codigo Postal��6    $
��Left=�68   $��347,127,0,0q�6S   $	��Top=�6h   �� 54   
   -
   5        $ label5��54      $��Telefono��6    $
��Left=�63   $��375,184,0,0q�6N   $	��Top=�6c   �� 55   
   -   5        $ label6��55      $��Email��6    $
��Left=�60   $��
67,233,0,0q�6K   $	��Top=�6_   �� 56   
   -   5        $ label7��56      $��Tipo de Usuario��6    $
��Left=�6:   $��336,232,0,0q�6U   $	��Top=�6j   �� 57   
   -   5        $ label8��57      $��NickName��6    $
��Left=�63   $��
41,279,0,0q�6N   $	��Top=�6b   �� 58   
   -   5        $ label9��58      $��Password��6    $
��Left=�63   $��
45,329,0,0q�6N   $	��Top=�6b   �� 59   
   -   5        $ label10��59      $��Pregunta Secreta��6!   $
��Left=�6<   $��330,281,0,0q�6W   $	��Top=�6l   �� 5:   
   -   5        $ label11��5:      $��Respuesta Secreta��6!   $
��Left=�6=   $��324,329,0,0q�6X   $	��Top=�6m   �� 5<   
   -   5        $ 	IdtextBox��5<       �� 
IsReadOnly . $
��Left=�6�   $��26��6�   $��
123,77,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��169��6�   ��67   �� *SelectedItem.UsuarioId+$ dataGrid�� �� Mode$ OneWay=�6�   �� 5=   
   -   5        $ NombretextBox��5=      $
��Left=�6�   $��26��6�   $��123,127,0,0q�6�   $
 Wrap=�6  $	��Top=�6  $	��169��67  ��6)   �� *SelectedItem.Nombre+$ dataGrid��$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 67  �� 5>   
   -   5        $ ApellidostextBox��5>      $
��Left=�6�   $��26��6�   $��122,184,0,0q�6�   $
 Wrap=�6  $	��Top=�6%  $	��169��6=  ��6,   �� *SelectedItem.Apellidos+$ dataGrid��$ OneWay=�$ PropertyChanged=� .  . 6=  �� 5?   
   -   5        $ EmailtextBox_Copy5��5?      $
��Left=�6�   $��26��6�   $��122,231,0,0q�6�   $
 Wrap=�6  $	��Top=�6#  $	��169��6;  ��6.   �� *SelectedItem.Email+$ dataGrid��$ OneWay=�$ PropertyChanged=� .  . 6;  �� 5@   
   -   5        $ NickNametextBox_Copy6��5@      $
��Left=�6�   $��26��6�   $��123,279,0,0q�6   $
 Wrap=�6  $	��Top=�6)  $	��169��6A  ��61   �� *SelectedItem.NickName+$ dataGrid��$ OneWay=�$ PropertyChanged=� .  . 6A  �� 5A   
   -   5        $ PasswordtextBox_Copy7��5A      $
��Left=�61   $��26��6L   $��123,329,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $	��169��6�   �� 5B   
   -   5        $ DirecciontextBox��5B      $
��Left=�6�   $��26��6�   $��
458,77,0,0q�6�   $
 Wrap=�6  $	��Top=�6%  $	��160��6=  ��6,   �� *SelectedItem.Direccion+$ dataGrid��$ OneWay=�$ PropertyChanged=� .  . 6=  �� 5C   
   -   5        $ CodPosttextBox_Copy3��5C      $
��Left=�6�   $��26��6�   $��458,127,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��160��6  ��60   �� *CodigoPostal+$ PropertyChanged=� .  . 6  �� 5D   
   -   5        $ TelefonotextBox_Copy4��5D      $
��Left=�6�   $��26��6�   $��458,184,0,0q�6   $
 Wrap=�6  $	��Top=�6)  $	��160��6A  ��61   �� *SelectedItem.Telefono+$ dataGrid��$ OneWay=�$ PropertyChanged=� .  . 6A  �� 5E   
   -   5        $ TipoUsucomboBox��5E      $
��Left=�6,   $��458,231,0,0q�6G   $	��Top=�6\   $	��160��6t   $��26��6�    �� Text$ Elige Tipo de usuario��6�   .@�5F      �� -   5         ��Name$ MedicoComboBox��5F      .��63   Medico6;   �� 5G      -   5        $ PeluComboBox��5G      .��61   
Peluqueria6=   �� 5H      -   5        $ AdminComboBox��5H      .��62   Administrador6A   5I      �� 5J   
   -   5        $# PreguntaSecrretatextBox_Copy8��5J      $
��Left=�6�   $��26��6�   $��458,279,0,0q�6�   $
 Wrap=�6�   $	��Top=�6	  $	��160��6!  ��69   �� *PreguntaSecreta+$ PropertyChanged=� .  . 6!  �� 5K   
   -   5        $" RespuestaSecrettextBox_Copy9��5K      $
��Left=�6�   $��26��6�   $��458,329,0,0q�6�   $
 Wrap=�6�   $	��Top=�6	  $	��160��6!  ��68   �� *RespuestaSecreta+$ PropertyChanged=� .  . 6!  &   System.Windows.Controls.DataGrid  5L   
   -    5          Name$ dataGrid��5L      $
��Left=�6%   $��
10,429,0,0q�6@   $	��Top=�6T   $	��216��6l   $	��630��6y   $��5,5,5,5q�6�      AutoGenerateColumns .  ��6�   ��    Columns 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn   Header$ 	UsuarioId��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	UsuarioId+  5O      $ Nombre��6%    65   �� *Nombre+  5P      $ 	Apellidos��6%    68   �� *	Apellidos+  5Q      $ Email��6%    64   �� *Email+  5R      $ NickName��6%    67   �� *
NickName+  5S      $ 	Direccion��6%    68   �� *	Direccion+  5T      $ Telefono��6%    67   �� *
Telefono+  5U      $ Email��6%    64   �� *Email+5W      �� 5X   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��73��6I   $��519,386,0,230q�6T   .+�5Y      �� -!   5        $ UpdateButton��5Y      $��36��6+   $��0,2,0,1q�6Q   ��5Z      �� 5[      $> 8/Proyecto_Clinic_Veterinaria;component/Icons/Edit-48.png��6!   5]      �� 5^      -"   5        $ DeleteButton��5^      $��36��6+   $��36��66   $��0,2,0,0q�6]   $	��Top=�6n   ��5_      �� 5`      $@ :/Proyecto_Clinic_Veterinaria;component/Icons/Delete-48.png��6!   5b      5c      �� 5d   
   -#   5        $ button��5d      $��Listar Usuarios��6!   $
��Left=�6;   $	��Top=�6V   $	��101��6n   $��39��6�   $��
41,385,0,0q�6�   �� 5e   
   -$   5         ��Name$ gridSplitter1_Copy��5e      $��4��63     J� RenderTransformOrigin$  0.5,0.5&�6=   $��0,68,318,-19q�6]   z�5f      V� 5g      .~�5h      �� �� 5i      �� 5j      ! �� Angle$! 90Q�6&   T� 5k      5l      5n      �� 5o   
   -%   5        $ gridSplitter1_Copy1��5o      $��4��64   $  0.5,0.5&�6>   $��0,-240,326,301q�6^   z�5p      V� 5q      .~�5r      �� �� 5s      �� 5t      $! 90Q�6&   T� 5u      5v      5x      5z      5{      