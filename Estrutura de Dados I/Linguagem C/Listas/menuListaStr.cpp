#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
#include"listaStr.h"

int main(void){

	lista l1;
	int op;
	Elem x,xi,xf;
	
	lInit(&l1);
	
	do{
		system("cls");
		printf("=========MENU=========\n");
		printf("1.Inserir\n");
		printf("2.Remover\n");
		printf("3.Contar Ocorrencias\n");
		printf("4.Mostra intervalo\n");
		printf("5.\n");
		printf("6.Sair do programa\n");
		printf("======================\n");
		printf("Lista: \n");
		lMostra(&l1);
		printf("\n======================\n");
		printf("Opcao: ");
		scanf("%d",&op);
		fflush(stdin);
		
		switch (op){
			case 1:
				printf("Entre com um elemento: ");
				gets(x);
				
				lIns(&l1,x);

				break;
			case 2:
				printf("Entre com um elemento: ");
				gets(x);
				
				if(lRem(&l1,x)){
					printf("Elemento removido com sucesso!!!\n");
				}else{
					printf("Elemento INEXISTENTE!\n");
				}
				
				system("pause");
				break;
			case 3:
				printf("Entre com um elemento: ");
				gets(x);
				
				lConta(&l1,x);
				
				system("pause");
				break;
			case 4:
				printf("Entre com o elemento inicial:");
				gets(xi);
				printf("Entre com o elemento final:");
				gets(xf);
				
				lMostra_intervalo(&l1,xi,xf);
				
				printf("\n");
				
				system("pause");
				break;
		}
		
		
		
	}while(op != 6);



}
