#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <string.h>
int main(void)
{
// A vari�vel texto1 � inicializada com a cadeia
// de caracteres PROGRAMA COMPUTADOR
char texto1[] = "PROGRAMA COMPUTADOR";
// A vari�vel texto2 � inicializada com a cadeia
// de caracteres PARA
char texto2[] = "PARA ";
char texto3[35];
// A linha abaixo inicializa a vari�vel texto3
// com vazio, ou seja, uma cadeia com tamanho zero
texto3[0] = '\0';
int achou, i, j, tam, k;
// A fun��o strlen retorna o tamanho da cadeia armazenada
// na vari�vel texto1
tam = strlen(texto1);
// A estrutura de repeti��o abaixo encontra a posi��o
// do espa�o, para colocar a cadeia armazenada na vari�vel
// texto2, dentro da cadeia da vari�vel texto1, gerando a
// cadeia texto3
// A posi��o do primeiro espa�o ser� armazenada na vari�vel i
i = 0;
achou = 0;
while (i < tam && achou == 0)
{
if (texto1[i] == ' ')
achou = 1;
else
i++;
}
// A fun��o strncpy copia da cadeia texto1, para a cadeia
// texto3 a quantidade de caracteres existentes antes do
// primeiro espa�o em branco
strncpy(texto3, texto1, i + 1);
// A linha abaixo inclui \0 na cadeia TEXTO3
// para finalizar a cadeia que est� sendo gerada
texto3[i + 1] = '\0';
// Na cadeia de caracteres texto3 ser� acrescentada,
// ou seja, concatenada,
// a cadeia "PARA " que est� na vari�vel texto2
strcat(texto3, texto2);
// A linha abaixo concatena o \0 para finalizar
// a cadeia que est� sendo gerada
strcat(texto3, "\0");
// A vari�vel j receber� a pr�xima posi��o a ser ocupada
// no vetor que representa a cadeia de caracteres que est�
// sendo gerada
// Neste exemplo, at� este ponto, a vari�vel texto3 cont�m os
// seguintes caracteres: "PROGRAMA PARA "
j = strlen(texto3);
// A estrutura de repeti��o abaixo copia os caracteres
// ap�s o espa�o em branco da cadeia armazenada na vari�vel
// texto1 para a cadeia armazenada na vari�vel texto3
for (k = i + 1; k<tam; k++)
{
texto3[j] = texto1[k];
j = j + 1;
}
// A linha abaixo acrescenta o \0 para finalizar a
// cadeia que est� sendo gerada
texto3[j] = '\0';
// A linha abaixo mostra a nova cadeia gerada
printf("\nNova cadeia de caracteres = %s\n", texto3);
system("pause");
}
