#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	char c[22] = "Ciência da computação";
	int i;
	i = 0;
	while(i<10){
		printf("%s\n",c);
		i++;
	}
	return 1;
}
