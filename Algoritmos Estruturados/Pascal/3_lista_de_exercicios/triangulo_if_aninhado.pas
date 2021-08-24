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
  	
  	write('É um triangulo isósceles ')
  	
  	else if ((Z = X) and (Z = Y) and (X = Y) ) then
  	
  	write('É um triângulo equilátero')
  	
  	else
  	
  	write('É um triângulo escaleno')
  
  
  else 
	writeln ('Não é um triângulo!!!');
  
  
End.