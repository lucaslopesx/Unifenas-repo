Program Pzim ;
var CONT,I,NUM,QN:integer;
Begin
   write('Entre com a quantidade de n�meros:');
   readln(QN);
   CONT:=0;
   for I:=1 to QN do
   	begin
   		write('Entre com um n�mero:');
   		readln(NUM);
   		if (NUM mod 2 = 0) then
   			CONT:=CONT +1;
   	end;
    writeln('Quantidade de n�meros pares:',CONT);
    writeln('Porcentagem de n�meros pares:',CONT/QN*100:0:2,'%');
    readln;
End.