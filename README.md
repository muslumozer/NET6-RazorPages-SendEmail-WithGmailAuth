# .NET Core 6 RazorPages Send Email With Gmail Auth

**MimeKit and NETCore.MailKit Nuget Packages Are Used In The Project.**


<h1 align="center">Preview</h1>

| <h1 align="center">Web Side</h1>  | <h1 align="center">Mail Side</h1> |
| ------------- | ------------- |
| ![webside](https://i.hizliresim.com/m0rig5f.png)  | ![mailside](https://i.hizliresim.com/oivjc8a.png) |


**How to use ?**

1) In the SendEmail.cs file in the Helpers folder, you need to replace your yourmail@gmail.com with your own email address.

2) For the "password" section in the same place, you need to complete the following operations.

**Starting on May 30, 2022, Google no longer supports the use of third-party apps or devices which ask you to sign in to your Google Account using only your username and password. So, we have to use a different solution for our application. To do this, we need to enable 2-step verification for our Gmail account first and then we can use the App Password feature to overcome this issue.**


**So, to enable 2-step verification, we have to:**

1) Navigate to our Google Account – the account you will send the emails from (https://myaccount.google.com/)
2) In the menu on the left, we should select Security
3) Then under the “Signing in to Google” section, we can see that 2-Step Verification is off – so we have to click on it
4) Click Get Started, provide your password, and confirm the code by providing a mobile number
5) If everything goes well, you should see the Turn On option, so just click on it

**At this point, we have enabled our 2-Step verification and we can return to the Security page. There, under the same “Signing in to Google” section, we can find the App passwords option set to None.** 

**So, we have to:**

1) Click on it
2) Provide a password
3) Click the Select app menu and choose the Other (Custom Name) option
4) Now, all we have to do is to provide any name we like for our app and click the Generate button