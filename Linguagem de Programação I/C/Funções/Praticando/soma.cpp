#include <stdio.h>
#include <stdlib.h>

int somar(int num1, int num2){
	int res;
	res = num1 + num2;
	return res;
}

int main(void){
	int num1,num2,res;
	printf("Digite um numero positivo: ");
	scanf("%d",&num1);
	printf("Digite outro numero positivo: ");
	scanf("%d",&num2);
	
	res = somar(num1,num2);
	
	printf("\nA soma dos dois números e igual a: %d",res);
	
	return 1;
}
