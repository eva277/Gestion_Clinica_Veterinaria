   M S B A M L   `   `   `  ����V  RProyecto_Clinic_Veterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyecto_Clinic_VeterinariaProyecto_Clinic_Veterinaria  5      ,    &Proyecto_Clinic_Veterinaria.AddMascota   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Proyecto_Clinic_Veterinaria     5      $	��650��5      $��274.277��6+     � 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%w  '��       �� 5	   
   " ��6   .�5
      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5   "   �� .+�5   &   �� $ errorControl��6@   5   #   5      �� 5      
���  ��$	��8.5(�6|   $
��Auto��6�   ��6(   �� *AdornedElement.ToolTip+$ errorControl��6�   5      5      5       5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��64   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5      5      5       .��5!      �� ��. ?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid$   SelectiveScrollingOrientation$
 Both=�63   .+�5"   
   �� -   5         ��Name$ label1��5"      $��Nombre��6    $
��Left=�61   $	��Top=�6L    �� Left$ 65��6d   
 �� Top$ 24��6u   �� 5#   
   -   5         ��Name$ NombretextBox1��5#      $
��Left=�6�   $��23��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��160��6�   $	 135��6  $ 22��6  ��6*   �� *Nombre+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6  �� 5$   
   -   5        $ label2��5$      $��Especie��6    $
��Left=�62   $	��Top=�6M   $ 70��6e   $ 65��6v   �� 5%   
   -   5         ��Name$ EspeciecomboBox��5%      $
��Left=�6-   $	��Top=�6H   $	��160��6`   $	 135��6�   $ 63��6�   .@�5&      �� -   5        $��CaninoComboBoxItem��5&      $��Canino��65   �� 5'      -   5        $��FelinoComboBoxItem��5'      $��Felino��65   �� 5(      -   5        $��ExoticoComboBoxItem��5(      $��Exotico��66   5)      �� 5*   
   -   5        $ label3��5*      $
��Raza��6    $
��Left=�6/   $	��Top=�6J   $ 90��6b   $	 104��6s   �� 5+   
   -	   5        $ RazatextBox��5+      $
��Left=�6�   $��23��6�   $
 Wrap=�6�   $	��Top=�6�   $	��160��6�   $	 136��6�   $	 104��6  ��6(   �� *Raza+$ PropertyChanged=� .  . 6  �� 5,   
   -
   5        $ label4��5,      $
��Sexo��6    $
��Left=�60   $	��Top=�6K   $ 84��6c   $	 150��6t   	� 5-   
   -   5         	�Name$ FemradioButton��5-      $��Hembra��6/   $
��Left=�6@   $	��Top=�6[    d� 	IsChecked$
 TrueY�6s   $	 136��6�   $	 156��6�   	� 5.   
   -   5        $ MaleradioButton��5.      $��Macho��60   $
��Left=�6@   $	��Top=�6[   $	 210��6s   $	 156��6�   �� 5/   
   -   5        $ label4_Copy��5/      $��Pelaje��6%   $
��Left=�66   $	��Top=�6Q   $ 79��6i   $	 192��6z   �� 50   
   -   5        $ PelajetextBox3_Copy��50      $
��Left=�6�   $��23��6�   $
 Wrap=�6�   $	��Top=�6�   $	��160��6�   $	 133��6  $	 195��6  ��6/   �� *Pelaje+$ PropertyChanged=� .  . 6  �� 51   
   -   5        $ label4_Copy1��51      $��
Nacimiento��6&   $
��Left=�6;   $	��Top=�6V   $	 307��6n   $	 104��6�   (  "System.Windows.Controls.DatePicker  52   
   -   5        $��FechaNacimientoDatePicker��52      $
��Left=�66   $	��Top=�6Q   $	��160��6�   $	 396��6�   $	 105��6�   �� 53   
   -   5        $ label4_Copy2��53      $
��Foto��6&   $
��Left=�65   $	��Top=�6P   $	 344��6h   $	 151��6z   �� 54   
   
���   �$��1q�6%   $
��Left=�69   $	��100��6T   $	��Top=�6a   $	��100��6y   $	 394��6�   $	 151��6�   ._�55      �� -   5         ��Name$ image��55      $��	-1,-1,1,1q�6#   56      �� 57   
   -   5        $ label5��57      $��Activo��6    $
��Left=�61   $	��Top=�6L   $ 77��6d   $	 230��6u   �� 58   
   -   5         ��Name$ ActivocheckBox��58      $
��Left=�6,   $	��Top=�6G   $	 133��6_   $	 236��6q   �� 59   
   -   5        $ label6��59      $��Dueño��6    $
��Left=�60   $	��Top=�6K   $	 333��6c   $ 20��6u   �� 5:   
   -   5        $ OwnercomboBox��5:      $
��Left=�6+   $	��Top=�6F   $	��160��6^   $	 393��6�   $ 24��6�   �� 5;   
   -   5        $ label6_Copy��5;      $��Usuario��6%   $
��Left=�67   $	��Top=�6R   $	 328��6j   $ 61��6|   �� 5<   
   -   5        $ UsercomboBox��5<      $
��Left=�6*   $	��Top=�6E   $	��158��6]   $	 393��6�   $ 65��6�   �� 5=   
   -   5         ��Name$ Acceptbutton��5=      $
��Left=�6'   $��36��6B   $��36��6h   $	��Top=�6t   $	 571��6�   $	 221��6�   ��5>      �� 5?       �� ImageSource$ Icon/Plus-48.png��6   5A      �� 5B   
   -   5        $ LoadImgbutton��5B      $	��...��6)   $
��Left=�67   $	��Top=�6R   $��32��6j   $��22��6u   $	 499��6�   $	 229��6�   5C      5D      