Program numeroMaior ;
var a, b, c, maiorStart, maiorEnd :real;
Begin
	
	readln(a);
	readln(b);
	readln(c);
	
	maiorStart := (a+b+abs(a-b))/2;
	maiorEnd := (c+maiorStart+abs(c-maiorStart))/2;
	
	write(maiorEnd:0:0,' é o maior');
	readln;
  
End.