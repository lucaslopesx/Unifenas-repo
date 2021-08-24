#include <iostream>

int main()
{
	int tam;
	int i;
	int vet[100];
	printf("Tamanho do vetor:");
	scanf("%d",&tam);
	
	//int *vet= new int[tam];
	
	for (i=0;i<tam;i++)
	{
		printf("Entre com o %do numero:",i+1);
		scanf("%d",&vet[i]);
	}
	
	for (i=0;i<tam;i++)
	{
		printf("Posicao %d = %d \n",i,vet[i]);
	}
	
	return 1;
}
