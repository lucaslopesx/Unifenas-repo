Program Exemplo_extenso;
var N:integer;
Begin
	write('Entre com um número:');
	readln(N);
  if N=1 then
		writeln('UM')
	else
		if N=2 then
			writeln('DOIS')
		else
			if N=3 then
				writeln('TRÊS')
			else
				if N=4 then
					writeln('QUATRO')
				else
					if N=5 then
						writeln('CINCO')
					else
						if N=6 then
							writeln('SEIS')
						else
							if N=7 then
								writeln('SETE')
							else
								if N=8 then
									writeln('OITO')
								else
									if N=9 then
										writeln('NOVE')
									else
										if N=0 then
											writeln('ZERO')
										else
											writeln('ENTRE COM NÚMEROS DE 0 A 9');
	write('Tecle enter para sair');
	readln;  
End.