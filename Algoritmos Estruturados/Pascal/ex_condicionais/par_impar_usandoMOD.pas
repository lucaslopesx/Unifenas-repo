Program Pzim ;
var num, resto :integer;
Begin
	writeln('Verificador de par ou ímpar');
	
	write('Digite um número: ');
	readln(num);
	
	resto := num mod 2;
	
	
	
	if ( resto = 0 ) then begin
   write('PAR');
 end else begin
   write('ÍMPAR');
 end;
 readln;
  
End.