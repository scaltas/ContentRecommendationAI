-- Insert 25 real songs as content
INSERT INTO Content (Title, Description, Genre, ReleaseDate, Author, AverageRating)
VALUES
    ('Bohemian Rhapsody', 'A rock opera masterpiece by Queen.', 'Rock', '1975-10-31', 'Queen', 9.1),
    ('Imagine', 'A classic song by John Lennon.', 'Pop', '1971-09-09', 'John Lennon', 8.9),
    ('Billie Jean', 'A hit song by Michael Jackson.', 'Pop', '1983-01-02', 'Michael Jackson', 8.7),
    ('Hotel California', 'An iconic track by The Eagles.', 'Rock', '1976-02-26', 'The Eagles', 9.0),
    ('Smells Like Teen Spirit', 'A grunge anthem by Nirvana.', 'Rock', '1991-09-10', 'Nirvana', 8.8),
    ('Yesterday', 'A classic Beatles song.', 'Pop', '1965-08-06', 'The Beatles', 8.6),
    ('Sweet Child o'' Mine', 'A famous rock song by Guns N'' Roses.', 'Rock', '1987-08-17', 'Guns N'' Roses', 8.9),
    ('Boogie Wonderland', 'A disco hit by Earth, Wind & Fire.', 'Disco', '1979-03-20', 'Earth, Wind & Fire', 8.2),
    ('Wonderwall', 'A popular song by Oasis.', 'Rock', '1995-10-30', 'Oasis', 8.4),
    ('Thriller', 'A title track from Michael Jackson''s album.', 'Pop', '1982-11-30', 'Michael Jackson', 8.8),
    ('Like a Rolling Stone', 'A classic Bob Dylan song.', 'Rock', '1965-07-20', 'Bob Dylan', 9.2),
    ('Boogie Woogie Bugle Boy', 'A swing song by The Andrews Sisters.', 'Swing', '1941-01-02', 'The Andrews Sisters', 8.0),
    ('Bad Guy', 'A hit song by Billie Eilish.', 'Pop', '2019-03-29', 'Billie Eilish', 8.7),
    ('Purple Haze', 'A classic rock track by Jimi Hendrix.', 'Rock', '1967-03-17', 'Jimi Hendrix', 8.9),
    ('Respect', 'A soul song by Aretha Franklin.', 'Soul', '1967-04-29', 'Aretha Franklin', 8.5),
    ('Radioactive', 'A modern rock song by Imagine Dragons.', 'Rock', '2012-11-05', 'Imagine Dragons', 8.2),
    ('Sweet Caroline', 'A popular Neil Diamond song.', 'Pop', '1969-09-16', 'Neil Diamond', 8.1),
    ('Hello', 'A ballad by Adele.', 'Pop', '2015-10-23', 'Adele', 8.6),
    ('Boys Don''t Cry', 'A new wave song by The Cure.', 'New Wave', '1979-06-15', 'The Cure', 8.0),
    ('Livin'' on a Prayer', 'A rock anthem by Bon Jovi.', 'Rock', '1986-10-31', 'Bon Jovi', 8.7),
    ('Smooth Criminal', 'A hit song by Michael Jackson.', 'Pop', '1987-10-21', 'Michael Jackson', 8.5),
    ('Hallelujah', 'A song by Leonard Cohen, famously covered by Jeff Buckley.', 'Folk', '1984-12-02', 'Leonard Cohen', 8.8),
    ('What''s Going On', 'A soulful Marvin Gaye track.', 'Soul', '1971-01-20', 'Marvin Gaye', 8.9),
    ('All About That Bass', 'A pop song by Meghan Trainor.', 'Pop', '2014-06-30', 'Meghan Trainor', 7.8),
    ('Hey Jude', 'A timeless Beatles song.', 'Pop', '1968-08-26', 'The Beatles', 9.3);


    DELETE FROM Interactions

INSERT INTO Interactions (UserId, ContentId, InteractionType, Timestamp, Rating)
VALUES
    ('user1', 1, 3, '2023-09-01 08:00:00', 10),
    ('user1', 2, 3, '2023-09-02 09:30:00', 2),
    ('user1', 3, 3, '2023-09-03 11:15:00', 3),
    ('user2', 4, 3, '2023-09-04 14:45:00', 10),
    ('user3', 1, 3, '2023-09-01 08:00:00', 2),
    ('user3', 2, 3, '2023-09-02 09:30:00', 10),
    ('user3', 3, 3, '2023-09-03 11:15:00', 9),
    ('user3', 4, 3, '2023-09-04 14:45:00', 4)