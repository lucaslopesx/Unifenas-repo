Program Pzim ;
var I,x,y,min,max,soma :integer;
Begin

	write('Digite um valor: ');
	readln(x);
	
	write('Digite outro valor: ');
	readln(y);

	if ( x < y ) then begin
  	min:= x;
  	max:= y;
	end else begin
 		min:= y;
  	max:= x;
	end;
	
	for I:= min to max do
	  begin
	  	if ( I mod 2 <> 0 ) then begin
      	soma := soma + I;
    	end;
	  end;
	  
	writeln('A soma dos números impares é igual a: ',soma);
	readln;
		

  
End.