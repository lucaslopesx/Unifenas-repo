Program Pzim ;
	var NV, i, x, y, c :integer;
			n1, n2, s :array[0..10] of integer;
Begin

	writeln('-------Grande Soma-------');
	writeln;
	
	write('Digite a quantidade de n�meros desejada:');
	readln(NV);
	
	c:= 0;
	
	for i := 1 to NV do
 		begin
 			n1[i]:= 0;
			n2[i]:= 0;	
 		end;
	
	for i := 1 to NV do
 		begin
 			write('Digite o ',i,'� n�mero da primeira linha: ');
			readln(x);
			
			write('Digite o ',i,'� n�mero da segunda linha: ');
			readln(y);
			
			n1[i]:= n1[i] + x;
			n2[i]:= n2[i] + y;
 		end;
 		
 	for i := NV downto 1 do
  	begin
  	
   		s[i]:= n1[i]+n2[i];
   		
			if (s[i] > 9) then 
				begin
					s[i]:= s[i] -	10;
					
					c:= i - 1;
					
					n1[c]:= n1[c] + 1;
   			end;		 		
				 			
				 																		
  	end;
  	
  	
  	writeln;
  	
  	writeln('Resultado da soma entre a primeira e a segunda linha!');
  	
		writeln;
  	for i := 1 to NV do
   		begin
      	write(s[i],' ');	
   		end;
   	
   	writeln;
   	
   	writeln('Consegui fazer a soma por�m ao somar 2 n�meros de 3 casas ex:500+500 ');
   	writeln('o resultado n�o ser� 1000, esse 1 some e n�o descobri um modo de inser�-lo');
  	
End.