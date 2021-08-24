#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include "Filas.h"

int main(void){
	Fila F1;
	int OP,X;
	Qinity(&F1);
	setlocale(LC_ALL,"");
	do{
		system("cls");
		printf("===========FILAS======\n");
		printf("1.Inserir\n");
		printf("2.Remover \n");
		printf("3.Mostrar \n");
		printf("4.Ocorrencia de um elemento\n");
		printf("5.\n");
		printf("6.\n");
		printf("7.\n");
		printf("8.Sair\n");
		printf("======================\n");
		printf("Fila: ");
		Mostra(&F1);
		printf("\n");
		printf("=======================\n");
		printf("Sua opção:");
		scanf("%d",&OP);
		
		switch(OP){
			
			case 1: 
				if(Qisfull(&F1)){
				printf("Fila cheia.\n");
				system("pause");
			}
				else{				
					printf("Insira um elemento: ");
				scanf("%d",&X);
				Enqueue(&F1,X);
			}
					
				break;
			case 2: 
				if(!Qisempty(&F1)){
				
				X=Dequeue(&F1);
				printf("Removido.%d \n",X);
				system("pause");
				}
				else{
					printf("Fila vazia.\n");
					system("pause");
				}
				break;
			case 3: 
				Mostra(&F1);
				printf("\n");
				system("pause");
				break;
			
			case 4:
				printf("Digite um elemento: ");
				scanf("%d",&X);
				
				printf("O elemento %d ocorre %d na fila.",X,Conta(&F1,X));
				system("pause");
			break;
			
		}
					
	}while(OP!=8);
	
	return 1;
}
