#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

float x;

printf("Digite um número: ");
scanf("%f",&x);

if(x>0){
	printf("\nRaiz quadrada: %.2f",sqrt(x));
}else{
	printf("\nNúmero inválido!");
}
return 1;

}
