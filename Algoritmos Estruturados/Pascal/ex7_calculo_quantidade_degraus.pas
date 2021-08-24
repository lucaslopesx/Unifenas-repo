Program calculo_quantidade_degraus ;
var res, alturaDegrau, alturaDesejada :real;
Begin

write('Digite a altura do degrau: ');
readln(alturaDegrau);

write('Digite a altura desejada:');
readln(alturaDesejada);

res := alturaDesejada/alturaDegrau;

writeln('A escada terá: ',res:0:2,' degraus');
readln;

  
End.