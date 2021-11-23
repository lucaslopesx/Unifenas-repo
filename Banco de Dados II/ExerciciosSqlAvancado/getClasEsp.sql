--Uma função que retorne a classificação de uma dada área de especialização de acordo com o
--número de médicos especializados na mesma. A classificação deverá ser feita conforme
--instruções a seguir:
--? Caso o número de médicos esteja entre 0 e 3, a especialização é considerada CARENTE;
--? Caso o número de médicos esteja entre 4 e 7, a especialização é considerada NORMAL;
--? Caso contrário, a especialização é considerada SATURADA. create function getClassificacaoEsp (@nomeEspecializacao varchar(100))returns varchar(100)asbegin	declare @qtdMed int	set @qtdMed = (select COUNT(m.codMedico)				   from Especializacao esp inner join Medico m on esp.codEspecializacao = m.codEspecializacao				   where esp.nome = @nomeEspecializacao)	if(@qtdMed <= 3)		return 'Carente'	else if(@qtdMed <= 7)		return 'Normal'			return 'Saturada'endprint dbo.getClassificacaoEsp('Ginecologia')