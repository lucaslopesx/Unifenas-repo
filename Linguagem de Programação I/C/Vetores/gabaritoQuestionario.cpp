#include <stdio.h>
#include <stdlib.h>

int main(void){
	int i,result=0;
	char res[10],gab[10];
	
	for(i=0;i<10;i++){
		printf("Digite o gabarito da %d questao: ",i);
		scanf("%c",&gab[i]);
		fflush(stdin);
	}
	
	for(i=0;i<10;i++){
		printf("Digite a resposta da %d questao: ",i);
		scanf("%c",&res[i]);
		fflush(stdin);
	}
	
	for(i=0;i<10;i++){
		if(res[i]==gab[i]){
			result++;
		}
	}
	
	printf("O aluno acertou %d questoes!",result);
}
