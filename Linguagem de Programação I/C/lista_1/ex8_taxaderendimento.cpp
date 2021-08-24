#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){
	
	int dep, taxa, rend, total;
	
	printf("Deposito: ");
	scanf("%d",&dep);
	printf("Taxa: ");
	scanf("%d",&taxa);
	
	rend = dep * taxa/100;
	total = dep + rend;
	
	printf("%d",rend);
	printf("\n%d",total);
	
	return 1;
}
