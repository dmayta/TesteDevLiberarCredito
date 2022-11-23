-- Listar todos os clientes do estado de SP que possuem mais de 60% das parcelas pagas;
SELECT * FROM Cliente c
INNER JOIN Financiamentos f ON f.Cpf = c.Cpf
INNER JOIN Parcela p ON p.IdFinancimento = f.Id
WHERE UF like 'SP' AND p.DataPagamento IS NOT NULL