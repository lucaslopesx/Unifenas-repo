//-------------------------------------------------------------------------- //
// Unit: Complexo                                                            //
// Versão: 1.9v                                                              //
// Autor: Raphael Augusto                                                    //
// Descrição: Esta unidade permite fazer operações simples com números com-  //
// plexos                                                                    //
// Licença: General Public License(GPL)                                      //
// ------------------------------------------------------------------------- //

Unit Complexo;
Interface
  Type

  // ---------------------------------------------------------------------- //
  // Tipo que armazena um número complexo, sendo que:                       //
  //  parteReal = A parte real(a) do número complexo(a + bi);               //
  //  parteImag = A parte imaginária(b) do número complexo(a + bi).         //
  // ---------------------------------------------------------------------- //
  TComplexo = record
    parteReal : real;
    parteImag : real;
  end;

  function novoComplexo(a, b : real) : TComplexo;
  procedure mostrarComplexo(z : TComplexo);

  function produtoConjugadoComplexo(z : TComplexo) : real;
  function conjugadoComplexo(z : TComplexo) : TComplexo;
  function moduloComplexo(z : TComplexo) : real;
  function argumentoComplexo(z : TComplexo) : real;
  function opostoComplexo(z : TComplexo) : TComplexo;
  function igualComplexo(z1, z2 : TComplexo) : boolean;

  function somarComplexo(z1, z2 : TComplexo) : TComplexo;
  function subtrairComplexo(z1, z2 : TComplexo) : TComplexo;
  function multiplicarComplexo(z1, z2 : TComplexo) : TComplexo;
  function dividirComplexo(z1, z2 : TComplexo) : TComplexo;

  function expComplexo(z : TComplexo) : TComplexo;
  function lnComplexo(z : TComplexo) : TComplexo;
  function potenciaComplexo(z1, z2 : TComplexo) : TComplexo;
  function raizComplexo(z1, z2 : TComplexo) : TComplexo;

  function senComplexo(z : TComplexo) : TComplexo;
  function cosComplexo(z : TComplexo) : TComplexo;
  function tanComplexo(z : TComplexo) : TComplexo;

