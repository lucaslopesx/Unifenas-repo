Program Pzim ;
var I, N, SP, SI :integer;
Begin

	for I:= 1 to 10 do
		begin
			writeln('Entre com o ',I,'� n�mero: ');
			readln(N);
			
			if (N mod 2 = 0) then // o n�mero � par
				SP:= SP + N
			else // o n�mero � �mpar
				SI:= SI + N;
		end;
		
	writeln('Soma dos pares: ',SP);
	writeln('Soma dos �mpares: ',SI);
	
		
  
End.