SET search_path TO MisPeliculas;

-- Inserções para a tabela Eventos
INSERT INTO Eventos (Nome, AnoInicio, Nacionalidade, Tipo) VALUES
('Festival de Cinema de Cannes', 1946, 'França', 'Festival'),
('Academy Awards', 1929, 'Estados Unidos', 'Academia'),
('Berlin International Film Festival', 1951, 'Alemanha', 'Festival'),
('Venice Film Festival', 1932, 'Itália', 'Festival'),
('Golden Globe Awards', 1944, 'Estados Unidos', 'Concurso');

-- Inserções para a tabela Edicao
INSERT INTO Edicao (Ano, DataEd, Localizacao, NomeEvento) VALUES
(2022, '2022-05-17', 'Cannes', 'Festival de Cinema de Cannes'),
(2024, '2024-05-17', 'Cannes', 'Festival de Cinema de Cannes'),
(2023, '2023-02-26', 'Los Angeles', 'Academy Awards'),
(2024, '2024-02-18', 'Berlin', 'Berlin International Film Festival'),
(2022, '2022-09-02', 'Venice', 'Venice Film Festival'),
(2023, '2023-01-08', 'Beverly Hills', 'Golden Globe Awards');

-- Inserções para a tabela Premio
INSERT INTO Premio (Tipo, Nome, AnoEdicao, NomeEvento) VALUES
('Melhor Diretor', 'Palma de Ouro', 2022, 'Festival de Cinema de Cannes'),
('Melhor Ator Principal', 'Oscar de Melhor Ator', 2023, 'Academy Awards'),
('Melhor Roteiro Original', 'Urso de Ouro', 2024, 'Berlin International Film Festival'),
('Melhor Ator Principal', 'Leão de Ouro', 2022, 'Venice Film Festival'),
('Melhor Ator Principal', 'Globo de Ouro de Melhor Atriz', 2023, 'Golden Globe Awards'),
('Melhor Documentário', 'Leão de Prata - Gran Prêmio do Júri', 2022, 'Venice Film Festival'),
('Melhor Ator Elenco', 'Palma de Ouro de Melhor Ator', 2024, 'Festival de Cinema de Cannes'),
('Melhor Roteiro Adaptado', 'Oscar de Melhor Roteiro Adaptado', 2023, 'Academy Awards'),
('Melhor Produção', 'Urso de Prata - Grande Prêmio do Júri', 2024, 'Berlin International Film Festival'),
('Melhor Ator Elenco', 'Globo de Ouro de Melhor Ator Coadjuvante', 2023, 'Golden Globe Awards'),
('Melhor Filme', 'Leão de Ouro de Melhor Filme', 2022, 'Venice Film Festival'),
('Melhor Ator Elenco', 'Oscar de Melhor Atriz Coadjuvante', 2023, 'Academy Awards'),
('Melhor Diretor', 'Urso de Prata de Melhor Direção de Fotografia', 2024, 'Berlin International Film Festival'),
('Melhor Roteiro Original', 'Oscar de Melhor Animação', 2023, 'Academy Awards'),
('Melhor Roteiro Adaptado', 'Globo de Ouro de Melhor Trilha Sonora Original', 2023, 'Golden Globe Awards');

