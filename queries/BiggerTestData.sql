INSERT INTO LibraryMember (FullName) VALUES 
('Alice Johnson'), ('Bob Smith'), ('Charlie Davis'), ('Diana Prince'), ('Evan Wright'), ('Fiona Gallagher'), ('George Miller'), ('Hannah Abbott'), ('Ian Malcolm'), ('Julia Roberts'),
('Kevin Hart'), ('Laura Palmer'), ('Mike Wheeler'), ('Nina Simone'), ('Oscar Isaac'), ('Paula Abdul'), ('Quinn Fabray'), ('Rose Tyler'), ('Sam Winchester'), ('Tom Riddle'),
('Ursula Corbero'), ('Victor Hugo'), ('Wendy Darling'), ('Xavier Renegade'), ('Yara Greyjoy'), ('Zack Morris'), ('Arthur Dent'), ('Beth Harmon'), ('Clara Oswald'), ('David Tennant'),
('Ellen Ripley'), ('Finn Hudson'), ('Gloria Pritchett'), ('Harry Potter'), ('Iris West'), ('James Bond'), ('Katniss Everdeen'), ('Luke Skywalker'), ('Mary Poppins'), ('Ned Stark'),
('Ophelia Hamlet'), ('Peter Parker'), ('Quint Jaws'), ('Rachel Green'), ('Sherlock Holmes'), ('Tony Stark'), ('Ulysses Grant'), ('Vito Corleone'), ('Wanda Maximoff'), ('Xena Warrior'),
('Yoda Jedi'), ('Zelda Legend'), ('Albus Dumbledore'), ('Bruce Wayne'), ('Clark Kent'), ('Daisy Buchanan'), ('Edward Cullen'), ('Frodo Baggins'), ('Gandalf Grey'), ('Hermione Granger'),
('Ichabod Crane'), ('Jack Sparrow'), ('Katara Water'), ('Legolas Greenleaf'), ('Marty McFly'), ('Nancy Drew'), ('Optimus Prime'), ('Percy Jackson'), ('Quicksilver Maximoff'), ('Rick Grimes'),
('Sarah Connor'), ('Tyrion Lannister'), ('Uther Pendragon'), ('Velma Dinkley'), ('Walter White'), ('Xander Harris'), ('Yvaine Stardust'), ('Ziva David'), ('Atticus Finch'), ('Bilbo Baggins');

