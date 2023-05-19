------------------------ Task 1 ----------------------
SELECT FirstName FROM Employees 
WHERE FirstName LIKE 'LA%' 
or FirstName LIKE 'LN%' 
or FirstName LIKE 'AA%' 
or FirstName LIKE 'AN%'


------------------------ Task 2 ----------------------
INSERT INTO Employees (FirstName, LastName) 
VALUES ('Lei_la', 'Imanova')

SELECT * FROM EMPLOYEES 
WHERE FirstName LIKE '%*_%' ESCAPE '*'


------------------------ Task 3 ----------------------
-- Note: Taska gore cox gumanki and ishlenilecek, data olmadigina gore or istifade etdim
SELECT TOP 10 PERCENT * FROM Customers WHERE CustomerID LIKE '%A_A%' OR CustomerID LIKE '%T_T_T_T%'


------------------------ Task 4 ----------------------
SELECT * FROM Employees WHERE FirstName NOT LIKE '%A_A%' OR FirstName NOT LIKE '%T_T%'


------------------------ Task 5 ----------------------
SELECT * FROM Employees WHERE LEFT(FirstName, 1) BETWEEN 'A' AND 'I'


------------------------ Task 6 ----------------------
SELECT * FROM Employees WHERE FirstName NOT LIKE '%T'



------------------------ Function task ----------------------
DECLARE @UserBirthday datetime = '2022-08-08'

SELECT IIF(Month(BirthDate) >= MONTH(@UserBirthday),
IIF (MONTH(BirthDate) = MONTH(@UserBirthday), 
IIF (DAY(BirthDate) > MONTH(@UserBirthday), 'Yıl, ay,gün olarak doldurmuştur', 'Yıl ve ay olarak doldurmuştur, gün olarak eksiktir.'), 'Yıl, ay,gün olarak doldurmuştur'
),'Yıl olarak doldurmuştur, ay ve gün olarak eksik'
)  AS [BirthDate checks] FROM Employees
WHERE YEAR(BirthDate) < YEAR(@UserBirthday) 

