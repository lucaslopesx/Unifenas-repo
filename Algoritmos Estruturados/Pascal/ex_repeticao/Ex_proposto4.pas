Program Pzim ;
var ID,SI,NP:integer;
Begin
  SI:=0;
  NP:=0;
	write('Entre com uma idade <0 para sair>:');
	readln(ID);
	while ID>0 do
		begin
		   SI:=SI+ID;
		   NP:=NP+1;
		   write('Entre com uma idade <0 para sair>:');
		   readln(ID);
		end;
	if (NP<>0) then
  	writeln('Média das idades:',SI/NP:0:2);
  
  write('Tecle <enter> para sair...');
  readln;
End.