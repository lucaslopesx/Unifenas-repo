#pragma once

#include <iostream>

using namespace std;

class listOrd
{
private: 
	struct no
	{
		char info;
		no* prox;
	};
	no* l;
	int tam;

public: 
	listOrd();
	void Insere(char);
	char Remove(char);
	void Mostra();
	int Tamanho();
};


listOrd::listOrd()
{
	l = NULL;
	tam = 0;
}

void listOrd::Insere(char x)
{
	no* n = new no;
	n->info = x;
	if (l == NULL or x < l->info)
	{
		n->prox = l;
		l = n;
		tam++;
	}
	else
	{
		no* p = l;
		while (p->prox != NULL and x > p->prox->info)
		{
			p = p->prox;
		}
		n->prox = p->prox;
		p->prox = n;
		tam++;
	}
	
}

char listOrd::Remove(char x)
{
	if (l == NULL || x < l->info)
	{
		return 0;
	}
	if (x == l->info)
	{
		no* n = l;
		l = l->prox;
		delete n;
		tam--;
		return 1;
	}
	no* p = l;
	while (p->prox != NULL && x > p->prox->info)
	{
		p = p->prox;
	}
	if (p->prox != NULL && x == p->prox->info)
	{
		no* n = p->prox;
		p->prox = n->prox;
		delete n;
		tam--;
		return 1;
	}
	return 0;
}



void listOrd::Mostra()
{
	no* p = l;
	cout << '[';
	while (p != NULL)
	{
		cout << p->info;
		if (p->prox != NULL)
		{
			cout << ',';
		}
		p = p->prox;
	}
	cout << ']' << endl;
}

int listOrd::Tamanho()
{
	return tam;
}
