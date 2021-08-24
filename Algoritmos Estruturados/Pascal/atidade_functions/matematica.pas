Program Calculos ;
uses util,bibliotecaMat;
var OP  :integer; // opção de menu
    N		:integer; // número para os cálculos

Begin
 repeat
 		clrscr;
 		linha(40,'=');
 		writeln('1.Imprimir a tubuada de um número');
 		writeln('2.Soma do números de um intervalo');
 		writeln('3.Cáculo da constante PI');
 		writeln('0.Sair');
 		linha(40,'=');
 	 	write('Qual a sua opção: ');
 	 	readln(OP);
 	 	
 	 	case (OP) of 
      1:begin
      		write('Digite um número inteiro: ');
      		readln(N);
      		tabuada(N);
      		espere;
				end;
      2:begin
      		write('Digite o intervalo: ');
      		readln(n);
      		writeln('Soma dos números: ',somaInter(n));
      		espere;
				end;
			3:begin
					write('Digite o número de intervalos: ');
					readln(n);
					writeln('Constante PI: ',constantePI(n));
					espere;
				end;
      else ;
    end;
 until OP=0;
  
End.