--Listar os primeiros quatro clientes que possuem alguma parcela com mais de cinco dias
--em atraso (Data Vencimento maior que data atual E data pagamento nula).
--Observação: (Data Vencimento maior que data atual E data pagamento nula) não fez muito sentido essa validação.


--Mas foi implementado trazendo o que foi pedido.
SELECT TOP 4 * FROM Cliente c
INNER JOIN Financiamentos f ON f.Cpf = c.Cpf
INNER JOIN Parcela p ON p.IdFinancimento = f.Id
WHERE GETDATE() > p.DataVencimento AND p.DataPagamento IS NULL