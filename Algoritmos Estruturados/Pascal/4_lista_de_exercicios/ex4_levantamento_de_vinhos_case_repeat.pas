Program Pzim ;
var	CV,CT,CB,CR :integer;
var OP :char;
var PT,PB,PR :real;
Begin
  
  writeln('Sistema de levantamento do estoque de vinhos!');
  writeln('');
  
  writeln('Para vinho TINTO digite T');
  writeln('Para vinho BRANCO digite B');
  writeln('Para vinho ROSÊ digite R');
  writeln('Para FINALIZAR digite F');
  
	//Contadores
  		CT:= 0;
  		CB:= 0;
  		CR:= 0;
  		CV:= 0;
  
  repeat
  	write('Digite a opção desejada: ');
  	readln(OP);
		
  		case (OP) of
    		'T','t':
					begin
    				writeln('Vinho TINTO adicionado');
    				CT:= CT + 1;
  				end;
    		'B','b':
    			begin
    				writeln('Vinho BRANCO adicionado');
    				CB:= CB + 1;
    			end;
    		'R','r':
    			begin
    				writeln('Vinho ROSÊ adicionado');
    				CR:= CR + 1;
    			end;
    		'F','f':
    			begin
    				clrscr;
    				writeln('FINALIZANDO....');
    	    end;
    	    
    	else writeln('Opção inválida!!'); 
			end; 
			
			CV:= CV + 1; 
    
  until ( (OP = 'F') or(OP = 'f') );
  
  CV:= CV - 1; //Retira a quantidade da Opção F pois ao coloca-la conta como se fosse um vinho a mais
	
	if ( CV > 0 ) then 
		begin
			writeln('');                            
  		writeln('Total de vinhos no armazém: ',CV);
  
  		writeln('');
			writeln('VINHOS');
	
			writeln('');
			writeln('Tinto');
			writeln('Garrafas: ',CT);
			writeln('Porcentagem: ',(CT*100)/CV);
			writeln('');
			writeln('Branco');
			writeln('Garrafas: ',CB);
			writeln('Porcentagem: ',(CB*100)/CV);
			writeln('');
			writeln('Rosê');
			writeln('Garrafas: ',CR);
			writeln('Porcentagem: ',(CB*100)/CV);			
 		end 
	else 
		begin
  		writeln('Não há nenhum vinho');
 		end; 
  
	
  
  
End.