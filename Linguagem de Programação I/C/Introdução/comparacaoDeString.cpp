#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(void){
	char nome[10];
	
	printf("Digite o nome: ");
	scanf("%s",&nome);
	
	if(stcmp(nome,"Ana") == 0){
		printf("� igual!");
	}else{
		printf("N�o � igual!\n")
	}
	
	return 1;
}
