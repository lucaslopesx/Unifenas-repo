Program Pzim ;
var DiviD,DiviS,Q,N :integer;
Begin

// Algoritmo da divisão: DiviD = DiviS*Q + R 

writeln('Algoritmo da divisão (Dividindo sem usar / )');
writeln('');

write('Digite o número a ser dividido [DIVIDENDO]: ');
readln(DiviD);

write('Digite o número DIVISOR: ');
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
   		writeln('Resto da divisão: ',DiviD);
		end 
	else 
		begin
		
			writeln('Divisão por 0: INDEFINIDA');
  		
		end;


		
	

  
End.