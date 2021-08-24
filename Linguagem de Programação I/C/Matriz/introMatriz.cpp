#include <stdio.h>
#include <stdlib.h>

int main(void){
	int i,j,m[3][5];
	
	for(i=0;i<3;i++){
		for(j=0;j<5;j++){
			m[i][j] = 1;
		}
	}
	
	for(i=0;i<3;i++){
		for(j=0;j<5;j++){
			printf("%d",m[i][j]);
		}
		printf("\n");
	}
	return 1;
}
