Program Pzim ;
var CONT,I,NUM,QN:integer;
Begin
   write('Entre com a quantidade de números:');
   readln(QN);
   CONT:=0;
   for I:=1 to QN do
   	begin
   		write('Entre com um número:');
   		readln(NUM);
   		if (NUM mod 2 = 0) then
   			CONT:=CONT +1;
   	end;
    writeln('Quantidade de números pares:',CONT);
    writeln('Porcentagem de números pares:',CONT/QN*100:0:2,'%');
    readln;
End.