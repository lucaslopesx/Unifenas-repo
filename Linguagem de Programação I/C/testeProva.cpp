#include <stdio.h>
#include <stdlib.h>

int main(void){
	
	int x,y;
	int a =14,b=3;
	float z;
	
	x = a/b;
	y = a%b;
	z = y/x;
	
	printf("x= %d",x);
	printf("\ny= %d",y);
	printf("\nz= %f",z);
	
	
	return 1;
}
