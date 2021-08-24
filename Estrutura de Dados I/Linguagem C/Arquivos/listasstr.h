#define TAM 8
#include <string.h>
typedef char Elem[30];

typedef struct
{
	Elem M[TAM];
	int Fim;
} Lista;

void Linit(Lista *L)
{
	L->Fim=0;
}

void Lins(Lista *L,Elem X)
{
	if (L->Fim<TAM) 
	{
		int i=L->Fim;
		while (i>0 and strcmp(X,L->M[i-1])<0)
		{
			strcpy(L->M[i],L->M[i-1]);
			i--;
		}
		strcpy(L->M[i],X);
		L->Fim++;
	}
}

void Lmostra (Lista *L)
{
    printf ("[");
    int i;

    for (i=0;i<L->Fim;i++)
    {
        printf("%s",L->M[i]);
        if (i+1 < L->Fim)
            printf(",");
    }
    printf ("]");
}

void Lmostra_intervalo(Lista *L, Elem XI, Elem XF)
{
	int i=0;
	printf("[");
	while((L->Fim>i)&&(strcmp(XI,L->M[i])>0))
	{
		i++;
	}
	
	while((i<L->Fim)&&(strcmp(XF,L->M[i])>=0))
	{
		printf("%s ",L->M[i]);
		i++;
	}
	printf("]");
}

//int Lconta(Lista *L, char X)
//{
//	int i=0, no=0;
//	
//	while((i<L->Fim)&&(X>L->M[i]))
//		i++;
//	
//	while((i<L->Fim)&&(X==L->M[i]))
//	{
//		no++;
//		i++;
//	}
//	return no;
//}

char Lrem(Lista *L, Elem X)
{
	int i=0;
	while(i<L->Fim and strcmp(X,L->M[i])>0)
	{
		i++;
	}
	if(i<L->Fim and !strcmp(X,L->M[i]))
	{
		while(i<(L->Fim-1))
		{
			strcpy(L->M[i],L->M[i+1]);
			i++;
		}
		L->Fim--;
		return 1;
	}
	else
	{
		return 0;
	}
	
}

 
