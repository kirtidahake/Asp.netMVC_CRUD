# Asp.netMVC_CRUD
youtube link = https://www.youtube.com/watch?v=nxxC9AJQXn8

action methods in mvc 

CRUD    
C = Create
R = Read , Retrieve
U = Update
D = Delete

insert = post
update = put
delete = delete
read = get

mvc contains 2 web.config files, 
views > web.config = to manage views
web.config = to manage application 

16:13 connect databse steps

steps:
1. created model
2. created service context
3. create dbset<Student> in service context
4. 
5. nuget package manager -> entity framework download 
6. added entity into service context (using System.Data.Entity;)
7. wrote connection string in web.config
8. enabled migration
10. created action result(Index) in home-controller
11. created serviceContext's object in home controller, using projectname.model;
12. created demo table in sql
13. added view of index 
14. List is displayed after executing
15. Create actoin method of create in home controller[HttpGet]
16. Create actoin method of create(Employee e) in home controller[HttpPost]
17. Add view of create
18. Added validation in create actin method
19. Added viewbag in index.cshtml (@Html.Raw(ViewBag.CreateMessage)
)




----------connecxtion string in web.config---------------- 
<connectionStrings>
	<add name="ServicesContext" connectionString="data source=KIRTILAPTOP\SQLEXPRESS;database=student_db;integrated security=true" providerName="system.data.sqlclient"/>
</connectionStrings>

-----------enable migrations---------------
tools -> nuget package manger -> package manager console
write in console - 
Enable-Migrations
add-migration migration_name_here
update-database
