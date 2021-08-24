#include <stdio.h>
#include <stdlib.h>

int main(void){
	int i,j,m[3][2],mt[2][3];
	
	for(i=0;i<3;i++){
		for(j=0;j<2;j++){
			printf("Digite o valor na linha %d na coluna %d: ",i,j);
			scanf("%d",&m[i][j]);
		}
	}
	
	for(i=0;i<3;i++){
		for(j=0;j<2;j++){
			mt[j][i] = m[j][i];
		}
	}
	for(i=0;i<2;i++){
		for(j=0;j<3;j++){
			printf("%d ",m[j][i]);
		}
		printf("\n");
	}
	return 1;
}
