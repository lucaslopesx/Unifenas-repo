#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){

int horas_t, vlr_sal_min, vlr_hora_t;
int vlr_sal_bru, imp, vlr_sal_liq;

scanf("%d",&horas_t);
scanf("%d",&vlr_sal_min);

vlr_hora_t = vlr_sal_min / 2;
vlr_sal_bru = vlr_hora_t * horas_t;
imp = vlr_sal_bru * 3/100;
vlr_sal_liq = vlr_sal_bru - imp;

printf("valor salario liquido: %d",vlr_sal_liq);

return 1;
}
