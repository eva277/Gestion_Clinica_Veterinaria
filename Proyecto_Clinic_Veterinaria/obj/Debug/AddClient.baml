   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyecto_Clinic_VeterinariaProyecto_Clinic_Veterinaria  5      +    %Proyecto_Clinic_Veterinaria.AddClient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Proyecto_Clinic_Veterinaria     5      $	��650��5      $	��230��6+   $
��Auto=�68     � 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%w  '��       �� 5	   
   " ��6   .�5
      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5   "   �� .+�5   &   �� $ errorControl��6@   5   #   5      �� 5      
���  ��$	��8.5(�6|   $
��Auto��6�   ��6(   �� *AdornedElement.ToolTip+$ errorControl��6�   5      5      5       5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5      5      5       .��5!      � $��10,10,10,10q�6   .+�5#   
   �� -   5         ��Name$ label1��5#      $��Nombre��6    $
��Left=�61   $��	87,18,0,0q�6L   $	��Top=�6_   �� 5$   
   -   5        $ label2��5$      $��	Apellidos��6    $
��Left=�64   $��
306,19,0,0q�6O   $	��Top=�6c   �� 5%   
   -   5        $ label6��5%      $��	Direccion��6    $
��Left=�64   $��	81,66,0,0q�6O   $	��Top=�6b   �� 5&   
   -   5        $ label2_Copy��5&      $��Codigo Postal��6%   $
��Left=�6=   $��344,112,0,0q�6X   $	��Top=�6m   �� 5'   
   -   5        $ label6_Copy��5'      $��Telefono��6%   $
��Left=�68   $��
87,111,0,0q�6S   $	��Top=�6g   �� 5(   
   -   5        $ label3��5(      $��Email��6    $
��Left=�60   $��103,152,0,0q�6K   $	��Top=�6`   �� 5*   
   -   5         ��Name$ NombretextBox��5*      $
��Left=�6�   $��26��6�   $��
160,19,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��128��6  ��6)   �� *Nombre+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . 6  �� 5+   
   -   5        $ ApellidostextBox��5+      $
��Left=�6�   $��26��6�   $��
381,19,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��192��6  ��6,   �� *	Apellidos+$ PropertyChanged=� .  . 6  �� 5,   
   -	   5        $ DirecciontextBox_Copy5��5,      $
��Left=�6�   $��26��6�   $��
160,67,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��394��6  ��62   �� *	Direccion+$ PropertyChanged=� .  . 6  �� 5-   
   -
   5        $ TelefonoTextbox��5-      $
��Left=�6�   $��26��6�   $��160,112,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��168��6  ��6+   �� *
Telefono+$ PropertyChanged=� .  . 6  �� 5.   
   -   5        $ CodigoPostalTextbox��5.      $
��Left=�6�   $��26��6�   $��449,112,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��124��6  ��6/   �� *CodigoPostal+$ PropertyChanged=� .  . 6  �� 5/   
   -   5        $ EmailtextBox��5/      $
��Left=�6�   $��23��6�   $��160,156,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��168��6  ��6(   �� *Email+$ PropertyChanged=� .  . 6  �� 51   
   -   5         ��Name$ Acceptbutton��51      $
��Left=�6'   $��518,164,0,0q�6B   $	��Top=�6W   $��36��6o   $��36��6z   ��52      �� 53       �� ImageSource$ Icon/Plus-48.png��6   55      56      57      