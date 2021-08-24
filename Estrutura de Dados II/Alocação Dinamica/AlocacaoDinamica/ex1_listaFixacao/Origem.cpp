#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

char* substr(char*, int, int);

char* substr(char* v, int ini, int tam) 
{
	char* aux = new char[tam + 1];
	int j = ini;
	for (int i = 0; i < tam; i++)
	{
		aux[i] = v[j];
		j++;
	}
	aux[tam] = '\0';
	return aux;
}

int main(void) 
{
	char site[40] = "http://www.unifenas.br/inscricao.asp";
	char* s;

	s = substr(site, 7, 15);

	printf("%s", site);

	return 0;
}