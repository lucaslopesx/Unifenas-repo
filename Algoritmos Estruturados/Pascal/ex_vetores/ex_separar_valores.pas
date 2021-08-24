Program Pzim ;
var NV, x, i, c :integer;
		VetPar:array[1..100] of integer; 
Begin

	writeln('-------Separando valores-------');
	writeln('');
	
	write('Digite quantos números deseja: ');
	readln(NV);
	
	writeln('');
	c:= 0;
	for i := 1 to NV do
 		begin
   		write('Digite o ',i,'° valor: ');
			readln(x);
			
			if ( x mod 2 = 0 ) then 
				begin
					inc(c);	
     			VetPar[c]:= x;
   			end;	
 		end;
 		
 	for i := 1 to c do
  	begin
    	write(VetPar[i],'  ');
  	end;
  
End.                     	