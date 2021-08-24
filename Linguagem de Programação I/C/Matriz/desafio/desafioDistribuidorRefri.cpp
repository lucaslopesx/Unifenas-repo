#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	int i,j,m[4][5], soma=0;
	
	for(i=0;i<4;i++){
		for(j=0;j<5;j++){
			printf("Digite o valor no %d° trimestre na região %d: ",i+1,j+1);
			scanf("%d",&m[i][j]);
			soma += m[i][j];
		}
	}
	
	printf("A soma total de vendas foi de: %d",soma);
	return 1;
}
