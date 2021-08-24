Program Pzim ;
var X,Y,SI,I:integer;
Begin
	write('Entre com o valor de X:');
	readln(X);
	write('Entre com o valor de Y:');
	readln(Y);
	SI:=0;
	for I:=X to Y do
	begin
		if (I mod 2=1) then
			SI:=SI+I;
	end;
	writeln('Soma dos números ímpares:',SI);
	
  writeln('Tecle <enter> para continuar...');
  readln;
End.