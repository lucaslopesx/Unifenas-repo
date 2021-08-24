 #include <stdio.h>
 #include <iostream>
 #include <string.h>
 #include <locale.h>
 #include "str_listas.h"
 
 struct produtos{
 	char numero[20];
 	int quantidade;
 	char nome[20];
 };
 
 void adc_ctt(){  //função adc_ctt #1
 	FILE * arq = fopen("menu_estoque.txt","ab+"); 
	produtos prod;
	//printf("Opção escolhida: 1\n");	
 	if ( arq == NULL || ferror(arq))
 		printf("Arquivo não encontrado.\n");
 	else{
 		printf("[ Opção escolhida: 1° opção \n]");
 		fflush(stdin);
 		printf("Digite o código do produto: ");
 		gets(prod.numero);
 		
 		fflush(stdin);
 		printf("Digite a quantidade de produto a adicionar: ");
 		scanf("%d",&prod.quantidade);
 		
 		fflush(stdin);
 		printf("Digite o nome do produto: ");
 		gets(prod.nome);
 		
 		fwrite(&prod,sizeof(struct produtos),1,arq);
 		
 		printf("\nProdutos gravados com sucesso!\n");
 		system("pause");
	 }
	 
	 fclose(arq);
 }           //fim adc_ctt#1
 
 void list(){//inicio list #2
 	FILE *arq = fopen("menu_estoque.txt","rb");
 	produtos prod;
 	Lista l1;

 	if(arq == NULL || ferror(arq))
 		printf("Houve um erro na abertura !\n");

	else{
		printf("[ Opção escolhida : 2° opção ]\n");
		while(fread(&prod,sizeof(struct produtos),1,arq)==1){	
			Lins(&l1,prod.nome);			
		}
		printf("======= Produtos  disponíveis em estoque ordenados ======\n\n");
		Lmostra(&l1);
	}
 	fclose(arq);
 	printf("\n");
 	system("pause");
 } //fim list #2
 
 void buscar(){//inicio buscar #3
 	FILE * arq = fopen("menu_estoque.txt","rb");
 	produtos prod;
 	char name[20];
 	int cont=0;
 	
 	if( arq==NULL || ferror(arq))
 		printf("Houve um erro ao abrir o arquivo \n");
 	else{
 		printf("[ Opção escolhida : 3° opção \n]");
 		fflush(stdin);
 		printf("Digite o nome do produto: ");
 		gets(name);
 		while(fread(&prod,sizeof(struct produtos),1,arq)==1){
 			if(strcmp(name,prod.nome)==0){
 				cont++;
 				printf("---------------------------------------\n");
 				printf("Código: %s\n",prod.numero);
 				printf("Quantidade: %d\n",prod.quantidade);
 				printf("Nome do produto: %s\n",prod.nome);
 				printf("---------------------------------------\n");
			 }
		 }
		if (cont==0)
			printf("Produto não localizado no estoque\n");
	 }
	fclose(arq);
 	system("pause");
 }//fim buscar #3
 void list_inicial(){ // inicio list_inicial#4
 	FILE * arq = fopen("menu_estoque.txt","rb");
 	
 	char l,aux;
 	int cont=0;
 	produtos prod;
 	
 	if (arq == NULL || ferror(arq))
 		printf("\nHouve um erro na abertura do arquivo.");
 		
 	else{
 		fflush(stdin);
 		printf("[ Opção escolhida: 4° opção ]\n");
 		printf("Digite a primeira letra do produto que deseja buscar: ");
 		scanf("%c",&l);
 		printf("\n---------------------  Produtos com a inicial [ %c ]  ---------------------------------\n",l);
 			while(fread(&prod,sizeof(struct produtos),1,arq)==1){
 			aux = prod.nome[0];
 	
 				if(aux==l){	
				 cont++;			
 					printf("Código: %s\n",prod.numero);
 					printf("Quantidade: %d\n",prod.quantidade);
 					printf("Nome: %s\n",prod.nome);
 					//printf("--------------------------------------------------\n");
 					printf("\n");
				 }			 
			 }
		if ( cont == 0)
			printf("Não há produtos listados com a inicial [ %c ]\n",l);		
	 }
 	fclose(arq);
 	system("pause");
 } //fim list_inicial #4
 
 void remover(){ 	// inicio remover #5
	FILE * arq = fopen("menu_estoque.txt","rb");
	FILE * arq2 = fopen("menu_estoque2.txt","wb");
	char name[20];
	int a=0,cont=0;
	produtos prod;
	
	
		if(arq==NULL || ferror(arq))
			printf("Houve um erro na abertura do arquivo!\n");
			
		else{
			printf("[ Opção escolhida: 5° opção ] \n");
			fflush(stdin);
			printf("Digite o nome do produto que deseja remover do estoque: ");
			gets(name);
			
			while(fread(&prod,sizeof(struct produtos),1,arq)==1){
				if(strcmp(prod.nome,name) != 0){
						fwrite(&prod,sizeof(struct produtos),1,arq2);
				}
				if(strcmp(prod.nome,name)==0)
					cont++;
							
			}
			if(cont==0)
				printf(" PRODUTO INEXISTENTE,TENTE NOVAMENTE  !\n");		
		}
	fclose(arq);
	fclose(arq2);
	a=remove("menu_estoque.txt");
	rename("menu_estoque2.txt","menu_estoque.txt");	
	system("pause");
			
	
 } 				// fim remover #5
 
 void conta_prod(){ // inicio conta_prod #
	 FILE * arq = fopen("menu_estoque.txt","rb");
	produtos prod ;
	int cont=0;
		if(arq==NULL || ferror(arq))
			printf("");
		else{
			while(fread(&prod,sizeof(struct produtos),1,arq)==1){
				cont++;
			}
			printf("\n [Em estoque: %d produtos]\n",cont);
		}
	fclose(arq);
	
}	// fim conta_prod #
void adc_arq(){ // inicio adc_arq #6

	FILE * arq = fopen("menu_estoque.txt","r");
	produtos prod;
	char name[20];
	
	printf("[ Opção escolhida: 6° opção ] \n");
	fflush(stdin);
	printf("Digite o nome do arquivo a ser gerado: ");
	scanf("%s",name);
	strcat(name,".txt");
	
	FILE * arq2 = fopen(name,"w");
		if(arq==NULL|| ferror(arq))
			printf("Erro na abertura do arquivo \n");	
		else{							
				while(fread(&prod,sizeof(struct produtos),1,arq)==1){
				 	fprintf(arq2," ( -Código: %s -Quantidade: %d -Nome: %s  ) \n",prod.numero,prod.quantidade,prod.nome);
				}
			printf("ARQUIVO .txt GERADO COM SUCESSO , DISPONÍVEL NA PASTA DO PROGRAMA \n");				
		}
		
	fclose(arq);
	fclose(arq2);
	system("pause");
		
} //fim adc_arq #6

