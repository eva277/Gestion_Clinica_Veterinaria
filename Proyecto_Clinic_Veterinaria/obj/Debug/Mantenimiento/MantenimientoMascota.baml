   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento)Proyecto_Clinic_Veterinaria.Mantenimiento  5      D    >Proyecto_Clinic_Veterinaria.Mantenimiento.MantenimientoMascota   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento     5      $	��630��5      $��612.777��6+     � 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%w  '��       �� 5	   
   " ��6   .�5
      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5   "   �� .+�5   &   �� $ errorControl��6@   5   #   5      �� 5      
���  ��$	��8.5(�6|   $
��Auto��6�   ��6(   �� *AdornedElement.ToolTip+$ errorControl��6�   5      5      5       5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5      5      5       .��5!      �� ��. ?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid$   SelectiveScrollingOrientation$
 Both=�63   .+�5"   
   �� -   5         ��Name$ label7_Copy1��5"      $��Busqueda��6&   $
��Left=�69   $	��Top=�6T    �� Left$	 126��6l   
 �� Top$ 20��6~   �� 5#   
   -   5         ��Name$ SearchTextbox��5#      $
��Left=�6)   $��26��6D    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��190��6|   $	 205��6�   $ 20��6�   �� 5$   
   -   5         ��Name$ SearchcomboBox��5$      $
��Left=�6+   $	��Top=�6F   $	��111��6^   $��26��6j    �� SelectedItem$ SearchBy��6v   $	 400��6�   $ 20��6�   .@�5%      �� $��Especie��6   �� 5&      $
��Raza��6   �� 5'      $
��Sexo��6   5(      �� 5)   
   -   5         ��Name$ SearchButton��5)      $��26��6'   $��26��62   $	 518��6Y   $ 20��6k   ��5*      �� 5+       �� ImageSource$? 9/Proyecto_Clinic_Veterinaria;component/Icon/Search-48.png��6   5-      �� 5/   
   -   5        $ label��5/      $��
Mascota Id��6   $
��Left=�64   $	��Top=�6O   $ 64��6g   $ 83��6x   �� 50   
   -   5        $ 	IdtextBox��50      $
��Left=�6x    �� 
IsReadOnly . $��24��6�   $
 Wrap=�6�   $	��Top=�6�   $	��177��6�   $	 146��6�   $ 80��6�   ��6%   �� $
 SelectedItem.MascotaId�$ PetsDataGrid�� �� Mode$ OneWay=�6�   �� 51   
   -   5        $ label1��51      $��Nombre��6    $
��Left=�61   $	��Top=�6L   $ 78��6d   $	 131��6u   �� 52   
   -   5        $ NombretextBox1��52      $
��Left=�6�   $��22��6�   $
 Wrap=�6  $	��Top=�6  $	��177��6-  $	 146��69  $	 128��6K  ��6*   �� $
 SelectedItem.Nombre�$ PetsDataGrid��$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6K  �� 53   
   -	   5        $ label2��53      $��Especie��6    $
��Left=�62   $	��Top=�6M   $ 82��6e   $	 168��6v   �� 54   
   -
   5        $ EspeciecomboBox��54      $
