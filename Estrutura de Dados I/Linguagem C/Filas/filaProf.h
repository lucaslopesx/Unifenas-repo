#define TAM 4
typedef struct
	{
		char M[TAM];
		int Com,Fim,Total;	
	} Fila;

void Qinit(Fila *F)
{
	F->Com = 0;
	F->Fim = 0;
	F->Total = 0;
}

void Enqueue(Fila *F, char X)
{
	if (F->Total<TAM)
	{
		F->M[F->Fim]=X;
		F->Fim++;
		if (F->Fim==TAM)
		{
			F->Fim=0;
		}
		F->Total++;
	}
}

char Dequeue(Fila *F)
{
	if (F->Total>0)
	{
		char X=F->M[F->Com];
		F->Com++;
		if (F->Com==TAM)
		{
			F->Com=0;
		}
		F->Total--;
		return X;
	}
}

char Qisempty(Fila *F)
{
	if (F->Total==0)
		return 1;
	else
		return 0;
}

char Qisfull(Fila *F)
{
	if (F->Total==TAM)
		return 1;
	else
		return 0;
}

void Mostra(Fila *F)
{
	printf("[");
	int i=F->Com;
	int c;
	for (c=0;c<F->Total;c++)
	{
		printf("%c",F->M[i]);
		i++;
		if (i==TAM)
		   i=0;
		if (c<F->Total-1)
		    printf(",");
	}
	printf("]");
	
}

