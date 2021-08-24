#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int num, soma;
	printf("Digite um valor: ");
	scanf("%d",&num);
	soma = 0;
	
	while(num!=0){
		soma = soma + num;
		printf("Digite um valor: ");
		scanf("%d",&num);
	}
	
	printf("A soma: %d\n",soma);
	
	return 1;
}
