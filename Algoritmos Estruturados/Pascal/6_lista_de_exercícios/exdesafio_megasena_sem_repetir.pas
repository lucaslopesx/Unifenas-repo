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
		      for j := 1 to 60 do
        		begin
          		numero[j]:= 0;	
        		end;
        		
        	total:= 0;
		      while ( total < dezena + 1 ) do
		      	begin
		        	j:= random(60)+1;
		        	if (numero[j] = 0) then
		        		begin
		          		numero[j]:= 1;
		          		sorteio[total]:= j;
		          		inc(total);
		        		end;  
						end;
					{ordenação}	
					for i2 := 1 to dezena do
  					begin
  						for j2 := 1 to dezena - 1 do
    						begin
      						if (sorteio[j2] > sorteio[j2+1]) then 
										begin
											aux:= sorteio[j2];
											sorteio[j2]:= sorteio[j2+1];
											sorteio[j2+1]:= aux;
        						end;
    						end;
  					end;

  					
  				for j2 := 1 to dezena do
    				begin           	
      				write(sorteio[j2]:3,' ');
    				end;
      		writeln;
	    	end;
	  end;
  writeln;
  readln;
  
End.