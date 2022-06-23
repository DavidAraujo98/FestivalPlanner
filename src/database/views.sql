/*	
** script that includes views of the database
**
** Miguel Nogueira & David Araújo
 */
--use Projeto;
use p2g2;
GO

CREATE VIEW FP.V_BANDAS AS
	SELECT		id, nome, telefone, email, nElementos
	FROM		FP.Banda;
GO

CREATE VIEW FP.V_GERAL AS
	SELECT		FP.Evento.id, FP.Evento.nome AS EVENTO_NOME, FP.Evento.dataInicio, FP.Evento.nDias, FP.Pessoa.nome AS PROMOTOR_NOME, FP.Pessoa.email AS PROMOTOR_EMAIL, FP.Pessoa.telefone AS PROMOTOR_TELEFONE, FP.Banda.nome
	FROM		FP.Pessoa INNER JOIN
				FP.Promotor ON FP.Pessoa.cc = FP.Promotor.cc INNER JOIN 
				FP.Evento ON FP.Promotor.cc = FP.Evento.cc_promotor LEFT JOIN
				FP.Concerto	ON FP.Concerto.id_evento = FP.Evento.id LEFT JOIN
				FP.Banda ON FP.Banda.id = FP.Concerto.id_banda; 

--DROP VIEW FP.V_BANDAS;
--DROP VIEW FP.V_GERAL;

--SELECT * FROM FP.V_BANDAS;
--SELECT * FROM FP.V_GERAL;