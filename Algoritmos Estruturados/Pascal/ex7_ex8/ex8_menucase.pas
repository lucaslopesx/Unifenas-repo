Program Pzim ;
var x,y :integer;
var OP :char; 
Begin

	write('Entre com um n�mero: ');
	readln(x);
	
	write('Entre com outro n�mero: ');
	readln(y);
	
	writeln('-------Menu de opera��es-------');
	writeln('A - retornar o soma de dois n�meros');
	writeln('S - retornar a subtra��o de dois n�meros');
	writeln('M - retornar a multiplica��o de dois n�meros;');
	writeln('Q - retornar o quociente inteiro da divis�o;');
	
	write('Digite o c�digo da opera��o desejada: ');
	readln(OP);
	
	case (OP) of
		'A','a':begin  
			  clrscr;
				writeln('Soma: ',x+y);
			end;
		'S','s':begin
			  clrscr;
				writeln('Subtra��o: ',x-y);
			end;
		'M','m':begin
				clrscr;
				writeln('Multiplica��o: ',x*y);
			end;
		'Q','q':begin
				clrscr;
				writeln('Divis�o: ',x DIV y);
			end;
		
		else writeln('Op��o inv�lida.');
	end;
  
End.