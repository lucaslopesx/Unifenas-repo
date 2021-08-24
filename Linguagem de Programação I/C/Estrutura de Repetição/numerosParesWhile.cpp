#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int i;
	i = 0;
	while(i<=20){
		if(i%2 == 0){
			printf("%d\n",i);	
		}
		i++;
	}

}
