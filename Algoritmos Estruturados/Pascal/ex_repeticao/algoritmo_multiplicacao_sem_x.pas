Program Pzim ;
var fat,x,C,res :integer;
Begin
   //MULTIPLICA��O
   
   write('Digite um n�mero: ');
   readln(fat);
   
   write('Digite outro: ');
   readln(x);
   
   C:= 1;
   
   
   	while ( C <= fat ) do 
	 		begin
      	
      	res:= res + x;
      	C:= C + 1;
      	
   		end;
   		
   		writeln('Resultado da multi: ',res);
End.