#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <string.h>
int main(void)
{
// A vari�vel texto1 recebe a cadeia de
// caracteres: Programa de computador
char texto1[] = "Programa de computador";
// A vari�vel texto2 recebe a cadeia de
// caracteres: de
char texto2[] = "de";
int posi;
// A fun��o strstr verifica a partir de qual posi��o
// a cadeia armazenada na vari�vel texto2
// aparece na cadeia armazenada na vari�vel texto1
// A vari�vel posi recebe a posi��o
posi = strstr(texto1, texto2) - texto1;
//Mostra o conte�do da vari�vel posi
printf("\nPosi��o = %d\n", posi);
system("pause");
}

