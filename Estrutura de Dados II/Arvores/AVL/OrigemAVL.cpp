#include <iostream>
using namespace std;

struct no_avl {
	char info;
	char fb;// fator de balanceamento
	no_avl* esq, * dir;
};

void RD(no_avl**);
void RE(no_avl**);

void ins_avl(no_avl** t, char x, char* h) {
	if (*t == NULL) {
		*t = new no_avl;
		(*t)->info = x;
		(*t)->esq = (*t)->dir = NULL;
		(*t)->fb = 0;
		*h = 1;
	}
	else
	{
		if (x < (*t)->info) {
			ins_avl(&(*t)->esq, x, h);
			if (*h) {
				switch ((*t)->fb){
					case 1:
						(*t)->fb = 0;
						*h = 0;
						break;
					case 0:
						(*t)->fb = -1;
						break;
					case -1:
						RD(t);
						*h = 0;
				}
			}
			else {
				if (x > (*t)->info) {
					ins_avl(&(*t)->dir, x, h);
					if (*h) {
						switch ((*t)->fb){
							case -1:
								(*t)->fb = 0;
								*h = 0;
								break;
							case 0:
								(*t)->fb = 1;
								break;
							case 1:
								RE(t);
								break;
						}
					}
				}
			}
		}
	}
}
void NP(no_avl* T)
{
	if (T != NULL)
	{
		cout << (int)T->info << " ";
		NP(T->esq);
		NP(T->dir);
	}
	else
		cout << ".";
}

void RD(no_avl** t) {
	no_avl* pb = (*t)->esq;
	if (pb->fb == -1) {// rot simples
		(*t)->esq = pb->dir;
		pb->dir = *t;
		(*t)->fb = 0;
		*t = pb;
	}
	else{//rot dupla
		no_avl* pc = pb->dir;
		pb->dir = pc->esq;
		pc->esq = pb;
		(*t)->esq = pc->dir;
		pc->dir = *t;
		if (pc->fb == -1) {
			(*t)->fb = 1;
		}
		else {
			(*t)->fb = 0;
		}
		if (pc->fb == 1) {
			(*t)->fb = -1;
		}
		else {
			pb->fb = 0;
		}
		*t = pc;
	}
}

void RE(no_avl** t) {
	no_avl* pb = (*t)->dir;
	if (pb->fb == 1) {//rot simples
		(*t)->dir = pb->esq;
		pb->esq = *t;
		(*t)->fb = 0;
		*t = pb;
	}
	else { //rot dupla
		no_avl* pc = pb->esq;
		pb->esq = pc->dir;
		pc->dir = pb;
		(*t)->dir = pc->esq;
		pc->esq = *t;
		if (pc->fb == 1) {
			(*t)->fb = -1;
		}
		else {
			(*t)->fb = 0;
		}
		if (pc->fb == -1) {
			pb->fb = 1;
		}
		else {
			pb->fb = 0;
		}
		*t = pc;
	}
	(*t)->fb = 0;
}

void main() {
	no_avl* t1 = NULL;
	char h;
	ins_avl(&t1, 10, &h);
	ins_avl(&t1, 5, &h);
	ins_avl(&t1, 2, &h);
	NP(t1);

}