CREATE TABLE Cliente
(
	Id		int identity(1,1),
	Nome	varchar(100),
	Cpf		varchar(11),
	UF		varchar(2),
	Celular	varchar(11),
	CONSTRAINT PK_Clientes PRIMARY KEY CLUSTERED (Cpf)
)


CREATE TABLE Financiamentos
(
	Id						int identity(1,1),
	Cpf						varchar(11),
	TipoFinancimento		int,
	ValorTotal				decimal(10,2),
	DataUltimoVencimento	datetime,
	CONSTRAINT PK_Financiamentos PRIMARY KEY CLUSTERED (Id),
	CONSTRAINT FK_Cliente FOREIGN KEY (Cpf) REFERENCES Cliente(Cpf)
)

CREATE TABLE Parcela
(
	Id						int identity(1,1),
	IdFinancimento			int,
	NumeroParcela			tinyint,
	ValorParcela			decimal(10,2),
	DataVencimento			datetime,
	DataPagamento			datetime,
	CONSTRAINT PK_Parcela PRIMARY KEY CLUSTERED (Id),
	CONSTRAINT FK_Financiamento FOREIGN KEY (IdFinancimento) 
	REFERENCES Financiamentos(Id)
)
