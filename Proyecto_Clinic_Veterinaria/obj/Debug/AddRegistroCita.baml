   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyecto_Clinic_VeterinariaProyecto_Clinic_Veterinaria  5      1    +Proyecto_Clinic_Veterinaria.AddRegistroCita   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Proyecto_Clinic_Veterinaria     5      $��456.091��5   3   .��5      � .+�5	   
   �� -   5          ��Name$  label��5	      $��Resumen Cita��6   $
��Left=�66   $��
185,25,0,0q�6Q   $	��Top=�6e   �� 5
   
   -   5        $  label1��5
      $��Fecha��6    $
��Left=�60   $��
226,76,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $  label2��5      $��Observaciones��6    $
��Left=�68   $��165,124,0,0q�6S   $	��Top=�6h   �� 5   
   -   5        $  label3��5      $��Usuario��6    $
��Left=�62   $��217,218,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $  label3_Copy��5      $��	Tipo Cita��6%   $
��Left=�69   $��210,260,0,0q�6T   $	��Top=�6i   �� 5   
   -   5        $  label3_Copy1��5      $��Cliente��6&   $
��Left=�68   $��220,304,0,0q�6S   $	��Top=�6h   �� 5   
   -   5        $  label3_Copy2��5      $��Mascota��6&   $
��Left=�68   $��210,350,0,0q�6S   $	��Top=�6h   �� 5   
   -   5         ��Name$ ResumentextBox��5      $
��Left=�6�   $��23��6�   $��
292,30,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��183��6  ��6*   �� *	Resumen+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions . 6  (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ 	FechaCita��5      $
��Left=�6�   $��
292,79,0,0q�6�   $	��Top=�6�   $	��183��6�      Text 6(   �� *CodigoPostal+ �� NotifyOnValidationError . $ PropertyChanged=� . 6�   �� 5   
   -
   5        $ ObservacionestextBox��5      $
��Left=�6�   $��67��6�   $��279,124,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��240��6  ��60   �� *Observaciones+$ PropertyChanged=� .  . 6  �� 5   
   -   5        	 ��Name$	 UsuariocomboBox��5      $
��Left=�6,   $��291,214,0,0q�6G   $	��Top=�6\   $	��183��6t   6�   �� 5   
   -   5        $	 TipoCitacomboBox��5      $
��Left=�6-   $��291,256,0,0q�6H   $	��Top=�6]   $	��183��6u   6�   �� 5   
   -   5        $	 ClienteCombobox��5      $
��Left=�6,   $��291,304,0,0q�6G   $	��Top=�6\   $	��183��6t   6�   �� 5   
   -   5        $	 MascotaCombobox��5      $
��Left=�6,   $��291,350,0,0q�6G   $	��Top=�6\   $	��183��6t   ��5      �� 5      .R�5      �� ��5      `� 5      
 �� StringFormat$
 	{0} - {1}��6+   .1�5   "   ��  �� Path$ Nombre�6*   �� 5   "   $
 Raza�6*   5      5       5!      5#      �� 5$   
   -   5         ��Name$ Acceptbutton��5$      $
��Left=�6'   $��431,397,0,0q�6B   $	��Top=�6W   $��36��6o   $��36��6z   ��5%      �� 5&       �� ImageSource$ Icon/Plus-48.png��6   5(      5)      5*      