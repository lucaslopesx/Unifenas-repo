#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>  

typedef struct registro{
	int num, saldo;
	char nome;
};

int main(void){
	setlocale(LC_ALL,"");
	
	registro conta[15];
	int i, op, posi, achou, num_conta, menor_saldo;
	char nome_cliente;

	for(i=1;i<16;i++){
		conta[i].num = 0;
		conta[i].nome = ' ';
		conta[i].saldo = 0;
	}
	posi = 1;
	
	do{
		system("cls");
		printf("\n===========================");
		printf("\n1.Cadastrar contas");
		printf("\n2.Visualizar contas de determinado cliente");
		printf("\n3.Excluir conta de menor saldo");
		printf("\n4.Sair");
		printf("\n===========================");
		printf("\n\nDigite sua opção: ");
		scanf("%d",&op);
		if(op>4 || op<1){
			printf("\n Opção inválida");
		}else{
			switch(op){
				case 1:
					if(posi>15){
						printf("\nLimite de contas atingido!!!");
					}else{
						achou = 0;
						printf("Digite o numero da conta a ser incluida: ");
						scanf("%d",&num_conta);
						
						for(i=1;i<16;i++){
							if(num_conta == conta[i].num){
								achou=1;
							}
						}
						
						if(achou == 1){
							printf("Conta ja cadastrada com esse número");
						}else{
							conta[posi].num = num_conta;
							printf("Digite o nome do cliente: ");
							scanf("%s",&conta[posi].nome);
							
							printf("Digite o saldo do cliente: ");
							scanf("%d",&conta[posi].saldo);
							
							printf("\n\nConta cadastrada com sucesso!!");
							posi++;
						}
					}
					system("pause");
					break;
				case 2:
					printf("Digite o nome do cliente a ser consultado: ");
					scanf("%s",&nome_cliente);
					achou = 0;
					
					for(i=0;i<16;i++){
						if(conta[i].nome == nome_cliente){
							printf("\nConta: %d",conta[i].num);
							printf("\nSaldo: %d",conta[i].saldo);
							achou = 1;
						} 
					}
					
					if(achou = 0){
						printf("\nNão existe conta cadastrada para este cliente!!");
					}
					
					system("pause");
					break;
				case 3:
					if(posi == 1){
						printf("\nNenhuma conta foi cadastrada!!");
					}else{
						menor_saldo = conta[1].saldo;
						achou = 1;
						
						i=2;
						
						while(i<posi){
							if(conta[i].saldo < menor_saldo){
								menor_saldo = conta[i].saldo;
								achou = i;
							}
							i++;
						}
						for(i=achou;i<16;i++){
							conta[i-1].num = conta[i].num;
							conta[i-1].nome = conta[i].nome;
							conta[i-1].saldo = conta[i].saldo;
						}
						printf("Conta excluída com sucesso!");
						posi--;
					}
					system("pause");
					break;
			}	
		}
		
	}while(op!=4);
	
	return 1;
}
