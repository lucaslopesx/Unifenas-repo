Program areaTrapezio ;
var area, altura, baseMaior, baseMenor :real;
Begin
writeln('Cálculo da area de um trapézio');

write('Digite a base maior:');
readln(baseMaior);

write('Digite a base menor:');
readln(baseMenor);

write('Digite a altura:');
readln(altura);

area := ((baseMaior * baseMenor)/2)*altura;

writeln('area do trapézio:',area:0:2);
readln;
  
End.