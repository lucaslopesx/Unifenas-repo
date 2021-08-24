#include <iostream>
#include <cstring>
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main(void){
	char texto1[50];
	int i,size;
	
	printf("Digite uma frase com até 50 caracteres: ");
	gets(texto1);
	
	size = strlen(texto1);
	
	for(i=0;i<size;i++){
		if(texto1[i] == 'a' || texto1[i] == 'e' || texto1[i] == 'i' || texto1[i] == 'o' || texto1[i] == 'u' || texto1[i] == 'A' || texto1[i] == 'E' || texto1[i] == 'I' || texto1[i] == 'O' || texto1[i] == 'U'){
			texto1[i] = '*';
		}
	}
	
	printf("Frase transformada: %s\n",texto1);
	
	getchar();
	system("pause");
}