void reposicao(){ //inicio reposicao #7
	FILE * arq = fopen("menu_estoque.txt","rb");
	produtos prod;
	int num_menor=0;
		if(ferror(arq)|| arq == NULL)
			printf("Erro na abertura do arquivo. \n");
			
		else{
			printf("[ Opção escolihda: 7° opção ]\n");
			while(fread(&prod,sizeof(struct produtos),1,arq)==1){
				if(prod.quantidade <= 5){
					printf("---------------------------------");
					printf("Código: %s\n",prod.numero);
					printf("Quantidade: %d\n",prod.quantidade);
					printf("Nome: %s\n",prod.nome);
					printf("---------------------------------");
					num_menor++;
				}
			}
				if(num_menor==0)
					printf("Todos produtos estão na quantidade adequada . \n");			
		}
	
	fclose(arq);
	system("pause");
} //fim reposicao #7

 
 int main(void){
 	int OP;
	int cont;
 	setlocale(LC_ALL,"");
 	produtos prod;
 	
 	do{

 	system("cls");
 	printf("-----------------SISTEMA DE GERENCIAMENTO DE ESTOQUES----------------------\n");
 	printf(" 1.Adicionar um produto                         2.Listar produtos\n");
 	printf(" 3.Buscar um produto          			4.Buscar pela inicial\n");
 	printf(" 5.Remover um produto                           6.Gerar um arquivo\n");
 	printf(" 7.Reposição de produtos 			8. Sair do gerenciador \n");
 	conta_prod();
 	printf("\n--------------------------------------------------------------------------\n");
 	scanf(" %d",&OP);
				
 		switch(OP){
 			case 1:
 					adc_ctt();		
 				break;
 				
 			case 2:
 					list();
 				break;
 				
 			case 3:
 					buscar();
 				break;
 			case 4:
 					list_inicial();
 				break;
 			case 5:
 					remover();
 				break;
 			case 6:
 					adc_arq();
 				break;
 			case 7:
 					reposicao();
 				break;
 			
 			default:
 				if(OP > 8){				 
			 		printf("\nOpção inválida !\n");
					system("pause");
				}
				if(OP == 8){
					printf("\nPrograma encerrado com sucesso.\n");
					system("pause");
					
				}		
		
		}
 	}while(OP!=8);
 	//fclose(arq);
 }
