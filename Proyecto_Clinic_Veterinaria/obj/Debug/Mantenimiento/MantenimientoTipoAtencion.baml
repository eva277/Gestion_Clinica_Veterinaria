   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento)Proyecto_Clinic_Veterinaria.Mantenimiento  5      I    CProyecto_Clinic_Veterinaria.Mantenimiento.MantenimientoTipoAtencion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:Proyecto_Clinic_Veterinaria.Mantenimiento     5      $��539.83��5   3     � 	Resources  5       �� 
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
143,14,0,0q�6l   $��77��6�   �� 5#   
   -   5         ��Name$ SearchTextbox��5#      $
��Left=�6)   $��30��6D    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��132��6|   $��
225,10,0,0q�6�   �� 5$   
   -   5         ��Name$ SearchcomboBox��5$      $
��Left=�6+   $	��Top=�6F   $��94��6^   $��30��6i    �� SelectedItem$ SearchBy��6u   $��
364,10,0,0q�6�   .@�5%      �� $��Importancia��6   �� 5&      $��Motivo��6   5'      �� 5(   
   -   5         ��Name$ SearchButton��5(      $��
474,10,0,0q�6B   $��30��6V   $��30��6a   $
��Left=�6m   $	��Top=�6�   ��5)      �� 5*       �� ImageSource$? 9/Proyecto_Clinic_Veterinaria;component/Icon/Search-48.png��6   5,      �� 5-   
   -   5        $ 
label_Copy��5-      $��Id Tipo Atencion��6$   $
��Left=�6?   $��
178,80,0,0q�6Z   $	��Top=�6n   �� 5.   
   -   5        $ label��5.      $��Nombre��6   $
��Left=�60   $��228,124,0,0q�6K   $	��Top=�6`   �� 5/   
   -   5        $ label1��5/      $��Motivo��6    $
��Left=�61   $��234,164,0,0q�6L   $	��Top=�6a   �� 50   
   -   5        $ label2��50      $��Importancia��6    $
��Left=�66   $��203,244,0,0q�6Q   $	��Top=�6f   �� 51   
   -	   5        $ label3��51      $��Usuario��6    $
��Left=�62   $��231,210,0,0q�6M   $	��Top=�6b   �� 52   
   -
   5        $ 	idTextbox��52       �� 
IsReadOnly . $
��Left=�6�   $��22��6  $��
298,84,0,0q�6  $
 Wrap=�6'  $	��Top=�6;  $��30��6S  ��6%   �� *SelectedItem.TipoAtencionId+$ TipoCitaDatagrid�� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6S  �� 53   
   -   5        $ NombrecomboBox��53      $
��Left=�6+   $��298,128,0,0q�6F   $	��Top=�6[   $	��120��6s   .@�54      �� $��Control��6   �� 55      $��
Vacunacion��6   �� 56      $��
Corte Pelo��6   57      �� 58   
   -   5        $ MotivocomboBox_Copy��58      {�.  $
��Left=�6B   $��298,168,0,0q�6]   $	��Top=�6r   $	��120��6�   6�   �� 59   
   -   5        $ UsuariocomboBox��59      $
��Left=�6,   $��298,210,0,0q�6G   $	��Top=�6\   $	��148��6t   6�   �� 5:   
   -   5        $ ImportanciatextBox1��5:      $
��Left=�6�   $��24��6�   $��298,247,0,0q�6�   $
 Wrap=�6  $	��Top=�6$  $��30��6<  ��6/   �� *Importancia+$ TipoCitaDatagrid��$ OneWay=�$ PropertyChanged=� .  . 6<  �� 5;   
   -   5        $ 
Listbutton��5;      $��Listar Tipos de Citas��6%   $��37,304,419,0q�6F   $��33��6u   $	��Top=�6�   �� 5<   
    �� Orientation$ 
Horizontal=�6   $��552,304,0,0q�6.   $
��Left=�6C   $��73��6^   $��40��6i   $	��Top=�6u   .+�5=      �� -   5        $ UpdateButton��5=      $��36��6+   $��0,2,0,1q�6Q   ��5>      �� 5?      $> 8/Proyecto_Clinic_Veterinaria;component/Icons/Edit-48.png��6!   5A      �� 5B      -   5        $ DeleteButton��5B      $��36��6+   $��0,2,0,1q�6Q   ��5C      �� 5D      $@ :/Proyecto_Clinic_Veterinaria;component/Icons/Delete-48.png��6!   5F      5G      &   System.Windows.Controls.DataGrid  5H   
   -   5          Name$ TipoCitaDatagrid��5H   &   $��5,5,5,5q�6   $
��Left=�6@   $��
10,350,0,0q�6[   $	��Top=�6o   $	��180��6�   $	��630��6�      AutoGenerateColumns .  ��6�   ��    Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ TipoAtencionId��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *TipoAtencionId+  5K      $ Nombre��6%    65   �� *Nombre+  5L      $ Motivo��6%    65   �� *Motivo+  5M      $ Importancia��6%    6:   �� *Importancia+5O      �� 5P   
   -   5         ��Name$ gridSplitter1��5P       J� RenderTransformOrigin$ 0.5,0.5&�6.   $��321,-339,0,0q�6N   $
��Left=�6d   $��3��6   $	��806��6�   $	��Top=�6�   z�5Q      V� 5R      .~�5S      ��  �� ScaleY$
 0.76Q�6%     �� ScaleX$  1.316Q�63   �� 5T      �� 5U      ! �� Angle$! 90Q�6&   T� 5V      5W      5Y      �� 5Z   
   -   5        $ gridSplitter1_Copy��5Z      $ 0.5,0.5&�63   $��327,29,0,-8q�6S   $
��Left=�6h   $��4��6�   $	��519��6�   $	��Top=�6�   z�5[      V� 5\      .~�5]      �� $ 1.173Q�6%   $  0.853Q�64   �� 5^      �� 5_      $! 90Q�6&   T� 5`      5a      5c      5d      5e      