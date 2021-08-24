#include <stdio.h>
#include <stdlib.h>

int verifica(int num){
	int res;
	if(num>0){
		res = 1;
	}else{
		res = 0;
	}
	return res;
}
int main(void){
	int num,res;
	printf("Digite um valor diferente de 0: ");
	scanf("%d",&num);
	
	res = verifica(num);

	if(res == 1){
		printf("O numero e positivo!!");
	}else{
		printf("O numero e negativo!!");
	}
	
	return 1;
}
