Program Pzim ;
uses biblioteca;
var a,b,c,m :integer;
Begin
	a:=5;
	b:=8;

	c:= soma(a,b);
	writeln('A soma é igual a: ',c);
	
	m:= maior(a,b);
	writeln('O maior valor é: ',m);
	
	espere;
  
End.