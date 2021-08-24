Program Pzim ;
var C,VALOR,MA,ME :integer;
Begin

	C:= 1;
	write('Entre com um valor: ');
	readln(VALOR);
	
	while VALOR <> 0 do
		begin
			if ( C = 1 ) then 
				begin
     			MA:= VALOR;
					ME:= VALOR;	
  			end 
			else 
				begin
     			if ( VALOR > MA ) then 
						MA:= VALOR;		
      		if ( VALOR < ME ) then
         		ME:= VALOR;       	
   			end;
   		C:= C+1;
   		write('Entre com um valor: ');
			readln(VALOR);
		end;
	writeln('Maior valor: ',MA);
  writeln('Menor valor: ',ME);
  
  write('Tecle <enter> para sair');
  readln;
End.