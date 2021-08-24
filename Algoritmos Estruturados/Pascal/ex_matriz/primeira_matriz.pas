Program Pzim ;
	var l,c :integer;
			m		:array[1..3,1..4] of integer;
Begin
	//lendo a matriz
	for l := 1 to 3 do
 		begin
   		for c := 1 to 4 do
     		begin
     			write('Digite o número da ',l,'a linha e ',c,'a coluna: ');
     			readln(m[l][c]);
     		end;
 		end;
		 
	for l := 1 to 3 do
 		begin
   		for c := 1 to 4 do
     		begin
     			write(m[l,c]:4);
     		end;
     		writeln;
 		end;	
End.