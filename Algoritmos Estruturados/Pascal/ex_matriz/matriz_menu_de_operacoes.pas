Program Pzim ;
	var l,c, op, NL, NC, soma,somaC, somaL, col, linha :integer;
			m				:array[1..100,1..100] of integer;
Begin
	repeat
		clrscr;
		writeln('=========Matrizes=========');
		writeln('1. Ler a matriz');
		writeln('2. Mostrar a matriz');
		writeln('3. Alterar um valor');
		writeln('4. Soma de todos os valores');
		writeln('5. Somar uma coluna');
		writeln('6. Somar uma linha');
		writeln('7. Sair');
		writeln('==========================');
		write('Digite a opção desejada: ');
		readln(op);
		
		somaC:= 0;
		somaL:= 0;
		col:= 0;
		linha:= 0;
		
		case (op) of 
    1: 	begin
					write('Número de linhas: ');
					readln(NL);
					writeln;
					write('Número de colunas: ');
					readln(NC);
					writeln;
					
					for l := 1 to NL do
     				begin
       				for c := 1 to NC do
           			begin
            			write('M[',l,',',c,']=');
            			readln(m[l][c]);
           			end;
     				end;	 
				end;
    2: 	begin
    			writeln('Matriz armazenada: ');
    			for l := 1 to NL do            	
       			begin
         			for c := 1 to NC do
            		begin
              		write(m[l][c]:4);
            		end;
            		writeln;
       			end;
       			writeln;
       			
       			write('Tecle <enter> para sair');
       			readln;
					 
				end;
		3: 	begin
					writeln('----Alterando um valor da matriz----');
					writeln('Escolha o valor na matriz a seguir.');
					for l := 1 to NL do            	
       			begin
         			for c := 1 to NC do
            		begin
              		write(m[l][c]:4);
            		end;
            		writeln;
       			end;
       			writeln;
       			
       		write('Digite o número da linha: ');
       		readln(l);
       		writeln;
       		write('Digite o número da coluna: ');
       		readln(c);
       		writeln;
       		write('Entre com o novo valor: ');
       		readln(M[l][c]);
       		writeln;
       		
       		writeln('----Matriz com valor alterado----');
       		for l := 1 to NL do            	
       			begin
         			for c := 1 to NC do
            		begin
              		write(m[l][c]:4);
            		end;
            		writeln;
       			end;
       			writeln;
       		
       		
       		write('Tecle <enter> para sair');
       		readln;
				end;
		4: 	begin
					for l := 1 to NL do
     				begin
       				for c := 1 to NC do
           			begin
             			soma:= soma + m[l][c];
											
           			end;
     				end;
     			writeln('Soma de todos os valores do vetor: ',soma);	
     			
     			write('Tecle <enter> para sair');
       		readln;
					 
				end;
		5: 	begin	
					writeln('Escolha a coluna na matriz a seguir.');
					for l := 1 to NL do            	
       			begin
         			for c := 1 to NC do
            		begin
              		write(m[l][c]:4);
            		end;
            		writeln;
       			end;
       			writeln;
       			
       		write('Digite o número da coluna que deseja somar: ');
					readln(col);
					
					if (col > NC) then 
						begin
      				writeln('Coluna não existente!');
     				end
     			else
     				begin
     					for l := 1 to NL do
     						begin
       						somaC:= somaC + m[l][col]
     						end;
     				
     					writeln;	
     					writeln('Soma dos números da coluna ',col,': ',somaC);
     					writeln;
     				end;
     				
     			write('Tecle <enter> para sair');
       		readln;
					 
				end;
		6:	begin
					writeln('Escolha a linha na matriz a seguir.');
					for l := 1 to NL do            	
       			begin
         			for c := 1 to NC do
            		begin
              		write(m[l][c]:4);
            		end;
            		writeln;
       			end;
       			writeln;
       			
       		write('Digite o número da linha que deseja somar: ');
					readln(linha);
					
					if (col > NL) then 
						begin
      				writeln('Coluna não existente!');
     				end
     			else
     				begin
     					for c := 1 to NC do
     						begin
       						somaL:= somaL + m[linha][c]
     						end;
     				
     					writeln;	
     					writeln('Soma dos números da linha ',linha,': ',somaL);
     					writeln;
     				end;
     				
     			write('Tecle <enter> para sair');
       		readln;
							
				end;
    else ;
  end;
		
 	until (op=7);
 	
 	
End.