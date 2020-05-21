# Bing Points Generator

Started as a Hobby project to test .Net Core during it's initial launch, specifically to Test the functionlaity across MacOS & Win Platforms.

Extended it to Search on various Phrases and enhancing my Vocabulary, and further extended it to Generate & add Bing Points to my account.

You can use it to search for content based on your interests and/or adding points to your Bing account


## Geting up and running (Runs on Both Win & MacOS)
- dotnet build
- dotnet run

## Saving Bing Points
- Make sure you are logged in to your MS account on the default browser

## Updating your search phrases
- Feel free to update the Phrases.txt to search relevant content as per your interests

## Caution 
- The program opens multiple Browser Tabs, you can adjust the timings between each new tab opening, [Program.cs line number 39](https://github.com/AbhiX28/Bing_Points_Generator/blob/master/Program.cs#L39) to increase the interval between new tabs opening
