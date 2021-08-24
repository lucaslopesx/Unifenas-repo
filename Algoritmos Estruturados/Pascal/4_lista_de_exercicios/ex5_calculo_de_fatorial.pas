Program Pzim ;
var	N,Fat :integer;
Begin

	writeln('Cálculo de fatorial!!');
	writeln('');
	
	write('Digite o número desejado: ');
	readln(N);
	
	Fat:= 1;
		
	if (N = 0) then 
		begin
   		Fat:= 1;	
 		end
	else if (N < 0) then
	 	begin
	 		writeln('Número negativo não suportado'); 	
 		end
 	else 
 		begin	
			while N>1 do
				begin
					Fat:= Fat * N;
					N:= N - 1;
				end;	 
 		end; 
 		
 		writeln('O resultado do número em fatorial é: ',Fat);  
End.