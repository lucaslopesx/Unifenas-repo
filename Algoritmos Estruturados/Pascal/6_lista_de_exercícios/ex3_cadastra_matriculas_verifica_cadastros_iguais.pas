Program Pzim ;
	var vetL 									:array[1..15] of integer;
			vetLP									:array[1..10] of integer;
			cont_L, cont_LP, j, i:integer;
Begin
	
	i:= 1;
	cont_L:=1;
	cont_LP:=1;
	writeln('----Total de alunos cursando l�gica e linguagem de programa��o----');
	writeln('');
	
	write('N�mero de matr�culas de l�gica (M�ximo de 15 matr�culas!):');
	readln(cont_L);
	
	write('N�mero de matr�culas de linguagem de programa��o (M�ximo de 10 matr�culas!): ');
	readln(cont_LP);
	
	writeln('Digite a matr�cula dos alunos de l�gica: ');
	for i := 1 to cont_L do
		begin
   		write('Matr�cula do ',i,'� aluno: ');
			readln(vetL[i]);
			
 		end;
	
	writeln('Digite a matr�cula dos alunos de linguagem de Programa��o: ');
	for i := 1 to cont_LP do
		begin
   		write('Matr�cula do ',i,'� aluno: ');
			readln(vetLP[i]);
 		end;
	clrscr;
	
	writeln('Matr�culas cadastradas nos dois cursos:');
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