Program Pzim ;
	var nomeAluno 								:array[1..6] of string; // nome dos alunos
			n1, n2 										:array[1..6] of real; // notas da 1a e 2a prova
			i, na											:integer;
			media, sm, maiorMedia			:real;
			nomeMelhor								:string;         
Begin
	na:=0;
	sm:=0;
	maiorMedia:=0;
	nomeMelhor:='';
	for i := 1 to 6 do
 		begin
   		write('Digite o nome do ',i,'� aluno: ');
   		readln(nomeAluno[i]);
   		
   		write('Digite a nota da 1a prova: ');
      readln(n1[i]);
       		
      write('Digite a nota da 2a prova: ');
  		readln(n2[i]);	
 		end;
 		
 	writeln('Rel�torio de notas: ');
	writeln('');
	writeln('Aluno ':-10,'1a Prova':10,'2a Prova':10,'M�dia':10,'Situa��o':15);
	writeln('');
	
	for i := 1 to 6 do
 		begin
  		write(nomeAluno[i]:-10);
  		write(n1[i]:10:2);
  		write(n2[i]:10:2);
  		
  		media:= (n1[i] + n2[i]) / 2;
  		write(media:10:2);
  		sm:= sm + media;
  		
			
			//acha maior m�dia e o nome do aluno que � possui
			if (media > MaiorMedia) then 
					begin
           	maiorMedia:= media;
           	nomeMelhor:= nomeAluno[i];
         	end;     
         	
         	
         	
  		
  		if (media >= 6 ) then 
				begin
					inc(na);
					writeln('Aprovado':15);
    		end
    	else 
    		begin
    			writeln('Reprovado':15);
    		end;
 		end;
 		
 	writeln('');
 		
 	writeln('M�dia da classe: ',sm/2:0:2);
 	writeln('N�mero de aprovados: ',na);
 	writeln('Porcentagem de aprova��o: ', na/6*100:0:2,'%');
 	
 	writeln('');
 	
 	writeln('Maior m�dia: ',maiorMedia:0:2);
 	writeln('Nome do melhor aluno: ',nomeMelhor);
End.