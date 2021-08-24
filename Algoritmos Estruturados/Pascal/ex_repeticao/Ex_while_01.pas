Program Pzim ;
var I:integer;
    OK:char;
Begin
	OK:='S';
	while (OK='S') or (OK='s') do
		begin
		    clrscr;
				write('Entre com sua idade:');
				readln(I);
				writeln('Sua idade aproximada em dias:',I*365);
				write('Continua <S/N>:');
				readln(OK);
		end;
  
End.