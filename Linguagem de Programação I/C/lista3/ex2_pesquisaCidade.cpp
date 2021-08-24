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
		printf("\nDigite o código da cidade: ");
		scanf("%d",&cod[i]);
	
		printf("Números de veículos de passeio da cidade:");
		scanf("%d",&npas[i]);
	
		printf("Número de acidentes de trânsito: ");
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
	
	
	printf("\nCidade código->%d possui maior número de acidentes: %d\n", codMaiorNumAci, maiorNumAci);
	printf("Cidade código->%d possui menor número de acidentes: %d\n", codMenorNumAci, menorNumAci);
	printf("Média de veículos nas 5 cidades: %.2f\n",mediaPas);
	printf("Média de acidentes nas cidades com menos de 2000 veiculos de passeio: %.2f", mediaAciMenor2000);

}
