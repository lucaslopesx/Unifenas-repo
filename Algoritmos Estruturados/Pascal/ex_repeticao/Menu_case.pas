Program Pzim ;
var A,B,S,OP  :integer;
    R      :real;
Begin
	writeln('Menu de op��es');
	writeln('1.Somar dois n�meros');
	writeln('2.Raiz quadrada de um n�mero');
	write('Digite a op��o desejada:');
	readln(OP);
	
	a:=0
	case (OP) of
		1:begin  
			  clrscr;
				write('Entre com um n�mero:');
				readln(A);
				write('Entre com outro n�mero:');
				readln(B);
				writeln('Soma:',A+B);
				a:= a+b;
			end;
		2:begin
			  clrscr;
				write('Entre com o n�mero:');
				readln(A);
				writeln('Raiz quadrada:',SQRT(A));
			end;
		else writeln('Op��o inv�lida.');
	end;
  readln;
End.