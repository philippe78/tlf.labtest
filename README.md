[TOCM]

[TOC]

### TFL CRM 7 Days Challenges

## Requirments

### Req 1 
- Remove all accounts that are inactive: 
	- An account is inactive when all these conditions are met: 
		-  There aren't any related cases with status open
		- The latest case closed is dated 3 years ago or more

###  Req 2

- Add new field 'Legacy hold' , type boolean 
	Only Read/Edit by user with security role “CEO-Business Manager”.
- Add new field 'Legacy Hold Details'
	Only Read/Edit by user with security role “CEO-Business Manager”.
	
###  Req 3

- When Selecting 'Yes' on 'Legacy hold' : 
	- Warning Message appears, asking to confirm the action and requesting to fill the details   


###  Req 4
- When the system deletes the inactive accounts,  all the related entities are deleted as well,

## How to build the code


**Building the solution with MS Visual Studio**

The solution contains two projects :

-  **tfl.test**: is a project for testing of  the application. 
-  **tlf.labtest**: is a Custom CodeActivity to create the bulkdeletion job.


Before building  the solution, follow the steps to link the CRM organisation with the Azure AD.
Open the  file tlf.labtest.sln inside the root folder of the project. 

Search for the file named app.config, open it  and  replace the ConnectionString  string with the value ClientID, ClientSecretm, from Azure AD. 

More details how to configure the AD later on the readme within the section Test.


## How to run the output

-  Download from the file lab_1_0_managed.zip, located under the folder 'CRM Solution'
-  Open the advance setting menu item from the new CRM Instance ( We are using for the instruction the classic view, but is  available other option as the  Power Platform )

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/14.png "Solution Import")

-  Select the menu item 'Solution' under the group 'Customisation' .

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/15.png "Solution Import")

- Follow the step to import from the wizard 

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/24.png "Solution Import")

- At the end of the import, select the solution, open it, and click on the item configuration

![Solution Import](https://raw.githubusercontent.com/philippe78/tlf.labtest/master/CRMSolution/pictures/20.png "Solution Import")

- Click the button Create bulk delete Job


## How to run any tests that you have written
## any assumptions that you’ve made


###End
