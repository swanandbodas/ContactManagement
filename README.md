# ContactManagement

PreRequisites:
1.  .Net Core 2.0
2.  SQL Express 14.0
3.  Swagger is configured. But if due to browser issues it poses problems Postman would be needed.

Notes:
1.  The Project is configured for Live Test and default Code Analysis. Based on Visual Studio performance impact, it can be enabled/disabled.
2.  

How to run the application ?:
1.  Execute the DDL script in folder ContentManagement\DatabaseScripts to generate the database schema
2.  Run the RunApp file in the ContactManagement\ContactManagement folder.
3.  It will  build and host the Web APIs on the local server.
4.  Chrome Browser would pop-up with Swagger. At times, based on individual machine speed, the code compilation and launching can take more         time. In that case Chrome Browser may open up even before Web API is hosted. So there needs to be some wait time until Browser starts   
    showing results.