--Uma fun��o que retorne a classifica��o de uma dada �rea de especializa��o de acordo com o
--n�mero de m�dicos especializados na mesma. A classifica��o dever� ser feita conforme
--instru��es a seguir:
--? Caso o n�mero de m�dicos esteja entre 0 e 3, a especializa��o � considerada CARENTE;
--? Caso o n�mero de m�dicos esteja entre 4 e 7, a especializa��o � considerada NORMAL;
--? Caso contr�rio, a especializa��o � considerada SATURADA. create function getClassificacaoEsp (@nomeEspecializacao varchar(100))returns varchar(100)asbegin	declare @qtdMed int	set @qtdMed = (select COUNT(m.codMedico)				   from Especializacao esp inner join Medico m on esp.codEspecializacao = m.codEspecializacao				   where esp.nome = @nomeEspecializacao)	if(@qtdMed <= 3)		return 'Carente'	else if(@qtdMed <= 7)		return 'Normal'			return 'Saturada'endprint dbo.getClassificacaoEsp('Ginecologia')