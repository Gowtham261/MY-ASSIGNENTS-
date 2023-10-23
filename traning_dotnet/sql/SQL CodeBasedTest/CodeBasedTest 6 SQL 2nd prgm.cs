DECLARE @EmployeeID INT;
DECLARE @Salary NUMERIC(10,2);
DECLARE EmployeeCursro CURSOR FOR 
SELECT @EmployeeID, @Salary from Employes
where Depno = 10;
OPEN EmployeeCursor;
FETCH NEXT FROM EmployeeCursor INTO @EmployeeID , @Salary;
while @@FETCH_STATUS = 0
BEGIN 
	SET @EmployeeID = @Salary*1.15;
	UPDATE Employes
	SET @Salary = @Salary
	WHERE @EmployeeID=@EmployeeID;
	FETCH NEXT FROM EmployeeCursor INTO @EmployeeID , @Salary;
	END;