Program Pzim ;
	var vet       :array[1..10] of integer;
			i, j, aux :integer;
Begin
	
	writeln('----Ordena��o crescente de valores----');
	writeln('');
	writeln('Digite 10 n�meros');
	
	
	for i := 1 to 10 do
 		begin
 			write('Digite o ',i,'� valor: ');
 			readln(vet[i]);
 		end;
 		
 	for i := 1 to 10 do
  	begin
  		for j := 1 to 9 do
    		begin
      		if (vet[j] > vet[j+1]) then 
						begin
							aux:= vet[j];
							vet[j]:= vet[j+1];
							vet[j+1]:= aux;
        		end;
    		end;
  	end;
  	
  writeln('');
  writeln('N�mero ordenado de forma crescente: ');
  writeln('');
  
  for i := 1 to 10 do
  	begin
    	writeln(vet[i]);
  	end;
  
End.