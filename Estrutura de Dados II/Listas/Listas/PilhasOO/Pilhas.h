#pragma once

#include <iostream>

using namespace std;

class Pilha
{
private:
	struct no
	{
		char info;
		no* prox;
	} *p;
	int tam;
public: 
	Pilha();
	void Push(char);
	char Pop();
	int tamanho();
};

Pilha::Pilha()
{
	p = NULL;
	tam = 0;
}

int Pilha::tamanho()
{
	return tam;
}

void Pilha::Push(char x)
{
	no* aux = new no;
	aux->info = x;
	aux->prox = p;
	p = aux;
	tam++;
}

char Pilha::Pop()
{
	char x;
	if (p != NULL)
	{
		no* aux = p;
		x = aux->info;
		p = aux->prox;
		tam--;
		delete aux;
	}
	return x;
}

