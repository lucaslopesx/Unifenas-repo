#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int i;
	
	for(i=0;i<=9;i++){
		printf("%d\n",i);
	}
	
	printf("=============\n");
	
	for(i=10;i>=0;i--){
		if(i%2==0){
			printf("%d\n",i);
		}
	}
	
	}
