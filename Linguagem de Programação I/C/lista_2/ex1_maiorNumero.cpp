#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

int x,y;

printf("Digite um numero: ");
scanf("%d",&x);
printf("Digite outro numero: ");
scanf("%d",&y);

if(x>y){
	printf("O n�mero %d � maior que %d",x,y);
}else if(x==y){
	printf("Os n�meros %d e %d s�o iguais!",x,y);
}else{
	printf("O n�mero %d � maior que %d",y,x);
}
return 1;

}
