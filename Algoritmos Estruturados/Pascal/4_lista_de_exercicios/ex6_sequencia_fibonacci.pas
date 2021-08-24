Program Pzim ;
var F,Pri,Seg,C :integer;
Begin
	
	Pri:= 1;
	Seg:= 1;
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