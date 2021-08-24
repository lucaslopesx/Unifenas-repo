unit util;
interface
Procedure linha(n:integer;c:char);
Procedure espere;

implementation
Procedure linha(n:integer;c:char);
var i :integer;	
	Begin
  	for i := 1 to n do
   		begin
     		write(c);
   		end;
   		writeln;
	End;
Procedure espere;
	Begin
  	readln;
	End;

end.