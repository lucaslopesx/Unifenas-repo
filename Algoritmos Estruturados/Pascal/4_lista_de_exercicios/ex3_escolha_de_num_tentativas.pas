Program Pzim ;
var num,chute :real;
var C :integer;
Begin

	writeln('Adivinhe o número entre 1 e 100!!');
	writeln('');
	
	num:=random(100)+1;
	
	
	writeln('Agora é minha vez!!');
	writeln('');
	
	write('Chute: ');
	readln(chute);
	
	C:= 1;
	
	while ( num <> chute ) do 
		begin
   		if(chute > num) then
   			begin
   				writeln('Número alto');
   			end
   		else
   			begin
   				writeln('Número baixo');
   			end;
   		C:= C + 1;
   		write('Chute: ');
			readln(chute);
 		end;
 		
 	writeln('');	
 	writeln('Parabéns você acertou!');
 	
 	writeln('');
 	writeln('O número pensado foi: ',num:0:2,' e você concluiu em: ',C,' tentativas');
	
		
  
End.