SELECT c.nomeCurso, d.nomeDisciplina
FROM curso c 
inner join disciplina d on d.idCurso = c.idCurso;