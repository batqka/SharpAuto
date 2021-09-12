Feature: GoogleFeature
Assessment

@google
Scenario: Run google search
	Given I open “Google search” page
	And I type "Nicolas Cage images" in the search field 
	And I click “Google Search” button
	Then I see “About NNN results” panel 