Program Pzim ;
var NV, i :integer;
		Vet		:array[1..50] of integer;
Begin

	write('Quantidade de valores: ');
	readln(NV);
	
	for i := 1 to NV do
 		begin
   		write('Entre com o ',i,'° valor: ');
   		readln(Vet[i]);
 		end;
 		
 	for i := NV downto 1 do
  	begin
    	write(Vet[i],' // ');
  	end;
  writeln;
  write('Tecle <enter> para sair...');
  readln;
  
End.