INSERT INTO Book (Title, Author) VALUES 
('The Great Gatsby', 'F. Scott Fitzgerald'), ('1984', 'George Orwell'), ('To Kill a Mockingbird', 'Harper Lee'), ('The Hobbit', 'J.R.R. Tolkien'), ('Brave New World', 'Aldous Huxley'),
('Fahrenheit 451', 'Ray Bradbury'), ('Animal Farm', 'George Orwell'), ('The Catcher in the Rye', 'J.D. Salinger'), ('The Grapes of Wrath', 'John Steinbeck'), ('Lord of the Flies', 'William Golding'),
('The Odyssey', 'Homer'), ('The Iliad', 'Homer'), ('Pride and Prejudice', 'Jane Austen'), ('Sense and Sensibility', 'Jane Austen'), ('Wuthering Heights', 'Emily Brontë'),
('Jane Eyre', 'Charlotte Brontë'), ('Moby Dick', 'Herman Melville'), ('War and Peace', 'Leo Tolstoy'), ('Anna Karenina', 'Leo Tolstoy'), ('Crime and Punishment', 'Fyodor Dostoevsky'),
('The Brothers Karamazov', 'Fyodor Dostoevsky'), ('Ulysses', 'James Joyce'), ('Dubliners', 'James Joyce'), ('Lolita', 'Vladimir Nabokov'), ('The Sound and the Fury', 'William Faulkner'),
('Catch-22', 'Joseph Heller'), ('Slaughterhouse-Five', 'Kurt Vonnegut'), ('The Road', 'Cormac McCarthy'), ('No Country for Old Men', 'Cormac McCarthy'), ('Beloved', 'Toni Morrison'),
('Song of Solomon', 'Toni Morrison'), ('Invisible Man', 'Ralph Ellison'), ('One Hundred Years of Solitude', 'Gabriel García Márquez'), ('Love in the Time of Cholera', 'Gabriel García Márquez'), ('The Alchemist', 'Paulo Coelho'),
('The Da Vinci Code', 'Dan Brown'), ('Angels & Demons', 'Dan Brown'), ('Gone Girl', 'Gillian Flynn'), ('The Girl with the Dragon Tattoo', 'Stieg Larsson'), ('The Shining', 'Stephen King'),
('It', 'Stephen King'), ('The Stand', 'Stephen King'), ('Dune', 'Frank Herbert'), ('Neuromancer', 'William Gibson'), ('Foundation', 'Isaac Asimov'),
('I, Robot', 'Isaac Asimov'), ('The Left Hand of Darkness', 'Ursula K. Le Guin'), ('The Handmaid''s Tale', 'Margaret Atwood'), ('Oryx and Crake', 'Margaret Atwood'), ('The Name of the Rose', 'Umberto Eco'),
('Life of Pi', 'Yann Martel'), ('The Book Thief', 'Markus Zusak'), ('The Kite Runner', 'Khaled Hosseini'), ('A Thousand Splendid Suns', 'Khaled Hosseini'), ('Little Women', 'Louisa May Alcott'),
('The Secret Garden', 'Frances Hodgson Burnett'), ('Peter Pan', 'J.M. Barrie'), ('Alice''s Adventures in Wonderland', 'Lewis Carroll'), ('Treasure Island', 'Robert Louis Stevenson'), ('Kidnapped', 'Robert Louis Stevenson'),
('Frankenstein', 'Mary Shelley'), ('Dracula', 'Bram Stoker'), ('The Picture of Dorian Gray', 'Oscar Wilde'), ('The Importance of Being Earnest', 'Oscar Wilde'), ('Huckleberry Finn', 'Mark Twain'),
('Tom Sawyer', 'Mark Twain'), ('The Old Man and the Sea', 'Ernest Hemingway'), ('A Farewell to Arms', 'Ernest Hemingway'), ('For Whom the Bell Tolls', 'Ernest Hemingway'), ('The Sun Also Rises', 'Ernest Hemingway'),
('On the Road', 'Jack Kerouac'), ('The Dharma Bums', 'Jack Kerouac'), ('Breakfast at Tiffany''s', 'Truman Capote'), ('In Cold Blood', 'Truman Capote'), ('The Stranger', 'Albert Camus'),
('The Plague', 'Albert Camus'), ('The Trial', 'Franz Kafka'), ('The Metamorphosis', 'Franz Kafka'), ('Waiting for Godot', 'Samuel Beckett'), ('The Bell Jar', 'Sylvia Plath'),
('Midnight''s Children', 'Salman Rushdie'), ('The Satanic Verses', 'Salman Rushdie'), ('The God of Small Things', 'Arundhati Roy'), ('A Suitable Boy', 'Vikram Seth'), ('The White Tiger', 'Aravind Adiga'),
('Life After Life', 'Kate Atkinson'), ('The Goldfinch', 'Donna Tartt'), ('The Secret History', 'Donna Tartt'), ('A Little Life', 'Hanya Yanagihara'), ('Normal People', 'Sally Rooney'),
('Conversations with Friends', 'Sally Rooney'), ('Shuggie Bain', 'Douglas Stuart'), ('The Overstory', 'Richard Powers'), ('Circe', 'Madeline Miller'), ('The Song of Achilles', 'Madeline Miller'),
('Project Hail Mary', 'Andy Weir'), ('The Martian', 'Andy Weir'), ('The Seven Husbands of Evelyn Hugo', 'Taylor Jenkins Reid'), ('Daisy Jones & The Six', 'Taylor Jenkins Reid'), ('Malibu Rising', 'Taylor Jenkins Reid');

