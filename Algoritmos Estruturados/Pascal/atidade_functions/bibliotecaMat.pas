unit bibliotecaMat;
interface
procedure tabuada(N:integer);
Function somaInter(n:integer):integer;
Function constantePI(n:integer):real;

implementation

procedure tabuada(N:integer);
var i:integer;
	Begin
  	for i := 1 to n do
   		begin
     		writeln(i,' x ',n,' =  ',n*i);
   		end;
	End;
Function somaInter(n:integer):integer;
var soma, i:integer;	
	Begin
  soma:= 0;
	for i := 1 to n do
 		begin
   		soma:= soma + i;
 		end;
		somaInter:= soma;	
	End;
	
Function constantePI(n:integer):real;
var i, aux, den, pot		:integer;
	 	somaTot, res:real;
	Begin
	den:= 0;
	for i := 0 to n-1 do
 		begin
 			den:= 2 * i + 1;
			
			if ( i mod 2 = 0 ) then 
				begin
					pot:= 1;	
   			end   
			else 
				begin
     			pot:= -1;	
   			end;
			
			somaTot:= somaTot + (pot/den);
			res:= 4 * somaTot;
 			inc(aux);		
 		end;
 		constantePI:= res;
	end;


end.