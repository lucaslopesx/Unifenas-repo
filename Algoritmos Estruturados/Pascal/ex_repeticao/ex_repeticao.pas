Program Pzim ;
var ID, P40, I :integer;
		ALT, PESO, SA :real;
Begin

	SA:= 0;

	for I:= 1 to 5 do
		begin
			clrscr;
			writeln('Cadastro número: ',I);
			write('Entre com a idade: ');
			readln(ID);
			write('Entre com a altura: ');
			readln(ALT);
			write('Entre com o peso: ');
			readln(PESO);
			
			SA:= SA + ALT;
			
			IF ( PESO < 40) then
				P40:= P40+1;
		end;
		writeln('Média das alturas: ', SA/5:0:2);
		writeln('Porcentagem de pessoas com peso menor que 40kg: ',P40/5*100:0:2,'%');
		writeln('Número de pessoas com peso menor que 40kg: ',P40)
  
End.