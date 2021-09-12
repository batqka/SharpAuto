Feature: BulkDelete
	Bulk delete users

Scenario: Bulk delete few users
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	And I select few users
	When I click "Delete" button and confirm
	Then I should see that selected users are deleted

Scenario: Bulk delete all users
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	And I click "Check all" checkbox
	And I uncheck current user
	When I click "Delete" button and confirm
	Then I should see that all users except the current ones are deleted
	
Scenario: Bulk delete only one user
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	And I select one user
	When I click "Delete" button and confirm
	Then I should see that selected user is deleted

Scenario: Bulk delete after uncheck user
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	And I select 3 users
	And I uncheck one of checked users
	When I click "Delete" button and confirm
	Then I should see that selected 2 users are deleted
	And I should see that unselected user not deleted

Scenario: Bulk delete - cancel
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	And I select few users
	And I click "Delete" button
	When I click "Cancel" button to refuse deletion
	Then I should see that selected users not deleted

Scenario: Bulk delete after search
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	And I select few users
	When I enter "some text" in search field
	Then I see users become unselected after search
	And I select few another users 
	When I click "Delete" button and confirm
	Then I should see that deleted only users selected last time 

Scenario: Bulk delete after filter adding
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	And I select few users
	When I add new filter
	Then I see users become unselected after adding new filter
	And I select few another users 
	When I click "Delete" button and confirm
	Then I should see that deleted only users selected last time 

Scenario: Bulk delete after column sort
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	And I select few users
	When I sorting the column "Column name"
	Then I see users become unselected after column sorting
	And I select few another users 
	When I click "Delete" button and confirm
	Then I should see that deleted only users selected last time 

Scenario: Bulk delete nothing
	Given I authorize as user with access to delete users
	And I open Testrail administration page on "Users" tab
	When I click "Delete" button
	Then I see that the "Delete" button is inactive

Scenario: Bulk delete with current user
	Given I authorize as user with access to delete users 
	And I open Testrail administration page on "Users" tab
	And I select few users
	And I select current user
	When I click "Delete" button
	Then I see that the "Delete" button is inactive

Scenario: Bulk delete without access to delete
	Given I authorize as user without access to users delete
	And I open Testrail administration page on "Users" tab
	And I select few users
	When I click "Delete" button
	Then I see that the "Delete" button is inactive or not exist

Scenario: Block request for bulk delete
	Given I authorize as user with access to delete users
	Given I block deleting request
	And I open Testrail administration page on "Users" tab
	And I select few users
	When I click "Delete" button and confirm
	Then I should see error message like "Something wrong, try again later"
