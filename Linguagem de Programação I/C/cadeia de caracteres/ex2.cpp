#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <string.h>
int main(void)
{
	char cadeia_digitada[25], cadeia_copiada[25];
	printf("Digite uma cadeia de caracteres: ");
	// A cadeia de caracteres digitada ser�
	// armazenada na vari�vel cadeia_digitada
	gets(cadeia_digitada);
	// A fun��o strncpy copia os n primeiros caracteres
	// da vari�vel cadeia_digitada
	// para a vari�vel cadeia_copiada
	strncpy(cadeia_copiada, cadeia_digitada, 3);
	cadeia_copiada[3] = '\0';
	//Mostra o conte�do da vari�vel cadeia_digitada
	printf("\nCadeia digitada = %s", cadeia_digitada);
	//Mostra o conte�do da vari�vel cadeia_copiada
	printf("\nCadeia copiada = %s", cadeia_copiada);
	system("pause");
}

