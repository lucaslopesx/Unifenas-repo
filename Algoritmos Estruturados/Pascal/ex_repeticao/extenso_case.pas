Program Exemplo_extenso;
var N:integer;
Begin
	write('Entre com um n�mero:');
	readln(N);
  case (N) of 
    1: writeln('UM');
    2: writeln('DOIS'); 
    3: writeln('TR�S');
    4: writeln('QUATRO');
    5: writeln('CINCO');
    6: writeln('SEIS');
    7: writeln('SETE');
    8: writeln('OITO');
    9: writeln('NOVE');
    0: writeln('ZERO');
    else writeln('ENTRE COM N�MEROS DE 0 A 9');
  end;
 	write('Tecle enter para sair');
	readln;
End.