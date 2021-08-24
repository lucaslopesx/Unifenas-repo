#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int i, tAlt;
	float alt, aux, maior;
	
	printf("Mostra maior altura\n");
	
	printf("Digite o total de alturas: ");
	scanf("%d",&tAlt);
	
	maior = 0;
	for(i=0;i<tAlt;i++){
		printf("Digite uma altura: ");
		scanf("%f",&alt);
		if(alt > maior){
			maior = alt;
		}
	}
	
	printf("\nMaior altura: %.2f",maior);
	
	
}
