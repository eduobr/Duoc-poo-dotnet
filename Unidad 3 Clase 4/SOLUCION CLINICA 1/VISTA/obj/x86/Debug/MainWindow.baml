   M S B A M L   `   `   `  ????	  VISTA    VISTA.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     ? Title$  INGRESO PACIENTES??5   	   $	??491??6#   $	??593??60   ???	#FF00CD00.??5      ? .+?5   
   ?? -   5        $??	groupBox1??5   _   $??PACIENTE??6   $	??145??6%   $
??Left=?62   $??10,8,0,0q?6M   $	??Top=?6p   $	??547??6?   .??5      ? .+?5      ?? -   5        $??label1??5   h   $??Numero Ficha??6   $??28??6/   $
??Left=?6;   $??9,10,0,0q?6V   $	??Top=?6v   ?? 5	      -   5        $??txtFicha??5	   T   $??23??6   $
??Left=?6&   $??	99,10,0,0q?6A   $	??Top=?6d   $??47??6|   ?? 5
      -   5        $??label2??5
   d   $??Nombre:??6   $??28??6*   $
??Left=?66   $??	152,8,0,0q?6Q   $	??Top=?6r   ?? 5      -   5        $??	txtNombre??5   U   $??23??6   $
??Left=?6&   $??
214,10,0,0q?6A   $	??Top=?6f   $	??120??6~   ?? 5      -   5        $??label3??5   c   $??Edad:??6   $??28??6(   $
??Left=?64   $??
343,11,0,0q?6O   $	??Top=?6q   ?? 5      -   5        $??txtEdad??5   U   $??23??6   $
??Left=?6&   $??
388,11,0,0q?6A   $	??Top=?6d   $??35??6|   ?? 5      -   5        $??label4??5   c   $??Salud:??6   $??28??6)   $
??Left=?65   $??	14,43,0,0q?6P   $	??Top=?6q   ?? 5      -	   5        $??cboSalud??5   U   $??23??6   $
??Left=?6'   $??	60,46,0,0q?6B   $	??Top=?6e   $	??120??6}   ?? 5      -
   5        $??label5??5   d   $??Fecha:??6   $??28??6)   $
??Left=?65   $??
186,43,0,0q?6P   $	??Top=?6r   (  "System.Windows.Controls.DatePicker  5      -   5        $??dpFecha??5   X   $??25??6   $
??Left=?6)   $??
229,43,0,0q?6D   $	??Top=?6g   $	??153??6   ?? 5      -   5        $??label6??5   b   $
??Hora??6   $??28??6'   $
??Left=?63   $??
403,41,0,0q?6N   $	??Top=?6p   ?? 5      -   5        $??txtHora??5   U   $??23??6   $
??Left=?6&   $??
452,43,0,0q?6A   $	??Top=?6d   $??31??6|   ?? 5      -   5        $??label7??5   j   $??Tipo Paciente??6   $??28??60   $
??Left=?6<   $??	18,78,0,0q?6W   $	??Top=?6x   ?? 5      -   5        $??cboTipoPaciente??5   U   $??23??6   $
??Left=?6'   $??	99,80,0,0q?6B   $	??Top=?6l   $	??120??6?   6?   5      5      ?? 5   
   -   5        $??gbAdulto??5   ^   $??ADULTO??6   $??67??6#   $
??Left=?6/   $??
14,162,0,0q?6J   $	??Top=?6n   $	??231??6?   {?.  .??5      ? .+?5      ?? -   5        $??label8??5   b   $??Trabajo??6   $??28??6*   $
??Left=?66   $??6,6,0,0q?6Q   $	??Top=?6p   ?? 5      -   5        $??
txtTrabajo??5   T   $??23??6   $
??Left=?6&   $??	70,11,0,0q?6A   $	??Top=?6f   $	??120??6~   5      5      ?? 5   
   -   5        $??gbNino??5   ]   $??NIÑO??6   $??67??6!   $
??Left=?6-   $??259,162,0,0q?6H   $	??Top=?6k   $	??224??6?   {?.  .??5      ? .+?5       ?? -   5        $??label9??5    b   $??Colegio??6   $??28??6*   $
??Left=?66   $??5,9,0,0q?6Q   $	??Top=?6p   ?? 5!      -   5        $??
txtColegio??5!   T   $??23??6   $
??Left=?6&   $??	62,11,0,0q?6A   $	??Top=?6f   $	??120??6~   5"      5#      ?? 5$   
   -   5        $??
lstListado??5$   N   $	??203??6   $
??Left=?6   $??
14,237,0,0q?6:   $	??Top=?6`   $	??270??6x   ?? 5%   
   -   5        $??	btnGrabar??5%   ^   $??Grabar??6   $??58??6"   $
??Left=?6.   $??495,172,0,0q?6I   $	??Top=?6o   $??62??6?   6?   ?? 5&   
   -   5        $??label10??5&   n   $??Fecha Mayor de Atencion??6   $??28??62   $
??Left=?6>   $??296,240,0,0q?6Y   $	??Top=?6}   ?? 5'   
   -   5        $??label11??5'   n   $??Fecha Menor de Atencion??6   $??28??62   $
??Left=?6>   $??296,274,0,0q?6Y   $	??Top=?6}   ?? 5(   
   -   5        $??label12??5(   r   $!??Numero de Adultos de Isapre??6   $??28??66   $
??Left=?6B   $??296,311,0,0q?6]   $	??Top=?6?   ?? 5)   
   -   5        $??label13??5)   w   $&?? Adultos con hora antes de las 13??6   $??28??6;   $
??Left=?6G   $??296,348,0,0q?6b   $	??Top=?6?   ?? 5*   
   -   5        $??lblLinQ1??5*   L   $??25??6   $
??Left=?6   $??468,243,0,0q?67   $	??Top=?6\   $??78??6t   ???	#FFFFC9006   ?? 5+   
   -   5        $??lblLinQ2??5+   L   $??28??6   $
??Left=?6   $??468,276,0,0q?67   $	??Top=?6\   $??78??6t   ???	#FFFFC9006   ?? 5,   
   -   5        $??lblLinQ3??5,   L   $??28??6   $
??Left=?6   $??495,312,0,0q?67   $	??Top=?6\   $??51??6t   ???	#FFFFC9006   ?? 5-   
   -   5        $??lblLinQ4??5-   L   $??28??6   $
??Left=?6   $??494,349,0,0q?67   $	??Top=?6\   $??52??6t   ???	#FFFFC9006   ?? 5.   
   -    5        $??btnEstadisticas??5.   j   $??Datos Estadisticos??6   $??23??6.   $
??Left=?6:   $??310,400,0,0q?6U   $	??Top=?6?   $	??236??6?   5/      50      