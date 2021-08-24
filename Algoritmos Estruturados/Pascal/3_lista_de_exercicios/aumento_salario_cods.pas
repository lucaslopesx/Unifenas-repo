Program Pzim ;
var cod:integer;
var sal, aumento :real;
Begin

	writeln('1 = Secretário');
	writeln('2 = Caixa');
	writeln('3 = Gerente');
	writeln('4 = Diretor');

	write('Digite o código referente ao seu cargo: ');
	
	readln(cod);
	
	write('Digite o valor do seu salário atual: ');
	
	readln(sal);

	if (cod = 1) then begin
	                                 
		aumento := sal *0.35;
		sal := sal * 1.35;
		
		writeln('Cargo: Secretário');
    writeln('Valor do aumento: ', aumento);
		writeln('Novo salário: ', sal);
  end  
  else if (cod = 2) then begin
  	
		aumento := sal *0.20;
		sal := sal * 1.20;
		
		writeln('Cargo: Caixa');
    writeln('Valor do aumento: ', aumento);
		writeln('Novo salário: ', sal);
  end	
  else if (cod = 3) then begin
  	
 		aumento := sal *0.10;
		sal:= sal * 1.10;
 		
 		writeln('Cargo: Gerente');
    writeln('Valor do aumento: ', aumento);
		writeln('Novo salário: ', sal);
  end	
 	else begin
 	
 		writeln('Cargo: Diretor');
    writeln('Valor do aumento: Sem aumento');
    
  end;
  
  readln;
 	
  
End.