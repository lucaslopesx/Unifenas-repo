Program Pzim ;
var X, Y, Z :real;
Begin
  write('Valor de X: ');
  readln(X);
  write('Valor de Y: ');
  readln(Y);
  write('Valor de Z: ');
  readln(Z);
  

  
  
  if ( (X < (Y+Z)) and (Y < (Z + X)) and (Z < (Y + X)) and (Z>0) and (Y>0) and (X>0)) then
  
  	if ( ((X = Z) and (Z <> Y)) or ((Z = Y) and (Z <> X)) or ((X = Y) and (X <> Z)) ) then
  	
  	write('� um triangulo is�sceles ')
  	
  	else if ((Z = X) and (Z = Y) and (X = Y) ) then
  	
  	write('� um tri�ngulo equil�tero')
  	
  	else
  	
  	write('� um tri�ngulo escaleno')
  
  
  else 
	writeln ('N�o � um tri�ngulo!!!');
  
  
End.