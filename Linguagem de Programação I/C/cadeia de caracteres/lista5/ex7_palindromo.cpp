#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <ctype.h>
#include <string.h>

#define TAM 20

int main(void)
{
	setlocale(LC_ALL,"");
	int i, palavra, aux;
	char teste[TAM],inversateste[TAM];
	
	printf("Digite a palavra : ");
	gets(teste);
	
	
	for(i=0; i<TAM; i++);
	{
		teste[i]=toupper(teste[i]); 
	}
	
	for(i=0; i<TAM; i++)
	{
		inversateste[i]=teste[i];
	}
	
	strrev(inversateste);
	
	palavra = strcmp(teste, inversateste);
	
	if (palavra ==0)
	{
		printf("\n A palavra fornecida é palíndroma");
	}
	else
	{
		printf("\n A palavra fornecida não é palíndroma");
	}
	return 1;
	
}	
