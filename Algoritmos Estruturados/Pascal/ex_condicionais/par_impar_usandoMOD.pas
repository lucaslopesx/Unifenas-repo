Program Pzim ;
var num, resto :integer;
Begin
	writeln('Verificador de par ou �mpar');
	
	write('Digite um n�mero: ');
	readln(num);
	
	resto := num mod 2;
	
	
	
	if ( resto = 0 ) then begin
   write('PAR');
 end else begin
   write('�MPAR');
 end;
 readln;
  
End.