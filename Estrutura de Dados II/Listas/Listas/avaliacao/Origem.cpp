#include <iostream>

void calcula(int i, int j, int *k)
{
	*k = i + j;
}

int main(void)
{
	int r;
	calcula(5, 2, &r);
	printf("Resultado = %d\n", r);
}