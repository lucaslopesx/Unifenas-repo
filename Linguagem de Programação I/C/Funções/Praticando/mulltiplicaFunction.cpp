#include <stdio.h>
#include <stdlib.h>

int multiplica(int num){
	int i, res = 0;
	
	for(i=0;i<=10;i++){
		res = num * i;
		printf("\n%d x %d = %d",num,i,res);
	}
}

int main(void){
	int num, res;
	
	printf("Digite um valor de 1 a 9: ");
	scanf("%d",&num);	
	
	res = multiplica(num);	
}
