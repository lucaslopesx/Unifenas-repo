Program Pzim ;
uses biblioteca;
var N,a,b:integer;
Begin

	writeln('-----FATORIAL-----');
	writeln;
	
	write('Entre com um valor inteiro: ');
	readln(N);
	
	writeln('O fatorial é: ',fatorial(N));
	writeln;
	
	write('Entre com b: ');
	readln(a);
	write('Entre com a: ');
	readln(b);
	
	writeln('Média entre A e B é igual a ',media(a,b):0:2);
	
	
	readln;
	
  
End.


//3! = 3*2*1 = 6