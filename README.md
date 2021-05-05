# WebScraper

C# project using AngleSharp and a MySQL server on AWS RDS.

##### Running the application will open a form with the following four fields:
- URL: URL of the page being scraped
- Base URL: URL prepended to the links scraped from the website (Only necessary for some sites)
- Element Classname: Classname of the parent element for the link and title
- Keyword: Keyword used to match all entries

##### The form will also have the following four buttons:
- Scrape: Scrapes the page for news titles and links
- Insert: Inserts all scraped entries into the database
- Pull: Pulls data from the database into the results box
- Delete: Deletes all entries in the database

##### Example #1:
- URL: "https://www.oceannetworks.ca/news/stories"
- Base URL: "https://www.oceannetworks.ca"
- Element Classname: "views-field views-field-nothing"
- Keyword: "Ocean"

##### Example #2:
- URL: "https://www.foxnews.com/"
- Base URL: ""
- Element Classname: "title title-color-default"
- Keyword: "Kamala"
