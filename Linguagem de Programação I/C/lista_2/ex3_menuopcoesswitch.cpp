#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");
int op;
float x,y;

printf("1. Somar dois n�meros.\n2. Raiz quadrada de um n�mero.\n");

printf("\nDigite a op��o desejada: ");
scanf("%d",&op);

switch(op){
	
	case 1:
		printf("1 N�mero: ");
		scanf("%f",&x);
		printf("2 N�mero: ");
		scanf("%f",&y);
		printf("\nA soma dos dois valores �: %.2f",x+y);
		break;
	case 2:
		printf("Digite um n�mero: ");
		scanf("%f",&x);
		printf("\nA raiz quadrada �: %.2f",sqrt(x));
}
return 1;
}
