#include <iostream>
#include "Filas.h"

using namespace std;

int main() 
{
	Fila *f = new Fila();

	f->Enqueue('a');
	f->Enqueue('b');
	f->Enqueue('c');
	f->Enqueue('d');
	f->EnqueueIni('f');


	f->Mostra();
	char x = f->Dequeue();

	char y = f->DequeueFim();

	cout << "Retirado do comeco da fila: " << x << endl;

	cout << "Retirado do final da fila: " << y << endl;
	f->Mostra();

	cout << "Tamanho da fila FINAL: " << f->Tamanho() << endl;
}