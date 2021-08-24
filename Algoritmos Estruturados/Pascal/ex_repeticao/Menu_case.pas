Program Pzim ;
var A,B,S,OP  :integer;
    R      :real;
Begin
	writeln('Menu de opções');
	writeln('1.Somar dois números');
	writeln('2.Raiz quadrada de um número');
	write('Digite a opção desejada:');
	readln(OP);
	
	a:=0
	case (OP) of
		1:begin  
			  clrscr;
				write('Entre com um número:');
				readln(A);
				write('Entre com outro número:');
				readln(B);
				writeln('Soma:',A+B);
				a:= a+b;
			end;
		2:begin
			  clrscr;
				write('Entre com o número:');
				readln(A);
				writeln('Raiz quadrada:',SQRT(A));
			end;
		else writeln('Opção inválida.');
	end;
  readln;
End.