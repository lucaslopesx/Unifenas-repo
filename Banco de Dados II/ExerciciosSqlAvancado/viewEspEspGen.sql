--Crie uma view que exiba o nome de todas as especializa��es juntamente com o nome de suas
--especializa��es gen�ricas;

CREATE VIEW espGenerica(esp, espGenerica)
as

select esp.nome, espGen.nome
from Especializacao esp inner join Especializacao espGen on esp.codEspecializacao = espGen.codEspecializacaoGenerica

select * from espGenerica