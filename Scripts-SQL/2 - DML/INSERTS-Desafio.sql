-- INSERTS tabela de Cliente

INSERT INTO Cliente values ('Diego Ortiz', '12345678910', 'SP', '11960680101')
INSERT INTO Cliente values ('Thiago da Silva', '23561580010', 'RJ', '11945780101')
INSERT INTO Cliente values ('Jenny Arias', '31597500101', 'SP', '11920520101')
INSERT INTO Cliente values ('Joao da Silva', '42344268410', 'RJ', '11965460101')
INSERT INTO Cliente values ('Theo Teste', '76895810130', 'SP', '11937560101')



--INSERT tabela de Financiamentos
INSERT INTO Financiamentos values ('12345678910', 1, 35000.10, GETDATE())
INSERT INTO Financiamentos values ('12345678910', 2, 80000.00, '2015-01-25 00:00:00.000')

INSERT INTO Financiamentos values ('23561580010', 1, 15000.00, GETDATE())
INSERT INTO Financiamentos values ('23561580010', 1, 25000.00, '2020-12-11 00:00:00.000')

INSERT INTO Financiamentos values ('31597500101', 1, 10000.00, GETDATE())
INSERT INTO Financiamentos values ('31597500101', 1, 35000.00, '2019-04-21 00:00:00.000')

INSERT INTO Financiamentos values ('42344268410', 1, 8000.00, GETDATE())
INSERT INTO Financiamentos values ('42344268410', 1, 100000.00, '2020-09-11 00:00:00.000')

INSERT INTO Financiamentos values ('76895810130', 1, 35000.00, GETDATE())
INSERT INTO Financiamentos values ('76895810130', 1, 25000.00, '2021-12-01 00:00:00.000')



--INSERT tabela de Parcelas
INSERT INTO Parcela values (1, 13, 1000.00, '2022-12-23 00:00:00.000', NULL)
INSERT INTO Parcela values (1, 12, 1000.00, '2022-11-23 00:00:00.000', NULL)
INSERT INTO Parcela values (1, 11, 1000.00, '2022-10-23 00:00:00.000', '2022-10-23 00:00:00.000')
INSERT INTO Parcela values (1, 10, 1000.00, '2022-9-23 00:00:00.000', '2022-09-22 00:00:00.000')

INSERT INTO Parcela values (3, 12, 1200.00, '2022-12-17 00:00:00.000', NULL)
INSERT INTO Parcela values (3, 11, 1200.00, '2022-11-17 00:00:00.000', NULL)
INSERT INTO Parcela values (3, 10, 1200.00, '2022-10-17 00:00:00.000', '2022-10-17 00:00:00.000')
INSERT INTO Parcela values (3, 9, 1200.00, '2022-02-17 00:00:00.000', '2022-01-30 00:00:00.000')
														
INSERT INTO Parcela values (5, 12, 800.00, '2021-05-01 00:00:00.000', NULL)
INSERT INTO Parcela values (5, 11, 800.00, '2021-04-01 00:00:00.000', '2021-04-05 00:00:00.000')
INSERT INTO Parcela values (5, 10, 800.00, '2021-03-01 00:00:00.000', '2021-02-28 00:00:00.000')
INSERT INTO Parcela values (5, 9, 800.00, '2021-02-01 00:00:00.000', '2021-01-30 00:00:00.000')
														
INSERT INTO Parcela values (8, 12, 1200.00, '2020-08-11 00:00:00.000', '2020-08-11 00:00:00.000')
INSERT INTO Parcela values (8, 11, 1200.00, '2020-07-11 00:00:00.000', '2020-07-11 00:00:00.000')
INSERT INTO Parcela values (8, 10, 1200.00, '2020-06-11 00:00:00.000', '2020-06-11 00:00:00.000')
INSERT INTO Parcela values (8, 9, 1200.00, '2020-05-11 00:00:00.000', '2020-05-11 00:00:00.000')

INSERT INTO Parcela values (9, 12, 1500.00, '2021-05-01 00:00:00.000', '2021-05-08 00:00:00.000')
INSERT INTO Parcela values (9, 11, 1500.00, '2021-04-01 00:00:00.000', '2021-04-08 00:00:00.000')
INSERT INTO Parcela values (9, 10, 1500.00, '2021-03-01 00:00:00.000', '2021-02-28 00:00:00.000')
INSERT INTO Parcela values (9, 9, 1500.00, '2021-02-01 00:00:00.000', '2021-01-30 00:00:00.000')
