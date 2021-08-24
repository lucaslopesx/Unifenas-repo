#include <iostream>
#include "Pilhas.h"

using namespace std;

int main() {

	Pilha *p = new Pilha();

	p->Push('a');
	p->Push('b');
	p->Push('c');

	char x = p->Pop();

	cout << x << endl;

	cout << "tamanho da pilha: " << p->tamanho() << endl;

	
	return 0;
}
