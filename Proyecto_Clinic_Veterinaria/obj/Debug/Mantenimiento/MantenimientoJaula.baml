   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento)Proyecto_Clinic_Veterinaria.Mantenimiento  5      B    <Proyecto_Clinic_Veterinaria.Mantenimiento.MantenimientoJaula   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento     5      $	��650��5      $	��550��6+     � 	Resources  5       �� 
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
��Left=�69   $	��Top=�6T   $��
120,13,0,0q�6l   $��83��6�   �� 5#   
   -   5        $ label3��5#      $��Ancho��6    $
��Left=�60   $��281,174,0,0q�6K   $	��Top=�6`   $��60��6x   �� 5$   
   -   5        $ label4��5$      $��Fondo��6    $
��Left=�60   $��387,175,0,0q�6K   $	��Top=�6`   $��61��6x   �� 5%   
   -   5        $ label5��5%      $��Usuario��6    $
��Left=�62   $��208,253,0,0q�6M   $	��Top=�6b   �� 5&   
   -   5        $ label1��5&      $��Ocupada��6    $
��Left=�62   $��200,214,0,0q�6M   $	��Top=�6b   �� 5'   
   -   5        $ label2��5'      $
��Alto��6    $
��Left=�6/   $��200,174,0,0q�6J   $	��Top=�6_   �� 5(   
   -   5        $ label��5(      $��
Tipo Jaula��6   $
��Left=�64   $��196,124,0,0q�6O   $	��Top=�6d   �� 5)   
   -   5        $ 
label_Copy��5)      $��Id Jaula��6$   $
��Left=�67   $��
208,85,0,0q�6R   $	��Top=�6f   �� 5*   
   -	   5         ��Name$ SearchTextbox��5*      $
��Left=�6)   $��30��6D    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��132��6|   $��
208,10,0,0q�6�   �� 5+   
   -
   5         ��Name$ SearchcomboBox��5+      $
��Left=�6+   $	��Top=�6F   $	��119��6^   $��30��6j    �� SelectedItem$ SearchBy��6v   $��
348,10,0,0q�6�   .@�5,      �� $
��Tipo��6   �� 5-      $��Disponibilidad��6   5.      �� 5/   
   -   5         ��Name$ SearchButton��5/      $��472,10,148,510q�6B   $��30��6Z   $��30��6e   ��50      �� 51       �� ImageSource$? 9/Proyecto_Clinic_Veterinaria;component/Icon/Search-48.png��6   53      �� 54   
   -   5        $ 	idtextBox��54      $
��Left=�6�   $��23��6�   $��
286,89,0,0q�6�   $
 Wrap=�6  $	��Top=�6   $	��137��68   �� 
IsReadOnly . ��6%   �� *SelectedItem.JaulaId+$ JaulasdataGrid�� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . 6D  �� 55   
   -   5        $ TipoJaulacomboBox��55      $
��Left=�6.   $��286,129,0,0q�6I   $	��Top=�6^   $	��137��6v   .@�56      �� $��Hotel��6   �� 57      $��Hospital��6   58      �� 59   
   -   5        $ AltotextBox��59      $
��Left=�6�   $��23��6�   $��242,175,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��34��6  ��6'   �� *Alto+$ PropertyChanged=� .  . 6  �� 5:   
   -   5        $ AnchotextBox_Copy��5:      $
��Left=�6�   $��23��6�   $��341,175,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��39��6  ��6-   �� *Ancho+$ PropertyChanged=� .  . 6  �� 5;   
   -   5        $ FondotextBox_Copy1��5;      $
��Left=�6�   $��23��6�   $��453,175,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��34��6  ��6.   �� *Fondo+$ PropertyChanged=� .  . 6  �� 5<   
   -   5         ��Name$ OcupadacheckBox��5<      $
��Left=�6,   $��286,221,0,0q�6G   $	��Top=�6\   �� 5=   
   -   5        $ UserComboBox��5=      $
��Left=�6)   $��286,254,0,0q�6D   $	��Top=�6Y   $	��137��6q   6}   &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ JaulasdataGrid��5>   &   $��5,5,5,5q�6   $
��Auto=�6>   $��Visible=�6p   $��Stretch=�6�   $��10,360,10,0q�6�   $	��Top=�6�   $	��180��6�   $
��Auto��6�      AutoGenerateColumns .  ��6  ��    Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ Jaula Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	JaulaId+  5A      $ 
Tipo Jaula��6%    69   �� *	TipoJaula+  5B      $ Medidas��6%    66   �� *Medida+4  .System.Windows.Controls.DataGridCheckBoxColumn  5C      $ Ocupada��6)    6:   �� *	Ocupada+$ OneWay=�5E      �� 5F   
   -   5        $ 
Listbutton��5F      $��Listar Jaulas��6%   $��31,310,447,0q�6>   $��39��6m   $	��Top=�6y   �� 5G   
    �� Orientation$ 
Horizontal=�6   $��536,309,0,0q�6.   $
��Left=�6C   $��72��6^   $��40��6i   $	��Top=�6u   .+�5H      �� -   5        $ UpdateButton��5H      $��36��6+   $��0,2,0,1q�6Q   ��5I      �� 5J      $> 8/Proyecto_Clinic_Veterinaria;component/Icons/Edit-48.png��6!   5L      �� 5M      -   5        $ DeleteButton��5M      $��36��6+   $��0,2,0,1q�6Q   ��5N      �� 5O      $@ :/Proyecto_Clinic_Veterinaria;component/Icons/Delete-48.png��6!   5Q      5R      �� 5S   
   -   5         ��Name$ gridSplitter1_Copy��5S       J� RenderTransformOrigin$ 0.5,0.5&�63   $��312,-14,0,-55q�6S   $
��Left=�6j   $��4��6�   $	��619��6�   $	��Top=�6�   z�5T      V� 5U      .~�5V      �� �� 5W      �� 5X        �� Angle$  90Q�6&   T� 5Y      5Z      5\      �� 5]   
   -   5        $ gridSplitter1��5]      $ 0.5,0.5&�6.   $��319,-330,0,0q�6N   $
��Left=�6d   $��3��6   $	��806��6�   $	��Top=�6�   z�5^      V� 5_      .~�5`      �� ! �� ScaleY$
! 0.76Q�6%   " �� ScaleX$" 1.316Q�63   �� 5a      �� 5b      $  90Q�6&   T� 5c      5d      5f      5h      5i      