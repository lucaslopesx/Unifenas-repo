 #include <stdio.h>
 #include <iostream>
 #include <string.h>
 #include <locale.h>
 #include "lista_cont.h"
 
 struct produtos{
 	char numero[20];
 	int quantidade;
 	char nome[20];
 };
 
 void adc_prod();    // funções
 void list();
 void buscar();
 void list_inicial();
 void remover(FILE *);
 void conta_prod();
 void reposicao();
 void adc_arq(FILE *);
 int tamarq(FILE *);
 
 void adc_prod(){  //função adc_prod #1
 	FILE * arq = fopen("menu_estoque.txt","ab+"); 
	produtos prod;	
 	if ( arq == NULL || ferror(arq))
 		printf("Arquivo não encontrado.\n");
 	else{
 		printf("\n[ Opção escolhida: 1° opção ]\n\n");
 		fflush(stdin);
 		printf("Digite o código do produto...: ");
 		gets(prod.numero);
 		
 		fflush(stdin);
 		printf("Digite a quantidade de produto..: ");
 		scanf("%d",&prod.quantidade);
 		
 		fflush(stdin);
 		printf("Digite o nome do produto...: ");
 		gets(prod.nome);
 		
 		fwrite(&prod,sizeof(struct produtos),1,arq);
 		
 		printf("\nProdutos gravados com sucesso!\n");
 		system("pause");
	 }
	 
	 fclose(arq);
 }           //fim adc_prod#1
 
 void list(){//inicio list #2
 	FILE *arq = fopen("menu_estoque.txt","rb");
 	produtos prod;
 	Lista l1;
 	Elem X;
 	int cont=0;

 	if(arq == NULL || ferror(arq))
 		printf("Houve um erro na abertura !\n");

	else{
		printf("\n[ Opção escolhida : 2° opção ]\n\n");
		printf("======= Produtos  disponíveis em estoque  ======\n\n");
		while(fread(&prod,sizeof(struct produtos),1,arq)==1){	
			printf("Código: %s \n",prod.numero);
			printf("Quantidade : %d\n",prod.quantidade);
			printf("Nome: %s\n\n",prod.nome);
			cont++;			
		}
		

	}
		if(cont==0)
			printf("	NÃO HÁ PRODUTOS NO ESTOQUE NO MOMENTO.\n");
			
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
 		printf("\n[ Opção escolhida : 3° opção ]\n\n");
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
			printf("\n\nPRODUTO NÃO LOCALIZADO NO ESTOQUE\n\n");
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
 		printf("\n[ Opção escolhida: 4° opção ]\n\n");
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
			printf("	NÃO HÁ PRODUTOS LISTADO COM A INICIAL [ %c ]\n\n",l);		
	 }
 	fclose(arq);
 	system("pause");
 } //fim list_inicial #4
 
 void remover(FILE *arq){ 	// inicio remover #5
	//FILE * arq = fopen("menu_estoque.txt","rb");
	FILE * arq2 = fopen("menu_estoque2.txt","wb");
	char name[20];
	int a=0,cont=0;
	produtos prod;
	
	
		if(arq==NULL || ferror(arq))
			printf("Houve um erro na abertura do arquivo!\n");
			
		else{
			printf("\n[ Opção escolhida: 5° opção ] \n\n");
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
				printf("\n\n PRODUTO INEXISTENTE,TENTE NOVAMENTE  !\n\n");		
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
int tamarq(FILE *arq)
 {
 	fseek(arq,0,SEEK_END);
 	return ftell(arq)/sizeof(produtos);
 }
void adc_arq(FILE *arq){ // inicio adc_arq #6

	Lista L;
	Linit(&L);
	int nr;
	produtos prod;
	Elem X;
	for (nr=0;nr<tamarq(arq);nr++)
	{
		fseek(arq,nr*sizeof(produtos),SEEK_SET);
		fread(&prod,sizeof(produtos),1,arq);
		strcpy(X.nome,prod.nome);
		X.nr=nr;
		Lins(&L,X);
	}
	FILE *arqtxt=fopen("relatorio_estoque.txt","w");
	fprintf(arqtxt,"\n");
	fprintf(arqtxt,"Código                           Quantidade        Nome\n");
	fprintf(arqtxt,"===============================================================\n");
	int c;
	for (c=0;c<tamarq(arq);c++)
	{
		nr=L.M[c].nr;
		fseek(arq,nr*sizeof(produtos),SEEK_SET);
		fread(&prod,sizeof(produtos),1,arq);
		fprintf(arqtxt,"%-30s %-20d %-18s\n",prod.numero,prod.quantidade,prod.nome);
	}
	fprintf(arqtxt,"===============================================================\n");
	fclose(arqtxt);
	printf("Arquivo ordenado gerado....\n");
	
	system("Pause");
		
} //fim adc_arq #6

void reposicao(){ //inicio reposicao #7
	FILE * arq = fopen("menu_estoque.txt","rb");
	produtos prod;
	int num_menor=0;
		if(ferror(arq)|| arq == NULL)
			printf("Erro na abertura do arquivo. \n");
			
		else{
			printf("[ Opção escolihda: 7° opção ]\n\n");
			while(fread(&prod,sizeof(struct produtos),1,arq)==1){
				if(prod.quantidade <= 5){
					printf("---------------------------------\n");
					printf("Código: %s\n",prod.numero);
					printf("Quantidade: %d\n",prod.quantidade);
					printf("Nome: %s\n",prod.nome);
					printf("---------------------------------\n");
					num_menor++;
				}
			}
				if(num_menor==0)
					printf("\nNão há produtos necessitando reposição ! \n\n");			
		}
	
	fclose(arq);
	system("pause");
} //fim reposicao #7

 
 int main(void){
 	int OP;
	int cont;
 	setlocale(LC_ALL,"");
 	produtos prod;
 	FILE * arq = fopen("menu_estoque.txt","rb+");
 	do{

 	system("cls");
 	printf("-----------------SISTEMA DE GERENCIAMENTO DE ESTOQUES----------------------\n");
 	printf(" 1.Adicionar um produto               		2.Listar \n");
 	printf(" 3.Buscar um produto          			4.Buscar pela inicial\n");
 	printf(" 5.Remover um produto                   	6.Gerar um arquivo\n");
 	printf(" 7.Reposição de produtos 			8.Sair do gerenciador\n");
 	
 	conta_prod();
 	printf("--------------------------------------------------------------------------\n");
 	scanf(" %d",&OP);
	fflush(stdin);			
 		switch(OP){
 			case 1:
 					adc_prod();		
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
 					remover(arq);
 				break;
 			case 6:
 					adc_arq(arq);
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
