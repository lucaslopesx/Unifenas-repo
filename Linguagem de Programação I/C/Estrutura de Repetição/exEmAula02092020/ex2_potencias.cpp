#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int base, pot, i;
	double res; //double para poder guardar um valor maior caso necessário
	
	printf("Digite um número para a base: ");
	scanf("%d",&base);
	printf("Digite um número para a potencia: ");
	scanf("%d",&pot);
	
	for(i=0;i<=pot;i++){
		res = pow(base,i);
		printf("Resultado com a potência %d na base %d: %d\n",pot , base, res);
	}
	
	return 1;
	
}
