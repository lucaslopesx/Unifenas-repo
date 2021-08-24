#include <iostream>
#include"listOrd.h"
using namespace std;

int main()
{
	listOrd* l1 = new listOrd();

	l1->Insere('c');
	l1->Insere('a');
	l1->Insere('b');
	l1->Insere('f');
	l1->Insere('d');
	l1->Insere('e');

	l1->Mostra();

	l1->Remove('d');
	l1->Mostra();
	cout << endl;
	cout << "Numero de elementos na lista: " << l1->Tamanho() << endl;

	system("pause");
	return 1;
}