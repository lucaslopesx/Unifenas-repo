#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){
	int sal, salreceber, grat, imp;
	
	printf("Salario: ");
	scanf("%d",&sal);
	grat = sal * 0.05;
	imp = sal * 0.07;
	
	salreceber = sal + grat - imp;
	
	printf("Novo salario: %d",salreceber);
	
	return 1;
}
