#include <iostream>
#define TAM 100

typedef struct{
	char nome[30];
	char telefone[15];
	char email[15];
}registro;

	void cadastra(FILE *);
	void consulta(FILE *);
	int tamarq(FILE *);
	
	
void cadastra(FILE *arq){
		
	registro reg;//armazena os campos
		
	printf("Cadastrando o registro numero: %d\n", tamarq(arq)+1);
	printf("Nome....: ");
	gets(reg.nome);
	fflush(stdin);
	printf("Telefone: ");
	gets(reg.telefone);
	fflush(stdin);
	printf("E-Mail..: ");
	gets(reg.email);
	fflush(stdin);
		
	fseek(arq,0,SEEK_END);//posiciona ao final do arquivo
	fwrite(&reg,sizeof(registro),1,arq);//grava o registro
		
	system("pause");
}
	
void consulta(FILE *arq){
	int nr;
	printf("Entre com o numero do registro: ");
	scanf("%d",&nr);
	fflush(stdin);
	registro reg;
		
	fseek(arq,(nr-1)*sizeof(registro),SEEK_SET);
	fread(&reg,sizeof(registro),1,arq);
		
	printf("Nome....: %s\n",reg.nome);
	printf("Telefone: %s\n",reg.telefone);
	printf("Email...: %s\n",reg.email);
		
	system("pause");
}
	
void relatorio(FILE *arq){
	FILE *arqtxt = fopen("Relatorio.txt","w");
	fprintf(arqtxt,"Conteudo da Agenda\n");
	fprintf(arqtxt,"Nome                           Telefone        E-mail\n");
	fprintf(arqtxt,"============================== =============== ==================\n");
	
	int nr;
	registro reg;
	
	for (nr=0;nr<tamarq(arq);nr++){
		fseek(arq,nr*sizeof(registro),SEEK_SET);
		fread(&reg,sizeof(registro),1,arq);
		fprintf(arqtxt,"%-30s %-15s %-15s \n",reg.nome, reg.telefone, reg.email);
	}
	
	fprintf(arqtxt,"=================================================================\n");
	fclose(arqtxt);
}
	
int tamarq(FILE *arq){
	fseek(arq,0,SEEK_END);
	return ftell(arq)/sizeof(registro);
}
	
int main(void){
	
	int op;
	
	FILE *arq;
	arq = fopen("dados.dat","rb+");
	if(arq == 0){
		arq = fopen("dados.dat","wb+");
	}

	do{
		
		system("cls");
		printf("-----------------AGENDA 1.0-----------------\n");
		printf("1. Cadastrar\n");
		printf("2. Consultar\n");
		printf("3. Relatorio\n");
		printf("4. Relatorio Ordenado\n");
		printf("5. Excluir\n");
		printf("6. Sair\n");
		printf("--------------------------------------------\n");
		
		printf("Sua opcao: ");
		scanf("%d",&op);
		fflush(stdin);
		
		switch(op){
			case 1:
				cadastra(arq);
				break;
			case 2:
				consulta(arq);
				break;
			case 3:
				relatorio(arq);
				break;
			case 4:
				
				break;
			case 5:
				
				break;
		}
		
	}while(op!=6);
	return 1;
}
