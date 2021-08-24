#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

char par(int n){
	if(n%2==0){
		return 1;
	}else{
		return 0;
	}
}

int main(void){
	int a;
	setlocale(LC_ALL,"");
	printf("PAR OU IMPAR!\n\n");
	printf("Digite um número: ");
	scanf("%d",&a);
	
	if(par(a)){
		printf("\nO número é par!");
	}else{
		printf("\nO número é ímpar!");
	}
}
