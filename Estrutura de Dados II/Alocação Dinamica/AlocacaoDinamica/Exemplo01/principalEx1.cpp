#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
int* subvet(int*, int);

void main(void)
{
	int N;
	setlocale(LC_ALL, "");
	FILE* arq = fopen("dados.txt", "r");

	fscanf(arq, "%d", &N);
	int* V = new int[N];

	for (int I = 0; I < N; I++)
	{
		fscanf(arq, "%d", &V[I]);
	}
	int* SV = subvet(V, N);
	printf("Vetor lido do arquivo:\n");
	for (int I = 0; I < N; I++)
	{
		printf("%d ", V[I]);
	}

	printf("Subvetor gerado pela função:\n");
	for (int I = 0; I < N / 2; I++)
	{
		printf("%d ", SV[I]);
	}
}
int* subvet(int* pV, int T)
{
	int qntd = T / 2;
	int* aux = new int[qntd];

	for (int i = 0; i < qntd; i++)
	{
		aux[i] = pV[i];
	}

	return aux;
}