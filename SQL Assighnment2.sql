use employee;
select * from emp1;


--1.Retrive alist of Managers.
select ename,job from emp1 where job='Manager';


--2.find out salary of both Miller and Smith.
select sal,ename from emp1 where ename in('Miller','Smith');

--3.Find out the names and salaries of all employees earning more than 1000 per month
select ename,sal from emp1 where sal>1000;


--4.Display the names and salaries of all employees except James.
select ename,sal from emp1 where ename!='Jamesw';

--5.Find out the details of employees whose names begin with 'S'.
select * from emp1 where ename like's%';

--6.Find out the names of all emplopyees that have 'A' anywhere in their name.
select * from emp1 where ename like 'A%';


--7. Find out te names of all employees that 'L' as their third character in their name.
select ename from emp1 where ename like '_L%';

--8.Find out the names of the employees whose name begin with 'A' or 'M'.
select ename from emp1 where ename like 'A%' or ename like 'M%';

--9.Compute yearly salary of Smith.
select sal*12 as "smith yearly salary" from emp1 where ename='Smith';

--10.Compute daily salary of Jones.
select sal/30 from emp1 where ename='Jones';

--11.Calculate the total monthly salary of all employees.
select sum(sal) from emp1;

--12.Print the average annual salary.
select avg(sal*12) from emp1;

--13.Select the name, job, salary, department number of all employees except Salesman from department number 30.
select ename,job,sal,deptno from emp1 where ename!='Salesman' and deptno=30;


--14.List unique departments of the emp table.
select deptno from emp1 group by deptno;

--15.List the name and salary of employees who earn more than 1500 and are in department 10 or 30.
--Lable the columns employee and monthly salary respectively.
select ename,sal from emp1 where sal>1500 and deptno in (10,30);