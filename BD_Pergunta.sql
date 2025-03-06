create database BD_Pergunta;
use BD_Pergunta;

CREATE TABLE Perguntas (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Pergunta TEXT NOT NULL,
    RespostaCerta TEXT NOT NULL,
    RespostaErrada1 TEXT NOT NULL,
    RespostaErrada2 TEXT NOT NULL,
    RespostaErrada3 TEXT NOT NULL,
    RespostaErrada4 TEXT NOT NULL
);