PROGRAM quadro_parede;
VAR X, Y, Z : REAL;
BEGIN

WRITE('Entre com o tamanho da escada: ');
READLN(Z);

WRITE('Entre com a altura em que deseja pregar o quadro: ');
READLN(X);

Y := SQRT(SQR(Z) -SQR(X));

WRITELN('A distancia em que a escada devera ficar e: ',Y:0:2);
READLN;

END.