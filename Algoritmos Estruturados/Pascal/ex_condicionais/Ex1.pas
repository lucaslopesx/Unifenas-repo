Program Pzim ;
var I,SOMA,NUM,QN:integer;
Begin
   SOMA:=0;
   write('Entre com a quantidade de n�meros:');
   readln(QN);
   for I:=1 to QN do
	    begin
				write('Entre com o ',I,'� n�mero:');
		   	readln(NUM);
		   	SOMA:=SOMA+NUM;
   	  end;
   write('Soma=',SOMA);
   readln;
End.