Program Pzim;

Procedure linha;
	begin
  	writeln('==================================');
	end;

Procedure linhan(x:integer);
var i:integer;	
	begin
	 	for i := 1 to x do
   		begin
     		write('=');	
   		end;
   		writeln;
	end;
	
Procedure linhanc(x:integer;y:char);
var i:integer;	
	begin
	 	for i := 1 to x do
   		begin
     		write(y);	
   		end;
   		writeln;
	end;
	
Procedure espere;
	Begin
		writeln('Pressione qualquer tecla para sair.');
  	repeat until keypressed;
	End;
	
Procedure somar2;
var n1,n2:integer;
	Begin
  	write('Digite o primeiro valor: ');
  	readln(n1);
  	write('Digite o segundo valor: ');
  	readln(n2);
  	writeln;
  	writeln('O valor da soma é ',n1+n2);
	End;
	
//Procedure menu;
//	begin
//  	writeln('1.Comprimentar');
//  	writeln('2.Pirâmide');
//  	writeln('5.Sair');	
//	end;


var i,OP:integer;
		nome:string;

Begin

	repeat
  	clrscr;
  	linhanc(40,'.');
  	writeln('1.Comprimentar');
  	writeln('2.Pirâmide');
  	writeln('3.Soma de 2 valores');
  	writeln('5.Sair');
  	linhanc(40,'.');
  	writeln;
  	
		write('Entre com a opção: ');
  	readln(OP);
  	
		case (OP) of 
     	1:begin
     			writeln('Digite o seu nome: ');
     			readln(nome);
     			
		 		end;
     	2:begin
     			clrscr;
     			for i := 1 to 10 do
        		begin
          		linhanc(i,'#');
        		end;
        	espere;
		 		end;
			3:begin
					clrscr;
					somar2;
					espere;
				end;
     else ;
   	end;
 	until (OP=5);
  
End.