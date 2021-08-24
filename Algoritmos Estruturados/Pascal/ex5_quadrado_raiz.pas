Program ex5_quadrado_raiz ;
var num:real;
Begin
  
  write('Digite um número positivo e maior do que 0:');
  readln(num);
  
  //res1 := sqr(num);
  //res2 := sqrt(num);
  
  writeln('Esse é o número ',num:0:0,' elevado ao quadrado: ',sqr(num):0:2);
  writeln('Essa é a raiz quadrada do número ',num:0:0,': ',sqrt(num):0:2);
  
  readln;
  
End.