#include <stdio.h>
#include <stdlib.h>

float media(float n1, float n2, float n3, char c){
	float r;
	if(c == 'A'){
		r = (n1+n2+n3)/3;
	}else{
		r = (n1*5+n2*3+n3*2)/10;
	}
	return r;
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
	
	m = media(n1,n2,n3,op);
	
	printf("Media = %.2f",m);
	
	return 1;
	
}
