#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

main(){
	setlocale(LC_ALL,"");
		
	int num1,num2;
	
	num1 = 10;
	num2 = 4;
	
	printf("Resultado adição: %i",num1 + num2);
	printf("\n");
	printf("Resultado subtração: %i",num1 - num2);
	printf("\n");
	printf("Resultado multiplicação: %i",num1 * num2);
	printf("\n");
	
}
