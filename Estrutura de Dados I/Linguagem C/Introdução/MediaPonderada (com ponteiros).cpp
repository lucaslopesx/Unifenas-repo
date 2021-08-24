#include <stdio.h>
#include <stdlib.h>

void media(float n1, float n2, float n3, char c, float *x){
	
	if(c == 'A'){
		*x = (n1+n2+n3)/3;
	}else{
		*x = (n1*5+n2*3+n3*2)/10;
	}
}

int main(void){
	float m;
	
	media(6.5,7.4,8,'A',&m);
	
	printf("Media = %.2f",m);
	
}
