Program Pzim ;
var F,Pri,Seg,C :integer;
Begin
	
	writeln('fibonacci');
	writeln('');
	
	write('Digite o primeiro numero da serie: ');
	readln(Pri);
	
	writeln('');
	
	writeln('Digite o segundo numero da serie: ');
	readln(Seg);
	
	writeln('');
	
	C:= 3;
	
	write(Pri,' ',Seg);
	
	while C <= 20 do
		begin
		
			F:= Pri + Seg;
			write(' ',F);
			Pri:= Seg;
			Seg:= F;
			
			C:= C + 1; 
		end;
		readln;
  
End.