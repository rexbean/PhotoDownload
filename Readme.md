# PhotoDownload
## Overview
Renren is a website like facebook in China. My friend wanted me to help her download all photos of her from all her friends' album on Renren.

## Programming Language
This project is written in C# with winform.

## Process
### 1. Simualte login
Using Chrome's DevTools to find out the POST request which is used to transmit the login data to the server. Write a method to forge a POST request with the data and save the Cookies in the response.
### 2. Find the firend list
Finding out the url of the friend list and forge a GET request to get friend list. Then using regex parse the HTML extrac the urls which can lead to their homepage.

### 3. Find the url of the album
Finding out url of the album and then forge the GET request.

### 4. Download the photos.
Parsing the html file with regex and get all photos urls and save them to the disk.

### 5. Multiple Threading to solve the UI
When the main thread deal with the sending requests and downloading photos, clicking the button on the UI will make the program stuck. Multiple threading can solve this problem.
