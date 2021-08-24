#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

main(){
	setlocale(LC_ALL,"");
	
	int num1,num2,res;
	
	printf("Digite o 1° valor: ");
	scanf("%i",&num1);
	printf("Digite o 2° valor: ");
	scanf("%i",&num2);
	
	res = num1 + num2;
	
	printf("\n");
	printf("O resultado da soma é: %i",res);
	
}
