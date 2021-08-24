#include <stdio.h>
#include <stdlib.h>

int main(void){
	int i,j,k,ma[3][3],mb[3][3],mMult[3][3],aux;
	
	for(i=0;i<3;i++){
		for(j=0;j<3;j++){
			printf("Digite o valor na linha %d na coluna %d: ",i,j);
			scanf("%d",&ma[i][j]);
		}
	}
	
	for(i=0;i<3;i++){
		for(j=0;j<3;j++){
			printf("Digite o valor na linha %d na coluna %d: ",i,j);
			scanf("%d",&mb[i][j]);
		}
	}
	
	for(i=0;i<3;i++){
		for(j=0;j<3;j++){
			aux = 0;
			for(k=0;k<3;k++){
				aux += ma[i][k] * mb[k][j];
			}
			mMult[i][j] = aux;
		}
	}
	
	for(i=0;i<3;i++){
		for(j=0;j<3;j++){
			printf("%d ",mMult[i][j]);
		}
		printf("\n");
	}
	return 1;
}
