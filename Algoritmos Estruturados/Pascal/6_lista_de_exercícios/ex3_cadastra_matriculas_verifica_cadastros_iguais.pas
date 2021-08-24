Program Pzim ;
	var vetL 									:array[1..15] of integer;
			vetLP									:array[1..10] of integer;
			cont_L, cont_LP, j, i:integer;
Begin
	
	i:= 1;
	cont_L:=1;
	cont_LP:=1;
	writeln('----Total de alunos cursando lógica e linguagem de programação----');
	writeln('');
	
	write('Número de matrículas de lógica (Máximo de 15 matrículas!):');
	readln(cont_L);
	
	write('Número de matrículas de linguagem de programação (Máximo de 10 matrículas!): ');
	readln(cont_LP);
	
	writeln('Digite a matrícula dos alunos de lógica: ');
	for i := 1 to cont_L do
		begin
   		write('Matrícula do ',i,'° aluno: ');
			readln(vetL[i]);
			
 		end;
	
	writeln('Digite a matrícula dos alunos de linguagem de Programação: ');
	for i := 1 to cont_LP do
		begin
   		write('Matrícula do ',i,'° aluno: ');
			readln(vetLP[i]);
 		end;
	clrscr;
	
	writeln('Matrículas cadastradas nos dois cursos:');
	writeln('');
	
	for i := 1 to cont_L do
 		begin
   		for j := 1 to cont_LP do
     		begin
     			if (vetL[i]=vetLP[j]) then 
					 	begin
            	writeln(vetLP[j]);
        		end;
     		end;	
 		end;
 		
 	readln;
	
	  
End.