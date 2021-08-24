#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int n, res, i;
	res = 0;
	
	printf("Digite um número: ");
	scanf("%d",&n);
	
	for(i=1;i<n;i++){
		if(n%i==0){
			res = res + i;
		}
	}
	
	if(res == n){
		printf("O número %d é perfeito!!",n);
	}else{
		printf("O número %d não é perfeito!!",n);
	}
}
