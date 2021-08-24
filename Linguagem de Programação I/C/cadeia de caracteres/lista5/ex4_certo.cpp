#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main(void)
{
	char frase[20],aux;
	int x,cont,j;
	printf("Digite uma frase:");
	gets(frase);
	strlwr(frase);
	for(x=0;x<20;x++)
	{
		cont=0;
		aux=frase[x];
		if(frase[x]!=NULL && frase[x]!=' ')
		{
			for(j=0;j<20;j++)
			{
				if(aux==frase[j])
				{
					cont++;
					frase[j]=NULL;
				}
			}
			if(cont>=2)
			{
				printf("A letra %c repete %i vezes\n",aux,cont);	
			}	
		}
	}
	return 1;
	
}
