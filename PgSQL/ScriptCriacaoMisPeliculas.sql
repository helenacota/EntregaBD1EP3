CREATE SCHEMA MisPeliculas;

SET search_path TO MisPeliculas, public;

CREATE TABLE Eventos (
    Nome VARCHAR(60) NOT NULL,
    AnoInicio INT NOT NULL,
    Nacionalidade VARCHAR(60),
    Tipo CHAR(10) NOT NULL,
    PRIMARY KEY (Nome)
);

CREATE TABLE Edicao (
    Ano INT NOT NULL,
    DataEd DATE,
    Localizacao VARCHAR(60),
    NomeEvento VARCHAR(60) NOT NULL,
    UNIQUE (Ano, NomeEvento, Localizacao),
    FOREIGN KEY (NomeEvento) REFERENCES Eventos (Nome),
    PRIMARY KEY (Ano, NomeEvento)
);

CREATE TABLE Premio (
    Tipo VARCHAR(60) NOT NULL,
    Nome VARCHAR(60),
    AnoEdicao INT NOT NULL,
    NomeEvento VARCHAR(60) NOT NULL,
    FOREIGN KEY (AnoEdicao, NomeEvento) REFERENCES Edicao (Ano, NomeEvento),  
    PRIMARY KEY (Tipo, NomeEvento, AnoEdicao)
);

CREATE TABLE Pessoa(
	NomeArt VARCHAR(60) NOT NULL,
	NomeVerdadeiro VARCHAR(60),
	Sexo VARCHAR(20) NOT NULL,
	AnoNasc INT,
	Site VARCHAR (100),
	AnoInic INT,
	Situacao CHAR(15) NOT NULL,
	NroTotalAnos INT NOT NULL,
	PRIMARY KEY(NomeArt)
);

CREATE TABLE Diretor(
	NomeArt VARCHAR(60) NOT NULL,
	FOREIGN KEY(NomeArt) REFERENCES Pessoa(NomeArt),
	PRIMARY KEY(NomeArt)
);

CREATE TABLE Produtor(
	NomeArt VARCHAR(60) NOT NULL,
	FOREIGN KEY(NomeArt) REFERENCES Pessoa(NomeArt),
	PRIMARY KEY(NomeArt)
);

CREATE TABLE Roteirista(
	NomeArt VARCHAR(60) NOT NULL,
	FOREIGN KEY(NomeArt) REFERENCES Pessoa(NomeArt),
	PRIMARY KEY(NomeArt)
);

CREATE TABLE Ator(
	NomeArt VARCHAR(60) NOT NULL,
	FOREIGN KEY(NomeArt) REFERENCES Pessoa(NomeArt),
	PRIMARY KEY(NomeArt)
);

CREATE TABLE Filmes(
	IdFilme INT NOT NULL,
	ArrecadaoPrimAno INT,
	IdiomaOrig VARCHAR(60) NOT NULL,
	Classe VARCHAR(15) NOT NULL,
	AnoProducao INT NOT NULL,
	TituloOriginal VARCHAR(100),
	DataEstreia DATE,
	TituloBrasil VARCHAR(100),
	PRIMARY KEY (IdFilme)
);

CREATE TABLE ENominado(
	NomeArt VARCHAR(60) NOT NULL,
	IdFilme INT NOT NULL,
	Tipo VARCHAR(60) NOT NULL,
	AnoEdicao INT NOT NULL,
    NomeEvento VARCHAR(60) NOT NULL,
	Ganhou BOOL NOT NULL,
	FOREIGN KEY(NomeArt) REFERENCES Pessoa(NomeArt),
	FOREIGN KEY(IdFilme) REFERENCES Filmes(IdFilme),
	FOREIGN KEY (Tipo, AnoEdicao, NomeEvento) REFERENCES Premio (Tipo, AnoEdicao, NomeEvento), 
	PRIMARY KEY(NomeArt,IdFilme,Tipo, AnoEdicao, NomeEvento)
);

CREATE TABLE LocalEstreia(
	Localizacao VARCHAR(60) NOT NULL,
	IdFilme INT NOT NULL,
	FOREIGN KEY(IdFilme) REFERENCES Filmes(IdFilme),
	PRIMARY KEY(Localizacao, IdFilme)
);

