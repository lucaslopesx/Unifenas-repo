#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

struct registro{
	int num_avi;
	char nome[30];
};


int main(void){
	setlocale(LC_ALL,"");
	registro reservas[60];
	int i,pos_livre,op,achou,numero,posi;
	int avi[4],lug[4];
	char nome[30];
	
	for (i=1;i<5;i++){
		avi[i] = 0;
		lug[i] = 0;
	}
	
	for(i=1;i<61;i++){
		reservas[i].num_avi = 0;
		reservas[i].nome[i] = ' ';	
	}
	pos_livre = 1;
	
	do{
		system("cls");
		printf("\n=======================================================");
		printf("\n1 – Cadastrar os números dos aviões");
		printf("\n2 – Cadastrar os lugares disponiveis em cada aviao");
		printf("\n3 – Reservar passagem");
		printf("\n4 – Consultar pelo número do aviao");
		printf("\n5 – Consultar pelo nome do passageiro");
		printf("\n6 – Finalizar");
		printf("\n=======================================================");
		
		printf("\nDigite a opção desejada: ");
		scanf("%d",&op);
		fflush(stdin);
		
		switch(op){
			case 1:
				for (i=1;i<5;i++){
					printf("\nDigite o numero do %d aviao: ",i);
					scanf("%d",&avi[i]);	
				}
				break;
			case 2:
				for (i=1;i<5;i++){
					printf("Digite o numero de lugares disponiveis: ");
					scanf("%d",&lug[i]);
				}	
				break;
			case  3: 
				printf("Digite o número do avião no qual deseja efetuar a reserva");
				scanf("%d",&numero);
				fflush(stdin);
				
				if(pos_livre>60){
					printf("Reservas em todos os aviões esgotadas");
				}else{
					achou = 0;
					for(i=1;i<5;i++){
						if(avi[i]==numero){
							achou = 1;
							posi = 1;
						}
					}
					if(achou == 0){
						printf("“Este avião não existe");
					}else if(lug[posi] == 0){
						printf("Aviao lotado!!!!");
					}else{
						printf("Digite o nome do passageiro: ");
						gets(nome);
						fflush(stdin);
						
						reservas[pos_livre].num_avi = numero;
						strcpy(reservas[pos_livre].nome, nome);
//						reservas[pos_livre].nome = nome;
						
						printf("Reserva efetuada com sucesso");
						
						pos_livre++;
						lug[posi]--;
						
					}
				}
				system("pause");
				break;
			case 4:
				
				printf("Digite o numero do aviao para consulta: ");
				scanf("%d",&numero);
				achou = 0;
				fflush(stdin);
				
				for(i=1;i<5;i++){
					if(avi[i] == numero){
						achou = 1;
					}
					if(achou = 0){
						printf("Este aviao nao existe");
					}else{
						achou = 0;
						for(i=0;i<(pos_livre-1);i++){
							if(reservas[i].num_avi == numero){
								printf("%d",reservas[i].nome);
								achou = 1;
							}
						}
						if(achou == 0){
							printf("Nenhuma reserva está cadastrada para este avião");
							
						}
					}
					
				}
				system("pause");
				break;
			case 5: 
				
				printf("Digite o nome do passageiro para consultar as reservas: ");
				gets(nome);
				fflush(stdin);
				
				achou = 0;
				
				for(i=0;i<(pos_livre-1);i++){
					if(reservas[i].nome == nome){
						printf("%d",reservas[i].num_avi);
						achou = 1;
					}
					if(achou == 0){
						printf("Nenhuma reserva esta cadastrada!");
					}
				}
				system("pause");
				break;
		}
		
	}while(op!=6);
	
	return 1;
}










