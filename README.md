# APBD_Task1
• 1. When does Git perform a fast-forward and when is a merge commit created?

Fast forward merge happens when main branch did not have any changes and we only modified our feature branch.

Merge commit is created when both branches main and feature branch have new commits (been modified) or changed

•	2. What is the practical difference between merge and rebase?

Merge-> keeps the original commits history unchanged including branching structure

adds a meerge commit when histories of branches diverge

Safe for shared branches 


Rebase-> Copies your commits and reapplies them on new base, replacing the originals

Makes history look linear

Avoids merge commits in many cases

•	3. How was the conflict resolved in your repository?

I used git merge and Git showed me the code snippet where the conflcit occured and then i had to choose which version of change i wanted to keep in my code.


