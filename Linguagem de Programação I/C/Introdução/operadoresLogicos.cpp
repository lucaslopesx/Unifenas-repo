#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int num;
	printf("Digite um valor inteiro: ");
	scanf("%i",&num);
	
	printf("\n O numero %i é maior que 4 e menor que 7? \n ",num);
	if((num > 4) && (num < 7)){
		printf("Verdade!");
	}else{
		printf("Mentira!");
	}
}
