Program Pzim ;
var R:array[1..5,1..8] of char;
    I,J,OP:integer;
Begin
  {Inicializando todas as posições da matriz com - (hífen)}
  {o hifen indica que a posição está vaga}
	for I:=1 to 5 do
		for J:=1 to 8 do
			R[I,J]:='-';

	repeat
	  clrscr;
 		writeln('==============================');	
		write('   '); //dando um espaço de três colunas ante de imprimir o número das cadeiras;
		for J:=1 to 8 do
			write(J:3); //imprimindo o número das cadeiras
		writeln;
		{imprimindo as cadeiras, filas (I) e números (J)}
		for I:=1 to 5 do
		  begin
		    write(I:3); // este comando imprime o número da fila
				for J:=1 to 8 do
					begin
						write(R[I,J]:3);
					end;
	      writeln;
			end;
		writeln('==============================');	
		writeln('(1)Reservar-(2)Liberar-(3)-Sair');
		write('Opção:');
		readln(OP);
		
		case (OP) of 
    1:begin  
    		writeln('----Reserva----');
				write('Digite o número da linha: ');
				readln(i);
				writeln;
				write('Digite o número da coluna: ');
				readln(j);
				
				if (R[i][j] = 'X') then
					begin
      			writeln('Cadeira ja reservada!!');
    			end
				else
					begin
						R[i][j]:= 'X';	
					end;
					
			write('Tecle <enter> para sair');
			readln;
				  
			end;
    2:begin
    		writeln('----Liberação----');
				write('Digite o número da linha: ');
				readln(i);
				writeln;
				write('Digite o número da coluna: ');
				readln(j);
				
				if (R[i][j] = '-') then 
					begin
      			writeln('Cadeira já está vazia!!');
    			end
				else
					begin
						R[i][j]:= '-';	
					end;
					
			write('Tecle <enter> para sair');
			readln;
				  
			end;
    else ;
  end;
		
	until OP=3; 
  
End.