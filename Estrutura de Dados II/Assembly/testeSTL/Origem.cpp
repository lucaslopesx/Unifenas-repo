/*
#include <queue>
#include <iostream>
using namespace std;

void printQ(queue<int> q)
{
    queue<int> queue = q;
    while (!queue.empty()) {
        cout << " " << queue.front();
        queue.pop();
    }
    cout << '\n';
}
int main()
{

    queue <int> q1, q2;

    q1.push(10);
    q1.push(11);
    q1.push(9);
    q1.push(76);
    q2.push(153);
    q2.push(100);
    q2.push(870);
    q2.push(654);
    q2.push(999);

    swap(q1, q2);

    if (q1.empty())
    {
        cout << "A fila esta vazia" << endl;
    }
    else
    {
        cout << "A fila possui elementos" << endl;
        printQ(q1);
    }

    cout << "Primeiro: " << q1.front() << endl; //Elemento que está em primeiro da fila
    cout << "Ultimo: " << q1.back() << endl; //Elemento que está por ultimo da fila
    q1.pop();
    cout << "Primeiro apos pop(): " << q1.front() << endl; //Elemento que está em primeiro da fila após o pop()

}
*/



/*
#include <list>
#include <iostream>

int main()
{
    using namespace std;
    list<int> l1;


    l1.push_back(10);
    l1.push_back(6);
    l1.push_back(12);
    l1.push_back(87);
    l1.push_back(1);

    cout << "Quantidade de elementos na lista: " << l1.size() << endl;
    cout << "Ultimo elemento: " << l1.back() << endl; //Mostra o ultimo elemento da lista
    cout << "Primeiro elemento: " << l1.front() << endl; //Mostra o primeiro elemento da lista
    l1.sort(); //Ordena a lista em ordem crescente
    cout << "Ultimo elemento apos ordenacao: " << l1.back() << endl; //Mostra o ultimo elemento da lista
    cout << "Primeiro elemento apos ordenacao: " << l1.front() << endl; //Mostra o primeiro elemento da lista

}
*/


/*
#include <vector>
#include <iostream>
using namespace std;
int main()
{
    vector<int> vet1;

    vet1.push_back(1);
    vet1.push_back(2);
    vet1.push_back(3);
    vet1.push_back(4);
    vet1.push_back(15);
    vet1[5] = 100;

    int tam = vet1.size();
    int maxTam = vet1.max_size();
    int back = vet1.back();
    int x = vet1.at(2);

    cout << "Tamanho atual do vetor: " << tam << endl;
    cout << "Tamanho maximo do vetor: " << maxTam << endl;
    cout << "Ultimo elemento: " << back << endl;
    cout << "Mostra o elemento que está no index 2: " << x << endl;
    for (int i = 0; i < vet1.size(); i++)
    {
        cout << vet1[i] << " ";
    }
}
*/



/*
#include <stack>
#include <iostream>

int main()
{
    using namespace std;
    stack <string> s1, s2;

    s2.push("Lucas");
    s2.push("Camila");
    s2.push("Gustavo");
    s1.push("Joao");
    s1.push("Maria");
    s1.push("Pedro");
    s1.push("Flavia");
    s1.push("Felipe");

    swap(s1, s2);

    cout << "Tamanho da pilha: " << s1.size() << endl;
    cout << "Ultima pessoa na pilha: " << s1.top() << endl;
    s1.pop();
    cout << "Tamanho da pilha apos pop(): " << s1.size() << endl;
    cout << "Ultima pessoa na pilha apos pop(): " << s1.top() << endl;

}
*/
#include <stack>
#include <iostream>

int main()
{
    using namespace std;
    stack <bool> s1;

    int x = 167;
    int res = 0;
    do
    {
        res = x % 2;
        s1.push(res);
        x = x / 2;
    } while (x > 0);
        
    do
    {
        cout << s1.top() << endl;
        s1.pop();
    } while (!s1.empty());
}



