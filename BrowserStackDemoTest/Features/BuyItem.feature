Feature: BuyItem

Background:
    Given "demouser" accesses the website
    Given they arrived on the Main page

Scenario: Navigate, select, buy and check
    Given they added "Galaxy S10" to cart
    And checked out their purchase
    And they logged in
    And they filled in shipping details
        | Name      | Value             |
        | FirstName | John              |
        | LastName  | Dow               |
        | Address   | Middle of nowhere |
        | State     | ND                |
        | PostCode  | 00000             |
    When they submit the order
