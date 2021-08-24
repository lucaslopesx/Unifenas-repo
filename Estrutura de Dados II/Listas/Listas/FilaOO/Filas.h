#pragma once

#include <iostream>

using namespace std;

class Fila
{
private:
	struct no
	{
		char info;
		no* prox;
	} *f, *i;
	int tam;
public:
	Fila();
	void Enqueue(char);
	void EnqueueIni(char);
	char Dequeue();
	char DequeueFim();
	int Tamanho();
	void Mostra();
};

Fila::Fila()
{
	f = NULL;
	i = NULL;
	tam = 0;
}

int Fila::Tamanho()
{
	return tam;
}

void Fila::Mostra()
{
	no* aux = i;
	cout << '[';
	while (aux != NULL)
	{
		cout << aux->info;
		if (aux->prox != NULL)
		{
			cout << ',';
		}
		aux = aux->prox;
	}
	cout << ']' << endl;
}

void Fila::Enqueue(char x)
{
	no* aux = new no;
	aux->info = x;
	aux->prox = NULL;
	if (tam == 0)
	{
		f = aux;
		i = aux;
	}
	else
	{
		f->prox = aux;
		f = aux;
	}
	tam++;
}

void Fila::EnqueueIni(char x)
{
	no* aux = new no;
	aux->info = x;
	aux->prox = i;
	if (tam == 0)
	{
		f = aux;
		i = aux;
	}
	else 
	{
		i = aux;
	}
	tam++;
}

char Fila::Dequeue()
{
	char x = 0;
	if (tam != 0)
	{
		no* aux = i;
		i = aux->prox;
		if (i == NULL)
		{
			f = NULL;
		}
		tam--;
		x = aux->info;
		delete aux;
	}
	return x;
}

char Fila::DequeueFim() 
{
	char x;
	if (tam > 0)
	{
		if (tam == 1)
		{
			x = i->info;
			delete i;
			i = NULL;
			f = NULL;
		}
		else
		{
			no* aux = i;
			while (aux->prox != f)
			{
				aux = aux->prox;
			}
			x = f->info;
			f = aux;
			delete aux->prox;
			f->prox = NULL;
			tam--;
		}
	}
	else
	{
		x = ' ';
		cout << "A fila esta vazia" << endl;
	}
	return x;
}
