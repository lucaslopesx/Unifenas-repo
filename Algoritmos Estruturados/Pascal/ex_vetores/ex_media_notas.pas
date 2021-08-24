Program Pzim ;
var N:array[1..15] of real;
		Media,soma:real;
		i,QN,NumApr:integer;
Begin
	writeln('-------Média entre notas usando vetor-------');
	writeln('');
	
	write('Quantidade de notas: ');
	readln(QN);
	writeln('');
	
	soma:= 0;
	for i := 1 to QN do
 		begin
   		write('Entre com a ',i,'a nota: ');
			readln(N[i]);
			soma:= soma + N[i];
		 end;
		 clrscr;
		
	if ( QN > 0 ) then 
		begin
   		Media:= soma / QN;
   		NumApr:= 0;
	
			writeln('Notas Armazenadas: ');
			writeln('');
	
			for i := 1 to QN do
 				begin
 					writeln(i,'a nota: ',N[i]:0:2);
					if (N[i] >= Media) then 
						begin
    		    	NumApr := NumApr + 1;
		   			end; 
		 		end;
		 	writeln('Média: ',Media:0:2);
			writeln('Números maiores que a média: ',NumApr);
 		end; 
	
	
	
	readln; 
  
End.