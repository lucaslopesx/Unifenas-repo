Program Pzim ;
var I,x :integer;
Begin

	write('Digite um número positivo: ');
	readln(x);

	if ( x > 0 ) then begin
		
		if ( x mod 2 = 0 ) then begin
    	
    	for I:=0 to 5 do
    		begin
    		
    		writeln(x);
    		x:= x + 2;
    		
    		end;
    	
  	end  else begin
  		x:= x + 1;
  		for I:=0 to 5 do
    		begin
    	
    		writeln(x);
    		x:= x + 2;
    		
    		end;	
   	end;
		  
	end else begin
  	write('[ERRO] O valor deve ser positivo, tente novamente');
	end;
  
End.