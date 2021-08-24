Program Pzim ;
var L:char;
Begin
 write('Entre com uma letra:');
 readln(L);
 case (L) of
 		'a'..'z','A'..'Z':writeln('É uma letra!');
 		'0'..'9':writeln('É um número!');
 		else writeln('Não letra e também não é um número.');
 end;
 readln;
  
End.