#define _CRT_SECURE_NO_WARNINGS
#include <iostream>


char* inverte(char*);

int main(void) {
	char antes[30];
	char* depois;

	printf("Entre com um nome: ");
	scanf("%[^\n]", antes);
	depois = inverte(antes);

	printf("Seu nome: %s", antes);
	printf("\nSeu nome ao contrario: %s", depois);
}

char* inverte(char* antes)
{
	int tamanho = strlen(antes);
	int j = 0;
	char* aux = new char[tamanho + 1];
	for (int i = tamanho - 1; i >= 0; i--)
	{
		aux[j] = antes[i];
		j++;
	}
	aux[tamanho] = '\0';
	return aux;
}