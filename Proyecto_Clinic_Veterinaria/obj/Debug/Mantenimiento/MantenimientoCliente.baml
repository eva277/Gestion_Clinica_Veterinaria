   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento)Proyecto_Clinic_Veterinaria.Mantenimiento  5      D    >Proyecto_Clinic_Veterinaria.Mantenimiento.MantenimientoCliente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento     5      $	��650��5      $	��600��6+   $
��Auto=�68     � 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%w  '��       �� 5	   
   " ��6   .�5
      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5   "   �� .+�5   &   �� $ errorControl��6@   5   #   5      �� 5      
���  ��$	��8.5(�6|   $
��Auto��6�   ��6(   �� *AdornedElement.ToolTip+$ errorControl��6�   5      5      5       5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5      5      5       .��5!      � $��10,10,10,10q�6   .+�5"   
   �� -   5         ��Name$ label7_Copy1��5"      $��Busqueda��6&   $
��Left=�69   $��
105,19,0,0q�6T   $	��Top=�6h   �� 5#   
   -   5         ��Name$ SearchTextbox��5#      $
��Left=�6)   $��26��6D   $��
184,19,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��190��6�   �� 5$   
   -   5         ��Name$ SearchcomboBox��5$      $
��Left=�6+   $��
395,19,0,0q�6F   $	��Top=�6Z   $	��111��6r   $��26��6~    �� SelectedItem$ SearchBy��6�   .@�5%      �� $��Nombre��6   �� 5&      $��	Apellidos��6   5'      �� 5(   
   -   5        $��SearchButton��5(      $��26��6%   $��26��60   $��518,19,86,535q�6<   ��5)      �� 5*       �� ImageSource$? 9/Proyecto_Clinic_Veterinaria;component/Icon/Search-48.png��6   5,      �� 5-   
   -   5        $ label0��5-      $��
Cliente Id��6    $
��Left=�65   $��	74,84,0,0q�6P   $	��Top=�6c   �� 5.   
   -   5        $ label1��5.      $��Nombre��6    $
��Left=�61   $��
79,124,0,0q�6L   $	��Top=�6`   �� 5/   
   -   5        $ label2��5/      $��	Apellidos��6    $
��Left=�64   $��291,124,0,0q�6O   $	��Top=�6d   �� 50   
   -   5        $ label6��50      $��	Direccion��6    $
��Left=�64   $��
73,172,0,0q�6O   $	��Top=�6c   �� 51   
   -	   5        $ label2_Copy��51      $��Codigo Postal��6%   $
��Left=�6=   $��369,172,0,0q�6X   $	��Top=�6m   �� 52   
   -
   5        $ label6_Copy��52      $��Telefono��6%   $
��Left=�68   $��
79,217,0,0q�6S   $	��Top=�6g   �� 53   
   -   5        $ label3��53      $��Email��6    $
��Left=�60   $��312,217,0,0q�6K   $	��Top=�6`   $��42��6x   �� 55   
   -   5        $ 	IdtextBox��55       �� 
IsReadOnly . $
��Left=�6�   $��26��6  $��
153,84,0,0q�6  $
 Wrap=�6"  $	��Top=�66  $��38��6N  ��6%   �� *SelectedItem.ClienteId+$ ClientesdataGrid�� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . 6N  �� 56   
   -   5        $ NombretextBox��56      $
��Left=�6�   $��26��6�   $��153,124,0,0q�6�   $
 Wrap=�6  $	��Top=�6&  $	��127��6>  ��6)   �� *SelectedItem.Nombre+$ ClientesdataGrid��$ OneWay=�$ PropertyChanged=� .  . 6>  �� 57   
   -   5        $ ApellidostextBox��57      $
��Left=�6�   $��26��6�   $��380,124,0,0q�6  $
 Wrap=�6  $	��Top=�6,  $	��192��6D  ��6,   �� *SelectedItem.Apellidos+$ ClientesdataGrid��$ OneWay=�$ PropertyChanged=� .  . 6D  �� 58   
   -   5        $ DirecciontextBox_Copy5��58      $
��Left=�6�   $��26��6�   $��153,172,0,0q�6	  $
 Wrap=�6  $	��Top=�62  $	��201��6J  ��62   �� *SelectedItem.Direccion+$ ClientesdataGrid��$ OneWay=�$ PropertyChanged=� .  . 6J  �� 59   
   -   5        $ CodigoPostalTextbox��59      $
��Left=�6�   $��26��6�   $��482,172,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��90��6  ��6/   �� *CodigoPostal+$ PropertyChanged=� .  . 6  �� 5:   
   -   5        $ TelefonoTextbox��5:      $
��Left=�6�   $��26��6�   $��153,217,0,0q�6  $
 Wrap=�6  $	��Top=�6*  $	��127��6B  ��6+   �� *SelectedItem.Telefono+$ ClientesdataGrid��$ OneWay=�$ PropertyChanged=� .  . 6B  �� 5;   
   -   5        $ EmailtextBox��5;      $
��Left=�6�   $��23��6�   $��380,220,0,0q�6�   $
 Wrap=�6  $	��Top=�6$  $	��192��6<  ��6(   �� *SelectedItem.Email+$ ClientesdataGrid��$ OneWay=�$ PropertyChanged=� .  . 6<  &   System.Windows.Controls.DataGrid  5=   
   -   5          Name$ ClientesdataGrid��5=   %   $��5,5,5,5q�6   $
��Left=�6?   $��
10,337,0,0q�6Z   $	��Top=�6n   $	��233��6�   $	��610��6�      AutoGenerateColumns .  ��6�   ��    Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Cliente Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	ClienteId+  5@      $ Nombre��6%    65   �� *Nombre+  5A      $ 	Apellidos��6%    68   �� *	Apellidos+  5B      $ 	Direccion��6%    68   �� *	Direccion+  5C      $ Telefono��6%    67   �� *
Telefono+5  /System.Windows.Controls.DataGridHyperlinkColumn  5D      $ Email��6*    69   �� *Email+5F      �� 5G   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��73��6I   $��39��6T   $��471,281,0,260q�6`   .+�5H      �� -   5         ��Name$ UpdateButton1��5H      $��36��6,   $��36��67   ��5I      �� 5J      $> 8/Proyecto_Clinic_Veterinaria;component/Icons/Edit-48.png��6!   5L      �� 5M      -   5        $ DeleteButton1��5M      $��36��6,   $��36��67   ��5N      �� 5O      $@ :/Proyecto_Clinic_Veterinaria;component/Icons/Delete-48.png��6!   5Q      5R      �� 5T   
   -   5         ��Name$ gridSplitter��5T      $
��Left=�6-   $	��521��6H   $��319,-193,0,0q�6U   $	��Top=�6k    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6�   z�5U      V� 5V      .~�5W      �� �� 5X      �� 5Y       �� Angle$ 90Q�6&   T� 5Z      5[      5]      �� 5^   
   -   5        $ gridSplitter_Copy��5^      $
��Left=�62   $	��523��6M   $��
315,11,0,0q�6Z   $	��Top=�6n   $ 0.5,0.5&�6�   $��2��6�   z�5_      V� 5`      .~�5a      �� �� 5b      �� 5c      $ 90Q�6&   T� 5d      5e      5g      �� 5h   
   -   5        $ 
Listbutton��5h      $��Listar Clientes��6%   $
��Left=�6?   $��
66,284,0,0q�6Z   $	��Top=�6n   $	��100��6�   $��36��6�   6�   5i      5j      