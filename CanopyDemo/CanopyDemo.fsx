#r @"..\packages\canopy\lib\canopy.dll"
#r @"..\packages\Selenium.WebDriver\lib\net40\WebDriver.dll"

//these are similar to C# using statements
open canopy
open runner
open System

//start an instance of the firefox browser
start firefox

//this is how you define a test
"taking canopy for a spin" &&& fun _ ->
    //this is an F# function body, it's whitespace enforced

    //go to url
    url "http://lefthandedgoat.github.io/canopy/testpages/"

    //assert that the element with an id of 'welcome' has
    //the text 'Welcome'
    "#welcome" == "Welcome"