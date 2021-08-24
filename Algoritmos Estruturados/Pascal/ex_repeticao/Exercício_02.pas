Program Pzim ;
var N,I  :integer;
Begin
	write('Entre com um valor:');
	readln(N);
	if (N mod 2=1) then
		N:=N+1;
	for I:=1 to 6 do
		begin
			writeln(N);
			N:=N+2;
		end;
  write('Tecle <enter> para continuar...');
  readln;
End.