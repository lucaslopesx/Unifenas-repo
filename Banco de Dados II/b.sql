select a.nomeAluno
from aluno a
left join matricula m on a.idAluno = m.idAluno
where ISNULL (m.idAluno)