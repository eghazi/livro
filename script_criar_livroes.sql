CREATE
  TABLE livroes
  (
    LivroID                       INTEGER NOT NULL IDENTITY NOT FOR REPLICATION ,
    sISBN                         VARCHAR(50) NOT NULL ,
    dtCadastro                    DATETIME,
	_deleted_                     INTEGER DEFAULT 0 ,
    sAutor                        VARCHAR (400) ,
    sNome                         VARCHAR (400) ,
    dPreco                        DECIMAL(3) ,
    dtPublicacao                  DATETIME,
	sImagemCapa                   VARCHAR (400) ,
	sDescImagemCapa               VARCHAR (400)  
  )
  ON "default"
GO
ALTER TABLE livroes
ADD CONSTRAINT livroes_deleted
CHECK ( _deleted_ BETWEEN 0 AND 1 )
GO
CREATE UNIQUE INDEX livroes_ID_livroes_IDX ON livroes
(
LivroID ASC
)
CREATE UNIQUE INDEX livroes_sNome_IDX ON livroes
(
sNome ASC
)

ALTER TABLE livroes ADD CONSTRAINT livroes_PK PRIMARY KEY CLUSTERED (
LivroID)
WITH
  (
    ALLOW_PAGE_LOCKS = ON ,
    ALLOW_ROW_LOCKS  = ON
  )
  ON "default"
GO
ALTER TABLE livroes ADD CONSTRAINT livroes__UN UNIQUE NONCLUSTERED (
sNome)
ON "default"
GO


SELECT * FROM livroes
--,,,dPreco, ,sImagemCapa,sDescImagemCapa
--,,50,'\\imagem\'+getdate()+'.jpg', 'imagem de contos'

INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123456','ze das couves0', 'contos0','capa0.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123456','ze das couves1', 'contos1','capa1.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123457','ze das couves2', 'contos2','capa2.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123458','ze das couves3', 'contos3','capa3.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123459','ze das couves4', 'contos4','capa4.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123410','ze das couves5', 'contos5','capa5.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123411','ze das couves6', 'contos6','capa6.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123412','ze das couves7', 'contos7','capa7.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123413','ze das couves8', 'contos8','capa8.jpg','imagem de capa', getdate(), getdate(), 50);
INSERT INTO livroes (sISBN,sAutor,sNome,sImagemCapa,sDescImagemCapa, dtCadastro, dtPublicacao, dPreco) values ('123414','ze das couves9', 'contos9','capa9.jpg','imagem de capa', getdate(), getdate(), 50);

select * from livroes;


