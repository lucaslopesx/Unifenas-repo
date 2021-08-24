#include <stdio.h>
#include <stdlib.h>

int main(void){
	int i, j, qtdMenorNota = 0, p1=0, p2=0, p3=0,k;
	float m[10][3], menorNota;
	
	
	for(i=0;i<10;i++){
		for(j=0;j<3;j++){
			printf("Aluno %d nota da prova %d: ",i+1,j+1);
			scanf("%f",&m[i][j]);
		}
	}
	
	for(i=0;i<10;i++){
		menorNota = 10;
		k=0;
		for(j=0;j<3;j++){
			if(m[i][j] < menorNota){
				menorNota = m[i][j];
			}
			printf("\nO aluno %d foi com %.2f",i+1,m[i][j]);
		}
		if(menorNota == m[i][k] && k==0){
			p1++;
			k++;
		}else if(menorNota == m[i][k] && k==1){
			p2++;
			k++;
		}else if(menorNota == m[i][k] && k==2){
			p3++;
			k++;
		}
		printf("\nA menor nota do aluno %d foi: %.2f\n       %d",i+1,menorNota,k);
	}
	
	printf("Quantidade de menores notas na prova 1: %d",p1);
	printf("\nQuantidade de menores notas na prova 2: %d",p2);
	printf("\nQuantidade de menores notas na prova 3: %d",p3);

}
