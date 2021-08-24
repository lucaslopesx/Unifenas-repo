#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

using namespace std;

struct no
{
	char info;
	no* prox;
};


int main(void) 
{
	no* l1;
	l1 = new no;
	l1->info = 'a';
	l1->prox = NULL;

	no* aux = new no;
	aux->info = 'b';
	aux->prox = NULL;
	l1->prox = aux;

	cout << l1->info;
	cout << l1->prox->info;


	return 0;
}