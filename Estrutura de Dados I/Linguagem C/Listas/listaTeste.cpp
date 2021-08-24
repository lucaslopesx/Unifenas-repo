#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
#include"lista.h"

int main(void){
	
	lista l1;
	
	lInit(&l1);
	
	lIns(&l1,'b');
	lIns(&l1,'m');
	lIns(&l1,'d');
	lIns(&l1,'a');
	lIns(&l1,'p');
	
	lMostra(&l1);
	lConta(&l1,'a');
	
	
	return 1;
}
