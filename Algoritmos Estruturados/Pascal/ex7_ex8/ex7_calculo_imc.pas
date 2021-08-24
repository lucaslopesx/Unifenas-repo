Program Pzim ;
var peso, altura, imc :real;
Begin

	writeln('---Cálculo de IMC---');
	
	write('Digite seu peso: ');
	readln(peso);
	
	write('Digite sua altura: ');
	readln(altura);
	
	imc := peso / (altura*2);
	
	writeln('Seu IMC é: ',imc:0:1);
	
	if ( imc < 18.5 ) then begin
	
		writeln('Abaixo do peso')
   
 end else if (imc <= 25) then begin
 		
 		writeln('Peso normal');
 
 end else if (imc <= 30) then begin
 
 		writeln('Acima do peso');
 
 end else begin
 
  	writeln('Obeso');
   
 end;
	
  
End.