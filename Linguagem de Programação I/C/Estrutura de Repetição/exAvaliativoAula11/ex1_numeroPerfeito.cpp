#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int n, res, i;
	res = 0;
	
	printf("Digite um n�mero: ");
	scanf("%d",&n);
	
	for(i=1;i<n;i++){
		if(n%i==0){
			res = res + i;
		}
	}
	
	if(res == n){
		printf("O n�mero %d � perfeito!!",n);
	}else{
		printf("O n�mero %d n�o � perfeito!!",n);
	}
}
