Program Pzim ;
var L:char;
Begin
 write('Entre com uma letra:');
 readln(L);
 case (L) of
 		'a'..'z','A'..'Z':writeln('� uma letra!');
 		'0'..'9':writeln('� um n�mero!');
 		else writeln('N�o letra e tamb�m n�o � um n�mero.');
 end;
 readln;
  
End.