Feature: Chat

@Chat
Scenario: launch application and check chat information
	Given launch application
	When change theme chat
	Then click Book a Check-up button in chat and Choose a specialist