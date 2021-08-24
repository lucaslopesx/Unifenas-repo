#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main(){
	setlocale(LC_ALL,"");
	int num1,num2,result;
	
	num1 = 10;
	num2 = 6;
	
	result = (num1 + num2);
	printf("A soma é: %d", result);
	printf("\n\n");
	
	system("pause");
}
