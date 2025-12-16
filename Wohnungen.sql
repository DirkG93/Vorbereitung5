-- Datenbank erstellen
CREATE DATABASE WohnungDB;
GO

-- Tabelle erstellen (5 Attribute + ID)
USE WohnungDB;
GO

CREATE TABLE Wohnung (
    WohnungID INT IDENTITY(1,1) PRIMARY KEY,
    Ort VARCHAR(60) NOT NULL,
    Zimmer INT NOT NULL,
    FlaecheQM INT NOT NULL,
    MieteCHF DECIMAL(10,2) NOT NULL,
    Balkon BIT NOT NULL
);
GO

-- Select
SELECT * FROM Wohnung;

-- 10 fiktive Beispiele einfügen
INSERT INTO Wohnung (Ort, Zimmer, FlaecheQM, MieteCHF, Balkon)
VALUES
('Zürich',     2, 55, 1950.00, 1),
('Winterthur', 3, 78, 2100.00, 1),
('Bern',       4, 95, 2450.00, 0),
('Basel',      1, 35, 1350.00, 0),
('Luzern',     3, 82, 2250.00, 1),
('St. Gallen', 2, 60, 1650.00, 1),
('Lausanne',   4,110, 2900.00, 1),
('Genf',       3, 88, 3100.00, 0),
('Chur',       2, 58, 1550.00, 0),
('Thun',       3, 80, 2050.00, 1);
GO