#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int n, x, i, j, fat;
	
	printf("Digite a quantidade de números a serem lidos: ");
	scanf("%d",&n);

	for(i=1;i<=n;i++){
		printf("\nDigite o %d° valor: ",i);
		scanf("%d",&x);
		fat = 1;
		j=1;
			while(j<=x){
				fat = fat * j;
				j++;
			}
		printf("Fatorial do número %d! = %d \n", x, fat);
	}
	
}
