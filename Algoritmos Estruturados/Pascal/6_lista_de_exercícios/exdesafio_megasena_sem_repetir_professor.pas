Program Pzim ;
var sorteio, numero												 :array[1..60] of integer;
aposta, dezena,i, j, i2, j2, aux, total, k:integer;
Begin
  
  writeln('----MEGA SENA----');
  writeln;
  
  write('Digite o número de dezenas: ');
  readln(dezena);
  
  write('Digite o número de apostas: ');
  readln(aposta);
  
  for j := 1 to  aposta do//inicializa todas as posições
  	begin
    	numero[j]:= 0;
  	end;
  
  if ((dezena = 0) or (aposta = 0) or (dezena < 0) or (aposta < 0)) then
	  begin
	    writeln('Digite algum número maior que 0 nos campos aposta e dezena');
	  end
  else
	  begin
	  writeln;
		writeln('Números sorteados: ');
		writeln;
		
	    for i := 1 to aposta do
	    	begin
		     	total:= 0;
		      while ( total < dezena ) do
		      	begin
		        	j:= random(60)+1;
		        	if (numero[j] = 0) then
		        		begin
		          		numero[j]:= 1;
		          		inc(total);
		        		end;  
						end;
  					
  				for j := 1 to 60 do
    				begin
							if ( numero[j] = 1 ) then 
								begin
         					write(j:3,' ');
      						numero[j]:=0;
       					end;           	
    				end;
      		writeln;
	    	end;
	  end;
  writeln;
  readln;
  
End.