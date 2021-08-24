#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){

	int ano_atual, ano_nascimento, idade_atual, idade_2050;
	printf("Ano atual: ");
	scanf("%d",&ano_atual);
	
	printf("Ano nascimento: ");
	scanf("%d",&ano_nascimento);
	
	idade_atual = ano_atual - ano_nascimento;
	idade_2050 = 2050 - ano_nascimento;
	
	printf("Idade atual: %d",idade_atual);
	printf("Idade 2050: %d",idade_2050);
}
