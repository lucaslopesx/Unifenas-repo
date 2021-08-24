#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>
#include <time.h>

int main(void){
setlocale(LC_ALL,"");

int op;
float sal;

printf("Aumento de sálario dos funcionários");
printf("\n\n1-Escrituário");
printf("\n2-Secretário");
printf("\n3-Caixa");
printf("\n4-Gerente");
printf("\n5-Diretor");

printf("\n\nDigite a opção desejada: ");
scanf("%d",&op);
switch(op){
	case 1:
		printf("\nDigite o sálario: ");
		scanf("%f",&sal);
		sal = sal * 1.5;
		printf("\nO novo sálario agora é de: %.2f",sal);
		break;
	case 2:
		printf("\nDigite o sálario: ");
		scanf("%f",&sal);
		sal = sal * 1.35;
		printf("\nO novo sálario agora é de: %.2f",sal);
		break;
	case 3:
		printf("\nDigite o sálario: ");
		scanf("%f",&sal);
		sal = sal * 1.20;
		printf("\nO novo sálario agora é de: %.2f",sal);
		break;
	case 4:
		printf("\nDigite o sálario: ");
		scanf("%f",&sal);
		sal = sal * 1.10;
		printf("\nO novo sálario agora é de: %.2f",sal);
		break;
	case 5:
		printf("\nO salario nao muda",sal);
		break;
}


}
