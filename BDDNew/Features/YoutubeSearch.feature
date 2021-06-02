Feature: YoutubeSearch
	Simple youtube search 

@mytag
Scenario: Search for my youtube channel
	Given User is at the youtube Home Page
	And user enters the search as ideasbysupreet
	When User clicks on search
	Then youtube channel name should be displayed