Program Pzim ;
	var vet 					:array[1..50] of real;
			i, j, QV 			:integer;
			maior, menor 	:real;
Begin

	write('Digite a quantidade de valores desejada: ');
	readln(QV);

	for i := 1 to QV do
 		begin
   		write('Digite o ',i,'° valor: ');
   		readln(vet[i]);
   		
   		if (QV = 1) then 
			 	begin
       		maior:= vet[i];
					menor:= vet[i];	
     		end     
			else 
				begin
       		if (vet[i] > maior) then 
					 	begin
           		maior:= vet[i];
         		end;	
     		end;
 		end;
 		
 	writeln('Maior valor: ',maior:0:2);
 	
 	for i := 1 to QV do
  	begin
    	vet[i]:= vet[i] / maior;
  	end;
  
  writeln('Valores divididos pelo maior: ');
  
  for i := 1 to QV do
  	begin
    	writeln(vet[i]:0:2);
  	end;
  	
  readln;
  
End.