#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){
	
	int sal, novosal;
	
	printf("Salario: ");
	scanf("%d",&sal);
	
	novosal = sal + sal * 25/100;
	
	printf("%d",novosal);
}
