#include <stdio.h>

void maior(int x,int y,int *z){
	if (x>y){
		*z = x;
	}else{
		*z = y;
	}	
}

void trocar(int *a,int *b){
	int aux;
	
	aux = *a;
	*a = *b;
	*b = aux;
}

int main(void){
	
	int m;
	int a,b;
	
	printf("Entre com o primeiro valor: ");
	scanf("%d",&a);
	printf("Entre com o segundo valor: ");
	scanf("%d",&b);
	
	maior(a,b,&m);
	
	printf("Maior valor = %d \n",m);
	
	trocar(&a,&b);
	printf("TROCANDO...");
	printf("\nValor de a = %d",a);
	printf("\nValor de b = %d",b);
	
	
	return 1;
}
