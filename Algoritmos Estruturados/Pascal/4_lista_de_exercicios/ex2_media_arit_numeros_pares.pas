Program Pzim ;
var Q,VALOR,SOMA :integer;
var MEDIA :real;	 
Begin

	writeln('M�dia aritm�tica entre n�meros pares');
	writeln('Para parar o programa [ TECLE 0 E D� ENTER ]');
	writeln('');

	write('Entre com um valor: ');
	readln(VALOR);
	
	SOMA:= 0;
	Q:= 0;
	while VALOR <> 0 do
		begin
			if ( VALOR mod 2 = 0 ) then 
				begin
					SOMA:= SOMA + VALOR;
					Q:= Q + 1;
				end;
   		write('Entre com um valor: ');
			readln(VALOR);
		end;
		
		
	writeln('M�dia aritm�tica entre os valores: ',SOMA/Q:0:2);
                                   	
  write('Tecle <enter> para sair');
  readln();
  
End.