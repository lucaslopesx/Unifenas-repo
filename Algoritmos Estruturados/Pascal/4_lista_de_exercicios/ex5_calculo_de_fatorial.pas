Program Pzim ;
var	N,Fat :integer;
Begin

	writeln('C�lculo de fatorial!!');
	writeln('');
	
	write('Digite o n�mero desejado: ');
	readln(N);
	
	Fat:= 1;
		
	if (N = 0) then 
		begin
   		Fat:= 1;	
 		end
	else if (N < 0) then
	 	begin
	 		writeln('N�mero negativo n�o suportado'); 	
 		end
 	else 
 		begin	
			while N>1 do
				begin
					Fat:= Fat * N;
					N:= N - 1;
				end;	 
 		end; 
 		
 		writeln('O resultado do n�mero em fatorial �: ',Fat);  
End.