Program Pzim ;
var vet1, vet2  :array[1..10] of integer;
		vet3 				:array[1..20] of integer;
		i,j					:integer;
Begin

	j:=1;
	for i := 1 to 10 do
 		begin
   		
   		write('Vetor 1: ');
			readln(vet1[i]);
			
			vet3[j]:=vet1[i];
			
			j:= j + 1;
			
			write('Vetor 22: ');
			readln(vet2[i]);
			
			vet3[j]:=vet2[i];
			
			j:= j + 1;		
 		end;
 		
 	for i := 1 to 20 do
  	begin
    	write(vet3[i]);
  	end;
  
End.