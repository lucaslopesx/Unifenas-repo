#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <ctype.h>

int main(void){
	char consoantes[] = {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','x','y','w','z'}; ///ghjklmnpqrstvxywz;
	char texto1[20];
	int i,j,aux,tam,cont=0;
	printf("Digite um texto: ");
	gets(texto1);
	tam=strlen(texto1);
		for(i=0;consoantes[i]!='\0';++i){
			for(j=0;j<tam;++j){
			if(texto1[j]==toupper(consoantes[i])||texto1[j]==consoantes[i]){
				++cont;
			}
			}
		}
			
	printf("\nTexto digitado: %s",texto1);
	printf("\nQuantidade de consoantes: %d",cont);
}