-- Inserções para a tabela Pessoa
INSERT INTO Pessoa (NomeArt, NomeVerdadeiro, Sexo, AnoNasc, Site, AnoInic, Situacao, NroTotalAnos) VALUES
('StevenSpielberg', 'Steven Allan Spielberg', 'Masculino', 1946, 'http://www.stevenspielberg.com', 1971, 'Atuando', 51),
('QuentinTarantino', 'Quentin Jerome Tarantino', 'Masculino', 1963, 'http://www.quentintarantino.info', 1980, 'Atuando', 42),
('GretaGerwig', 'Greta Celeste Gerwig', 'Feminino', 1983, 'http://www.gretagerwig.com', 2006, 'Atuando', 16),
('ChristopherNolan', 'Christopher Edward Nolan', 'Masculino', 1970, 'http://www.christophernolan.net', 1998, 'Atuando', 26),
('MerylStreep', 'Mary Louise Streep', 'Feminino', 1949, 'http://www.merylstreep.com', 1975, 'Aposentado', 47),
('AlfonsoCuaron', 'Alfonso Cuarón Orozco', 'Masculino', 1961, 'http://www.alfonsocuaron.com', 1983, 'Falecido', 22),
('CateBlanchett', 'Catherine Elise Blanchett', 'Feminino', 1969, 'http://www.cateblanchett.com', 1992, 'Atuando', 30),
('MartinScorsese', 'Martin Charles Scorsese', 'Masculino', 1942, 'http://www.martinscorsese.net', 1963, 'Aposentado', 59),
('JoaquinPhoenix', 'Joaquín Rafael Phoenix', 'Masculino', 1974, 'http://www.joaquinphoenix.com', 1986, 'Atuando', 38),
('SaoirseRonan', 'Saoirse Una Ronan', 'Feminino', 1994, 'http://www.saoirseronan.com', 2003, 'Atuando', 19),
('DenisVilleneuve', 'Denis Villeneuve', 'Masculino', 1967, 'http://www.denisvilleneuve.net', 1994, 'Atuando', 28),
('NataliePortman', 'Natalie Hershlag', 'Feminino', 1981, 'http://www.natalieportman.com', 1994, 'Aposentado', 27),
('BongJoonho', 'Bong Joon-ho', 'Masculino', 1969, 'http://www.bongjoonho.com', 1994, 'Atuando', 28),
('FrancesMcDormand', 'Frances Louise McDormand', 'Feminino', 1957, 'http://www.francesmcdormand.com', 1982, 'Atuando', 39),
('WesAnderson', 'Wesley Wales Anderson', 'Masculino', 1969, 'http://www.wesanderson.com', 1994, 'Atuando', 28),
('ScarlettJohansson', 'Scarlett Ingrid Johansson', 'Feminino', 1984, 'http://www.scarlettjohansson.com', 1996, 'Atuando', 26),
('CoenBrothers', 'Ethan Jesse Coen', 'Masculino', 1957, 'http://www.coenbrothers.net', 1984, 'Falecido', 17),
('JuliaRoberts', 'Julia Fiona Roberts', 'Feminino', 1967, 'http://www.juliaroberts.com', 1987, 'Aposentado', 35),
('BarryJenkins', 'Barry Jenkins', 'Masculino', 1979, 'http://www.barryjenkins.net', 2003, 'Atuando', 18),
('CharlizeTheron', 'Charlize Theron', 'Feminino', 1975, 'http://www.charlizetheron.com', 1995, 'Atuando', 27),
('BradPitt', 'William Bradley Pitt', 'Masculino', 1963, 'http://www.bradpitt.com', 1987, 'Atuando', 35),
('CateWinslet', 'Kate Elizabeth Winslet', 'Feminino', 1975, 'http://www.katewinslet.com', 1991, 'Atuando', 31),
('LeonardoDiCaprio', 'Leonardo Wilhelm DiCaprio', 'Masculino', 1974, 'http://www.leonardodicaprio.com', 1989, 'Atuando', 33),
('EmmaStone', 'Emily Jean Stone', 'Feminino', 1988, 'http://www.emmastone.com', 2004, 'Atuando', 18),
('TomHanks', 'Thomas Jeffrey Hanks', 'Masculino', 1956, 'http://www.tomhanks.com', 1980, 'Aposentado', 44);


-- Inserções para as tabelas Diretor, Produtor, Roteirista, Ator
INSERT INTO Diretor (NomeArt) VALUES
('StevenSpielberg'),
('QuentinTarantino'),
('GretaGerwig'),
('ChristopherNolan'),
('AlfonsoCuaron'),
('CateBlanchett'),
('MartinScorsese'),
('JoaquinPhoenix'),
('SaoirseRonan'),
('DenisVilleneuve'),
('NataliePortman'),
('BongJoonho'),
('FrancesMcDormand'),
('WesAnderson'),
('ScarlettJohansson'),
('CoenBrothers'),
('JuliaRoberts'),
('BarryJenkins'),
('CharlizeTheron');

INSERT INTO Produtor (NomeArt) VALUES
('StevenSpielberg'),
('QuentinTarantino'),
('GretaGerwig'),
('ChristopherNolan'),
('MerylStreep'),
('AlfonsoCuaron'),
('CateBlanchett'),
('MartinScorsese'),
('JoaquinPhoenix'),
('SaoirseRonan'),
('DenisVilleneuve'),
('NataliePortman'),
('BongJoonho'),
('FrancesMcDormand'),
('WesAnderson'),
('ScarlettJohansson'),
('CoenBrothers'),
('JuliaRoberts'),
('BarryJenkins'),
('CharlizeTheron');