��Left=�6-   $	��Top=�6H   $	��177��6`   $	 146��6�   $	 168��6�   .@�55      �� -   5        $��CaninoComboBoxItem��55      $��Canino��65   �� 56      -   5        $��FelinoComboBoxItem��56      $��Felino��65   �� 57      -   5        $��ExoticoComboBoxItem��57      $��Exotico��66   58      �� 59   
   -   5        $ label3��59      $
��Raza��6    $
��Left=�6/   $	��Top=�6J   $ 98��6b   $	 210��6s   �� 5:   
   -   5        $ RazatextBox��5:      $
��Left=�6�   $��22��6�   $
 Wrap=�6�   $	��Top=�6  $	��177��6'  $	 146��63  $	 210��6E  ��6'   �� $
 SelectedItem.Raza�$ PetsDataGrid��$ OneWay=�$ PropertyChanged=� .  . 6E  �� 5;   
   -   5        $ label4��5;      $
��Sexo��6    $
��Left=�60   $	��Top=�6K   $ 98��6c   $	 257��6t   	� 5<   
   -   5         	�Name$ FemradioButton��5<      $��Hembra��6/   $
��Left=�6@   $	��Top=�6[    d� 	IsChecked$
 TrueY�6s   $	 146��6�   $	 260��6�   	� 5=   
   -   5        $ MaleradioButton��5=      $��Macho��60   $
��Left=�6@   $	��Top=�6[   $	 220��6s   $	 260��6�   �� 5>   
   -   5        $ label4_Copy��5>      $��Pelaje��6%   $
��Left=�66   $	��Top=�6Q   $ 92��6i   $	 299��6z   �� 5?   
   -   5        $ PelajetextBox3_Copy��5?      $
��Left=�6�   $��22��6�   $
 Wrap=�6�   $	��Top=�6�   $	��177��6  $	 146��6  $	 300��6%  ��60   �� *Pelaje+$ PropertyChanged=�$ OneWay=� .  . 6%  �� 5@   
   -   5        $ label4_Copy1��5@      $��
Nacimiento��6&   $
��Left=�6;   $	��Top=�6V   $	 328��6n   $	 190��6�   (  "System.Windows.Controls.DatePicker  5A   
   -   5        $��FechaNacimientoDatePicker��5A      $
��Left=�67   $	��Top=�6R   $	��178��6�   $	 413��6�   $	 192��6�   �� 5B   
   -   5        $ label4_Copy2��5B      $
��Foto��6&   $
��Left=�65   $	��Top=�6P   $	 362��6h   $	 228��6z   �� 5C   
   
���   �$��1q�6%   $
��Left=�69   $	��100��6T   $	��Top=�6a   $	��100��6y   $	 413��6�   $	 228��6�   ._�5D      �� -   5         ��Name$ image��5D      $��	-1,-1,1,1q�6#   5E      �� 5F   
   -   5        $ label5��5F      $��Activo��6    $
��Left=�61   $	��Top=�6L   $	 356��6d   $ 74��6v   �� 5G   
   -   5         ��Name$ ActivocheckBox��5G      $
��Left=�6,   $	��Top=�6G   $	 413��6_   $ 80��6q   �� 5H   
   -   5        $ label6��5H      $��Dueño��6    $
��Left=�60   $	��Top=�6K   $	 354��6c   $	 112��6u   �� 5I   
   -   5        $ OwnercomboBox��5I      $
��Left=�6+   $	��Top=�6F   $	��178��6^   $	 413��6�   $	 116��6�   �� 5J   
   -   5        $ label6_Copy��5J      $��Usuario��6%   $
��Left=�67   $	��Top=�6R   $	 348��6j   $	 156��6|   �� 5K   
   -   5        $ UsercomboBox��5K      $
��Left=�6*   $	��Top=�6E   $	��176��6]   $	 413��6�   $	 160��6�   �� 5L   
   -   5        $ LoadImgbutton��5L      $	��...��6)   $
��Left=�67   $	��Top=�6R   $��32��6j   $��22��6u   $	 518��6�   $	 304��6�   &   System.Windows.Controls.DataGrid  5M   
   -    5          Name$ PetsDataGrid��5M   %   $��5,5,5,5q�6   $	��200��6S   $	��Top=�6`   $ 10��6x   $	 403��6�   $	��608��6�      AutoGenerateColumns .  ��6;   ��     Columns  5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn!   Header$! 	MascotaId��6%   1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 68   �� *	MascotaId+  5P      $! Nombre��6%   " 65   �� *Nombre+  5Q      $! Especie��6%   " 66   �� *	Especie+  5R      $
! Raza��6%   " 63   �� *Raza+  5S      $
! Edad��6%   " 63   �� *Edad+  5T      $
! Sexo��6%   " 63   �� *Sexo+4  .System.Windows.Controls.DataGridTemplateColumn  5U      $
! Foto��6)   #   CellTemplate# 5V      �� 5W      .R�5X      �� $	��100��6<   $	��100��6H   $��UniformToFill=�6U   ��6$   �� *Foto+6U   5Y      5[        5\      $! Dueño��6%   " 64   �� *NombreCompleto+5^      �� 5_   
   -!   5        $ button��5_      $��Listar Mascotas��6!   $
��Left=�6;   $	��Top=�6V   $	��117��6n   $��39��6�   $ 46��6�   $	 359��6�   �� 5`   
   -"   5        $ ��Name$$ gridSplitter1��5`      $	��576��6.   $	 308��6;   $
 -228��6M   $��4��6_   % J� RenderTransformOrigin$% 0.5,0.5&�6i   z�5a      V� 5b      .~�5c      �� �� 5d      �� 5e      & �� Angle$& 90Q�6&   T� 5f      5g      5i      �� 5j   
   -#   5        $$ gridSplitter1_Copy��5j      $	��576��63   $	 315��6@   $ 64��6R   $��4��6b   $% 0.5,0.5&�6l   z�5k      V� 5l      .~�5m      �� �� 5n      �� 5o      $& 90Q�6&   T� 5p      5q      5s      �� 5t   
   ' �� Orientation$' 
Horizontal=�6   $
��Left=�6.   $��73��6I   $��40��6T   $	 518��6`   $	 360��6r   .+�5u      �� -$   5        $ UpdateButton��5u      $��36��6+   $��36��66   ��5v      �� 5w      $> 8/Proyecto_Clinic_Veterinaria;component/Icons/Edit-48.png��6!   5y      �� 5z      -%   5        $ DeleteButton��5z      $��36��6+   $��36��66   ��5{      �� 5|      $@ :/Proyecto_Clinic_Veterinaria;component/Icons/Delete-48.png��6!   5~      5      5�      5�      