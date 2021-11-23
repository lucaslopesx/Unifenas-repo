--Uma procedure que, dado o nome de um m�dico, retorne em uma vari�vel de sa�da o nome da
--cl�nica em que ele ganha o maior sal�rio; 

create procedure clinicaMaiorSalMed(@nomeMed varchar(100), @nomeClinica varchar(100) OUTPUT)
as
begin

	declare @codMedico int
	declare @codClinica varchar(100)

	set @codMedico = (select m.codMedico
					  from Medico m
					  where m.nomeMedico = @nomeMed)

	set @codClinica = (select top 1 cm.codClinica
					   from ClinicaMedico cm
					   where cm.codMedico = 1 and cm.salario = (select top 1 MAX(cm.salario)
																from ClinicaMedico cm
																where cm.codMedico = @codMedico))

	set @nomeClinica = (select c.nomeClinica
						from Clinica c
						where c.codClinica = @codClinica)

end

declare @saida varchar(100)
execute clinicaMaiorSalMed 'Luana Maria Ferreira', @nomeClinica = @saida output
print @saida