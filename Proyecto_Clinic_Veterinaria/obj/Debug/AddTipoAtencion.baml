   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyecto_Clinic_VeterinariaProyecto_Clinic_Veterinaria  5      1    +Proyecto_Clinic_Veterinaria.AddTipoAtencion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Proyecto_Clinic_Veterinaria     5      $��222.832��5   3     � 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%w  '��       �� 5	   
   " ��6   .�5
      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5   "   �� .+�5   &   �� $ errorControl��6@   5   #   5      �� 5      
���  ��$	��8.5(�6|   $
��Auto��6�   ��6(   �� *AdornedElement.ToolTip+$ errorControl��6�   5      5      5       5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5      5      5       .��5!      � .+�5"   
   �� -   5         ��Name$ label��5"      $��Nombre��6   $
��Left=�60   $��
214,28,0,0q�6K   $	��Top=�6_   �� 5#   
   -   5        $ label1��5#      $��Motivo��6    $
��Left=�61   $��
220,76,0,0q�6L   $	��Top=�6`   �� 5$   
   -   5        $ label2��5$      $��Importancia��6    $
��Left=�66   $��243,157,0,0q�6Q   $	��Top=�6f   �� 5%   
   -   5         ��Name$ ImportanciatextBox1��5%      $
��Left=�6�   $��23��6�   $��336,157,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��30��6  ��6/   �� *Importancia+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6  �� 5&   
   -   5        $ label3��5&      $��Usuario��6    $
��Left=�62   $��218,118,0,0q�6M   $	��Top=�6b   �� 5'   
   -   5         ��Name$ UsuariocomboBox��5'      $
��Left=�6,   $��280,118,0,0q�6G   $	��Top=�6\   $	��120��6t   6�   �� 5(   
   -   5         ��Name$ Acceptbutton��5(      $
��Left=�6'   $��406,177,0,0q�6B   $	��Top=�6W   $��36��6o   $��36��6z   ��5)      �� 5*       �� ImageSource$ Icon/Plus-48.png��6   5,      �� 5-   
   -   5        $ NombrecomboBox��5-      $
��Left=�6+   $��
280,32,0,0q�6F   $	��Top=�6Z   $	��120��6r   .@�5.      �� $��Control��6   �� 5/      $��
Vacunacion��6   �� 50      $��
Corte Pelo��6   51      �� 52   
   -	   5        $ MotivocomboBox_Copy��52      {�.  $
��Left=�6B   $��
280,76,0,0q�6]   $	��Top=�6q   $	��120��6�   6�   54      55      