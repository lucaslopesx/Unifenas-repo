Program Pzim ;
	var num, vetp, veti :array[1..10] of integer;
			i, cont_p, cont_i:integer;
Begin

	writeln('Separação de valores pares e impares');
	
	cont_p:= 1;
	cont_i:= 1;

	for i := 1 to 10 do
 		begin
   		write(i,'° número: ');
   		readln(num[i]);
   		
   		if (num[i] mod 2 = 0) then 
			 	begin
       		vetp[cont_p]:= num[i];
					inc(cont_p);	
     		end     
		 	else 
				begin
					veti[cont_i]:= num[i];
					inc(cont_i);
     		end;
 		end;
 	writeln('');
 		
 	if (cont_p = 1) then 
	 	begin
	 		writeln('Vetor par vazio!!');
  	end  
	else 
		begin
			writeln('Vetor par: ');
			writeln('');
			for i := 1 to cont_p - 1 do
   			begin
     			writeln(vetp[i]);
  			end;
  	end;
  writeln('');
  	
 	if (cont_i = 1) then 
	 	begin
	 		writeln('Vetor ímpar vazio!!');
  	end  
	else 
		begin
			writeln('Vetor ímpar: ');
			writeln('');
			for i := 1 to cont_i - 1 do
   			begin
     			writeln(veti[i]);
  			end;
  	end;
  
End.
