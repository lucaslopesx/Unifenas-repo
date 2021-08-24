#include<iostream.>
#include<string.h>

typedef struct{
	char nome[20];
	char tel[20];
	char email[20];
}reg;

int tamanho(FILE *);

void cadastrar(FILE *);

void consultar(FILE *);

void gerarArqTxt(FILE *);

int main(void){
	
	int op;
	FILE *arq;
	
	if((arq = fopen("dados.dat","rb+")) == NULL){
		if((arq = fopen("dados.dat","wb+")) == NULL){
			printf("\n Falha ao abrir arquivo! \n");
			system("pause");
		}
	}
	
	
	do{
		system("cls");
		printf("\n======AGENDA======\n");
		printf("1.Cadastrar\n");
		printf("2.Colsultar\n");
		printf("3.Gerar Arquivo\n");
		printf("4.Sair\n");
		printf("\n==================\n");
		printf("QUANTIDADE DE CONTATOS: %d=\n", tamanho(arq));
		printf("\n==================\n");
		printf("Opção: \n");
		scanf("%d", op);
		
		switch(op){
			case 1://Cadastrar novo contato
				cadastrar(arq);
				break;
			case 2://Consulta contato por código
				consultar(arq);
				break;
			case 3://Gerar arquivo txt com todos os contatos
				gerarArqTxt(arq);
				break;
			case 4: fclose(arq);
		
		}while(op!=4);
		
	}
	
	void cadastrar(FILE *arq){
		reg contato;
		char confirma;
		
		fflush(stdin);
		
		printf("\nCADASTRANDO NOVO REGISTRO\n");
		printf("Numero do registro: %d\n",tamanho(arq)+1);
		printf("Nome: ");
		gets(contato.nome);
		printf("\nTelefone: ");
		gets(contato.tel);
		printf("\nEmail: ");
		gets(contato.email);
		
		printf("Confirma <s/n>: ");
		scanf("%c",confirma);
		
		if(toupper(confirma) == 'S'){
			printf("\n Gravado com sucesso \n");
			fseek(arq,0,SEEK_END);
			fwrite(&contato,sizeof(reg),1,arq);
		}
	}
	
	int tamanho(FILE *arq){
		fseek(arq, 0, SEEK_END);
		return ftell(arq) / sizeof(reg);
	}
	
}
