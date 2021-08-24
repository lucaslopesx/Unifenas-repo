Program Pzim ;
var I, N, SP, SI :integer;
Begin

	for I:= 1 to 10 do
		begin
			writeln('Entre com o ',I,'° número: ');
			readln(N);
			
			if (N mod 2 = 0) then // o número é par
				SP:= SP + N
			else // o número é ímpar
				SI:= SI + N;
		end;
		
	writeln('Soma dos pares: ',SP);
	writeln('Soma dos ímpares: ',SI);
	
		
  
End.