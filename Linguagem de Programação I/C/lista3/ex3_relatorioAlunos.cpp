#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	float nota1[6], nota2[6], media[6], mediaTotal;
	int i, aprovado=0, reprovado=0, exame=0, somaTotal;
	
	for(i=0;i<6;i++){
		printf("\nAluno: %d\n",i);
		printf("Digite a primeira nota: ");
		scanf("%f",&nota1[i]);
		printf("Digite a segunda nota: ");
		scanf("%f",&nota2[i]);	
	}
	
	for(i=0;i<6;i++){
		media[i] = (nota1[i]+nota2[i])/2;
		printf("Média do aluno %d: %.2f\n", i, media[i]);
	}
	
	for(i=0;i<6;i++){
		if(media[i]<3){
			reprovado++;
		}else if(media[i]<7){
			exame++;
		}else{
			aprovado++;
		}
	}
	
	for(i=0;i<6;i++){
		somaTotal += media[i];
		mediaTotal = somaTotal/6;
	}
	
	
	printf("\n");
	
	printf("\nAté 3 -> Reprovado\nEntre 3 e 7 -> Exame\nDe 7 para cima -> Aprovado\n\n");
	printf("\nTotal de aprovados: %d\n",aprovado);
	printf("Total de em exame: %d\n",exame);
	printf("Total de reprovados: %d\n",reprovado);
	printf("Média da classe: %.2f",mediaTotal);
}