CREATE TABLE FilmeNominado(
	IdFilme INT NOT NULL,
	Tipo VARCHAR(60) NOT NULL,
	AnoEdicao INT NOT NULL,
    NomeEvento VARCHAR(60) NOT NULL,
	Premiado BOOL,
	FOREIGN KEY(IdFilme) REFERENCES Filmes(IdFilme),
	FOREIGN KEY (Tipo, AnoEdicao, NomeEvento) REFERENCES Premio(Tipo, AnoEdicao, NomeEvento),
	PRIMARY KEY(IdFilme, Tipo, AnoEdicao, NomeEvento)
);

CREATE TABLE EJuri(
	Ano INT NOT NULL, 
	NomeArt VARCHAR(60) NOT NULL,
	NomeEvento VARCHAR(60) NOT NULL,
	FOREIGN KEY(NomeArt) REFERENCES Pessoa(NomeArt),
	FOREIGN KEY(Ano, NomeEvento) REFERENCES Edicao(Ano, NomeEvento),
	PRIMARY KEY(Ano, NomeArt, NomeEvento)
);


CREATE OR REPLACE FUNCTION check_ator_filme_nomination()
RETURNS TRIGGER AS $$
BEGIN
    IF EXISTS (
        SELECT 1
        FROM AtorElenco ae
        JOIN FilmeNominado fn ON ae.IdFilme = fn.IdFilme
        WHERE ae.NomeArt = NEW.NomeArt
          AND fn.NomeEvento = NEW.NomeEvento
          AND fn.AnoEdicao = NEW.Ano
    ) THEN
        RAISE EXCEPTION 'Cannot insert. Matching record found in AtorElenco and FilmeNominado.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER before_insert_check
BEFORE INSERT ON EJuri
FOR EACH ROW EXECUTE FUNCTION check_ator_filme_nomination();

CREATE TABLE Documentarios(
	IdFilme INT NOT NULL,
	FOREIGN KEY(IdFilme) REFERENCES Filmes(IdFilme),
	PRIMARY KEY(IdFilme)
);

CREATE TABLE Outros(
	IdFilme INT NOT NULL,
	FOREIGN KEY(IdFilme) REFERENCES Filmes(IdFilme),
	PRIMARY KEY(IdFilme)
);

CREATE TABLE AtorPrinc(
	IdFilme INT NOT NULL,
	NomeArt VARCHAR(60) NOT NULL,
	FOREIGN KEY(IdFilme) REFERENCES Outros(IdFilme),
	FOREIGN KEY(NomeArt) REFERENCES Ator(NomeArt),
	PRIMARY KEY(IdFilme, NomeArt)
);

CREATE TABLE AtorElenco(
	IdFilme INT NOT NULL,
	NomeArt VARCHAR(60) NOT NULL,
	FOREIGN KEY(IdFilme) REFERENCES Outros(IdFilme),
	FOREIGN KEY(NomeArt) REFERENCES Ator(NomeArt),
	PRIMARY KEY(IdFilme, NomeArt)
);

CREATE TABLE EDiretor(
	IdFilme INT NOT NULL,
	NomeArt VARCHAR(60) NOT NULL,
	EPrincipal VARCHAR(60) NOT NULL,
	FOREIGN KEY(IdFilme) REFERENCES Filmes(IdFilme),
	FOREIGN KEY(NomeArt) REFERENCES Diretor(NomeArt),
	PRIMARY KEY(IdFilme, NomeArt)
);

CREATE TABLE EProdutor(
	IdFilme INT NOT NULL,
	NomeArt VARCHAR(60) NOT NULL,
	FOREIGN KEY(IdFilme) REFERENCES Filmes(IdFilme),
	FOREIGN KEY(NomeArt) REFERENCES Produtor(NomeArt),
	PRIMARY KEY(IdFilme, NomeArt)
);

CREATE TABLE ERoteirista(
	IdFilme INT NOT NULL,
	NomeArt VARCHAR(60) NOT NULL,
	FOREIGN KEY(IdFilme) REFERENCES Filmes(IdFilme),
	FOREIGN KEY(NomeArt) REFERENCES Roteirista(NomeArt),
	PRIMARY KEY(IdFilme, NomeArt)
);