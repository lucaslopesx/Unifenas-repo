#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <cstring>
#include <stdlib.h>

int main(void){
	
	char cadeia_digitada[25], cadeia_copiada[25];
	printf("Digite uma cadeia de caracteres: ");
	// A cadeia de caracteres digitada ser�
	// armazenada na vari�vel cadeia_digitada
	gets(cadeia_digitada);
	// A fun��o strcpy copia a cadeia de caracteres da vari�vel
	// cadeia_digitada para a vari�vel cadeia_copiada
	strcpy(cadeia_copiada, cadeia_digitada);
	// Mostra o conte�do da vari�vel cadeia_digitada
	printf("\nCadeia digitada = %s", cadeia_digitada);
	//Mostra o conte�do da vari�vel cadeia_copiada
	printf("\nCadeia copiada = %s\n", cadeia_copiada);
	system("pause");

}
