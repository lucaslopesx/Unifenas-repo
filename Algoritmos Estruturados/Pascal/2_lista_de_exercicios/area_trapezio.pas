Program areaTrapezio ;
var area, altura, baseMaior, baseMenor :real;
Begin
writeln('C�lculo da area de um trap�zio');

write('Digite a base maior:');
readln(baseMaior);

write('Digite a base menor:');
readln(baseMenor);

write('Digite a altura:');
readln(altura);

area := ((baseMaior * baseMenor)/2)*altura;

writeln('area do trap�zio:',area:0:2);
readln;
  
End.