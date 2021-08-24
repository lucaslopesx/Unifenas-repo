#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){

int p_fab, perc_d, perc_i, vlr_d, vlr_i, p_final;
scanf("%d",&p_fab);
scanf("%d",&perc_d);
scanf("%d",&perc_i);

vlr_d = p_fab * perc_d / 100;
vlr_i = p_fab * perc_i / 100;

p_final = p_fab + vlr_d + vlr_i;
printf("\nLucro: %d",vlr_d);
printf("\nImpostos: %d",vlr_i);

printf("\nPREÇO FINAL: %d", p_final);

return 1;
}
