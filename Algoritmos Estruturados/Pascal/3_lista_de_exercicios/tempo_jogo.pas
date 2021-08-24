Program Questao05 ;
var HI,HF,MI,MF,TH,TM :integer;
Begin
	write('Entre com a hora de início:');
	readln(HI);
	write('Entre com os minutos de início:');
	readln(MI);
	
	write('Entre com a hora de final:');
	readln(HF);
	write('Entre com os minutos de finais:');
	readln(MF);
	
	if HF<HI then
		TH:=HF+24-HI
	else
		TH:=HF-HI;
		
		
	if MF<MI then
		TM:=MF+60-MI
	else
		TM:=MF-MI;
	
	writeln('O jogo teve ',TH,' horas e ',TM,' minutos');
	
	readln;
End.