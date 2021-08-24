#include <stdio.h>

int maior(int x, int y){
	if(x>y){
		return x;
	}else{
		return y;
	}
}

float media(int a, int b){
	float media;
	
	media = (a+b)/2.0;
	
	return media;
}

int main(void){
	
	int a=35, b=70;
	
//	int m;
	
//	m = maior(a,b);

	printf("Valor de a: %d",a);
	printf("\nValor de b: %d",b);
	
	printf("\n\nMaior valor: %d",maior(a,b));
	printf("\nMedia dos valores: %.2f",media(a,b));
	
	return 1;
}
