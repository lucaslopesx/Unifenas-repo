Program Pzim ;
	var NV, i, P :integer;
			DADO :array[1..6] of integer;
Begin

	writeln('-------Lan�amento de dados-------');	
	writeln;
	
	write('Quantidade de vezes que deseja lan�ar o dado: ');
	readln(NV);
	
	writeln;
	
	for i := 1 to 6 do
 		begin
   		DADO[i]:= 0;	
 		end;
	
	for i := 1 to NV do
 		begin
   		P:= random(6)+1;
   		DADO[P]:= DADO[P] + 1;
 		end;
 		
 	writeln('N�meros sorteados: ');
 	writeln;
 	
 	for i := 1 to 6 do
  	begin
    	writeln('N�mero ',i,' apareceu um total de: ',DADO[i],' vezes.');
  	end;
 	
  
End.