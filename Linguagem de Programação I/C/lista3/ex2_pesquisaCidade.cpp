#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int cod[5], npas[5], naci[5], i, j, maiorNumAci, codMaiorNumAci, menorNumAci, codMenorNumAci, soma=0, somaAci=0;
	i=0;
	j=0;
	float mediaPas, mediaAciMenor2000;
	
	while(i<5){
		printf("\nDigite o c�digo da cidade: ");
		scanf("%d",&cod[i]);
	
		printf("N�meros de ve�culos de passeio da cidade:");
		scanf("%d",&npas[i]);
	
		printf("N�mero de acidentes de tr�nsito: ");
		scanf("%d",&naci[i]);
		
		i++;
	}

	maiorNumAci=0;	
	for(i=0;i<5;i++){
		if(naci[i]>maiorNumAci){
			maiorNumAci = naci[i];
			codMaiorNumAci = cod[i];
			menorNumAci = naci[i];
		}
		
		soma += npas[i];
		
		if(npas[i]<2000){
			somaAci += naci[i];
			j++;
		}
	}
	for(i=0;i<5;i++){
		if(naci[i]<menorNumAci){
			menorNumAci = naci[i];
			codMenorNumAci = cod[i];
		}
	}
	mediaPas = soma/5;
	mediaAciMenor2000 = somaAci/j;
	
	
	printf("\nCidade c�digo->%d possui maior n�mero de acidentes: %d\n", codMaiorNumAci, maiorNumAci);
	printf("Cidade c�digo->%d possui menor n�mero de acidentes: %d\n", codMenorNumAci, menorNumAci);
	printf("M�dia de ve�culos nas 5 cidades: %.2f\n",mediaPas);
	printf("M�dia de acidentes nas cidades com menos de 2000 veiculos de passeio: %.2f", mediaAciMenor2000);

}
