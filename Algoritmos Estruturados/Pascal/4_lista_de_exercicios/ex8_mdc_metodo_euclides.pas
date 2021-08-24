Program Pzim ;
var a,b,r :integer;
Begin

	write('Digite A: ');
	readln(A);
	
	write('Digite B: ');
	readln(B);
	
	while ( (A)MOD(B) > 0 ) do 
		begin
  		R:= A mod B;
  		A:= B;
  		B:= R;
 		end;
 		
 	writeln('O resultado do MDC é: ',B);
 	readln;
  
End.