Program Pzim ;
var NA,C: integer; //NA = num. de alunos e C = contar os alunos
    N1,N2,M,MM:real;  //MM = Maior M�dia
    NOME,NOME_M:string;//NOME_M = Nome do aluno que tem a maior m�dia
Begin
	write('N�mero de alunos:');
	readln(NA);
	
	for C:=1 to NA do
		begin
		  clrscr;
			write('Nome:');
			readln(NOME);
			write('1a Nota:');
			readln(N1);
			write('2a Nota:');
			readln(N2);
			M:=(N1+N2)/2;
			if (C=1) then
				begin
					MM:=M;
					NOME_M:=NOME;
				end
			else
				if (M>MM) then
					begin
						MM:=M;
						NOME_M:=NOME;
					end;
			clrscr;
			writeln('Aluno.......:',NOME);
			writeln('M�dia.......:',M:0:2);
			write('Tecle <enter> para continuar...');
  		readln;
		end;
		clrscr;
		writeln('Maior m�dia:',MM:0:2);
		writeln('Nome.......:',NOME_M);
  
End.