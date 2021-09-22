using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetodeMetodosdeOrdenacao
{
    class Metodos
    {
		int t1;
		int c1;

		public int T1 { get => t1; set => t1 = value; }
		public int C1 { get => c1; set => c1 = value; }

		public void QuickSort(int[] vet, int inicio, int fim)
		{
			int aux, pivo, i, j;
			pivo = vet[(inicio + fim) / 2];
			i = inicio;
			j = fim;

			while (i <= j)
			{
				while (vet[i] < pivo)
				{
					i++;
					C1++;
				}
				if (vet[i] > pivo) //Possibilidade do pivo ser maior, tem que contar troca do mesmo jeito
				{
					C1++;
				}

				while (vet[j] > pivo)
				{
					j--;
					C1++;
				}
				if (vet[j] < pivo) //Possibilidade do pivo ser menor, tem que contar troca do mesm jeito
				{
					C1++;
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
			int i, k, nv;
			nv = tam;
			while (nv > 1)
			{
				i = 0;
				while (i < (nv - 1))
				{
					C1++;
					if (vet[i] > vet[i + 1])
					{
						T1++;
						k = vet[i];
						vet[i] = vet[i + 1];
						vet[i + 1] = k;
					}
					i++;
				}
				nv--;
			}
		}
		public void InsertSort(int[] vet)
		{
			int tam = vet.Length;
			int i, j, k;
			i = 1;
			while (i < tam)
			{
				j = i - 1;
				k = vet[i];
				while (j >= 0 && vet[j] > k)
				{
					T1++;
					C1++;
					vet[j + 1] = vet[j];
					vet[j] = k;
					j--;
				}
				if (j != -1 && vet[j] < k)
				{
					C1++;
				}
				i++;
			}
		}
		public void SelectSort(int[] vet)
		{
			int tam = vet.Length;
			int i, j, k, ik;
			i = 0;
			while (i < tam - 1)
			{
				k = vet[i];
				ik = i;
				j = i + 1;
				while (j < tam)
				{
					C1++;
					if (vet[j] < k)
					{
						k = vet[j];
						ik = j;
					}
					j++;
				}
				vet[ik] = vet[i];
				vet[i] = k;
				i++;
				T1++;
			}
		}

	}
}
