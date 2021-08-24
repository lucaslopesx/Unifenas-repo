#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){
	
	int sal, perc, aumento, novosal;
	printf("Salario: ");
	scanf("%d",&sal);
	printf("Percentual: ");
	scanf("%d",&perc);
	aumento = sal * perc/100;
	printf("\nNovo Salario: %d",novosal);
	
}
