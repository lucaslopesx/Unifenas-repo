#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <string.h>
int main(void)
{
	char cadeia1[25], cadeia2[25];
	printf("Digite a primeira cadeia de caracteres: ");
	// A primeira cadeia de caracteres digitada ser�
	// armazenada na vari�vel cadeia1
	gets(cadeia1);
	printf("Digite a segunda cadeia de caracteres: ");
	// A segunda cadeia de caracteres digitada ser�
	// armazenada na vari vel cadeia2
	gets(cadeia2);
	// A fun��o strcmp compara as cadeias
	if (strcmp(cadeia1, cadeia2) == 0)
	printf("\nAs cadeias digitadas s�o iguais ");
	else if (strcmp(cadeia1, cadeia2) > 0)
	printf("\nA cadeia1 � alfabeticamente maior que a cadeia2 \n");
	else
	printf("\nA cadeia2 � alfabeticamente maior que a cadeia1 \n");
	system("pause");
}

