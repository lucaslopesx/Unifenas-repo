using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
	class Metodos
	{
		public void QuickSort(int[] vet, int inicio, int fim)
		{
			int aux, pivo, i, j, pivoAux;
			pivoAux = (inicio + fim) / 2;
			pivo = vet[pivoAux];
			i = inicio;
			j = fim;

			while (i<=j)
			{
				while (vet[i] < pivo)
				{
					i++;
				}
				while (vet[j] > pivo)
				{
					i--;
				}
				if (i <= j)
				{
					aux = vet[i];
					vet[i] = vet[j];
					vet[j] = aux;
					i++;
					j--;
				}
			}
			if (j > pivo)
			{
				QuickSort(vet, inicio, j);
			}
			if (i < fim)
			{
				QuickSort(vet, i, fim);
			}
		}

	}
}
