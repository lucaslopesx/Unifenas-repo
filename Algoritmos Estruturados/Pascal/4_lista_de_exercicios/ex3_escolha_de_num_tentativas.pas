Program Pzim ;
var num,chute :real;
var C :integer;
Begin

	writeln('Adivinhe o n�mero entre 1 e 100!!');
	writeln('');
	
	num:=random(100)+1;
	
	
	writeln('Agora � minha vez!!');
	writeln('');
	
	write('Chute: ');
	readln(chute);
	
	C:= 1;
	
	while ( num <> chute ) do 
		begin
   		if(chute > num) then
   			begin
   				writeln('N�mero alto');
   			end
   		else
   			begin
   				writeln('N�mero baixo');
   			end;
   		C:= C + 1;
   		write('Chute: ');
			readln(chute);
 		end;
 		
 	writeln('');	
 	writeln('Parab�ns voc� acertou!');
 	
 	writeln('');
 	writeln('O n�mero pensado foi: ',num:0:2,' e voc� concluiu em: ',C,' tentativas');
	
		
  
End.