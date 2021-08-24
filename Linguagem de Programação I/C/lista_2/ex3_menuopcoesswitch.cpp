#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");
int op;
float x,y;

printf("1. Somar dois números.\n2. Raiz quadrada de um número.\n");

printf("\nDigite a opção desejada: ");
scanf("%d",&op);

switch(op){
	
	case 1:
		printf("1 Número: ");
		scanf("%f",&x);
		printf("2 Número: ");
		scanf("%f",&y);
		printf("\nA soma dos dois valores é: %.2f",x+y);
		break;
	case 2:
		printf("Digite um número: ");
		scanf("%f",&x);
		printf("\nA raiz quadrada é: %.2f",sqrt(x));
}
return 1;
}
