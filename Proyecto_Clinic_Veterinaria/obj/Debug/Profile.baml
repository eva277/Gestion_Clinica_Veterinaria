   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyecto_Clinic_VeterinariaProyecto_Clinic_Veterinaria  5      )    #Proyecto_Clinic_Veterinaria.Profile   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Proyecto_Clinic_Veterinaria     5      $	��650��5      $��359.972��6+   $
��Auto=�6<     � 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%w  '��       �� 5	   
   " ��6   .�5
      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5   "   �� .+�5   &   �� $ errorControl��6@   5   #   5      �� 5      
���  ��$	��8.5(�6|   $
��Auto��6�   ��6(   �� *AdornedElement.ToolTip+$ errorControl��6�   5      5      5       5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5      5      5       .��5!      � .+�5"   
   �� -   5         ��Name$ label1��5"      $��Nombre��6    $
��Left=�61   $��	55,27,0,0q�6L   $	��Top=�6_   �� 5#   
   -   5        $ label2��5#      $��	Apellidos��6    $
��Left=�64   $��	49,86,0,0q�6O   $	��Top=�6b   �� 5$   
   -   5        $ label3��5$      $��	Direccion��6    $
��Left=�64   $��
372,25,0,0q�6O   $	��Top=�6c   �� 5%   
   -   5        $ label4��5%      $��Codigo Postal��6    $
��Left=�68   $��
349,75,0,0q�6S   $	��Top=�6g   �� 5&   
   -   5        $ label5��5&      $��Telefono��6    $
��Left=�63   $��
53,179,0,0q�6N   $	��Top=�6b   �� 5'   
   -   5        $ label6��5'      $��Email��6    $
��Left=�60   $��
70,133,0,0q�6K   $	��Top=�6_   �� 5(   
   -   5        $ label7��5(      $��Tipo de Usuario��6    $
��Left=�6:   $��338,130,0,0q�6U   $	��Top=�6j   �� 5)   
   -   5        $ label8��5)      $��NickName��6    $
��Left=�63   $��
44,227,0,0q�6N   $	��Top=�6b   �� 5*   
   -	   5        $ label9��5*      $��Password��6    $
��Left=�63   $��
48,277,0,0q�6N   $	��Top=�6b   �� 5+   
   -
   5        $ label10��5+      $��Pregunta Secreta��6!   $
��Left=�6<   $��332,179,0,0q�6W   $	��Top=�6l   �� 5,   
   -   5        $ label11��5,      $��Respuesta Secreta��6!   $
��Left=�6=   $��326,227,0,0q�6X   $	��Top=�6m   �� 5-   
   -   5        $ label12��5-      $��Modificar Usuario��6!   $
��Left=�6=   $��452,285,0,0q�6X   $	��Top=�6m   �� 5/   
   -   5         ��Name$ NombretextBox��5/      $
��Left=�6�   $��26��6�   $��
114,27,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��169��6  ��6)   �� *Nombre+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6  �� 50   
   -   5        $ ApellidostextBox��50      $
��Left=�6�   $��26��6�   $��
113,84,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��169��6  ��6,   �� *	Apellidos+$ PropertyChanged=� .  . 6  �� 51   
   -   5        $ EmailtextBox_Copy5��51      $
��Left=�6�   $��26��6�   $��113,131,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��169��6  ��6.   �� *Email+$ PropertyChanged=� .  . 6  �� 52   
   -   5        $ TelefonotextBox_Copy4��52      $
��Left=�6�   $��26��6�   $��114,179,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��169��6  ��61   �� *
Telefono+$ PropertyChanged=� .  . 6  �� 53   
   -   5        $ NickNametextBox_Copy6��53      $
��Left=�6�   $��26��6�   $��114,227,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��169��6  ��61   �� *
NickName+$ PropertyChanged=� .  . 6  �� 54   
   -   5        $ PasswordtextBox_Copy7��54      $
��Left=�6�   $��26��6�   $��114,277,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��169��6  ��61   �� *
Password+$ PropertyChanged=� .  . 6  �� 55   
   -   5        $ DirecciontextBox��55      $
��Left=�6�   $��26��6�   $��
437,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��160��6  ��6,   �� *	Direccion+$ PropertyChanged=� .  . 6  �� 56   
   -   5        $ CodPosttextBox_Copy3��56      $
��Left=�6�   $��26��6�   $��
437,75,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��160��6  ��60   �� *CodigoPostal+$ PropertyChanged=� .  . 6  �� 57   
   -   5         ��Name$ TipoUsucomboBox��57      $
��Left=�6,   $��437,129,0,0q�6G   $	��Top=�6\   $	��160��6t   $��26��6�    �� Text$ Elige Tipo de usuario��6�   .@�58      �� -   5         ��Name$ MedicoComboBox��58      .��63   Medico6;   �� 59      -   5        $ PeluComboBox��59      .��61   
Peluqueria6=   �� 5:      -   5        $ AdminComboBox��5:      .��62   Administracion6B   5;      �� 5<   
   -   5        $# PreguntaSecrretatextBox_Copy8��5<      $
��Left=�6�   $��26��6�   $��437,177,0,0q�6�   $
 Wrap=�6�   $	��Top=�6	  $	��160��6!  ��69   �� *PreguntaSecreta+$ PropertyChanged=� .  . 6!  �� 5=   
   -   5        $" RespuestaSecrettextBox_Copy9��5=      $
��Left=�6�   $��26��6�   $��437,227,0,0q�6�   $
 Wrap=�6�   $	��Top=�6	  $	��160��6!  ��68   �� *RespuestaSecreta+$ PropertyChanged=� .  . 6!  �� 5>   
   -   5         ��Name$ UpdateButton1��5>      $��36��6(   $��36��63   $��561,277,53,47q�6Z   ��5?      �� 5@       �� ImageSource$ Icons/Edit-48.png��6   5B      5C      5D      