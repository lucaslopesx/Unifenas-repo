 #include <stdio.h>
 #include <iostream>
 #include <string.h>
 #include <locale.h>
 
 struct produtos{
 	char numero[20];
 	int quantidade;
 	char nome[20];
 };
 
 void adc_ctt(){  //função adc_ctt #1
 	FILE * arq = fopen("menu_estoque.txt","ab"); 
	 produtos prod;
	 	
 	if ( arq == NULL || ferror(arq))
 		printf("Arquivo não encontrado.\n");
 	else{
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
 	if(arq == NULL || ferror(arq))
 		printf("Houve um erro na abertura !");
 	else{
 		while(fread(&prod,sizeof(struct produtos),1,arq)==1){
 			printf("----------------------------------------\n");
 			printf("Código: %s \n",prod.numero);
 			printf("Quantidade: %d",prod.quantidade);
 			printf("\nProduto: %s\n",prod.nome);
 			printf("----------------------------------------\n");
		 }
	 }
 	fclose(arq);
 	system("pause");
 } //fim list #2
 
 void buscar(){//inicio buscar #3
 	FILE * arq = fopen("menu_estoque.txt","rb");
 	produtos prod;
 	char name[20];
 	
 	if(arq==NULL || ferror(arq))
 		printf("Houve um erro ao abrir o arquivo \n");
 	else{
 		fflush(stdin);
 		printf("Digite o nome do produto: ");
 		gets(name);
 		while(fread(&prod,sizeof(struct produtos),1,arq)==1){
 			if(strcmp(name,prod.nome)==0){
 				printf("---------------------------------------\n");
 				printf("Código: %s\n",prod.numero);
 				printf("Quantidade: %d\n",prod.quantidade);
 				printf("Nome do produto: %s\n",prod.nome);
 				printf("---------------------------------------\n");
			 }
		 }
	 }
 system("pause");
 }//fim buscar #3
 void list_inicial{ 
 }
 
 int main(void){
 	int OP;
	int cont;
 	setlocale(LC_ALL,"");
 	produtos prod;
 	FILE * arq = fopen("menu_estoque.txt","rb");
 	
 	do{
 		
 		while(fread(&prod,sizeof(struct produtos),1,arq)==1){ //contador de struct apontando pro arquivo menu_teste.txt
 			cont++;
		 }
		 
 	system("cls");
 	printf("-----------------SISTEMA DE GERENCIAMENTO DE ESTOQUES----------------------\n");
 	printf("1. Adicionar um produto \n");
 	printf("2. Listar todos produtos\n");
 	printf("3. Buscar um produto \n");
 	printf("4. Remover um produto \n");
 	printf("5. Sair do programa\n");
 	printf("--------------------------------------------------------------------------\n");
 	printf("Produtos salvos: %d produto[s]",cont);
 	scanf("%d",&OP);
	 				
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
 			default:
			 	printf("\nOpção inválida !\n");
				system("pause");		
		 }
 	}while(OP!=5);
 	fclose(arq);
 }
