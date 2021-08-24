#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int i,soma;
	i=0;
	soma=0;
	while(i<=100){
		if(i%2 == 0){
			soma = soma + i;
		}
		i++;
	}
	printf("Soma dos pares menores que 100: %d",soma);

}
