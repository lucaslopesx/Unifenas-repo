Program Area_circulo ;
var area, raio :real;
Begin
  
  write('Digite o valor do raio:');
  readln(raio);
  
  area := PI * sqr(raio);
  
  write('A área do circulo é igual a:', area:0:4);
  readln;
  
  
End.