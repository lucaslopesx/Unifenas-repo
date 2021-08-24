Program Pzim ;
var ma, mb																									:array[1..50,1..50] of integer;
		NL, NC, i, j, OP																				:integer;
		maior, menor, imaior, jmaior, imenor, jmenor, k,li,somaD:integer;
		arq 																										:text;
		nomeArq																									:string;
Begin
 	repeat
 		clrscr;
 		writeln('----Menu de matriz----');
		writeln;
 		writeln('===================================');
 		writeln('1.Ler a matriz A: ');
 		writeln('2.Ler a matriz B: ');
 		writeln('3.Mostar a matriz carregada');
 		writeln('4.Maior e menor valor e a posição de cada um');
 		writeln('5.Multiplicar a matriz por uma constante');
 		writeln('6.Binarizar a matriz');
 		writeln('7.Soma da diagonal principal');
 		writeln('8.Soma da diagonal secundária');
 		writeln('9.Sair');
 		writeln('===================================');
 		write('Entre com a sua opção: ');
 		readln(OP);
 		
 		case (OP) of 
    	1:	begin
	     			clrscr;
	     				write('Digite o nome do arquivo desejado: ');
	     				readln(nomeArq);
		     			assign(arq, nomeArq ) ;// atribui arquivo 'dados.txt' a variavel arq
		     			reset(arq); // abre o arquivo para leitura 
							read(arq,NL);
							read(arq,NC);
						writeln;
						//inicialização de variáveis
						for i := 1 to NL do
	     				begin
	       				for j := 1 to NC do
	           			begin
	            			ma[i][j]:=0;
	           			end;
	     				end;
	     			//lendo a matriz
						for i := 1 to NL do
	     				begin
	       				for j := 1 to NC do
	           			begin
	            			read(arq,ma[i][j]);
	           			end;
	     				end;
						close(arq);//fecha o arquivo que estava sendo utilizado 	
			 		end;
			2:	begin
						clrscr;
	     				write('Digite o nome do arquivo desejado: ');
	     				readln(nomeArq);
		     			assign(arq, nomeArq ) ;// atribui arquivo 'dados.txt' a variavel arq
		     			reset(arq); // abre o arquivo para leitura 
							read(arq,NL);
							read(arq,NC);
						writeln;
						//inicialização de variáveis
						for i := 1 to NL do
	     				begin
	       				for j := 1 to NC do
	           			begin
	            			mb[i][j]:=0;
	           			end;
	     				end;
	     			//lendo a matriz
						for i := 1 to NL do
	     				begin
	       				for j := 1 to NC do
	           			begin
	            			read(arq,mb[i][j]);
	           			end;
	     				end;
						close(arq);//fecha o arquivo que estava sendo utilizado 	
					end;
			3: 	begin
						clrscr;
	     			writeln('Matriz 
						 carregada:');
	     			writeln;
	     			
	     			for i := 1 to NL do
	        		begin
	        			for j := 1 to NC do
	          	 		begin
	            			write(ma[i][j]:4);
	           			end;
	           			writeln;
	        		end;
	        	repeat until keypressed;
					end;
			4:	begin
						clrscr;
							for i := 1 to NL do
      					begin
      						for j := 1 to NC do
       							begin
         							if (i=1)and(j=1) then 
												begin
                  				maior:= ma[i,j]; imaior:= i; jmaior:= j;
                  				menor:= ma[i,j]; imenor:= i; jmenor:= j;
                				end
                			else
                				begin
                					if (ma[i][j] > maior ) then 
														begin
                      				maior:= ma[i,j]; imaior:= i; jmaior:= j;
                     				end;
													if (ma[i][j] < menor ) then 
														begin
															menor:= ma[i,j]; imenor:= i; jmenor:= j;
             								end;	
                				end;
       							end;
      					end;
      			writeln('Maior elemento: ',maior,' linha[',imaior,']  coluna[',jmaior,']');
       			writeln('Menor elemento: ',menor,' linha[',imenor,']  coluna[',jmenor,']');
       			writeln;
       			writeln('Matriz');
		     		writeln;
		     			
		     		for i := 1 to NL do
		        	begin
		        		for j := 1 to NC do
		          	 	begin
		            		write(ma[i][j]:4);
		           		end;
		           		writeln;
		        	end;
      			repeat until keypressed;
					end;
			5:	begin
						write('Entre com a constante: ');
						readln(k);
						for i := 1 to NL do
		        	begin
		        		for j := 1 to NC do
		          	 	begin
		            		ma[i][j]:= ma[i][j] * k;
		           		end;
		        	end;
						repeat until keypressed;
					end;
			6: 	begin
						write('Entre com o linear: ');
						readln(li);
						
						for i := 1 to NL do
      				begin
        				for j := 1 to NC do
            			begin
            			if (ma[i][j] > li) then 
										begin
											ma[i][j]:= 1;
					        	end	      
									else 
										begin
			                ma[i][j]:= 0;
			      				end;
            			end;
      				end;
      			writeln('Matriz binarizada: ');
						for i := 1 to NL do
		        	begin
		        		for j := 1 to NC do
		          	 	begin
		            		write(ma[i][j]:4);
		           		end;
		           		writeln;
		        	end;
      			repeat until keypressed;
					end;
					
			7:	begin
						somaD:= 0;
						if ( NL = NC) then 
							begin
        				for i := 1 to NC do
				          begin
				        		somaD:= somaD + ma[i][i];
				        	end;
				        writeln('Soma da diagonal principal: ',somaD);
      				end
      			else
      				begin
      					writeln('Matriz não é quadrada');
      				end;
      			repeat until keypressed;
					end;
			8:	begin
//						somaD:= 0;
						if ( NL = NC) then 
							begin
//        				for i := 1 to NL do   {USANDO 2 FOR}
//            			begin
//            				for j := 1 to NC do
//                			begin
//                  			if (i+j = NL+1) then 
//													begin
//                       			somaD:= somaD + ma[i][j];
//                     			end;
//                			end;
//            			end;
            			somaD:=0;
            			j:=NL;
            			for i := 1 to NL do
               			begin
                 			somaD:= somaD + ma[i,j];
                 			dec(j);
               			end;
				        writeln('Soma da diagonal secundária: ',somaD);
      				end
      			else
      				begin
      					writeln('Matriz não é quadrada');
      				end;
      			repeat until keypressed;
					end;			
   end;
  until (OP = 9);
  
  
End.