#include <iostream>
#include "OrigemABB.h"

using namespace std;

struct no
{
	char info;
	no* esq, * dir;
};

void TIns(no** t, char x)
{
	if (*t == NULL)
	{
		*t = new no;
		(*t)->info = x;
		(*t)->esq = (*t)->dir = NULL;
	}
	else
	{
		if (x<(*t)->info)
		{
			TIns(&((*t)->esq), x);
		}
		else
		{
			TIns(&((*t)->dir), x);
		}
	}
}

void PreOrdem(no* t)
{
	if (t != NULL)
	{
		cout << (int)t->info << " ";
		PreOrdem(t->esq);
		PreOrdem(t->dir);
	}
	else
	{
		cout << ". ";
	}
}

void EmOrdem(no* t) 
{
	if (t != NULL)
	{
		EmOrdem(t->esq);
		cout << (int)t->info << " ";
		EmOrdem(t->dir);
	}
	else
	{
		cout << ". ";
	}
}

int Max(int esq, int dir)
{
	if (esq >= dir)
	{
		return esq;
	}
	else if (dir > esq)
	{
		return dir;
	}
	return 0;
}

int altura(no* t)
{
	if (t == NULL)
	{
		return 0;
	}
	else
	{
		return 1 + Max(altura(t->esq), altura(t->dir));
	}
}


void PosOrdem(no* t)
{
	if (t != NULL)
	{
		PosOrdem(t->esq);
		PosOrdem(t->dir);
		cout << (int)t->info << " ";
	}
	else
	{
		cout << ". ";
	}
}

char Pesquisa(no** t, char x)
{
	if (*t == NULL)
	{
		return 0;
	}
	else if (x < (*t)->info)
	{
		Pesquisa(&(*t)->esq, x);
	}
	else if (x > (*t)->info)
	{
		Pesquisa(&(*t)->dir, x);
	}
	else
	{
		return 1;
	}
}

no* getMax(no** t)
{
	if ((*t)->dir == NULL)
	{
		no* p = *t;
		*t = p->esq;
		return p;
	}
	else
	{
		return getMax(&(*t)->dir);
	}
}

char Remove(no** t, char x)
{
	if ((*t) == NULL) 
		return 0;
	if ((*t)->info == x)
	{
		no* p = *t;
		if ((*t)->dir == NULL)
		{
			*t = (*t)->esq;
		}
		else if ((*t)->esq == NULL)
		{
			*t = (*t)->dir;
		}
		else 
		{
			p = getMax(&(*t)->esq);
			(*t)->info = p->info;
		}
		delete p;
		return 1;
	}
	if (x < (*t)->info)
	{
		return Remove(&(*t)->esq, x);
	}
	else 
	{
		return Remove(&(*t)->dir, x);
	}
}

int main(void) 
{
	no* t = NULL;
	
	TIns(&t, 5);
	TIns(&t, 9);
	TIns(&t, 3);
	TIns(&t, 4);
	TIns(&t, 2);
	TIns(&t, 8);
	TIns(&t, 1);
	TIns(&t, 11);


	cout << "PreOrdem" << endl;
	PreOrdem(t);
	cout << endl;

	char r = Remove(&t, 11);
	if (r)
	{
		cout << "\nElemento Removido" << endl;
	}
	else
	{
		cout << "\nElemento Inexistente" << endl;
	}
	cout << "\nEmOrdem" << endl;
	EmOrdem(t);
	cout << endl;
	cout << "\nPosOrdem" << endl;
	PosOrdem(t);
	cout << endl;
	cout << "\nAltura: " << altura(t) << endl;

	

	char p = Pesquisa(&t, 5);
	if (p)
	{
		cout << "\nElemento encontrado" << endl;
	}
	else
	{
		cout << "\nElemento nao encontrado" << endl;
	}
	return 0;
}