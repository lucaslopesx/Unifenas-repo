 #include <stdio.h>
 #include <iostream>
 #include <string.h>
 #include <locale.h>
 #include <unistd.h>
 #define TAM 100
 
 struct clientes{
 	char email[20];
 	char telefone[10];
 	char nome[20];
 };
 
 clientes cli[TAM];

void formatarArq() {
    FILE *arq = fopen("menu_teste.txt","w+"); //recria um arquivo limpo
    printf("\n\tLista limpa!\n ");
    fclose(arq);
    system("pause");
}

/*void organizarArq(void){//algoritmo de ordenação do tipo selection sort (ordenação por seleção)
     clientes vet; //vet é um variavel do tipo struct Agenda
     int aux,i,j,k,retorno;
     char *str, *str2, *straux;//o asterisco [*] indica que a variavel é uma string
     aux = qtd; // aux recebe a quantidade de contatos inscritos
     // Rotina de ordenação
     for (i = 0 ; i < aux ; i++){
         str = max[i].nome;//a variavel str recebe o primeio contato
         for (j = i+1 ; j < aux ; j++){
             str2 = max[j].nome;//a variavel str2 recebe o segundo contato
             //strcmp faz a comparação entre as strings onde 0 são strings iguais
             if ( strcmp ( str, str2 ) > 0 ){
                 vet = max[i];
                 max[i] = max[j];
                 max[j] = vet;
             }
         }
     }
     remove("agenda.txt");//Apaga o Arquivo
     arq = fopen("agenda.txt", "w+");//Recria um arquivo limpo
     if (arq == NULL){//caso o sistema não consiga criar o arquivo
        printf (" ERRO!\n ");// sera mostrada esta mensagens
        getch();// espera que o usuário pressione uma tecla
        exit(1);//caso esse erro ocorra este comando encerra o programa
     }
     for (k = 0 ; k < aux ; k++){
           retorno = fwrite (&max[k], sizeof(contatos) ,1,arq);
           if (retorno != 1) { //se fwrite retornar com erro
               printf("\n ERRO! ");//sera mostrada esta mensagen
           }
     }
     fclose(arq);//fecha o arquivo agenda.txt
     printf("\n Lista Ordenada!\n ");
     getch();//espera que o usuário pressione uma tecla
}*/

 
 void adc_ctt(){  //função adc_ctt #1
 	FILE * arq = fopen("menu_teste.txt","ab+"); 
	clientes cli;
	int i;
	int cont = 0;
	int qnt = 0;
	
	 	
 	if ( arq == NULL || ferror(arq))
 		printf("Arquivo não encontrado.\n");
 	else{
 		i=0;
 		fflush(stdin);
 		printf("Digite seu email: ");
 		gets(cli.email);
 		
 		fflush(stdin);
 		printf("Digite seu telefone: ");
 		gets(cli.telefone);
 		
 		fflush(stdin);
 		printf("Digite seu nome: ");
 		gets(cli.nome);

 	
 		fwrite(&cli,sizeof(struct clientes),1,arq);
 		
 		printf("\nDados gravados com sucesso!\n");
 		system("pause");
	 }
	 cont++;
	 
	 fclose(arq);
 }           //fim adc_ctt#1
 
  void list(){//inicio list #2
 	FILE *arq = fopen("menu_teste.txt","rb");
 	clientes cli;
 	if(arq == NULL || ferror(arq))
 		printf("Houve um erro na abertura !");
 	else{
 		while(fread(&cli,sizeof(struct clientes),1,arq)==1){
 			printf("----------------------------------------\n");
 			printf("Email: %s \n",cli.email);
 			printf("Telefone: %s",cli.telefone);
 			printf("\nNome: %s\n",cli.nome);
 			printf("----------------------------------------\n");
		 }
	 }
 	fclose(arq);
 	system("pause");
 } //fim list #2
 
 void buscar(){//inicio buscar #3
 	FILE * arq = fopen("menu_teste.txt","rb");
 	clientes cli;
 	int cont;
 	char name[20];
 	
 	if(arq==NULL || ferror(arq))
 		printf("Houve um erro ao abrir o arquivo \n");
 	else{
 		fflush(stdin);
 		printf("Digite o nome do contato: ");
 		gets(name);
 		cont=0;
 		while(fread(&cli,sizeof(struct clientes),1,arq)==1){
 			if(strcmp(name,cli.nome)==0){
 				printf("---------------------------------------\n");
 				printf("Email: %s\n",cli.email);
 				printf("Telefone: %s\n",cli.telefone);
 				printf("Nome: %s\n",cli.nome);
 				printf("---------------------------------------\n");
 				cont=1;
			 }
		 }
		 if(cont==0)
		 	printf("Nenhum contato foi localizado !\n");
	 }
 system("pause");
 }//fim buscar #3
 
 void list_inicial(){ //inicio list_inicial #4
 	FILE * arq = fopen("menu_teste.txt","rb");
 	char l;
 	char aux;
 	clientes cli;
 	
 	if (arq == NULL || ferror(arq))
 		printf("\nHouve um erro na abertura do arquivo.");
 		
 	else{
 		fflush(stdin);
 		printf("Digite a primeira letra do contato que deseja buscar: ");
 		scanf("%c",&l);
 			while(fread(&cli,sizeof(struct clientes),1,arq)==1){
 			aux = cli.nome[0];
 				if(aux==l){
 					printf("--------------------------------------------------\n");
 					printf("Email: %s\n",cli.email);
 					printf("Telefone: %s\n",cli.telefone);
 					printf("Nome: %s\n",cli.nome);
 					printf("--------------------------------------------------\n");
				 }
				 
			 }
 		
	 }
 	fclose(arq);
 	system("pause");
 }// fim list_inicial #4
 
 void remover(){ 	// inicio remover #5
	FILE * arq = fopen("menu_teste.txt","rb");
	FILE * arq2 = fopen("menu_teste2.txt","wb");
	char name[20];
	int a=0,cont=0;
	clientes cli;
	
	printf("\n");
	
		if(arq==NULL || ferror(arq))
			printf("Houve um erro na abertura do arquivo!\n");
			
		else{
			printf("Digite o nome do contato que deseja remover da agenda: ");
			fflush(stdin);
			gets(name);
			
			while(fread(&cli,sizeof(struct clientes),1,arq)==1){
				if(strcmp(cli.nome,name) != 0){
						fwrite(&cli,sizeof(struct clientes),1,arq2);
				}
				if(strcmp(cli.nome,name)==0)
					cont++;
							
			}
			if(cont==0)
				printf("  CONTATO INEXISTENTE,TENTE NOVAMENTE  !\n");		
		}
	fclose(arq);
	fclose(arq2);
	a=remove("menu_teste.txt");
	rename("menu_teste2.txt","menu_teste.txt");	
	system("pause");
			
	
 } 				// fim remover #5
 
