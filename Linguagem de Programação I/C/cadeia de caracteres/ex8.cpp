#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <string.h>
int main(void)
{
// A vari�vel texto1 � inicializada com a cadeia
// de caracteres PROGRAMA DE COMPUTADOR
char texto1[] = "PROGRAMA DE COMPUTADOR";
// A vari�vel texto2 � inicializada com a cadeia
// de caracteres "DE "
char texto2[] = "DE ";
int posi, i, j, tam;
char texto3[25];
// A vari�vel posi recebe a posi��o a partir
// da qual a cadeia da vari�vel texto2 aparece
// dentro da cadeia texto1
posi = strstr(texto1, texto2) - texto1;
// A fun��o strlen retorna o tamanho da cadeia armazenada
// na vari�vel texto1
tam = strlen(texto1);
// A estrutura de repeti��o abaixo copia da cadeia armazenada
// na vari�vel texto1 para a vari�vel texto3, os caracteres
// das posi��es de 0 at� a posi��o anterior ao in�cio da
// cadeia "DE ", dentro da cadeia armazenada na vari�vel texto1
for (i = 0; i<posi; i++)
texto3[i] = texto1[i];
// Neste exemplo, at� este ponto, a vari�vel texto3
// cont�m os seguintes caracteres: "PROGRAMA "
// A vari�vel j receber� a pr�xima posi��o a ser ocupada
// no vetor que representa a cadeia de caracteres
// que est� sendo gerada
j = i;
// A estrutura de repeti��o abaixo continua copiando os
// caracteres da cadeia armazenada na vari�vel texto1 para a
// cadeia armazenada na vari�vel texto3
// Neste caso, ser�o copiados os caracteres que est�o nas
// posi��es ap�s o in�cio da cadeia da vari�vel texto2
for (i = posi + strlen(texto2); i <= tam - 1; i++)
{
texto3[j] = texto1[i];
j = j + 1;
}
// Mostra o conte�do da cadeia gerada
printf("\nCadeia gerada = %s\n", texto3);
system("pause");
}

