Program Calculos ;
uses util,bibliotecaMat;
var OP  :integer; // op��o de menu
    N		:integer; // n�mero para os c�lculos

Begin
 repeat
 		clrscr;
 		linha(40,'=');
 		writeln('1.Imprimir a tubuada de um n�mero');
 		writeln('2.Soma do n�meros de um intervalo');
 		writeln('3.C�culo da constante PI');
 		writeln('0.Sair');
 		linha(40,'=');
 	 	write('Qual a sua op��o: ');
 	 	readln(OP);
 	 	
 	 	case (OP) of 
      1:begin
      		write('Digite um n�mero inteiro: ');
      		readln(N);
      		tabuada(N);
      		espere;
				end;
      2:begin
      		write('Digite o intervalo: ');
      		readln(n);
      		writeln('Soma dos n�meros: ',somaInter(n));
      		espere;
				end;
			3:begin
					write('Digite o n�mero de intervalos: ');
					readln(n);
					writeln('Constante PI: ',constantePI(n));
					espere;
				end;
      else ;
    end;
 until OP=0;
  
End.