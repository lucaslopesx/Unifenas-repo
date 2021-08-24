Program Pzim ;
	var vet 			:array[1..10] of integer;
			i, j, aux :integer;
Begin

	for i := 1 to 10 do
		begin
   		readln(vet[i]);
		end;
		
	for i := 1 to 10 do
 		begin
  		for j := 1 to 9 do
    		begin
      		if (vet[j] < vet[j+1]) then 
						begin
         			aux:= vet[j];
         			vet[j]:= vet[j+1];
         			vet[j+1]:= aux;
        		end;
    		end;
 		end;
 		
 	writeln('Número ordenado de forma decrescente: ');
  writeln('');
 		
 	for i := 1 to 10 do
  	begin
    	writeln(vet[i]);
  	end;
  
End.