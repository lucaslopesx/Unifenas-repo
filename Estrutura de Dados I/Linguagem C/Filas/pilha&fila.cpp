#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include "filas.h"
#include "pilha.h"

int main(void){

	int op,x;
	pilha p;
	fila fi,fp;
	
	init(&p);
	qInit(&fi);
	qInit(&fp);
	;
	do{	
		printf("Digite um numero: ");
		scanf("%d",&op);
		if(op%2==0){
			enQueue(&fp,op);
		}else{
			enQueue(&fi,op);
		}			
	}while(op!=0);
	
	
	printf("Elementos das filas:");
	while(!queueIsEmpty(&fi) or !queueIsEmpty(&fp)){
	
		if(!queueIsEmpty(&fi)){
				x = deQueue(&fi);
				printf("\n %d ",x);
				if(x > 0){
					push(&p,x);
				}
		}
		if(!queueIsEmpty(&fp)){
				x = deQueue(&fp);
				printf("\n %d ",x);
				if(x > 0){
					push(&p,x);
				}
		}	
	
	} 
		
		

	printf("\nPilha p1: ");
	while(not empty(&p)){
		printf("\n %d ",pop(&p));
	}
	
	printf("\n");
	
	return 1;

}
