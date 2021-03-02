# OOPS Challenge

The purpose of the application is to help a fictitious company called Bills Burgers to manage their process of selling hamburgers.

Our application will help Bill to select types of burgers, some of the additional items (additions) to be added to the burgers and pricing. We want to create a base hamburger, but also two other types of hamburgers that are popular ones in Bills store.


The basic hamburger should have the following items. Bread roll type, meat and up to 4 additional additions (things like lettuce, tomato, carrot, etc) that the customer can select to be added to the burger.


Each one of these items gets charged an additional price so you need some way to track how many items got added and to calculate the final price (base burger with all the additions). This burger has a base price and the additions are all separately priced (up to 4 additions, see above).

Create a Hamburger class to deal with all the above. The constructor should only include the roll type, meat and price, can also include name of burger or you can use a setter.

Also create two extra varieties of Hamburgers (subclasses) to cater for


  - a)	Healthy burger (on a brown rye bread roll), plus two addition items that can be added. The healthy burger can have 6 items (Additions) in total. Hint: you probably want to process the two additional items in this new class (subclass of Hamburger), not the base class (Hamburger), since the two additions are only appropriate for this new class (in other words new burger type).
  - b)	Deluxe hamburger - comes with chips and drinks as additions, but no extra additions are allowed. Hint: You have to find a way to automatically add these new additions at the time the deluxe burger object is created, and then prevent other additions being made.
  
All 3 classes should have a method that can be called anytime to show the base price of the hamburger plus all additionals, each showing the addition name, and addition price, and a grand/final total for the burger (base price + all additions)


### Expected Outcome 

![OutPut Screenshot Add Here](./images/NAME_OOPS Challenge_output.jpg)

#### To push the code in gitlab you can follow these steps

1. Create Project and Name the project as  **OOPS_Challenge** in your local machine

2. Navigate to Hackathon2k20_OOPS_Challenge folder

    `cd OOPS_Challenge`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `OOPS_Challenge` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-ust.stackroute.in/{{yourusername}}/OOPS_Challenge.git`

     **Note: {{yourusername}} should be replaced by your username from gitlab**

5. Check the status of your repo 
     
     `git status`

6. Use the following command to update the index using the current content found in the working tree, to prepare the content staged for the next commit.

     `git add .`
 
7. Commit and Push the project to git

     `git commit -a -m "Initial commit | or place your comments according to your need"`

     `git push -u origin master`

8. Check on the git repo online, if the files have been pushed