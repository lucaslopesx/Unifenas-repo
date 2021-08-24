 #include <iostream>
 #include "lista_cont.h"
 
 typedef struct
 {
 	char nome[30];
 	char telefone[15];
 	char email[15];
 } registro;
 
 void cadastra(FILE *);
 void consulta(FILE *);
 int tamarq(FILE *);
 void relatorio(FILE *);
 void relatorioord(FILE *);
 
 int main(void)
 {
   FILE *arq;
   arq = fopen("dados.dat","rb+");
   if (arq==0)//arquiva nao existe no disco ou nao pode ser aberto
   {
   	arq= fopen("dados.dat","wb+");
   }
   int op;
   do 
   {
   		system("cls");
   		printf("=============Agenda 1.0 =============\n");
   		printf("1. Cadastrar\n");
   		printf("2. Consultar\n");
   		printf("3. Relatorio\n");
   		printf("4. Relatorio ordenado\n");
   		printf("5. Excliur\n");
   		printf("6. Sair\n");
   		printf("======================================\n");
   		printf("Sua opcao:");
   		scanf("%d",&op);
   		fflush(stdin);
   		switch (op)
   		{
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
				relatorioord(arq);
				break;
			case 5:
				break;	
		}
   		
   }while (op!=6);
   fclose(arq);
   return 1;	
 }
 
 void cadastra(FILE *arq)
 {
 	printf("Cadastrando o registro numero:%d\n",tamarq(arq)+1);
 	registro reg;

	printf("Nome......:");
 	gets(reg.nome);
 	printf("Telefone..:");
 	gets(reg.telefone);
 	printf("e-mail....:");
 	gets(reg.email);
 	
 	fseek(arq,0,SEEK_END);
 	fwrite(&reg,sizeof(registro),1,arq);
 	
 	printf("Registro gravado com sucesso!\n");
 	system("pause");
 }
 
 void consulta(FILE *arq)
 {
 	int nr;
	printf("Entre com o numero do registro:");
	scanf("%d",&nr);
	fflush(stdin);
	registro reg;
	fseek(arq,(nr-1)*sizeof(registro),SEEK_SET);
	fread(&reg,sizeof(registro),1,arq);
	
	printf("Nome.....:%s\n",reg.nome);
	printf("Telefone.:%s\n",reg.telefone);
	printf("e-mail...:%s\n",reg.email);
	
	system("pause");
 	
 }

void relatorio(FILE *arq)
{
	FILE *arqtxt=fopen("Relatio.txt","w");
	fprintf(arqtxt,"Relacao de contados cadastrados na Agenda\n");
	fprintf(arqtxt,"Nome                           Telefone        e-mail\n");
	fprintf(arqtxt,"===============================================================\n");
	int nr;
	registro reg;
	for (nr=0;nr<tamarq(arq);nr++)
	{
		fseek(arq,nr*sizeof(registro),SEEK_SET);
		fread(&reg,sizeof(registro),1,arq);
		fprintf(arqtxt,"%-30s %-15s %-15s\n",reg.nome,reg.telefone,reg.email);
	}
	fprintf(arqtxt,"===============================================================\n");
	fclose(arqtxt);
	printf("Relatorio gerado com sucesso.\n");
	system("Pause");
}

void relatorioord(FILE *arq)
{
	Lista L;
	Linit(&L);
	int nr;
	registro reg;
	Elem X;
	for (nr=0;nr<tamarq(arq);nr++)
	{
		fseek(arq,nr*sizeof(registro),SEEK_SET);
		fread(&reg,sizeof(registro),1,arq);
		strcpy(X.nome,reg.nome);
		X.nr=nr;
		Lins(&L,X);
	}
	FILE *arqtxt=fopen("RelatioOrdenado.txt","w");
	fprintf(arqtxt,"Relacao de contados cadastrados na Agenda\n");
	fprintf(arqtxt,"Nome                           Telefone        e-mail\n");
	fprintf(arqtxt,"===============================================================\n");
	int c;
	for (c=0;c<tamarq(arq);c++)
	{
		nr=L.M[c].nr;
		fseek(arq,nr*sizeof(registro),SEEK_SET);
		fread(&reg,sizeof(registro),1,arq);
		fprintf(arqtxt,"%-30s %-15s %-15s\n",reg.nome,reg.telefone,reg.email);
	}
	fprintf(arqtxt,"===============================================================\n");
	fclose(arqtxt);
	printf("Relatorio gerado com sucesso.\n");
	system("Pause");
	
}
 
 int tamarq(FILE *arq)
 {
 	fseek(arq,0,SEEK_END);
 	return ftell(arq)/sizeof(registro);
 }
 

