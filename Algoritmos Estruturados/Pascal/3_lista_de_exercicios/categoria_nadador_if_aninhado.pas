Program Pzim ;
var idade :integer; 
Begin

  writeln('Categoria do nadador!');
	
	write('Digite sua idade: ');
	readln(idade);
	
	if ( idade >= 5) then
  
  	if (idade <= 10) then
  	
  	write('Categoria: Infantil')
  	
  	else if ((idade > 10) and (idade <= 16) ) then
  	
  	write('Categoria: Juvenil')
  	
  	else if ((idade > 16) and (idade <=30)) then
  	
  	write('Categoria: Adulto')
  
  	else 
  	
  	write('Categoria: Sênior')
  
  else 
	writeln ('ERRO');
  
End.