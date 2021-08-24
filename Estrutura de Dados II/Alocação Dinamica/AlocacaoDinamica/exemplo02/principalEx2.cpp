#define _CRT_SECURE_NO_WARNINGS
#include <iostream>


int main(void) {
	int nl, nc;

	FILE* arq = fopen("dados.txt", "r");

	fscanf(arq, "%d %d", &nl, &nc);

	int** m;
	m = new int* [nl];

	for (int i = 0; i < nl; i++)
	{
		m[i] = new int[nc];
	}

	for (int i = 0; i < nl; i++)//linhas
	{
		for (int j = 0; j < nc; j++)//colunas
		{
			fscanf(arq, "%d", &m[i][j]);
		}
	}

	for (int i = 0; i < nl; i++)
	{
		for (int j = 0; j < nc; j++)
		{
			printf("%4d", m[i][j]);
		}
		printf("\n");
	}
}