INSERT INTO Roteirista (NomeArt) VALUES
('QuentinTarantino'),
('GretaGerwig'),
('ChristopherNolan'),
('CateBlanchett'),
('MartinScorsese'),
('JoaquinPhoenix'),
('SaoirseRonan'),
('DenisVilleneuve'),
('NataliePortman'),
('BongJoonho'),
('FrancesMcDormand'),
('WesAnderson'),
('ScarlettJohansson'),
('CoenBrothers'),
('JuliaRoberts'),
('BarryJenkins'),
('CharlizeTheron');

INSERT INTO Ator (NomeArt) VALUES
('JoaquinPhoenix'),
('SaoirseRonan'),
('DenisVilleneuve'),
('NataliePortman'),
('FrancesMcDormand'),
('WesAnderson'),
('ScarlettJohansson'),
('JuliaRoberts'),
('BarryJenkins'),
('CharlizeTheron'),
('BradPitt'),
('CateWinslet'),
('LeonardoDiCaprio'),
('EmmaStone'),
('TomHanks');

-- Inserções adicionais para a tabela Filmes
INSERT INTO Filmes (IdFilme, ArrecadaoPrimAno, IdiomaOrig, Classe, AnoProducao, TituloOriginal, DataEstreia, TituloBrasil) VALUES
(1, 150000000, 'Inglês', 'Outros', 2019, 'The Midnight Sky', '2019-12-10', 'O Céu da Meia-Noite'),
(2, 80000000, 'Francês', 'Documentarios', 2021, 'Gagarine', '2021-05-17', 'Gagarine - O Espaço que nos Une'),
(3, 5000000, 'Coreano', 'Outros', 2020, 'Parasite', '2020-05-21', 'Parasita'),
(4, 300000000, 'Inglês', 'Outros', 2018, 'Avengers: Infinity War', '2018-04-27', 'Vingadores: Guerra Infinita'),
(5, 120000000, 'Espanhol', 'Documentarios', 2022, 'Marona', '2022-03-04', 'Marona: Como Um Cão'),
(6, 25000000, 'Alemão', 'Outros', 2017, 'Toni Erdmann', '2017-05-25', 'Toni Erdmann'),
(7, 70000000, 'Inglês', 'Outros', 2022, 'Dune', '2022-09-15', 'Duna'),
(8, 6000000, 'Português', 'Documentarios', 2023, 'Sem Título: A História de Jovens Realizadores Brasileiros', '2023-08-01', 'Sem Título'),
(9, 10000000, 'Japonês', 'Outros', 2021, 'Drive My Car', '2021-07-14', 'Drive My Car'),
(10, 180000000, 'Inglês', 'Outros', 2016, 'Rogue One: A Star Wars Story', '2016-12-14', 'Rogue One: Uma História Star Wars');

-- Inserções adicionais para a tabela LocalEstreia
INSERT INTO LocalEstreia (Localizacao, IdFilme) VALUES
('Los Angeles', 1),
('Paris', 2),
('Seul', 3),
('New York', 4),
('Madrid', 5),
('Berlim', 6),
('London', 7),
('São Paulo', 8),
('Tokyo', 9),
('Los Angeles', 10);

-- Inserções adicionais para as tabelas Documentarios e Outros
INSERT INTO Documentarios (IdFilme) VALUES
(2),
(5),
(8);

INSERT INTO Outros (IdFilme) VALUES
(1),
(3),
(4),
(6),
(7),
(9),
(10);


-- Inserções para a tabela AtorPrinc
INSERT INTO AtorPrinc (IdFilme, NomeArt) VALUES
(1, 'BradPitt'),
(1, 'EmmaStone'),
(3, 'ScarlettJohansson'),
(4, 'CateWinslet'),
(4, 'TomHanks'),
(6, 'SaoirseRonan'),
(7, 'JoaquinPhoenix'),
(7, 'LeonardoDiCaprio'),
(9, 'NataliePortman'),
(10, 'JuliaRoberts');

-- Inserções para a tabela AtorElenco
INSERT INTO AtorElenco (IdFilme, NomeArt) VALUES
(1, 'CateWinslet'),
(3, 'LeonardoDiCaprio'),
(3, 'JuliaRoberts'),
(6, 'BarryJenkins'),
(6, 'EmmaStone'),
(7, 'WesAnderson'),
(9, 'NataliePortman'),
(9, 'ScarlettJohansson'),
(10, 'CharlizeTheron'),
(4, 'SaoirseRonan');

