   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento)Proyecto_Clinic_Veterinaria.Mantenimiento  5      S    MProyecto_Clinic_Veterinaria.Mantenimiento.MantenimientoRegistroHotel_Hospital   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento     5      $	��600��5      $	��650��6,   .��5      � $
��Auto��6   $��Stretch=�6   $��Stretch=�65   $
��Auto��6S   .+�5	   
   �� -   5          ��Name$  label7_Copy1��5	      $��Busqueda��6&   $
��Left=�69   $��	161,7,0,0q�6T   $	��Top=�6g   $��80��6   �� 5
   
   -   5         ��Name$ SearchTextbox��5
      $
��Left=�6)   $��26��6D   $��	246,8,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��119��6�   �� 5   
   -   5         ��Name$ SearchcomboBox��5      $
��Left=�6+   $��	369,8,0,0q�6F   $	��Top=�6Y   $��99��6q   $��26��6|    �� SelectedItem$ SearchBy��6�   .@�5      �� $��Raza Mascota��6   5      �� 5   
   -   5         ��Name$ SearchButton��5      $��24��6'   $��24��63   $��473,10,153,0q�6>   $	��Top=�6o   ��5      �� 5       �� ImageSource$? 9/Proyecto_Clinic_Veterinaria;component/Icon/Search-48.png��6   5      �� 5   
   -   5        $  label1_Copy��5      $��Fecha de Salida��6%   $
��Left=�6?   $��204,161,0,0q�6Z   $	��Top=�6o   �� 5   
   -   5        $  label��5      $��
Disponible��6   $
��Left=�64   $��230,318,0,0q�6O   $	��Top=�6d   �� 5   
   -   5        $  label2��5      $��Mascota��6    $
��Left=�62   $��241,201,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $  label2_Copy��5      $��Jaula��6%   $
��Left=�65   $��260,242,0,0q�6P   $	��Top=�6e   �� 5   
   -	   5        $  label2_Copy1��5      $��Usuario��6&   $
��Left=�68   $��246,283,0,0q�6S   $	��Top=�6h   �� 5   
   -
   5        $  label1��5      $��Fecha de Ingreso��6    $
��Left=�6;   $��196,119,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $  labeldf��5      $��Id Registro��6!   $
��Left=�67   $��
229,72,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ 	idtextbox��5       �� 
IsReadOnly . $
��Left=�6�   $��26��6  $��
323,73,0,0q�6  $
 Wrap=�6,  $	��Top=�6@  $��34��6X  ��6%   �� *'%SelectedItem.RegistroHotel_HospitalId+ �� ElementName$ 
HHDatagrid��	 �� Mode$	 OneWay=�
 �� NotifyOnValidationError
 .  �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . 6X  (  "System.Windows.Controls.DatePicker  5   
   -   5        $��IngresoDatePicker��5      $
��Left=�6.   $��323,122,0,0q�6I   $	��Top=�6^   $	��137��6v   6�     5   
   -   5        $��RegresoDatePicker��5      $
��Left=�6.   $��323,162,0,0q�6I   $	��Top=�6^   $	��137��6v   6�   �� 5   
   -   5         ��Name$ DisponiblecheckBox��5      $
��Left=�6/   $��323,327,0,0q�6J   $	��Top=�6_   $��18��6w   �� 5   
   -   5        $ MascotacomboBox��5      $
��Left=�6,   $��323,206,0,0q�6G   $	��Top=�6\   $	��137��6t   ��5      �� 5       .R�5!      �� ��5"      `� 5#       �� StringFormat$ 	{0} - {1}��6+   .1�5$   "   ��  �� Path$ Nombre�6*   �� 5%   "   $
 Raza�6*   5&      5(      5)      5+      �� 5,   
   -   5        $ JaulacomboBox��5,      $
��Left=�6*   $��323,247,0,0q�6E   $	��Top=�6Z   $	��137��6r   ��5-      �� 5.      .R�5/      �� ��50      `� 51      $ 	{0} - {1}��6+   .1�52   "   �� $ 	TipoJaula�6*   �� 53   "   $ Medida�6*   54      56      57      59      �� 5:   
   -   5        $ UsuaruicomboBox��5:      $
��Left=�6,   $��323,288,0,0q�6G   $	��Top=�6\   $	��137��6t   6�   �� 5;   
   -   5        $ button��5;      $��Listar Regitros��6!   $
��Left=�6;   $	��Top=�6V   $��90��6n   $��30��6�   $��
19,379,0,0q�6�   �� 5<   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��545,377,0,0q�6I   $��36��6^   $	��Top=�6j   .+�5=      �� -   5        $ UpdateButton��5=      $��36��6,   $��36��67   ��5>      �� 5?      $> 8/Proyecto_Clinic_Veterinaria;component/Icons/Edit-48.png��6!   5A      �� 5B      -   5        $ DeleteButton��5B      $��36��6+   $��36��66   ��5C      �� 5D      $@ :/Proyecto_Clinic_Veterinaria;component/Icons/Delete-48.png��6!   5F      5G      &   System.Windows.Controls.DataGrid  5H   
   -   5          Name$ 
HHDatagrid��5H   &   $��5,5,5,5q�6   $
��Left=�6:   $��
10,422,0,0q�6U   $	��Top=�6i   $	��168��6�   $	��630��6�      AutoGenerateColumns .  ��6�   ��    Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ 
RegistroId��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *RegistroHotel_HospitalId+  5K      $ Ingreso��6%    66   �� *	Ingreso+  5L      $ Regreso��6%    66   �� *	Regreso+4  .System.Windows.Controls.DataGridCheckBoxColumn  5M      $ 
Disponible��6)    6=   �� *
Disponible+$	 OneWay=�  5N      $ Nombre Mascota��6%    6=   �� *Nombre+  5O      $ Raza Mascota��6%    6;   �� *Raza+5Q      �� 5R   
   -   5         ��Name$ gridSplitter1_Copy1��5R      $��2��64    J� RenderTransformOrigin$ 0.5,0.5&�6>   $��324,-428,0,0q�6^   $	��970��6t   $	��Top=�6�   $
��Left=�6�   z�5S      V� 5T      .~�5U      ��  �� ScaleY$ 0.629Q�6%    �� ScaleX$
 1.59Q�64   �� 5V      �� 5W       �� Angle$ 90Q�6&   T� 5X      5Y      5[      �� 5\   
   -   5        $ gridSplitter1_Copy��5\      $��2��63   $ 0.5,0.5&�6=   $��321,-1,0,-129q�6]   $	��730��6t   $	��Top=�6�   $
��Left=�6�   z�5]      V� 5^      .~�5_      �� $ 0.838Q�6%   $ 1.194Q�64   �� 5`      �� 5a      $ 90Q�6&   T� 5b      5c      5e      5f      5g      