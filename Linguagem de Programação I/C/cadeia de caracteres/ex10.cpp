#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <string.h>
int main(void)
{
	// A vari�vel texto1 � inicializada com a cadeia
	// de caracteres PROGRAMA DE COMPUTADOR
	char texto1[] = "PROGRAMA DE COMPUTADOR";
	char texto2[35];
	// A linha abaixo inicializa a vari�vel texto2
	// com vazio, ou seja, uma cadeia com tamanho zero
	texto2[0] = '\0';
	// A linha abaixo copia o conte�do da vari�vel
	// texto1 para a vari�vel texto2
	strcpy(texto2, texto1);
	// A linha abaixo inseri a cadeia ES e o finalizador
	// de strings na cadeia texto2
	strcat(texto2, "ES\0");
	// A linha abaixo mostra a nova cadeia gerada
	printf("\nNova cadeia de caracteres = %s\n", texto2);
	system("pause");
}
