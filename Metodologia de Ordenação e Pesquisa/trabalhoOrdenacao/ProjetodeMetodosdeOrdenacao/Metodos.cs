using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetodeMetodosdeOrdenacao
{
    class Metodos
    {
		int t1, t2, t3, t4;
		int c1, c2, c3, c4;

        public int T1 { get => t1; set => t1 = value; }
		public int T2 { get => t2; set => t2 = value; }
		public int T3 { get => t3; set => t3 = value; }
        public int T4 { get => t4; set => t4 = value; }
        public int C1 { get => c1; set => c1 = value; }
        public int C2 { get => c2; set => c2 = value; }
        public int C3 { get => c3; set => c3 = value; }
        public int C4 { get => c4; set => c4 = value; }

        public void QuickSort(int[] vet, int inicio, int fim)
		{
			int aux, pivo, i, j, pivoAux;
			pivoAux = (inicio + fim) / 2;
			pivo = vet[pivoAux];
			i = inicio;
			j = fim;

			while (i<=j)
			{
				C1++; 
				while (vet[i] < pivo)
				{
					
					i++;
				}
				while (vet[j] > pivo)
				{
					
					j--;
				}
				if (i <= j)
				{
					T1++;
					aux = vet[i];
					vet[i] = vet[j];
					vet[j] = aux;
					i++;
					j--;
				}
			}
			if (j > inicio)
			{
				QuickSort(vet, inicio, j);
			}
			if (i < fim)
			{
				QuickSort(vet, i, fim);
			}
		}
		public void BubbleSort(int[] vet)
		{
			int tam = vet.Length;
			for (int ultimo = tam - 1; ultimo > 0; ultimo--)
			{
				for (int i = 0; i < ultimo; i++)
				{
					C2++;
					if (vet[i] > vet[i + 1])
					{
                        T2++;
						int aux = vet[i];
						vet[i] = vet[i + 1];
						vet[i + 1] = aux;
					}
				}
			}
		}
		public void InsertSort(int[] vet)
		{
			int tam = vet.Length;
			int aux, j;
			for (int i = 0; i < tam; i++)
			{
				aux = vet[i];
				j = i - 1;
				while (j >= 0 && vet[j] > aux)
				{
					C3++;
					T3++;
					vet[j + 1] = vet[j];
					j--;
				}
				vet[j + 1] = aux;
			}
		}
		public void SelectSort(int[] vet)
		{
			int tam = vet.Length;
			for (int i = 0; i < tam - 1; i++)
			{
				int min = i;
				for (int j = i + 1; j < tam; j++)
				{
					C4++;
					if (vet[j] < vet[min])
					{
						min = j;
					}
				}
				if (vet[i] != vet[min])
				{
					T4++;
					int aux = vet[i];
					vet[i] = vet[min];
					vet[min] = aux;
				}
			}
		}
		
	}
}
