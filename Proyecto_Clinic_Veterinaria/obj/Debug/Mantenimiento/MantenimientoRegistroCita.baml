   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento)Proyecto_Clinic_Veterinaria.Mantenimiento  5      I    CProyecto_Clinic_Veterinaria.Mantenimiento.MantenimientoRegistroCita   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento     5      $��702.232��5      $	��650��60     � 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%w  '��       �� 5	   
   " ��6   .�5
      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5   "   �� .+�5   &   �� $ errorControl��6@   5   #   5      �� 5      
���  ��$	��8.5(�6|   $
��Auto��6�   ��6(   �� *AdornedElement.ToolTip+$ errorControl��6�   5      5      5       5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5      5      5       .��5!      � .+�5"   
   �� -   5         ��Name$ 
label_Copy��5"      $��Cita Id��6$   $
��Left=�66   $��
132,96,0,0q�6Q   $	��Top=�6e   �� 5#   
   -   5        $ label��5#      $��Resumen Cita��6   $
��Left=�66   $��
236,97,0,0q�6Q   $	��Top=�6e   �� 5$   
   -   5        $ label1��5$      $��Fecha��6    $
��Left=�60   $��222,147,0,0q�6K   $	��Top=�6`   �� 5%   
   -   5        $ label2��5%      $��Observaciones��6    $
��Left=�68   $��148,194,0,0q�6S   $	��Top=�6h   �� 5&   
   -   5        $ label3��5&      $��Usuario��6    $
��Left=�62   $��222,288,0,0q�6M   $	��Top=�6b   �� 5'   
   -   5        $ label3_Copy��5'      $��	Tipo Cita��6%   $
��Left=�69   $��215,330,0,0q�6T   $	��Top=�6i   �� 5(   
   -   5        $ label7_Copy1��5(      $��Busqueda��6&   $
��Left=�69   $	��Top=�6T   $��
148,13,0,0q�6l   $��91��6�   �� 5)   
   -   5        $ label3_Copy1��5)      $��Cliente��6&   $
��Left=�68   $��225,374,0,0q�6S   $	��Top=�6h   �� 5*   
   -	   5        $ label3_Copy2��5*      $��Mascota��6&   $
��Left=�68   $��215,420,0,0q�6S   $	��Top=�6h   �� 5+   
   -
   5         ��Name$ SearchTextbox��5+      $
��Left=�6)   $��30��6D    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��122��6|   $��
244,10,0,0q�6�   �� 5,   
   -   5         ��Name$ SearchcomboBox��5,      $
��Left=�6+   $	��Top=�6F   $	��112��6^   $��30��6j    �� SelectedItem$ SearchBy��6v   $��
372,10,0,0q�6�   .@�5-      �� $��Resumen��6   �� 5.      $��Raza Paciente��6   �� 5/      $��Tipo de Cita��6   50      �� 51   
   -   5         ��Name$ SearchButton��51      $��
502,10,0,0q�6B   $��36��6V   $
��Left=�6b   $��36��6}   $	��Top=�6�   ��52      �� 53       �� ImageSource$? 9/Proyecto_Clinic_Veterinaria;component/Icon/Search-48.png��6   55      �� 56   
   -   5        $ 	idTextBox��56      $
��Left=�6�   $��24��6�   $��
186,97,0,0q�6  $
 Wrap=�6  $	��Top=�6)  $��27��6A  ��6%   �� *SelectedItem.RegistroCitaId+$ RegistroDatagrid�� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions . 6A  �� 57   
   -   5        $ ResumentextBox��57      $
��Left=�6�   $��24��6�   $��
340,99,0,0q�6�   $
 Wrap=�6  $	��Top=�6'  $	��183��6?  ��6*   �� *SelectedItem.Resumen+$ RegistroDatagrid��$ OneWay=�$ PropertyChanged=� .  . 6?  (  "System.Windows.Controls.DatePicker  58   
   -   5        $��	FechaCita��58      $
��Left=�6�   $��277,148,0,0q�6�   $	��Top=�6�   $	��183��6�      Text 6&   �� *CodigoPostal+$ PropertyChanged=� .  �� NotifyOnValidationError . 6�   �� 59   
   -   5        $ ObservacionestextBox��59      $
��Left=�6�   $��68��6�   $��262,194,0,0q�6  $
 Wrap=�6   $	��Top=�64  $	��240��6L  ��60   �� *SelectedItem.Observaciones+$ RegistroDatagrid��$ OneWay=�$ PropertyChanged=� .  . 6L  �� 5:   
   -   5        $ UsuariocomboBox��5:      $
��Left=�6,   $��284,284,0,0q�6G   $	��Top=�6\   $	��183��6t   6�   �� 5;   
   -   5        $ TipoCitacomboBox��5;      $
��Left=�6-   $��284,326,0,0q�6H   $	��Top=�6]   $	��183��6u   6�   �� 5<   
   -   5        $ ClienteCombobox��5<      $
��Left=�6,   $��284,374,0,0q�6G   $	��Top=�6\   $	��183��6t   6�   �� 5=   
   -   5        $ MascotaCombobox��5=      $
��Left=�6,   $��284,420,0,0q�6G   $	��Top=�6\   $	��183��6t   ��5>      �� 5?      .R�5@      �� ��5A      `� 5B       �� StringFormat$ {0}: {1}��6+   .1�5C   "   �� $
 Nombre�6*   �� 5D   "   $

 Raza�6*   5E      5G      5H      5J      &   System.Windows.Controls.DataGrid  5K   
   -   5          Name$ RegistroDatagrid��5K   %   $��5,5,5,5q�6   $
��Left=�6@   $��
10,542,0,0q�6[   $	��Top=�6o   $	��150��6�   $	��630��6�      AutoGenerateColumns .  ��6�   ��    Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$ 
RegistroId��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *RegistroCitaId+  5N      $ Resumen��6%    66   �� *	Resumen+  5O      $ Fecha��6%    64   �� *Fecha+  5P      $ Observaciones��6%    6<   �� *Observaciones+  5Q      $ Tipo Atencion��6%    6<   �� *Motivo+  5R      $ Raza Mascota��6%    6;   �� *Raza+  5S      $ Nombre Mascota��6%    6=   �� *Nombre+  5T      $ Nombre Cliente��6%    6=   �� *NombreCompleto+5V      �� 5W   
   -   5        $ 
Listbutton��5W      $��Listar Registros��6%   $��24,495,437,0q�6A   $��36��6p   $	��Top=�6|   �� 5X   
    �� Orientation$ 
Horizontal=�6   $��546,490,0,0q�6.   $��42��6C   $	��Top=�6O   $
��Left=�6g   $��72��6�   .+�5Y      �� -   5        $ UpdateButton��5Y      $��36��6+   $��36��66   $��0,2,0,1q�6]   ��5Z      �� 5[      $> 8/Proyecto_Clinic_Veterinaria;component/Icons/Edit-48.png��6!   5]      �� 5^      -   5        $ DeleteButton��5^      $��36��6+   $��36��66   $��0,2,0,1q�6^   ��5_      �� 5`      $@ :/Proyecto_Clinic_Veterinaria;component/Icons/Delete-48.png��6!   5b      5c      �� 5d   
   -   5         ��Name$ gridSplitter1_Copy��5d        J� RenderTransformOrigin$  0.5,0.5&�63   $��320,134,0,-117q�6S   $
��Left=�6k   $��2��6�   $	��685��6�   $	��Top=�6�   z�5e      V� 5f      .~�5g      �� ! �� ScaleY$! 0.893Q�6%   " �� ScaleX$
" 1.12Q�64   �� 5h      �� 5i      # �� Angle$# 90Q�6&   T� 5j      5k      5m      �� 5n   
   -   5        $ gridSplitter1��5n      $  0.5,0.5&�6.   $��320,-359,0,0q�6N   $
��Left=�6d   $��2��6   $	��858��6�   $	��Top=�6�   z�5o      V� 5p      .~�5q      �� $! 0.709Q�6%   $
" 1.41Q�64   �� 5r      �� 5s      $# 90Q�6&   T� 5t      5u      5w      5z      5{      