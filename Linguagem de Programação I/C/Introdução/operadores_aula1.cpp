#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

main(){
	setlocale(LC_ALL,"");
		
	int num1,num2;
	
	num1 = 10;
	num2 = 4;
	
	printf("Resultado adi��o: %i",num1 + num2);
	printf("\n");
	printf("Resultado subtra��o: %i",num1 - num2);
	printf("\n");
	printf("Resultado multiplica��o: %i",num1 * num2);
	printf("\n");
	
}
