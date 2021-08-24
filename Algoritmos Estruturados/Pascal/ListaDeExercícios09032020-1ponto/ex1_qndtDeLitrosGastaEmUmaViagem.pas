Program litrosgastos ;
var velMedia, tempoGasto, distP, qntdLitrosGasta :real;
Begin
	
	write('Tempo gasto:');
	readln(tempoGasto);
	
	write('Velocidade média: ');
	readln(velMedia);
	
	distP := velMedia * tempoGasto;
	
	qntdLitrosGasta := distP / 12;
	
	write(qntdLitrosGasta:0:3);
	readln;	
	
		
  
End.