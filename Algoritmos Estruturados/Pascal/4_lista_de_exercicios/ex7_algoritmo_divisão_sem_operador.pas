Program Pzim ;
var DiviD,DiviS,Q,N :integer;
Begin

// Algoritmo da divis�o: DiviD = DiviS*Q + R 

writeln('Algoritmo da divis�o (Dividindo sem usar / )');
writeln('');

write('Digite o n�mero a ser dividido [DIVIDENDO]: ');
readln(DiviD);

write('Digite o n�mero DIVISOR: ');
readln(DiviS);

Q:= 0;


	if ( DiviS <> 0 ) then 
		begin
    	while (	DiviD-DiviS >= 0 ) do 
				begin
					Q:= Q + 1;
     			DiviD:= DiviD - DiviS;
   			end;
   		writeln('Quociente: ',Q);
   		writeln('Resto da divis�o: ',DiviD);
		end 
	else 
		begin
		
			writeln('Divis�o por 0: INDEFINIDA');
  		
		end;


		
	

  
End.