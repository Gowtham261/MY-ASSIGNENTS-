create table Code_Employeee
(
empno int primary key,
empname varchar(35) NOT NULL,
empsal numeric(10,2) CHECK (empsal >= 2500),
emptype char(1) CHECK (emptype IN ('F','P'))
);
CREATE PROCEDURE THEEmployee
@empname VARCHAR(35),
@empsal numeric(10,2),
@emptype char(1)
as 
begin 
insert into Code_Employeee (empname,empsal,emptype)
values (@empname,@empsal,@emptype)
END;