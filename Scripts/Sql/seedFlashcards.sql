-- SQLite
-- sqlite> .read ./Scripts/Sql/seedFlashcards.sql
INSERT INTO Flashcards (Prompt, CorrectAnswer, CreatedAt, Progress, RipeAfter)
VALUES ("This card should be ripe", "London", "2016-01-01 10:20:05.123", 3, "2016-01-01 10:20:05.123");