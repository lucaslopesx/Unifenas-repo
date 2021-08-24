#include <iostream>
#include <cstring>
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main(void){
	int i, j, qtd[26], cont=0, size;
	char frase[26];
	
	char letras[] = "abcdefghijklmnopqrstuvwxyz";
	
	printf("Digite uma frase: ");
	gets(frase);
	
	size = strlen(frase);
	for(i=0;i<size;i++){
		for(j=0;j<26;j++){
			if(frase[i] == letras[j]){
				qtd[j]++;
				cont++;
			}		
		}
	}		
	printf("%d",cont);
	for(i=0;i<26;i++){
		if(qtd[i] > 0){
			printf("A letra %s se repetiu %d",letras[i],qtd[i]);
		}
	}
	
	return 1;

}
