#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

int x;

printf("Digite um n�mero: ");
scanf("%d",&x);

if(x%5 == 0){
	printf("\nMult�plo de 5!");
}else{
	printf("\nN�o � mult�plo de 5!");
}
}
