#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <string.h>
int main(void)
{
	char letra1, letra2, letra3;
	letra1 = 'D';
	letra2 = letra1 + 1;
	letra3 = letra1 + 2;
	printf("\nCaractere = %c", letra1);
	printf("\nSucessor de %c = %c", letra1, letra2);
	printf("\nSucessor de %c = %c\n", letra2, letra3);
	system("pause");
}