void conta_ctt(){ // inicio conta_ctt #6
	 FILE * arq = fopen("menu_teste.txt","rb");
	clientes cli;
	int cont=0;
		if(arq==NULL || ferror(arq))
			printf("Houve um erro na abertura do arquivo\n");
		else{
			while(fread(&cli,sizeof(struct clientes),1,arq)==1){
				cont++;
			}
			printf("Contatos salvos : %d",cont);
		}
	fclose(arq);
	
}	// fim conta_ctt #6

void inativar(){ // inicio inativar #7
	
} // fim inativar #7

void adc_arq(){ // inicio adc_arq #8

	FILE * arq = fopen("menu_teste.txt","r");	
	clientes cli;
	char name[20];
	fflush(stdin);
	printf("Digite o nome do arquivo a ser gerado: ");
	scanf("%s",name);
	strcat(name,".txt");
	
	FILE * arq2 = fopen(name,"w");
		if(arq==NULL)
			printf("Erro na abertura do arquivo \n");	
		else{							
			while(fread(&cli,sizeof(struct clientes),1,arq)==1){
				 fprintf(arq2," ( -Email: %s |-Telefone: %s |-Nome: %s |-STATUS: %s ) \n",cli.email,cli.telefone,cli.nome);
			}
			printf("ARQUIVO .txt GERADO COM SUCESSO , DISPONÍVEL NA PASTA DO PROGRAMA \n");				
		}
		
	fclose(arq);
	fclose(arq2);
	system("pause");
		
} //fim adc_arq #8
 
 int main(void){
 	int OP;
	int cont; 
 	setlocale(LC_ALL,"");
 	clientes cli;
 	//FILE * arq = fopen("menu_teste.txt","rb"); // criar um arquivo na função main com o destino do txt impedi a remoção
 												//com remove();			
 	do{
		 
 	system("cls");
 	printf("-----------------AGENDA MÓVEL----------------------\n\n");
 	printf("1.Adicionar um contato       2.Listar\n");
 	printf("3.Buscar um contato          4.Buscar pela inicial \n");
 	printf("5.Remover um contato         6.Gerar um arquivo \n");
 	printf("7.Formatar                   8.Sair do programa\n\n");
 	
 	conta_ctt();
 	printf("\n----------------------------------------------------\n");
	printf("Digite a opção desejada: ");
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
 					formatarArq();
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
