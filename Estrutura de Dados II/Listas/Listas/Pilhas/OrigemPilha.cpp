#include <iostream>

using namespace std;

struct no
{
	char info;
	no* prox;
};

void Push(no** p, char x) 
{
	no* aux = new no;
	aux->info = x;
	aux->prox = *p;
	*p = aux;
}

char Pop(no** p)
{
	char x;
	if(*p != NULL) 
	{
		x = (*p)->info;
		no* aux = *p;
		*p = (*p)->prox;
		delete aux;
	}
	return x;
}

void Kill(no** p) 
{
	no* aux;
	while (*p != NULL)
	{
		aux = *p;
		*p = aux->prox;
		delete aux;
	}
}

void Mostra(no* p) 
{
	cout << '[';
	while (p != NULL)
	{
		cout << p->info;
		if (p->prox != NULL) {
			cout << ',';
		}
		p = p->prox;
	}
	cout << ']';
}

int main() 
{
	no* p1 = NULL;
	Push(&p1, 'a');
	Push(&p1, 'b');
	Push(&p1, 'c');

	/*char y = Pop(&p1);
	cout << "Elemento do topo: " << y << endl;

	y = Pop(&p1);
	cout << "Elemento do topo: " << y << endl;*/

	Mostra(p1);
	Kill(&p1);

	

	return 0;
}