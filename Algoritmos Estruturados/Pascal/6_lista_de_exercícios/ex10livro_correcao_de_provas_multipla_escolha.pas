Program Pzim ;
	var nomeAluno, resposta  				:array[1..6] of string;
			gabarito										:array[1..8] of string;
			num, pontos, tot_ap, i, j 	:integer;
			perc_ap 										:real;
Begin

	for i := 1 to 8 do
 		begin
  		write('Digite a resposta da quest�o ',i,': ');
  		readln(gabarito[i]);
 		end;
 	
 	tot_ap:= 0;
 	
 	for i := 1 to 10 do
  	begin           	
  		write('Digite o n�mero do ',i,'� aluno: ');
  		readln(num);
  		
  		pontos:= 0;
  		
  		for j := 1 to 8 do
    		begin        	
      		write('Digite a resposta dada pelo aluno ',num,' � ',j,'� quest�o: ');
      		readln(resposta[j]);
      		
      		
      		if (resposta[j] = gabarito[j]) then 
						begin
          		pontos:= pontos + 1;
        		end;
    		end;
    	writeln('A nota do aluno ',num,' foi: ',pontos);
    	
    	if (pontos >= 6) then 
				begin
       		tot_ap:= tot_ap + 1;
     		end;
  	end;
  perc_ap:= tot_ap * 100/10;
  
  writeln('O percentual de alunos aprovados �: ',perc_ap:0:2);
  
End.