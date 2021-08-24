#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include "filaProf.h"


int main(void)
{
	Fila F1;
	int OP,X;
	setlocale(LC_ALL,"");
	Qinit(&F1);
	do
	{
		system("cls");
		printf("===============Filas============\n");
		printf("1.Inserir\n");
		printf("2.Remover\n");
		printf("3.Mostrar\n");
		printf("4.\n");
		printf("5.\n");
		printf("6.\n");
		printf("7.\n");
		printf("8.Sair\n");
		printf("================================\n");
		printf("Sua opção:");
		scanf("%d",&OP);
		switch (OP)
		{
			case 1:
				if (Qisfull(&F1))
				{
					printf("A fila está cheia!\n");
					system("pause");
				}
				else
				{
					printf("Informe o elemento:");
					scanf("%d",&X);
					Enqueue(&F1,X);
			    }
				break;
			case 2:
				if (!Qisempty(&F1))
				{
					X=Dequeue(&F1);
					printf("Elemento removido:%d\n",X);
				}
				else
				{
					printf("A fila está vazia!\n");
				}
				system("pause");
				break;
			case 4:
				printf("Informe o elemento: ");
				scanf("%d",&X);
				
				system("pause");
				break;
		}
	} while (OP!=8);
	
	return 1;
	
}

