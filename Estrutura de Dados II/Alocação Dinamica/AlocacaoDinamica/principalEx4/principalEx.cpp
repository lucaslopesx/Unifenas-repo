#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

int* Max(int* pV1, int* pV2, int n)
{
	int* aux = new int[n];
	for (int i = 0; i < n; i++)
	{
		if (pV1[i] >= pV2[i])
		{
			aux[i] = pV1[i];
		}
		else
		{
			aux[i] = pV2[i];
		}
	}
	return aux;
}

int main(void) 
{
	int v1[5] = { 2,5,3,8,6 };
	int v2[5] = { 8,2,0,5,6 };

	int* m = Max(v1, v2, 5);

	for (int i = 0; i < 5; i++)
	{
		printf("%d ", m[i]);
	}

	return 0;
}