-- Inserções para a tabela EDiretor
INSERT INTO EDiretor (IdFilme, NomeArt, EPrincipal) VALUES
(1, 'StevenSpielberg', 'Sim'),
(2, 'QuentinTarantino', 'Sim'),
(3, 'GretaGerwig', 'Sim'),
(4, 'ChristopherNolan', 'Sim'),
(5, 'AlfonsoCuaron', 'Sim'),
(6, 'CateBlanchett', 'Sim'),
(7, 'MartinScorsese', 'Sim'),
(8, 'JoaquinPhoenix', 'Sim'),
(9, 'DenisVilleneuve', 'Sim'),
(10, 'FrancesMcDormand', 'Sim');

-- Inserções para a tabela EProdutor
INSERT INTO EProdutor (IdFilme, NomeArt) VALUES
(1, 'StevenSpielberg'),
(2, 'QuentinTarantino'),
(3, 'GretaGerwig'),
(4, 'AlfonsoCuaron'),
(5, 'CateBlanchett'),
(6, 'MartinScorsese'),
(7, 'DenisVilleneuve'),
(8, 'SaoirseRonan'),
(9, 'FrancesMcDormand'),
(10, 'WesAnderson');


-- Inserções para a tabela ERoteirista
INSERT INTO ERoteirista (IdFilme, NomeArt) VALUES
(1, 'QuentinTarantino'),
(2, 'GretaGerwig'),
(3, 'ChristopherNolan'),
(4, 'CateBlanchett'),
(5, 'MartinScorsese'),
(6, 'JoaquinPhoenix'),
(7, 'SaoirseRonan'),
(8, 'DenisVilleneuve'),
(9, 'NataliePortman'),
(10, 'FrancesMcDormand');


-- Inserções para a tabela EJuri
INSERT INTO EJuri (Ano, NomeArt, NomeEvento) VALUES
(2022, 'MerylStreep', 'Festival de Cinema de Cannes'),
(2022, 'ChristopherNolan', 'Festival de Cinema de Cannes'),
(2023, 'QuentinTarantino', 'Academy Awards'),
(2023, 'GretaGerwig', 'Academy Awards'),
(2024, 'CateBlanchett', 'Berlin International Film Festival'),
(2024, 'MartinScorsese', 'Berlin International Film Festival');


-- Inserções para a tabela ENominado
INSERT INTO ENominado (NomeArt, IdFilme, Tipo, AnoEdicao, NomeEvento, Ganhou) VALUES
('BradPitt', 1, 'Melhor Ator Principal', 2022, 'Venice Film Festival', 'false'),
('CateWinslet', 1, 'Melhor Ator Principal', 2022, 'Venice Film Festival', 'true'),
('ChristopherNolan', 1, 'Melhor Diretor', 2022, 'Festival de Cinema de Cannes', 'true'),
('LeonardoDiCaprio', 1, 'Melhor Roteiro Adaptado', 2023, 'Academy Awards', 'true'),
('QuentinTarantino', 2, 'Melhor Ator Principal', 2023, 'Academy Awards', 'true'),
('GretaGerwig', 2, 'Melhor Roteiro Original', 2023, 'Academy Awards', 'true'),
('ScarlettJohansson', 2, 'Melhor Ator Elenco', 2023, 'Academy Awards', 'true'),
('LeonardoDiCaprio', 2, 'Melhor Ator Principal', 2023, 'Academy Awards', 'false'),
('CateBlanchett', 3, 'Melhor Ator Principal', 2023, 'Golden Globe Awards', 'true'),
('MartinScorsese', 3, 'Melhor Diretor', 2024, 'Berlin International Film Festival', 'false'),
('BradPitt', 3, 'Melhor Ator Principal', 2023, 'Golden Globe Awards', 'false'),
('FrancesMcDormand', 3, 'Melhor Ator Elenco', 2024, 'Festival de Cinema de Cannes', 'false');

-- Inserções corrigidas para a tabela FilmeNominado
INSERT INTO FilmeNominado (IdFilme, Tipo, AnoEdicao, NomeEvento, Premiado) VALUES
(1, 'Melhor Filme', 2022, 'Venice Film Festival', 'false'),
(1, 'Melhor Documentário', 2022, 'Venice Film Festival', 'false'),
(2, 'Melhor Filme', 2022, 'Venice Film Festival', 'false'),
(2, 'Melhor Documentário', 2022, 'Venice Film Festival', 'false'),
(3, 'Melhor Filme', 2022, 'Venice Film Festival', 'true'),
(3, 'Melhor Documentário', 2022, 'Venice Film Festival', 'false');