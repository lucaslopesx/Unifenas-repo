#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	char op;
	
	float res, comp, larg;
	res = 0;
	
	do{
		printf("Digite o comprimento: ");
		scanf("%f",&comp);
		fflush(stdin);
		printf("Digite a largura: ");
		scanf("%f",&larg);
		fflush(stdin);
		printf("Deseja cadastrar mais um comodo? (s/n): ");
		scanf("%c",&op);
		
		res = res + (comp*larg);
	}while(op != 'n');
	
	printf("A area total da casa é: %.2f", res);

}
