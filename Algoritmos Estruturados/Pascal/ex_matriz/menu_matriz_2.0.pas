Program Pzim ;

Procedure linhanc(x:integer;y:char);
var i:integer;
	Begin
  	for i := 1 to x do
   		begin
     		write(y);
   		end;
   		writeln;
	End;
	
Procedure espere;
	Begin
		writeln;
		writeln('Pressione qualquer tecla para sair.');
  	repeat until keypressed;
	End;

var ma, mb, mc, mt																					:array[1..50,1..50] of integer;
		NLa, NCa, NLb, NCb, NLc, NCc, NLt, NCt, k, i, j, OP			:integer;
		arq 																										:text;
		nomeArq																									:string;
Begin
 	repeat
 		clrscr;
 		writeln('----Menu de matriz----');
		writeln;
 		linhanc(40,'=');
 		writeln('1.Ler a matriz A: ');
 		writeln('2.Ler a matriz B: ');
 		writeln('3.Mostrar matriz A: ');
 		writeln('4.Mostrar matriz B: ');
 		writeln('5.Multiplicar A por B: ');
 		writeln('6.Mostrar a matriz C: ');                                                                                 
 		writeln('7.Transpor matriz A: ');
 		writeln('8.Gravar a transposta em arquivo ');
 		writeln('9.Sair');
 		linhanc(40,'=');
 		write('Entre com a sua opção: ');
 		readln(OP);
 		
 		case (OP) of 
    	1:	begin
	     			clrscr;
		     			assign(arq, 'dados.txt' ) ;// atribui arquivo 'dados.txt' a variavel arq
		     			reset(arq); // abre o arquivo para leitura 
							read(arq,NLa);
							read(arq,NCa);
						writeln;
						//inicialização de variáveis
						for i := 1 to NLa do
	     				begin
	       				for j := 1 to NCa do
	           			begin
	            			ma[i][j]:=0;
	           			end;
	     				end;
	     			//lendo a matriz
						for i := 1 to NLa do
	     				begin
	       				for j := 1 to NCa do
	           			begin
	            			read(arq,ma[i][j]);
	           			end;
	     				end;
						close(arq);//fecha o arquivo que estava sendo utilizado 	
			 		end;
			2:	begin
						clrscr;
		     			assign(arq, 'dados2.txt' ) ;// atribui arquivo 'dados.txt' a variavel arq
		     			reset(arq); // abre o arquivo para leitura 
							read(arq,NLb);
							read(arq,NCb);
						writeln;
						//inicialização de variáveis
						for i := 1 to NLb do
	     				begin
	       				for j := 1 to NCb do
	           			begin
	            			mb[i][j]:=0;
	           			end;
	     				end;
	     			//lendo a matriz
						for i := 1 to NLb do
	     				begin
	       				for j := 1 to NCb do
	           			begin
	            			read(arq,mb[i][j]);
	           			end;
	     				end;
						close(arq);//fecha o arquivo que estava sendo utilizado 	
					end;
			3: 	begin
						clrscr;
	     			writeln('Matriz A carregada');
	     			writeln;
	     			
	     			for i := 1 to NLa do
	        		begin
	        			for j := 1 to NCa do
	          	 		begin
	            			write(ma[i][j]:4);
	           			end;
	           			writeln;
	        		end;
	        	espere;
					end;
			4:	begin
						clrscr;
	     			writeln('Matriz B carregada');
	     			writeln;
	     			
	     			for i := 1 to NLb do
	        		begin
	        			for j := 1 to NCb do
	          	 		begin
	            			write(mb[i][j]:4);
	           			end;
	           			writeln;
	        		end;
	        	espere;
					end;
			5:	begin
						clrscr;
						if (NLa = NCb) then 
							begin
		        		for i := 1 to NLa do
		      				begin
										for j := 1 to NCb do
		        					begin
		          					mc[i,j]:=0;
		          					for k := 1 to NCa do
		               				begin
		              					mc[i,j]:= mc[i,j] + ma[i,k] * mb[k,j];
		               				end;
		        					end;        			
		     					end;
		     					writeln('Matrizes multiplicadas');
		     					readln;
      				end      
						else 
							begin
								writeln('Matrizes não compatíveis');
     					end;
						
					end;
			6: 	begin
						clrscr; 						
	     			writeln('Matriz C carregada');
	     			writeln;
	     			
	     			
	        	espere;
						
					end;
					
			7:	begin
						clrscr;
						writeln('Matriz B transposta');
						writeln;
						NLt:=NCb;
						NCt:=NLb;
						for i:=1 to NCb do
              Begin
              	for j:=1 to NLb do
                	Begin
                  	mt[j,i]:=mb[j,i];
                  end;
              end;
     				  for i:=1 to NLt do
                Begin
                  for j:=1 to NCt do
                    Begin
                      write(mt[j,i]:4);
                    end;
                  writeln;
                end;
	        	espere;
					end;
			8:	begin
						assign(arq, 'transposta.txt' );// cria o arquivo transposta.txt
						rewrite(arq);
						writeln(arq, 'Transposta: ');// escreve no arquivo texto, para o LOG
						for i:=1 to NLt do
              Begin
                for j:=1 to NCt do
                  Begin
                    write(arq,mt[j,i]:4);
                  end;
                writeln(arq);
              end;
            close(arq);
//					
					end;			
   end;
  until (OP = 9);
  
  
End.