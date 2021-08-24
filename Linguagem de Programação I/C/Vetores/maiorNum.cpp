#include <stdio.h>
#include <stdlib.h>

int main(void){

	int x[5],i,maiorNum=0;
	
	for(i=0;i<5;i++){
		printf("Digite um numero: ");
		scanf("%d",&x[i]);
		if(x[i]>maiorNum){
			maiorNum = x[i];
		}
	}
	
	printf("Maior numero: %d",maiorNum);


	return 1;
}
