unit biblioteca;

interface

	procedure espere;
	function soma(x,y:integer):integer;
	Function media(a,b:integer):real;
	Function fatorial(n:integer):integer;
	function maior(x,y:integer):integer;


implementation

	function soma(x,y:integer):integer;
		Begin
	  	soma:= x+y;
		End;
	
	Function fatorial(n:integer):integer;
	var i,f:integer;
		Begin
			f:= 1;
	  	for i := 2 to n do
	   		begin
	     		f:= f * i;
	   		end;
	   		
	   		fatorial:= f;
		End;
		
	function maior(x,y:integer):integer;
		Begin
	  	if (x>y) then 
				begin
	     		maior:=x;	
	   		end
	   	else
	   		begin
	   			maior:=y;
	   		end;
		End;
		
	Function media(a,b:integer):real;
		var m :real;
		Begin
	  	m:=((a+b)/2);
	  	media:=m;
		End;
		
	Procedure espere;
		Begin
			writeln('Pressione enter para sair.');
	  	readln;
		End;
		
end.