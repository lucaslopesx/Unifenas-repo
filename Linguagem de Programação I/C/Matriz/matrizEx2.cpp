#include <stdio.h>
#include <stdlib.h>

int main(void){
	int i,j,m[3][4],aux=11;
	
	for(i=0;i<3;i++){
		for(j=0;j<4;j++){
			m[i][j] = aux;
			aux++;
		}
	}
	
	for(i=0;i<3;i++){
		for(j=0;j<4;j++){
			printf("%d ",m[i][j]);
		}
		printf("\n");
	}
	return 1;
}
