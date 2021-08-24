#include <stdio.h>
#include <stdlib.h>

void media(float n1, float n2, float n3, char c, float *x){
	
	if(c == 'A'){
		*x = (n1+n2+n3)/3;
	}else{
		*x = (n1*5+n2*3+n3*2)/10;
	}
}

int main(void){
	float m;
	float n1,n2,n3;
	char op;
	
	printf("Nota 1: ");
	scanf("%f",&n1);
	printf("Nota 2: ");
	scanf("%f",&n2);
	printf("Nota 3: ");
	scanf("%f",&n3);
	
	printf("Media aritmetica [A] ou ponderada [B]: ");
	scanf(" %c",&op);
	
	media(n1,n2,n3,op,&m);
	
	printf("Media = %.2f",m);
	
	return 1;
	
}
