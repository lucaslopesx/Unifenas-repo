#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int soma(int *vet, int x){
	int s, i;
	s=0;
	for(i=0;i<x;i++){
		s = s + vet[i];
	}
	return s;
}

float media(int *vet, int x){
	int i, soma;
	soma=0;
	for(i=0;i<x;i++){
		soma = soma + vet[i];
	} 
	return soma/x;
}

int main(void){
setlocale(LC_ALL,"");

int v[20];
int i,x;

printf("Entre com a quantidade de valores: ");
scanf("%d",&x);

for(i=0;i<x;i++){
	printf("Entre com o %d° valor: ",i);
	scanf("%d",&v[i]);
}

printf("\nSoma do vetor:%d \n",soma(v,x));
printf("\nMedia do vetor:%.2f",media(v,x));

return 1;

}
