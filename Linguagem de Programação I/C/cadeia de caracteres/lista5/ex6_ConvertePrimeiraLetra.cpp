#include <iostream>
#include <cstring>
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main(void){

	int i=0, size;
	char texto[50];
	
	printf("Digite uma frase: ");
	gets(texto);
	
	size = strlen(texto);
	
	texto[i] = toupper(texto[i]);
	for(i=0;i<size;i++){
		if(texto[i] == ' '){
			texto[i+1] = toupper(texto[i+1]);
		}
	}
	
	printf("Frase modificada: %s",texto);


}
