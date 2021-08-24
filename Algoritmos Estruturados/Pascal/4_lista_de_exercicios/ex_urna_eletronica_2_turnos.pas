Program Pzim ;
var C1, C2, CB, CT, n :integer;
var OP :char;
Begin

	writeln('--------Urna eletrônica--------');
	writeln('');
	
	writeln('Para candidato de Direita digite 1');
  writeln('Para candidato de Esquerda digite 2');
  writeln('Para voto em BRANCO digite B');
  writeln('Para FINALIZAR digite F');
  
  writeln('');
  
  //Contadores
  		C1:= 0;
  		C2:= 0;
  		CB:= 0;
  		
  		
  repeat
  	write('Digite a opção desejada:');
  	readln(OP);
    
    case ( OP ) of 
      '1':
      	begin
					C1:= C1 + 1;
				end;  
      '2':
      	begin
					C2:= C2 + 1;
				end;
			'B','b':
				begin
					CB:= CB + 1;
				end;
			'F','f':
				begin
					clrscr;
					writeln('Finalizando');
				end;
      else writeln('Opção inválida!!');
    end;
    
  until (	(OP = 'F') or(OP = 'f') );
  
  //Distribuição de votos em branco
  	if ( C1 > C2 ) then 
			begin
      	CT:= C1 + CB;
      	n:= 1;
    	end
		else if( C2 > C1) then
			begin
      	CT:= C2 +CB;
      	n:= 2;
    	end
		else //Segundo turno caso empate 
			begin
				//Contadores
  			C1:= 0;
  			C2:= 0;
 				CB:= 0;
 				clrscr;
				writeln('Empate!');
				writeln('-------Segunto turno-------');
					writeln('');
				writeln('Para candidato de Direita digite 1');
	  		writeln('Para candidato de Esquerda digite 2');
	  		writeln('Para voto em BRANCO digite B');
	  		writeln('Para FINALIZAR digite F'); 
	  		
	  		repeat
		  		write('Digite a opção desejada:');
		  		readln(OP);
		    
		    	case ( OP ) of 
		    	  '1':
		     	 		begin

								C1:= C1 + 1;
							end;  
		     		 '2':
		      		begin
								C2:= C2 + 1;
							end;
						'B','b':
							begin
								CB:= CB + 1;
							end;
						'F','f':
							begin
								clrscr;
								writeln('Finalizando');
							end;
		      	else writeln('Opção inválida!!');
		      	end;
		  	until (	(OP = 'F') or (OP = 'f') );

		    
					if ( C1 > C2 ) then 
						begin
      				CT:= C1 + CB;
      				n:= 1;
    				end
					else if( C2 > C1) then
						begin
      				CT:= C2 + CB;
      				n:= 2;
    				end
    			else
    				begin
							writeln('ERRO'); 
    				end;			  		  	
    	end;
    	
			

		
		
		
		writeln('Candidato 1:',C1,' votos');
		writeln('Candidato 2:',C2,' votos');
		writeln('Brancos....:',CB,' votos');
		writeln('');
		
		writeln('Vencedor...: Candidato ',n,' com ',CT,' votos');
		readln();
		
  
End.
