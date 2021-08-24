#include <stdio.h>
#include <stdlib.h>
#include "filas.h"

int main(void){
	
	fila f1;
	qInit(&f1);
	enQueue(&f1,'a');
	enQueue(&f1,'b');
	enQueue(&f1,'c');
	enQueue(&f1,'d');
	enQueue(&f1,'e');
	
	mostra(&f1);
	printf("\n");
	
	deQueue(&f1);
	deQueue(&f1);
	
	mostra(&f1);
	return 1;
}
