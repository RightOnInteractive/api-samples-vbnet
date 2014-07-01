api-samples-vbnet
=================

VB.NET based code samples for integration with the ROI API

Overview:
This repository contains a Visual Basic folder that contains a program that allows the user to test API keys against Right-On Interactive's (ROI's) server to determine that they can be used to make requests to the server. 

Installation:
In order to use this API tester, Microsoft Visual Studio 2010 Edition or later must be installed on your personal computer. Once Visual studio is downloaded and installed, simply download the contents of this repository and place the folder in the Projects folder, located in the Visual Studio folder. Once downloaded, simply open the .sln file in Visual Studio and run it, or you can navigate to the .exe file and run the executable version, which is located in the Bin/Debug folder.

Directions:
Once the program has been opened, you will see a window with directions, as well as a small form for an API key and a secret key. Below the form, you will see two buttons, which are for each of the two API tests this program is capable of making.

The 'Authorize' button is the first API test, which makes a simple request to ROI's server with the API key and secret key entered in the fields and displays whether the server call was successful or not. To use this test, simply enter the API key and secret key that were given to you by ROI in the appropriate text fields and press the Authorize button. The result of the server request will be displayed in the message box to the right of the form.

The 'Show Contacts Table' button is the second API test, which makes a request to ROI's server to get information from the Contacts table and then displays the results of the request. To make this API call, simply enter the API key and secret key into the corresponding fields and press the Show Contacts Table button. If the credentials were valid and the call to the server was successful, a new window will open that contains the first and last names, email, and phone number of each individual in the Contacts table in the ROI database. If the call was not successful, an error message will appear in the message field to the right of the form.
