#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){
	int sal, salreceber, imp;
	printf("salario: ");
	scanf("%d",&sal);
	
	imp = sal * 10/100;
	
	salreceber = sal + 50 - imp;
	
	printf("salario a receber: %d",salreceber);
	
	return 1;
}
