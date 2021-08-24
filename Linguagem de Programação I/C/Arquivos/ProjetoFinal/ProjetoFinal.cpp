//#define _CRT_SECURE_NO_WARNINGS

#include<iostream>
#include<string.h>

struct reg
{
	char nome[20];
	char tel[20];
	char email[20];
};

int tamanho(FILE *);
void cadastrar(FILE *);
void consultar(FILE *);
void gerararqtxt(FILE *);

int main()
{

	int op;
	FILE *arq;

	if ((arq = fopen("dados.dat", "rb+")) == NULL)
	{
		if ((arq = fopen("dados.dat", "wb+")) == NULL)
		{
			printf("\nFalha ao abrir o arquivo!\n");
			system("pause");
		}
	}

	do
	{
		system("CLS");
		printf("\n========== AGENDA ==========");
		printf("\n1.Cadastrar\n");
		printf("\n2.Consultar\n");
		printf("\n3.Gerar arquivo\n");
		printf("\n4.Sair\n");
		printf("============Contatos: %d=\n", tamanho(arq));
		printf("Opcao: ");
		scanf("%d", &op);
		switch (op)
		{
		case 1: //cadastrar novo contato
			cadastrar(arq);
			break;
		case 2: //consultar contato por código
			//consultar(arq);
			break;
		case 3: //gera arquivo txt com todos os contatos
			//gerararqtxt(arq);
			break;
		case 4: fclose(arq);
		}
	} while (op != 4);
}

void cadastrar(FILE *arq)
{ 
	reg contato; 
	char confirma;

	fflush(stdin);
	printf("Cadastrando novo registro: \n");
	printf("\nNumero do registro: %d\n", tamanho(arq) +1);
	printf("Nome............: ");
	gets(contato.nome);
	printf("Telefone.........:");
	gets(contato.tel);
	printf("e-mail...........:");
	gets(contato.email);
	printf("\nConfirma <s/n>:");
	scanf("%c", &confirma);

	if (toupper(confirma) == 'S')
	{
		printf("\n gravando ....\n");
		fseek(arq, 0, SEEK_END);
		fwrite(&contato, sizeof(reg), 1, arq);

	}
}

void consultar(FILE *arq)
{ 
	reg contato; 
	int nr; 
	printf("\nConsulta pelo Codigo\n");
	printf("\nInforme o Codigo....:");
	scanf("%d", &nr);
	if ((nr <= tamanho(arq)) && (nr > 0))
	{
		fseek(arq, (nr - 1) * sizeof(reg), SEEK_SET);
		fread(&contato, sizeof(reg), 1, arq);
		printf("\nNome........:%s", contato.nome);
		printf("\nTelefone....:%s", contato.tel);
		printf("\ne-mail......:%s\n\n", contato.email);
	}
	else
	{ 
		printf("\nNumero de registro invalido!\n");
	}
	system("pause");
}

void gerararqtxt(FILE *arq)
{
	char nomearq[20];
	printf("Nome do arquivo texto:");
	scanf("%s", nomearq);
	strcat(nomearq, ".txt");
	
	FILE *arqtxt = fopen(nomearq, "w");
	
	if (!arqtxt)
	{
		printf("\nNão foi possivel criar esse arquivo!\n");
		system("pause");
	}

	fprintf(arqtxt, "Nome               Telefone            E-mail\n");
	fprintf(arqtxt, "==================================================\n");
	int nr; 
	reg contato;
	for (nr = 0; nr < tamanho(arq); nr++)
	{
		fseek(arq, nr * sizeof(reg), SEEK_SET);
		fread(&contato, sizeof(reg), 1, arq);
		fprintf(arqtxt, "%-20s%-20s%-20s\n", contato.nome, contato.tel, contato.email);
	}
		fprintf(arqtxt, "===========================================================\n");
		fclose(arqtxt);
	}

int tamanho(FILE *arq)
{
	fseek(arq, 0, SEEK_END);
	return ftell(arq) / sizeof(reg);
}



