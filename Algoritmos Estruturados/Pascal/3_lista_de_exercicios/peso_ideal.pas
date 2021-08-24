Program Pzim ;
var sex :integer;
var h, pesoI:real;
Begin

	writeln('1 - Homem');
	writeln('2 - Mulher');

	write('Digite o código correspondente ao seu sexo: ');
	readln(sex);

	write('Digite sua altura: ');
	readln(h);

	if(sex = 1) then begin

  	pesoI := 72.7 * h - 58;
  	write('Seu peso ídeal é: ', pesoI);
  end	
  else begin
  
  	pesoI := 62.1 * h - 44.7;
  	write('Seu peso ídeal é: ', pesoI);
   end;
   
End.