INSERT INTO Loan (LoanDate, FkMemberId, FkBookId) VALUES 
('2023-10-01', 1, 1), ('2023-10-02', 2, 2), ('2023-10-03', 3, 3), ('2023-10-04', 4, 4), ('2023-10-05', 5, 5),
('2023-10-06', 6, 6), ('2023-10-07', 7, 7), ('2023-10-08', 8, 8), ('2023-10-09', 9, 9), ('2023-10-10', 10, 10),
('2023-10-11', 11, 11), ('2023-10-12', 12, 12), ('2023-10-13', 13, 13), ('2023-10-14', 14, 14), ('2023-10-15', 15, 15),
('2023-10-16', 16, 16), ('2023-10-17', 17, 17), ('2023-10-18', 18, 18), ('2023-10-19', 19, 19), ('2023-10-20', 20, 20),
('2023-10-21', 21, 21), ('2023-10-22', 22, 22), ('2023-10-23', 23, 23), ('2023-10-24', 24, 24), ('2023-10-25', 25, 25),
('2023-10-26', 26, 26), ('2023-10-27', 27, 27), ('2023-10-28', 28, 28), ('2023-10-29', 29, 29), ('2023-10-30', 30, 30),
('2023-11-01', 31, 31), ('2023-11-02', 32, 32), ('2023-11-03', 33, 33), ('2023-11-04', 34, 34), ('2023-11-05', 35, 35),
('2023-11-06', 36, 36), ('2023-11-07', 37, 37), ('2023-11-08', 38, 38), ('2023-11-09', 39, 39), ('2023-11-10', 40, 40),
('2023-11-11', 41, 41), ('2023-11-12', 42, 42), ('2023-11-13', 43, 43), ('2023-11-14', 44, 44), ('2023-11-15', 45, 45),
('2023-11-16', 46, 46), ('2023-11-17', 47, 47), ('2023-11-18', 48, 48), ('2023-11-19', 49, 49), ('2023-11-20', 50, 50),
('2023-11-21', 51, 51), ('2023-11-22', 52, 52), ('2023-11-23', 53, 53), ('2023-11-24', 54, 54), ('2023-11-25', 55, 55),
('2023-11-26', 56, 56), ('2023-11-27', 57, 57), ('2023-11-28', 58, 58), ('2023-11-29', 59, 59), ('2023-11-30', 60, 60),
('2023-12-01', 61, 61), ('2023-12-02', 62, 62), ('2023-12-03', 63, 63), ('2023-12-04', 64, 64), ('2023-12-05', 65, 65),
('2023-12-06', 66, 66), ('2023-12-07', 67, 67), ('2023-12-08', 68, 68), ('2023-12-09', 69, 69), ('2023-12-10', 70, 70),
('2023-12-11', 71, 71), ('2023-12-12', 72, 72), ('2023-12-13', 73, 73), ('2023-12-14', 74, 74), ('2023-12-15', 75, 75),
('2023-12-16', 76, 76), ('2023-12-17', 77, 77), ('2023-12-18', 78, 78), ('2023-12-19', 79, 79), ('2023-12-20', 80, 80);

INSERT INTO BookReturn (ReturnDate, FkLoanId) VALUES 
('2023-10-10', 1), ('2023-10-12', 2), ('2023-10-15', 3), ('2023-10-16', 4), ('2023-10-18', 5),
('2023-10-20', 6), ('2023-10-22', 7), ('2023-10-25', 8), ('2023-10-28', 9), ('2023-11-01', 10),
('2023-11-03', 11), ('2023-11-05', 12), ('2023-11-08', 13), ('2023-11-10', 14), ('2023-11-12', 15),
('2023-11-15', 16), ('2023-11-18', 17), ('2023-11-20', 18), ('2023-11-22', 19), ('2023-11-25', 20),
('2023-11-28', 21), ('2023-11-30', 22), ('2023-12-02', 23), ('2023-12-05', 24), ('2023-12-08', 25),
('2023-12-10', 26), ('2023-12-12', 27), ('2023-12-15', 28), ('2023-12-18', 29), ('2023-12-20', 30),
('2023-12-22', 31), ('2023-12-25', 32), ('2023-12-28', 33), ('2024-01-01', 34), ('2024-01-03', 35),
('2024-01-05', 36), ('2024-01-08', 37), ('2024-01-10', 38), ('2024-01-12', 39), ('2024-01-15', 40);
