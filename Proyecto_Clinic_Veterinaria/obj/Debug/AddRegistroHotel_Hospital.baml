   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyecto_Clinic_VeterinariaProyecto_Clinic_Veterinaria  5      ;    5Proyecto_Clinic_Veterinaria.AddRegistroHotel_Hospital   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Proyecto_Clinic_Veterinaria     5      $	��278��5      $	��650��6,   .��5      � .+�5	   
   �� -   5          ��Name$  label1��5	      $��Fecha de Ingreso��6    $
��Left=�6;   $��
182,15,0,0q�6V   $	��Top=�6j   (  "System.Windows.Controls.DatePicker  5
   
   -   5        $��IngresoDatePicker��5
      $
��Left=�6.   $��
310,13,0,0q�6I   $	��Top=�6]   $	��158��6u   6�   �� 5   
   -   5        $  label1_Copy��5      $��Fecha de Salida��6%   $
��Left=�6?   $��
190,57,0,0q�6Z   $	��Top=�6n     5   
   -   5        $��RegresoDatePicker��5      $
��Left=�6.   $��
310,53,0,0q�6I   $	��Top=�6]   $	��158��6u   6�   �� 5   
   -   5        $  label��5      $��
Disponible��6   $
��Left=�64   $��216,214,0,0q�6O   $	��Top=�6d   �� 5   
   -   5         ��Name$ DisponiblecheckBox��5      $
��Left=�6/   $��310,218,0,0q�6J   $	��Top=�6_   $��26��6w   �� 5   
   -   5        $  label2��5      $��Mascota��6    $
��Left=�62   $��
227,97,0,0q�6M   $	��Top=�6a   �� 5   
   -   5         ��Name$ MascotaCombobox��5      $
��Left=�6,   $��
310,93,0,0q�6G   $	��Top=�6[   $	��158��6s   $��25��6�   ��5      �� 5      .R�5      �� ��5      `� 5       �� StringFormat$ 	{0} - {1}��6+   .1�5   "   ��  �� Path$ Nombre�6*   �� 5   "   $
 Raza�6*   5      5      5      5      �� 5   
   -	   5        $  label2_Copy��5      $��Jaula��6%   $
��Left=�65   $��246,138,0,0q�6P   $	��Top=�6e   �� 5   
   -
   5        $ JaulacomboBox��5      $
��Left=�6*   $��310,138,0,0q�6E   $	��Top=�6Z   $	��158��6r   ��5       �� 5!      .R�5"      �� ��5#      `� 5$      $ {0}: {1}��6+   .1�5%   "   �� $ 	TipoJaula�6*   �� 5&   "   $ Medida�6*   5'      5)      5*      5,      �� 5-   
   -   5        $  label2_Copy1��5-      $��Usuario��6&   $
��Left=�68   $��232,179,0,0q�6S   $	��Top=�6h   �� 5.   
   -   5        $ UsuaruicomboBox��5.      $
��Left=�6,   $��310,179,0,0q�6G   $	��Top=�6\   $	��158��6t   6�   �� 5/   
   -   5         ��Name$ 	textBlock��5/      $
��Left=�6'   $��
91,310,0,0q�6B   $
��Wrap=�6V   $	��Top=�6�   $y�Hidden=�6�   ��6j   �� *'%SelectedItem.RegistroHotel_HospitalId+ �� ElementName$ 
HHDatagrid�� �� Mode$ OneWay=�6�   �� 50   
   -   5         ��Name$ Acceptbutton��50      $
��Left=�6'   $��432,232,0,0q�6B   $	��Top=�6W   $��36��6o   $��36��6z   ��51      �� 52      	 �� ImageSource$	 Icon/Plus-48.png��6   54      55      56      