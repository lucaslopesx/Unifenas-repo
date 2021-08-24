#include <stdlib.h>
#include <stdio.h>

int main(void){
	
	int m[3][6], i, j;
	
	for(i=0;i<3;i++){
		for(j=0;j<6;j++){
			printf("Digite o valor da linha %d e coluna %d: ",i,j);
			scanf("%d",&m[i][j]);
		}
	}
	for(i=0;i<3;i++){
		for(j=0;j<6;j++){
			printf(" %d",m[i][j]);
		}
		printf("\n");
	}
	
	return 1;
}
