
Welcome to an ASP core template example using an Sql Server Database context
(as of 6 Feb 2020. Nick Phillips)

_____Conceptual (Entity) Database Design:_____
    -------           ---------            -----------
    Person--||-----|<- Account--||-----|<- Transaction
    -------           ---------            -----------

_____Logical Database Design_____

    PERSON: PK-PersonId, FirstName, LastName, Address, PhoneNumber
    ACCOUNT: PK-AccountId, Type, Balance, FK-PersonId
    TRANSACTION: PK-DateTime, PK-FK-AccountID, Type, Amount, Description

_____Physical Database Design_____

    ENTITY/PROPERTY__CODE/DB-TYPE__NULL__UNIQUE__DEFAULT__KEYS__REFERENTIAL-CONSTRAINTS__GENERATED__SEQUENCE__VALIDATION__CONCURRENCY

    PERSON
        PersonId       guid  notNull  Unique  noDef pKey  onUpdateCascade,onDeleteNoAction  genOnAdd  autoSeq  noVal  notConCheck
        FirstName      string  null  notUnique  noDef  noKeys  noRefConst  noGen  noSeq  noVal  notConCheck
        LastName       string  null  notUnique  noDef  noKeys  noRefConst  noGen  noSeq  noVal  notConCheck
        Address        string  null  notUnique  noDef  noKeys  noRefConst  noGen  noSeq  noVal  notConCheck
        PhoneNumber    string  null  notUnique  noDef  noKeys  noRefConst  noGen  noSeq  noVal  notConCheck

    ACCOUNT
        AccountId      ulong  notNull  Unique  noDef pKey  onUpdateCascade,onDeleteNoAction genOnAdd startFromTrilSeq noVal notConCheck
        Type           enum  notNull  notUnique noDef  noKeys  noRefConst  noGen  noSeq  noVal  notConCheck
        Banlance       money  notNull notUnique  noDef  noKeys  noRefConst  noGen  noSeq  noVal  notConCheck
        PersonId       FK PERSON

    TRANSACTION
        DateTime       datetime  notNull Unique datetime.now-default  pKey  onUpdateCascade,onDeleteNoAction genOnAdd seqOnAdd noVal notConCheck 
        AccountID      FK ACCOUNT
        Type           enum notNull notUnique noDef noKeys noRefConst noGen noSeq noVal notConCheck
        Amount         money notNull notUnique noDef noKeys noRefConst noGen noSeq noVal notConCheck
        Description    string null  notUnique noDef  noKeys noRefConst noGen noSeq noVal notConCheck

____UseCases____

____Business Rules____
    - on sign up a person must create an account &  on acount creation 
    a person must always make an initial transaction (deposit)


_____Setup_____

    - create plan
        -> map out conceptual,logical & physical database design, 
        -> document usecases/business rules, endpoints
    - dotnet new webapi
    - create Models/POCO classes
    - create ModelContext/dbcontext
    - inject context (Startup.ConfigureServices...UseSqlServer(connectionString))
    - correct JSON serializer (Startup.ConfigureService...ReferenceLoopHandling.Ignore)
    - alter model wtih fluentAPI
    - create Data/SeedData.cs
    - dotnet ef migration add initialcreate
    - dotnet ef database update
    - create CRUD operation controllers (dotnet aspnet-codegenerator controller....)
    - create extra USECASE operations controller
    - test and document endpoints
    - recheck microsoft asp/ef/sqlServer/C# documentation before finalizing
    - dockerize finished product
    - deploy/run local/azure with database



