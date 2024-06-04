CREATE TABLE Customers (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(20),
    Address VARCHAR(255),
    Status ENUM("Activo", "Inactivo"),
    RegistrationDate DATETIME
);

CREATE TABLE Categories (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL,
    Status ENUM("Activo", "Inactivo")
);

CREATE TABLE Movies (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    Description TEXT,
    ReleaseYear DATETIME,
    CategoryId INT,
    Availability ENUM(
        "Disponible",
        "Agotada",
        "Desactivada"
    ),
    AmountOfMovies INT,
    FOREIGN KEY (CategoryId) REFERENCES Categories (CategoryId)
);

CREATE TABLE Employees (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(20),
    Status ENUM("Activo", "Inactivo"),
    HireDate DATETIME
);

CREATE TABLE Rentals (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    CustomerId INT,
    MovieId INT,
    RentalDate DATETIME,
    ReturnDate DATETIME,
    EmployeeId INT,
    Status ENUM(
        "Rentada",
        "Fuera de plazo",
        "Devuelta",
        "Perdida"
    ),
    FOREIGN KEY (CustomerId) REFERENCES Customers (CustomerId),
    FOREIGN KEY (MovieId) REFERENCES Movies (MovieId),
    FOREIGN KEY (EmployeeId) REFERENCES Employees (EmployeeId)
);

INSERT INTO Customers (FirstName, LastName, Email, Phone, Address, Status, RegistrationDate) VALUES
('John', 'Doe', 'johndoe@example.com', '1234567890', '123 Main St, City, Country', 'Activo', NOW()),
('Jane', 'Smith', 'janesmith@example.com', '0987654321', '456 Elm St, City, Country', 'Activo', NOW()),
('Alice', 'Johnson', 'alicejohnson@example.com', '5551234567', '789 Oak St, City, Country', 'Inactivo', NOW());

INSERT INTO Categories (CategoryName, Status) VALUES
('Action', 'Activo'),
('Comedy', 'Activo'),
('Drama', 'Activo');

INSERT INTO Movies (Title, Description, ReleaseYear, CategoryId, Availability, AmountOfMovies) VALUES
('The Matrix', 'A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.', '1999-03-31', 1, 'Disponible', 5),
('The Shawshank Redemption', 'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', '1994-10-14', 3, 'Disponible', 3),
('The Hangover', 'Three buddies wake', '2009-06-02', 2, 'Disponible', 4);

INSERT INTO Employees (FirstName, LastName, Email, Phone, Status, HireDate) VALUES
('Michael', 'Smith', 'michaelsmith@example.com', '9876543210', 'Activo', NOW()),
('Emily', 'Johnson', 'emilyjohnson@example.com', '5559876543', 'Activo', NOW()),
('David', 'Brown', 'davidbrown@example.com', '3334445555', 'Inactivo', NOW());

INSERT INTO Rentals (CustomerId, MovieId, RentalDate, ReturnDate, EmployeeId, Status) VALUES
(1, 1, NOW(), NULL, 1, 'Rentada'),
(2, 2, NOW(), NULL, 2, 'Rentada'),
(3, 3, NOW(), NULL, 1, 'Rentada');