#include <stdio.h>
#include <stdlib.h>
#include "pilha.h"

int main(void){
	
	pilha pp,pi;
	int n,x,i;
	
	init(&pp);
	init(&pi);
	
	printf("Quantidade de numeros: ");
	scanf("%d",&n);
	
	for(i=0;i<n;i++){
		printf("%d numero:",i+1);
		scanf("%d",&x);
		if(x % 2 == 0){
			push(&pp,x);
		}else{
			push(&pi,x);
		}
	}
	printf("\nImpares: ");
	while(!empty(&pi)){
		printf("%d ",pop(&pi));
	}
	printf("\n\nPares: ");
	while(!empty(&pp)){
		printf("%d ",pop(&pp));
	}
	return 1;
}











