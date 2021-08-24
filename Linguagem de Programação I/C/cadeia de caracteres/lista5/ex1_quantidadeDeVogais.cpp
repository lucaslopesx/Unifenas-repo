#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <ctype.h>

int main(void){
	char texto1[20];
	char vogais[6] = {'a','e','i','o','u'};
	char toupp[10];
	int i=0,j=0,tam,cont=0,a;
	printf("Entre com uma frase: ");
	gets(texto1);
	
	a=toupper(vogais[i]);
	tam = strlen(texto1);
	
	for(i=0;i<6;++i){
		toupp[i]=toupper(vogais[i]);
		for(j=0;j<tam;++j){
			if(texto1[j]==toupper(vogais[i])||texto1[j]==vogais[i]){
			cont+=1;
			}
		}
	}
	printf("Frase digitada: %s\n",texto1);
	printf("Quantidade de vogais -aeiou- : %d",cont);
	
	
}
