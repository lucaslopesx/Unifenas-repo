Program Pzim ;
	var num, posi, neg 			:array[1..8] of integer;
			cont, cont_n, cont_p, i:integer;
Begin

	cont_n:= 1;
	cont_p:= 1;
	
	for i := 1 to 8 do
 		begin
   		readln(num[i]);
			if (num[i] >= 0) then 
				begin
					posi[cont_p]:= num[i];
					cont_p:= cont_p + 1;
   			end   
			else 
				begin
     			neg[cont_n]:= num[i];
     			cont_n:= cont_n + 1;
   			end;	
   			
 		end;
 	clrscr;
 		
 		
 	if ( cont_n = 1 ) then 
	 	begin
    	writeln('Vetor negativo vazio');	
  	end 
 	else 
	 	begin
	 		writeln('Vetor negativo: ');
			writeln('');
    	for i := 1 to cont_n - 1 do
     		begin
       		writeln(neg[i]);
     		end;
 	 	end;
 	 	
 	 	writeln('');
 	
 	if ( cont_p = 1 ) then 
	 	begin
    	writeln('Vetor positivo vazio');
  	end
	else 
		begin
			writeln('Vetor positivo: ');
			writeln('');
    	for i := 1 to cont_p - 1 do
     		begin
       		writeln(posi[i]);
     		end;
  	end;

	
  
End.