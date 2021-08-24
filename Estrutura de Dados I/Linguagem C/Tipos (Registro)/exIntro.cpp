#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

typedef float inteiro;

int main(void){
	setlocale(LC_ALL,"");

	inteiro x;
	int y;
	
	x=10.5;
	
	printf("%f",x);
	
	return 1;
}
