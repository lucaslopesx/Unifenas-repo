#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <locale.h>

typedef struct {
	int matricula;
	char nome[30];
	float nota[4];
}aluno;

void ledados(aluno *preg){
	int i;
	
	printf("Digite a matrícula: ");
	scanf("%d",&preg->matricula);
	
	fflush(stdin);
	
	printf("Entre com o nome: ");
	gets(preg->nome);
	
	for(i=0;i<=3;i++){
		printf("Entre com a %d° nota: ",i+1);
		scanf("%f",&preg->nota[i]);
		fflush(stdin);	
	}
}

float calcmedia(aluno *preg){
	int i;
	float soma = 0;
	for(i=0;i<=3;i++){
		soma += preg->nota[i];
	}
	return soma/4;
	
}

int main(void){
	setlocale(LC_ALL,"");
	
	int i;
	aluno reg;
	float m;
	
	ledados(&reg);
	
	printf("Matrícula: %d\n",reg.matricula);
	printf("Nome.....: %s\n",reg.nome);
	
	for(i=0;i<=3;i++){
		printf("Nota %d: %.2f\n",i+1,reg.nota[i]);	
	}
	
	m = calcmedia(&reg);
	
	printf("A média das notas é: %.2f",m);
	return 1;	
}
