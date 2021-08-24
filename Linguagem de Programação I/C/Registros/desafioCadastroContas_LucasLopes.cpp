 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <string.h>
 
 
  struct conta{
 	char nome[50];
 	int num;
 	float saldo;
 };
 
 int main(){
 	setlocale(LC_ALL,"");
 	int op,i,cont=0,j,posi=0,qn=0,a=0,aux,cont2=0;
 	int repeticao_num[15];
 	char x[50];
 	char fim[]={'\0'};
 	float menor_valor;
 	conta Dados[15];
 	do{
	system("cls");
 	printf("================MENU DE OPÇÕES=============\n");
 	printf("1.Cadastrar contas.\n");
 	printf("2.Visualizar todas contas do clientes.\n");
 	printf("3.Excluir conta com menor saldo.\n");
 	printf("4.Sair.\n");
 	scanf("%d",&op);
 	printf("=============================================\n");
 		switch(op){
		 
 		case 1:
 		
 			printf("Entre com o nome %d cliente: ",i+1);
 			scanf("%s",Dados[i].nome);
 			
// 			if(cont2!=0){
// 			printf("\nRegistre um número para a %d.a conta : ",i+1);
// 			scanf("%d",&Dados[i].num); 		//parte original
// 			repeticao_num[i]=Dados[i].num;
// 			}
 			//repeticao_num[i]=Dados[i].num;
 			if(cont2==0){
			 	printf("\nRegistre um número para a %d conta : ",i+1);
				scanf("%d",&Dados[i].num); 		//parte teste
				repeticao_num[j]=Dados[i].num;
				++j;
			 }	
 			for(j=0;j<qn;++j){
 				if(Dados[i].num==repeticao_num[j]){
 					printf("Erro,numero já registrado.");
 					printf("Tente outro numero: ");
 					scanf("%d",&Dados[i].num);
 					++cont2;
 					++j;
				 }				 
			 }	
			 
			 
 			printf("\nDigite o saldo da %d conta: ",i+1);
 			scanf("%f",&Dados[i].saldo);
		 
		 ++i;
		 qn=i;
		 system("pause");
		break;

		case 2:
			printf("--Registro de clientes--\n");
			printf("Digite o nome do cliente a ser consultado: ");
			scanf("%s",&x);
			for(i=0;i<qn;++i){
				if(strcmp(Dados[i].nome,x)==0){
				++a;
				posi=i;
				printf("Conta encontrada:\n nome: %s | numero: %d\n",Dados[posi].nome,Dados[posi].num);
				printf("Saldo disponível: saldo %.2f reais\n",Dados[posi].saldo);
				printf("------\n");
			
				system("pause");				
				}
			
			//}
				else{
			printf("\nNenhuma conta registrada com esse nome\n");
			system("pause");
				}	
			}	
			break;
			
			case 3:
				a=0;
				menor_valor=Dados[0].saldo;
				for(i=0;i<qn;++i){
					a=i+1;
					if(Dados[i].saldo<menor_valor){
						aux=i;//
						menor_valor=Dados[i].saldo;	
					}
				}
				printf("Conta de menor saldo excluida!\n");
				printf("Dados excluídos:\n cliente:%s conta:%d saldo: %.2f reais\n",Dados[aux].nome,Dados[aux].num,menor_valor);
				Dados[aux].saldo=Dados[-1].saldo;
				strcpy(Dados[aux].nome,fim);
				Dados[aux].num=Dados[-1].num;
				
				
				system("pause");
				break;
			
			
	}

	}while(op<4);
		 
 	
 }
