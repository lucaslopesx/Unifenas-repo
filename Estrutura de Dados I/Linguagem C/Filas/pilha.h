#define max 20

typedef struct {
	int topo,m[max];
}pilha;

void init(pilha *p){
	p->topo = 0;
}

void push(pilha *p, int r){
	if(p->topo < max){
		p->m[p->topo] = r;
		p->topo++;	
	}
}

int pop(pilha *p){
	if(p->topo > 0){
		p->topo--;
		return p->m[p->topo];
	}
}

char empty(pilha *p){
	if(p->topo == 0){
		return 1;
	}else{
		return 0;
	}
}

char isFull(pilha *p){
	if(p->topo==max){
		return 1;
	}else{
		return 0;
	}
}
