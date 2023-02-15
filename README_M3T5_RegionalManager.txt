Lab P3: Module 3 Team 5 (Regional Manager)

### Notes
This was done before client meeting on Thursday-9 Feb, therefore, the feedback form still remains but can be ignored as our new component will be changed from feedback form to performanceEvaluation. The working prototype would be the Request Form. 
--------------------------------------------------------------------------------------

### How to run the app
1. Open the project
2. Open terminal 
3. cd YouthActionDotNet
4. cd ClienApp
5. npm i
6. cd .. 
7. dotnet run
--------------------------------------------------------------------------------------

### After run
1. Open browser, run it on https://localhost:5001
--------------------------------------------------------------------------------------

### Login 
As we currently have yet to integrate with Module 3 Team 2, we will put our form at the admin side.
Username: test
Password: 1234
--------------------------------------------------------------------------------------

### Our prototype
-- [View] -- 
1. Hamburger menu (top left-hand corner)
2. Request and Feedback 
3. Click on the Request Button
	3.1 You will be able to see all the forms that has been sent so far

-- [Add] -- 
4. Click the button on the top right-hand side corner (beside the search and refresh button)
5. Click on Add Request to add a form

-- [Delete] -- 
6. Click on any of the form from the view table
7. Click Click the button on the top right-hand side corner (beside the search and refresh button)
8. Click on Delete Request to delete the form
--------------------------------------------------------------------------------------

### Our file 
-- [Request Form] --
1. Pages : Request 
2. Control : RequestControl
3. Controllers : RequestControllers
4. Model : Request

-- [Feedback] -- no longer used
1. Pages : Feedback
2. Control : FeedbackControl
3. Controllers : FeedbackControllers
4. Model : Feedback
--------------------------------------------------------------------------------------