Implementation

  // ------------------------------------------------------------------------- //
  // Esta função simplifica o processo de inicialização                        //
  // dos valores de um número complexo.                                        //
  // ------------------------------------------------------------------------- //
  function novoComplexo(a{real}, b{imaginária} : real) : TComplexo;
  var
    z : TComplexo;

  begin

    z.parteReal := a;
    z.parteImag := b;

    novoComplexo := z;

  end;

  // ------------------------------------------------------------------------- //
  // Escreve o número complexo na tela do console, no formato:                 //
  //   a + bi                                                                   //
  // ------------------------------------------------------------------------- //
  procedure mostrarComplexo(z : TComplexo);
  var
    sinal : char;

  begin

    if z.parteImag > 0 then
      sinal := '+' else sinal := '-';

    if (z.parteReal <> 0) and (z.parteImag <> 0) then
      write(z.parteReal:0:3, ' ', sinal,' ', abs(z.parteImag):0:3, 'i')
    else if (z.parteReal = 0) and (z.parteImag <> 0) then
      write(z.parteImag:0:3, 'i')
    else if (z.parteReal <> 0) and (z.parteImag = 0) then
      write(z.parteReal:0:3)
    else
      write('0');

  end;

  // ------------------------------------------------------------------------- //
  // Retorna o produto do número complexo[z] pelo seu conjugado,               //
  // sendo a simplificação:                                                    //
  //  (a + bi)(a - bi) = a² - abi + abi - b²i²                                 //
  //                   = a² + b²                                               //
  // ------------------------------------------------------------------------- //
  function produtoConjugadoComplexo(z : TComplexo) : real;
  begin

    produtoConjugadoComplexo := z.parteReal * z.parteReal + 
                                z.parteImag * z.parteImag;

  end;

  // ------------------------------------------------------------------------- //
  // Retorna o conjugado do número complexo[z]:                                //
  //  (a + bi) = (a - bi)                                                      //
  // ------------------------------------------------------------------------- //
  function conjugadoComplexo(z : TComplexo) : TComplexo;
  begin

    z.parteImag := -z.parteImag;
    conjugadoComplexo := z;

  end;

  // ------------------------------------------------------------------------- //
  // Retona o módulo do número complexo:                                       //
  //  mod(z) = sqrt(sqr(a) + sqr(b))                                           //
  // ------------------------------------------------------------------------- //
  function moduloComplexo(z : TComplexo) : real;
  begin

    moduloComplexo := sqrt(z.parteReal * z.parteReal + 
                           z.parteImag * z.parteImag);

  end;

  // ------------------------------------------------------------------------- //
  // Retona o argumento do número complexo[z]:                                 //
  //  arg(a + bi) = arcTan(b / a)                                              //
  // ------------------------------------------------------------------------- //
  function argumentoComplexo(z : TComplexo) : real;
  begin

    if z.parteReal <> 0 then 
      argumentoComplexo := arcTan(z.parteImag / z.parteReal)
    else
      argumentoComplexo := PI/2;
    
  end;

  // ------------------------------------------------------------------------- //
  // Inverte o número complexo[z]:                                             //
  //  (a + bi) -> (- a - bi)                                                   //
  // ------------------------------------------------------------------------- //
  function opostoComplexo(z : TComplexo) : TComplexo;
  begin

    z.parteReal := -z.parteReal;
    z.parteImag := -z.parteImag;

    opostoComplexo := z;

  end;

  // ------------------------------------------------------------------------- //
  // Verifica se dois números complexos[z1 e z2] são iguais.                   //
  // ------------------------------------------------------------------------- //
  function igualComplexo(z1, z2 : TComplexo) : boolean;
  begin

  if (z1.parteReal = z2.parteReal) and (z1.parteImag = z2.parteImag) then
    igualComplexo := true
  else
    igualComplexo := false;

  end;

  // ------------------------------------------------------------------------- //
  // Soma dois números complexos[z1 + z2].                                     //
  // ------------------------------------------------------------------------- //
  function somarComplexo(z1, z2 : TComplexo) : TComplexo;
  var
    z : TComplexo;

  begin

    z.parteReal := z1.parteReal + z2.parteReal;
    z.parteImag := z1.parteImag + z2.parteImag;

    somarComplexo := z;

  end;

  // ------------------------------------------------------------------------- //
  // subtrai dois números complexos[z1 - z2].                                  //
  // ------------------------------------------------------------------------- //
  function subtrairComplexo(z1, z2 : TComplexo) : TComplexo;
  var
    z : TComplexo;

  begin

    z.parteReal := z1.parteReal - z2.parteReal;
    z.parteImag := z1.parteImag - z2.parteImag;

    subtrairComplexo := z;

  end;

  // ------------------------------------------------------------------------- //
  // Multiplica dois números complexos[z1 * z2], sendo que a forma             //
  // simplificada é:                                                           //
  //  (a + bi)(c + di) = ac + adi + bci + bdi²                                 //
  //                   = (ac - bd) + i(ad + bc)                                //
  // ------------------------------------------------------------------------- //
  function multiplicarComplexo(z1, z2 : TComplexo) : TComplexo;
  var
    z : TComplexo;

  begin

    z.parteReal := z1.parteReal * z2.parteReal - z1.parteImag * z2.parteImag;
    z.parteImag := z1.parteReal * z2.parteImag + z1.parteImag * z2.parteReal;

    multiplicarComplexo := z;

  end;

  // ------------------------------------------------------------------------- //
  // Divide dois números complexos[z1 / z2], sendo que a forma simplificada é  //
  //  (a + bi)/(c + di) = ((a + bi)*(c - di))/((c + di)*(c - di))              //
  //                    = (ac - adi + bci - bdi²)/(c² + d²)                    //
  //                    = (ac  + bd)/(c² + d²) + i(bc - ad)/(c² + d²)          //
  // ------------------------------------------------------------------------- //
  function dividirComplexo(z1, z2 : TComplexo) : TComplexo;
  var
    z : TComplexo;
    c : real;        // Conjugado de z2

  begin

    c := z2.parteReal * z2.parteReal + z2.parteImag * z2.parteImag;
    z.parteReal := (z1.parteReal * z2.parteReal  + z1.parteImag * z2.parteImag)/c;
    z.parteImag := (z1.parteImag * z2.parteReal  - z1.parteReal * z2.parteImag)/c;

    dividirComplexo := z;

  end;

  // ------------------------------------------------------------------------- //
  // Calcula o exponecial da base E elevado ao número complexo[e ^ Z]:         //
  //  exp(b * i) = cos(x) + i * sin(x) -> teorema de Euler                     //
  //  exp(a + b * i) = exp(a) * exp(b * i)                                     //
  //                 = exp(a) * (cos(b) + i * sin(b))                          //
  //                 = exp(a) * cos(b) + i * sin(b) * exp(a)                   //
  // ------------------------------------------------------------------------- //
  function expComplexo(z : TComplexo) : TComplexo;
  var
    e : real;
    w : TComplexo;

  begin

    e := exp(z.parteReal);
    w.parteReal := e * cos(z.parteImag);
    w.parteImag := e * sin(z.parteImag);

    expComplexo := w;

  end;

  // ------------------------------------------------------------------------- //
  // Calcula o valor principal de ln(z):                                       //
  // Fonte: https://pt.wikipedia.org/wiki/N%C3%BAmero_complexo                //
  //  ln(z) = ln(mod(z)) + i * arg(z)                                          //
  // ------------------------------------------------------------------------- //
  function lnComplexo(z : TComplexo) : TComplexo;
  var
    w : TComplexo;

  begin

    w.parteReal := ln(sqrt(z.parteReal * z.parteReal + z.parteImag * z.parteImag));

    if z.parteReal <> 0 then
      w.parteImag := arcTan(z.parteImag / z.parteReal)
    else
      w.parteImag := 1.5707963267948966; {PI/2}

    lnComplexo := w;

  end;

  // ------------------------------------------------------------------------- //
  // {Calcula a potência dos números complexo[z1 ^ z2]:                        //
  //  (a + bi)^(x + yi) = (cos(x * arctan(b/a) + y * ln(sqrt(a*a + b*b))) +    //
  //                   i * sin(x * arctan(b/a) + y * ln(sqrt(a*a + b*b)))) *   //
  //                     exp(x * ln(sqrt(a * a + b * b)) - y * arctan(b/a)))   //
  // ------------------------------------------------------------------------- //
  function potenciaComplexo(z1, z2 : TComplexo) : TComplexo;
  var
    w : TComplexo;
    
    {Variáveis usadas para reduzir contas repetitivas}
    m : real; // Logaritmo do conjugado de z1
    l : real; // Calcula o exponencial da parte real
    n : real; // Calcula o argumento do número complexo
    p : real; 
    
  begin
                       
    m := ln(sqrt(z1.parteReal * z1.parteReal + z1.parteImag * z1.parteImag));
    
    if z1.parteReal <> 0 then
      n := arcTan(z1.parteImag / z1.parteReal)
    else
      n := PI/2;
    
    p := z2.parteReal * n + z2.parteImag * m;
    l := exp(z2.parteReal * m - z2.parteImag * n);

    w.parteReal := l * cos(p);
    w.parteImag := l * sin(p);

    potenciaComplexo := w;

  end;

  // ------------------------------------------------------------------------- //
  // Calcula a raiz dos números complexo[z1 ^ z2]}                             //
  // ------------------------------------------------------------------------- //
  function raizComplexo(z1, z2 : TComplexo) : TComplexo;
  begin
                       
    raizComplexo := potenciaComplexo(z1, dividirComplexo(novoComplexo(1, 0), z2));

  end;

  // ------------------------------------------------------------------------- //
  // Calcula o seno do número complexo[z]:                                     //
  // Fonte: https://pt.wikipedia.org/wiki/Seno                                 //
  //   sen(a + bi) = sin(a) * (exp(b) + exp(-b))/2 +                           //
  //             i * cos(a) * (exp(b) - exp(-b))/2                             //
  // ------------------------------------------------------------------------- //
  function senComplexo(z : TComplexo) : TComplexo;
  var
    w : TComplexo;

  begin

    w.parteReal := (sin(z.parteReal) * (exp(z.parteImag) + exp(-z.parteImag)))/2;
    w.parteImag := (cos(z.parteReal) * (exp(z.parteImag) - exp(-z.parteImag)))/2;

    senComplexo := w;

  end;

  // ------------------------------------------------------------------------- //
  // Calcula o cosseno do número complexo[z]:                                  //
  // Fonte: https://pt.wikipedia.org/wiki/Cosseno                              //
  //   cos(a + bi) = cos(a) * (exp(b) + exp(-b))/2 -                           //
  //             i * sin(a) * (exp(b) - exp(-b))/2                             //
  // ------------------------------------------------------------------------- //
  function cosComplexo(z : TComplexo) : TComplexo;
  var
    w : TComplexo;

  begin

    w.parteReal := (cos(z.parteReal) * (exp(z.parteImag) + exp(-z.parteImag)))/2;
    w.parteImag := -(sin(z.parteReal) * (exp(z.parteImag) - exp(-z.parteImag)))/2;

    cosComplexo := w;

  end;

  // ------------------------------------------------------------------------- //
  // Calcula a tangente do número complexo[z]                                  //
  // ------------------------------------------------------------------------- //
  function tanComplexo(z : TComplexo) : TComplexo;
  begin

    tanComplexo := dividirComplexo(senComplexo(z), cosComplexo(z));

  end;
End.