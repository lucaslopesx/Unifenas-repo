#include <iostream>

void troca(int *i, int *j){
	int temp;
	temp = *i;
	*i = *j;
	*j = temp;
}
 

int main(){

	int a=3, b=7;
	troca(&a,&b);
	
	printf("%d %d \n",a,b);
	
	return 1;

}

