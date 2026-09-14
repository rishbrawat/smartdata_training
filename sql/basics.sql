-- sql stands for structured query language, its a tool for organizing, managing and retrieving data stored by a computer database.
/*
    Donald D. Chamberlin and Raymond F. Boyce invented SQL (Structured Query Language) in the early 1970s while working as researchers at IBM. [1] (https://en.wikipedia.org/wiki/SQL), [2] (https://www.atscale.com/glossary/sql/)
    
    
    works only on relational databases
    the program that controls the database is called a database management system(dbms)

    requesting data from a database and receiving the results is called a database query.


    FEATURES
    __________
     lets a user define the structure and organization of the data and relationships among all the stored data.

     allows an user or an application to retrieve stored data from the database and use it.

     allows to update database by adding new data, removing old data and modifying previously stored data.

     can be used to restrict the user's ability to retrieve, add and modify data, protecting data against unauthorized access.

     is used to coordinate data sharing by concurrent users, ensuring that changes made my one user do not wipe out changes made by other user.

     defines intergrity constraints in the database, protecting it from corruption due to inconsistent updates or system failiures.

    
     consists of about 40 statements

    sql is declarative or descriptive language, because it describes what the user wants the computer to do rather than how the computer should do it.

    sql is a integral part of a dbms, its a language or tool to communicate with the dbms.
    sql is interactive query language and its a database programming language
    
*/


/*
    the statement that retrieves the data from the database is called SELECT
*/
SELECT city, office, sales 
    FROM offices;

/*
    here the select statement asks for 3 pieces of data 'city' 'office' and 'sales' 
    for each it is clearly specified that this data will come from 'offices' table.
*/

/*
    data types                                            
        integers: id numbers, quantities.
        
        decimal numbers: that have fractional parts and is required exactly, money amounts.

        floating point numbers: used to store scientific numbers that can be calculated approximately.

        fixed length character string: that always have a same length such as postal codes, if the string is smaller than the length defined for the fixed column, its padded with whitespace, so it fits the exact storage length.

        variable length character string: these are not padded, instead the exact number of characters provided is stored along with the length of data string.

        money amounts:
        dates and times: variuos combination of time, dates, timestamps and others are supported.
        boolean data: ms server supports boolean truth and false.
        large character objects
        large binary objects
        non roman characters


        string or character data must be enclosed with ' '(quotes)
        missing data is null value
*/
SELECT * 
FROM OFFICES
WHERE ESTABLISHED_DATE > '2015-01-15';

SELECT * 
FROM OFFICES
WHERE region='South' 
AND sales > 30000 
AND established_date > '2015-01-01'
ORDER BY office;

/* 
    where clause tells sql to include only certain rows of data in the query results. a search condition is used specify the desired rows.

    the group by clause specifies a summary query, instead of producing one row of query results for each row of data in the database, a summary query groups together similiar rows and then produces one summary row of query search results.
    

    calculates columns: columns whose value are calculated from the stored data values.
*/
SELECT office, city, (target-sales) 
FROM OFFICES 
WHERE (target-sales) >= 0
ORDER BY (target-sales) ASC;

/*
    to retrieve all columns from a table, use asterisk(*)
*/
SELECT * 
FROM OFFICES;

/*
    row selection: the WHERE clause is used to specify the rows we want to retrieve.
*/
SELECT *
FROM OFFICES
WHERE sales > target;

/*
    comparisons: (=, <>, <, <=, >, >=)
*/

/*
    the range test (between) checks whether a data value lies between two specified values.
*/
SELECT *
FROM OFFICES
WHERE sales BETWEEN 500000 AND 1000000;

/*
    set membership using 'in'
*/