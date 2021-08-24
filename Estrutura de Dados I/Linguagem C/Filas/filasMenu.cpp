#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include "filas.h"
int main(void){
	fila f1;
	
	int op,x;

	setlocale(LC_ALL,"");
	qInit(&f1);
	
	do{
		system("cls");
		printf("=====================Filas=====================\n");
		printf("1.Inserir\n");
		printf("2.Remover\n");
		printf("3.-------\n");
		printf("4.Conta Ocorências\n");
		printf("5.Inserir no inicio\n");
		printf("6.Remover do final\n");
		printf("7.\n");
		printf("8.Sair\n");
		printf("======================\n");
		printf("Fila: ");
		mostra(&f1);
		printf("\n");
		printf("=======================\n");
		printf("Sua opção: ");
		scanf("%d",&op);
		
		switch (op){
			case 1:
				if(queueIsFull(&f1)){
					printf("Fila cheia!\n");
					system("pause");
				}else{
					printf("Informe o elemento: ");
					scanf("%d",&x);
					enQueue(&f1,x);
				}	
				
				break;
			case 2:
				if(!queueIsEmpty(&f1)){
					x = deQueue(&f1);
					printf("Elemento removido:%d\n!",x);	
				}else{
					printf("Fila vazia!!!\n");
				}
				system("pause");
				break;
			case 3:
				printf("Fila: ");
				break;
			case 4:
				printf("Informe o elemento: ");
				scanf("%d",&x);
				
				printf("O elemento %d ocorre %d vezes na fila.\n",x,conta(&f1,x));		
				
				system("pause");
				break;
			case 5:
				if(queueIsFull(&f1)){
					printf("Fila cheia!\n");
					system("pause");
				}else{
					printf("Informe o elemento a ser inserido no começo da fila: ");
					scanf("%d",&x);
					enQueueInicio(&f1,x);
				}	

				break;
			case 6:
				if(!queueIsEmpty(&f1)){
					x = deQueueFim(&f1);
					printf("Elemento removido do final da fila:%d\n!",x);	
				}else{
					printf("Fila vazia!!!\n");
				}
				system("pause");
				break;
		}
	}while(op != 8);

	return 1;
}
