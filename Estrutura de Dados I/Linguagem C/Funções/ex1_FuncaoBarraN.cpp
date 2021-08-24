#include <stdio.h>

void linha(){
	printf("======================\n");
}

void linhanc(int n){
	int c;
	for(c=0;c<n;c++){
		printf("=");
	}
	printf("\n");

}

int main(){
	int k;
	linhanc(10);
	printf("UNIFENAS");
	linhanc(10);
	
	for(k=0;k<15;k++){
		linhanc(k);
	}
	
}
