#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

int x;

printf("Digite um número: ");
scanf("%d",&x);

if(x%5 == 0){
	printf("\nMultíplo de 5!");
}else{
	printf("\nNão é multíplo de 5!");
}
}
