#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){

int x,x1,x2,x3,x4;

printf("Digite um numero positivo e maior do que 0: ");
scanf("%d",&x);


x1 = pow(x,2);
x2 = pow(x,3);
x3 = sqrt(x);
x4 = cbrt(x);

printf("Ao quadrado: %d",x1);
printf("\nAo cubo: %d",x2);
printf("\nRaiz quadrada: %d",x3);
printf("\nRaiz cubica: %d",x4);

return 1;
}
