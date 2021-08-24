Program Pzim ;
var x,y :integer;
var OP :char; 
Begin

	write('Entre com um número: ');
	readln(x);
	
	write('Entre com outro número: ');
	readln(y);
	
	writeln('-------Menu de operações-------');
	writeln('A - retornar o soma de dois números');
	writeln('S - retornar a subtração de dois números');
	writeln('M - retornar a multiplicação de dois números;');
	writeln('Q - retornar o quociente inteiro da divisão;');
	
	write('Digite o código da operação desejada: ');
	readln(OP);
	
	case (OP) of
		'A','a':begin  
			  clrscr;
				writeln('Soma: ',x+y);
			end;
		'S','s':begin
			  clrscr;
				writeln('Subtração: ',x-y);
			end;
		'M','m':begin
				clrscr;
				writeln('Multiplicação: ',x*y);
			end;
		'Q','q':begin
				clrscr;
				writeln('Divisão: ',x DIV y);
			end;
		
		else writeln('Opção inválida.');
	end;
  
End.