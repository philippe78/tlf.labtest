
### TFL CRM 7 Days Challenges

## Requirments

### Req 1 
- Remove all accounts that are inactive: 
	- An account is inactive when all these conditions are met: 
		-  There aren't any related cases with status "open"
		- The latest case closed is dated 3 years ago or more

###  Req 2

- Add new field 'Legacy hold' , type boolean 
	Only View/Edit by user with security role “CEO-Business Manager”.
- Add new field 'Legacy Hold Details'
	Only View/Edit by user with security role “CEO-Business Manager”.
	
###  Req 3

- When Selecting 'Yes' on 'Legacy hold' : 
	- Warning Message appears, asking to confirm the action and requesting to fill in the details   


###  Req 4
- When the system deletes the inactive accounts,  all the related entities are deleted as well

## How to build the code


**Building the solution with MS Visual Studio**

The solution contains two projects :

-  **tfl.test**: is a project for testing of the application. 
-  **tlf.labtest**: is a Custom CodeActivity to create the bulkdeletion job.



Open the  file tlf.labtest.sln inside the root folder of the project. 

Search for the file named app.config, open it  and  replace the ConnectionString  string with the value ClientID, ClientSecretm, from Azure AD. 

More details how to configure the AD [here](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/ad.pdf ("here")


## How to run the output

-  Download from the file lab_1_0_managed.zip, located under the folder 'CRM Solution'
-  Open the advance setting menu item from the new CRM Instance ( We are using for the instruction the classic view, but is available other option as the  Power Platform )

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/14.png "Solution Import")

-  Select the menu item 'Solution' under the group 'Customisation' .

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/15.png "Solution Import")

- Follow the wizard steps to import the file 

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/24.png "Solution Import")

- At the end of the import, select the solution, open it, and click on the item configuration

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/20.png "Solution Import")

- Click the button Create bulk delete Job


## How to run any tests that you have written

The tests are based on the 'Customer Service HUB Application' select it when prompted the first login as shown on the  image below : 

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/pict13.png "Solution Import")


CRM Dynamics CE, has different modules build with different architetture, for each one the testing needs to follow a different approach.
I have delivered with this solution two groups  of tests that cover the requirements.  

 - Based on Visual studio UNIT Test, these are  automated but cover only the programming side 
-  Acceptance test based on manual operations 

With more time availble, the acceptance test can be done also using some third party tools as Katalon

Only for the atomated tests, is required to create an active directory user on Azure and link it to the CRM as an application user, since is required the Client ID and Cient Secret. More details  [here](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/ad.pdf "here")


# Manual Test 1

Description :

Login with a user without the role “CEO-Business Manager”.

Result :
The form should not contain any field for Legacy hold, under the section GDPR

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/25.png "Solution Import")

# Manual Test 2

Description :

Login with a user with  the role “CEO-Business Manager”.

Result :
The form should  contain  Legacy hold, and Legacy Hold details  under the section GDPR

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/26.png "Solution Import")


# Manual Test 3

Description :

"CEO-Business Manager”select  yes in the field 'legacy hold', and then try to save without filling the 'legacy hold details field'  

Result :
The form should  show before a warning message and setup mandatory the field legacy hold. 

Trying to save, shows another warning message, preventing the operation.

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/28.png "Solution Import")

# Manual Test 4

Description: 
- Create a new account
- Create a new case and fill the customer section with the new account just created
- Add a new task
- Delete the  account

Result :
The account and all the related entites will be removed from the system

# Manual Test 5

Description: the system should delete automatically all the inactive accounts older than 3 years.
Result: navigate on the 'system job' menu  under the voice  "Advance settings"

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/33.png "Solution Import")

Select from the view only "reccuring system jobs". A new system job called 'Retention policy daily' should be present on the list.\

Click on it.

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/34.png "Solution Import")



Check the section "selected query" and the section "next run"

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/31.png "Solution Import")


# Automated Test

- This test, create a new account, and add to it a new case, then try to delete the new account 
- The test is succefull only if the case is deleted with  the releated  account 


![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/29.png "Solution Import")


![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/30.png "Solution Import")

## any assumptions that you’ve made

I have tried to reduce as much as possibile Visual Studio and C#, in order to make the application simple to manage .

What I have used on this project - 
- Javascript : 
		The warning popup 
		 The function that disable/enable field   according to the user role
		 The Configuration page of the solution

 Field Security role
 		 To prevent any other user to edit the field 'Legacy Hold and 'legacy hold details
Bulk Deletion job
		To delete each day all the oldest inactive acccount
![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/31.png "Solution Import")

		
- Rollup field 
		To count if there are any cases open for the account, and retrive the latest closure date
		![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/32.png "Rollup")
- Action 
		to call the custom Code Activity
- costum Activity
	 To create the bulk deletion job






###End
