#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

float x;

printf("Digite um n�mero: ");
scanf("%f",&x);

if(x>0){
	printf("\nRaiz quadrada: %.2f",sqrt(x));
}else{
	printf("\nN�mero inv�lido!");
}
return 1;

}
