#include <iostream>

int main()
{
	FILE *arq=fopen("dados.txt","r");
	
	int nl,nc;
	
	fscanf(arq,"%d",&nl);
	fscanf(arq,"%d",&nc);
	
	printf("No. de linhas:%d\n",nl);
	printf("No. de colunas:%d\n",nc);
	
}
