Program Pzim ;
var expo, base, pote, i :integer;
Begin

	writeln('-------Exponencia��o sem fun��es-------');
	writeln('');
	
	write('Digite o valor da base: ');
	readln(base);
	
	writeln('');
	
	write('Digite o valor do expoente: ');
	readln(expo);
	
	pote:= 1;
	i:=0;
	while ( i <  expo ) do 
		begin
    	pote:= pote * base;
    	i:= i + 1;
		end;
	 	
		
		writeln('Pot�ncia: ',pote);
  
End.