#include <stdio.h>
#include <stdlib.h>

int main(){
	
	int n, r, i=0;
	int m[8];
	
	printf("Digite um numero: ");
	scanf("%d",&n);
	
	while(n>0){
		r = n % 2;
		n = n / 2;
		m[i] = r;
		i++;
	}
	
	printf("Corresponde em binario: ");
	
	while(i>0){
		i--;
		printf("%d",m[i]);
	}
	
	return 1;
}
