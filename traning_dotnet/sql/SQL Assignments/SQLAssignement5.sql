create procedure GetPaySlip
@salary Decimal(5000)
AS
BEGIN
declare @HRA DECIMAL(2000)
SET @HRA = 0.10*@salary
declare @DA DECIMAL(200)
SET @DA = 0.20*@salary
declare @PF DECIMAL(1800)
SET @PF = 0.8*@salary
declare @IT DECIMAL(500)
SET @IT = 0.5*@salary
declare @Deduction DECIMAL
SET @Deduction = @PF+@IT
declare @GrossSalary DECIMAL
SET @GrossSalary =@salary+@HRA+@DA
declare @NetSalary DECIMAL 
SET @NetSalary = @GrossSalary-@Deduction
select @ename = EMPNAME, @salary = SAL
    from empp
print 'Employee Payslip for ' + @ename 
    print 'Basic Salary: ' + cast(@Salary as varchar(20))
    print 'HRA: ' + cast(@HRA as varchar(20))
    print 'DA: ' + cast(@DA as varchar(20))
    print 'PF: ' + cast(@PF as varchar(20))
    print 'IT: ' + cast(@IT as varchar(20))
    print '-----------'
    print 'Gross Salary: ' + cast(@GrossSalary as varchar(20))
    print 'Deductions: ' + cast(@Deductions as varchar(20))
    print '--------- '
    print 'Net Salary: ' + cast(@NetSalary as varchar(20))
end
select * from empp
exec GetPaySlip @empno = 7566;